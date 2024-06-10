using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Validaciones;
using CapaLogica.Login;
using Software_Contable.Forms.FormPrincipal;
using System.Text.RegularExpressions;
using System.Windows.Media;
using Microsoft.SqlServer.Server;
using Color = System.Drawing.Color;
using CapaSoporte.Cache;


namespace Software_Contable
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        ClaseLogin login = new ClaseLogin();
        

        private void btnIniciarSesion_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text != "USUARIO")
            {
                if (txtContrasena.Text != "CONTRASEÑA")
                {
                    bool validaLogin = login.LoginUsuario(txtUsuario.Text, txtContrasena.Text);

                    if (validaLogin == true)
                    {
                        // Verifica si ClaseUsuarioCache.Contrasena_Cache es un número
                        if (int.TryParse(ClaseUsuarioCache.Contrasena_Cache, out int numero))
                        {
                            // Muestra el formulario
                            frmInicializarContrasena frmInicializarContrasena = new frmInicializarContrasena();
                            frmInicializarContrasena.ShowDialog();

                            if (frmInicializarContrasena.DialogResult == DialogResult.OK)
                            {

                            }


                        }

                        frmPrincipal frmPrincipal = new frmPrincipal();
                        frmPrincipal.Show();
                        frmPrincipal.FormClosed += CerrarSesion;
                        this.Hide();
                    }
                    else
                    {
                        txtContrasena.Text = "CONTRASEÑA";
                        txtContrasena.ForeColor = Color.Gray;
                        txtContrasena.UseSystemPasswordChar = false;                        

                        mensajeError("Usuario y/o Contraseña incorrectos");
                        IniciaTimers();

                        txtUsuario.Focus();
                    }
                }
                else
                {
                    mensajeError("Por favor ingrese su Contraseña");
                    IniciaTimers();
                }
            }
            else
            {
                mensajeError("Por favor ingrese su Nombre de Usuario");
                IniciaTimers();
            }
        }

        private void CerrarSesion(object sender, FormClosedEventArgs e)
        {
            lblErrorLogin.Visible = false;
            this.Show();
        }

        

        #region Eventos txtUsuario
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
                txtUsuario.ForeColor = Color.White;
            }
        }

        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
                txtUsuario.ForeColor = Color.Gray;
            }
        }

        private void txtUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_NombreUsuario(e);
        }

        #endregion Eventos txtUsuario

        #region Eventos txtContrasena
        private void txtContrasena_Enter(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "CONTRASEÑA")
            {
                txtContrasena.Text = "";
                txtContrasena.ForeColor = Color.White;
                txtContrasena.UseSystemPasswordChar = true;
            }
        }

        private void txtContrasena_Leave(object sender, EventArgs e)
        {
            if (txtContrasena.Text == "")
            {
                txtContrasena.Text = "CONTRASEÑA";
                txtContrasena.ForeColor = Color.Gray;
                txtContrasena.UseSystemPasswordChar = false;
            }
        }

        private void txtContrasena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(13)) //Si pulsa Enter dentro txtContrasena se presiona automaticamente el boton btnIniciarSesion
            {
                btnIniciarSesion.PerformClick();
            }
        }

        #endregion Eventos txtContrasena

        #region Eventos Contraseña Incorrecta
        private void mensajeError(string msg)
        {
            lblErrorLogin.ForeColor = Color.White;
            lblErrorLogin.Text = msg;
            lblErrorLogin.Visible = true;
        }


        bool cambia = true;
        private void timerError_Tick(object sender, EventArgs e)
        {
            if (cambia == false)
            {
                lblErrorLogin.ForeColor = Color.White;
                cambia = true;
            }
            else
            {
                lblErrorLogin.ForeColor = Color.Red;
                cambia= false;
            }
        }

        int contador = 0;
        int duracionParpadeo = 3;
        private void timerTiempodeParpadeo_Tick(object sender, EventArgs e)
        {
            contador++;
            if (contador >= duracionParpadeo)
            {
                timerError.Stop();
                timerTiempodeParpadeo.Stop();
                lblErrorLogin.ForeColor = Color.White;
            }

            //Reinicia el contador para que parpade entre rojo y blanco la misma cantidad de tiempo cada vez que se pulsa
            if (timerError.Enabled == false && timerTiempodeParpadeo.Enabled == false)
            {
                contador = 0;
            }
        }

        public void IniciaTimers()
        {
            timerError.Start();
            timerTiempodeParpadeo.Start();
        }

        #endregion


        private void frmLogin_Activated(object sender, EventArgs e)
        {
            btnIniciarSesion.Focus();

            txtUsuario.Text = "FrankAdmin";
            txtUsuario.ForeColor = Color.Gray;

            txtContrasena.Text = "123";
            txtContrasena.ForeColor = Color.Gray;
            txtContrasena.UseSystemPasswordChar = false;
        }


    }
}
