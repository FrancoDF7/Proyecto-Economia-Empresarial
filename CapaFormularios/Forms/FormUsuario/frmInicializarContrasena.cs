using CapaLogica.Usuarios;
using CapaSoporte.Validaciones;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaSoporte.Extras;
using Software_Contable.MessageBoxs;

namespace CapaFormularios.Forms.FormUsuario
{
    public partial class frmInicializarContrasena : Form
    {
        public frmInicializarContrasena()
        {
            InitializeComponent();
        }

        #region Declaraciones de Instancias

        ClaseUsuario claseUsuario = new ClaseUsuario();
        ClaseMoverForm moverFormulario = new ClaseMoverForm();

        MessageBoxConfirmarEleccion msgBoxConfirmar = new MessageBoxConfirmarEleccion();
        MessageBoxOperacionExitosa messageBox = new MessageBoxOperacionExitosa();

        #endregion

        private void frmInicializarContrasena_Load(object sender, EventArgs e)
        {
            lblExplicacion.Text = "Se ha detectado un primer inicio de sesión" +
                "\ndebe cambiar su contraseña.";

            txtContraNueva1.UseSystemPasswordChar = true;
            txtContraNueva2.UseSystemPasswordChar = true;
        }        

        private void btnCambiarContrasena_Click(object sender, EventArgs e)
        {
            bool ContrasenaSegura = ValidacionKeyPress.Valida_ContrasenaSegura(txtContraNueva1, txtContraNueva2, errorContrasena1, errorContrasena2, lblVerificaContrasena);

            if(ContrasenaSegura == true)
            {           
                claseUsuario.CambiarContrasena(txtContraNueva1.Text);
                txtContraNueva1.Text = "";
                txtContraNueva2.Text = "";
                    
                messageBox.MostrarMessageBox("Contraseña cambiada exitosamente");
                this.Hide();
            }

        }

        //Ver/Ocultar Contraseña
        #region Ver/Ocultar Contraseña
        private void btnVerContrasena1_Click(object sender, EventArgs e)
        {
            if (btnVerContrasena1.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                btnVerContrasena1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtContraNueva1.UseSystemPasswordChar = true;
            }
            else
            {
                btnVerContrasena1.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtContraNueva1.UseSystemPasswordChar = false;
            }

            //Para que no genere un falso positivo al presionar el boton btnContrasena1
            if (txtContraNueva1.Text == txtContraNueva2.Text)
            {
                errorContrasena1.Clear();
            }

        }
        private void btnVerContrasena2_Click(object sender, EventArgs e)
        {
            if (btnVerContrasena2.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                btnVerContrasena2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtContraNueva2.UseSystemPasswordChar = true;
            }
            else
            {
                btnVerContrasena2.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtContraNueva2.UseSystemPasswordChar = false;
            }

            //Para que no genere un falso positivo al presionar el boton btnContrasena2
            if (txtContraNueva1.Text == txtContraNueva2.Text)
            {
                errorContrasena2.Clear();
            }

        }
        #endregion Ver/Ocultar Contraseña

        //Hace que cambie el color y texto del label segun el contendio del textbox
        private void txtContraNueva1_TextChanged(object sender, EventArgs e)
        {
            ValidacionKeyPress.ActualizaLabel_ContrasenaSegura(txtContraNueva1, lblVerificaContrasena);
        }

        //Posee una referencia a todos los objetos dentro de la BarraTitulo
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ClaseMoverForm mover = new ClaseMoverForm();
            mover.MoverForm(this.Handle);
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Cancelar();
        }

        public void Cancelar()
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }


    }
}
