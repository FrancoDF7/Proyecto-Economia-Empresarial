using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Usuarios;
using CapaSoporte.Cache;
using CapaSoporte.Validaciones;
using CapaFormularios.MessageBoxs;

namespace CapaFormularios.Forms.FormUsuario
{
    public partial class frmEditarPerfil : Form
    {
        ClaseUsuario ClaseEditarUsuario = new ClaseUsuario();
        ValidacionErrProv ValidaErrProv = new ValidacionErrProv();
        //ValidacionKeyPress ValidaKeyPress = new ValidacionKeyPress();

        public frmEditarPerfil()
        {
            InitializeComponent();
        }

        private void frmEditarPerfil_Load(object sender, EventArgs e)
        {
            txtNombreUsuario.Text = ClaseUsuarioCache.NombreUsuario_Cache;
            txtNombre.Text = ClaseUsuarioCache.Nombre_Cache;
            txtApellido.Text = ClaseUsuarioCache.Apellido_Cache;
            txtEmail.Text = ClaseUsuarioCache.Email_Cache;

            //Activa los caracteres para contraseña en los TextBoxs
            txtContraActual.UseSystemPasswordChar = true;
            txtContraNueva1.UseSystemPasswordChar = true;
            txtContraNueva2.UseSystemPasswordChar = true;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            bool ContrasenaActualValida = ClaseEditarUsuario.Valida_ContrasenaActual(txtContraActual, errorContrasenaActual);

            //bool EmailValido = ValidaErrProv.Valida_Error_Email(errorVerificaEmail, txtEmail);

            bool ContrasenaSegura = ValidacionKeyPress.Valida_ContrasenaSegura(txtContraNueva1, txtContraNueva2, errorContraNueva1, errorContraNueva2, lblVerificaContrasena);

            if (ContrasenaActualValida == true && ContrasenaSegura == true)
            {
                MessageBoxConfirmarEleccion msgBoxConfirmar = new MessageBoxConfirmarEleccion();
                DialogResult result = msgBoxConfirmar.MostrarMessageBox("¿Desea guardar los cambios?");

                if (result == DialogResult.Yes)
                {
                    ClaseEditarUsuario.EditarMiPerfil(txtNombreUsuario.Text, txtContraActual.Text, txtContraNueva1.Text, txtNombre.Text, txtApellido.Text, txtEmail.Text);

                    txtContraActual.Clear();
                    txtContraNueva1.Clear();
                    txtContraNueva2.Clear();

                    MessageBoxOperacionExitosa messageBox = new MessageBoxOperacionExitosa();
                    messageBox.MostrarMessageBox("Perfil editado exitosamente");
                }
                else if (result == DialogResult.No)
                {
                    txtContraActual.Clear();
                    txtContraNueva1.Clear();
                    txtContraNueva2.Clear();
                }
                else
                {

                }             

            }           
            
        }


        private void txtContraNueva1_TextChanged(object sender, EventArgs e)
        {
            ValidacionKeyPress.ActualizaLabel_ContrasenaSegura(txtContraNueva1, lblVerificaContrasena);
        }


        //Ver/Ocultar Contraseña
        #region Ver/Ocultar Contraseña
        private void btnVerContraActual_Click(object sender, EventArgs e)
        {
            if (btnVerContraActual.IconChar == FontAwesome.Sharp.IconChar.Eye)
            {
                btnVerContraActual.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
                txtContraActual.UseSystemPasswordChar = true;
            }
            else
            {
                btnVerContraActual.IconChar = FontAwesome.Sharp.IconChar.Eye;
                txtContraActual.UseSystemPasswordChar = false;
            }

            //Para que no genere un falso positivo al presionar el boton btnContrasena1
            if (txtContraActual.Text == txtContraNueva2.Text)
            {
                errorContrasenaActual.Clear();
            }
        }


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
                errorContraNueva1.Clear();
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
                errorContraNueva2.Clear();
            }

        }
        #endregion Ver/Ocultar Contraseña

        //Mover el Formulario
        #region Mover Formulario
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        #endregion
        //Cerrar Formulario
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
