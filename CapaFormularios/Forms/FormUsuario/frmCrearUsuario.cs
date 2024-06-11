using CapaLogica.Usuarios;
using CapaSoporte.Extras;
using CapaSoporte.Validaciones;
using CapaFormularios.MessageBoxs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace CapaFormularios.Forms.FormUsuario
{
    public partial class frmCrearUsuario : Form
    {
        public frmCrearUsuario()
        {
            InitializeComponent();
        }

        ClaseUsuario claseUsuario = new ClaseUsuario();
        ValidacionErrProv ValidaErrProv = new ValidacionErrProv();

        MessageBoxConfirmarEleccion msgBoxConfirmar = new MessageBoxConfirmarEleccion();
        MessageBoxOperacionExitosa msgBoxOperacion = new MessageBoxOperacionExitosa();        
        

        private void frmCrearUsuario_Load(object sender, EventArgs e)
        {
            //Inicializa los ComboBox
            cmbTipoUsuario.SelectedIndex = 0;
            cmbEstadoUsuario.SelectedIndex = 0;
        }

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            bool NombreUsuarioValido = ValidaErrProv.Valida_Error_NombreUsuario(errorNombreUsuario, txtNombreUsuario);

            bool NombreValido = ValidaErrProv.Valida_CampoVacio(errorNombre, txtNombre);

            bool ApellidoValido = ValidaErrProv.Valida_CampoVacio(errorApellido, txtApellido);

            bool DNIValido = ValidaErrProv.Valida_Error_DNI(errorDNI, txtDNI);

            //bool ContrasenaValida = ValidaErrProv.Valida_ContrasenaDoble(errorContrasena, txtContrasena, txtContrasena2);

            #region Validacion de Correo Electronico

            errorEmail.Clear();
            bool EmailExiste = true;
            if (ValidaErrProv.Valida_Error_Email(errorEmail, txtEmail) == true) //Si devuelve TRUE significa que el formato de Email ingresado es valido
            {
                if (claseUsuario.Verifica_Si_Existe_Email(txtEmail.Text) == false) //Si devuelve FALSE significa que el Email NO EXISTE en la base de datos, por lo tanto se permite su inserción
                {
                    EmailExiste = false;
                }
                else
                {
                    EmailExiste = true;
                    errorEmail.SetError(txtEmail, "El Correo Electronico ingresado ya existe");
                }
            }
            #endregion

            try
            {
                if (NombreUsuarioValido == true && NombreValido == true && ApellidoValido == true && DNIValido == true && EmailExiste == false)
                {

                    DialogResult result = msgBoxConfirmar.MostrarMessageBox("¿Está seguro de crear este usuario?");

                    if (result == DialogResult.Yes)
                    {
                        //En el tercer parametro se utiliza el DNI para inicializar la contraseña por primera vez cuando se crea el usuario
                        claseUsuario.CrearUsuario(Convert.ToInt32(txtDNI.Text), txtNombreUsuario.Text, txtDNI.Text, txtNombre.Text.TrimStart().TrimEnd(), txtApellido.Text.TrimStart().TrimEnd(), cmbTipoUsuario.Text, txtEmail.Text.ToLower(), cmbEstadoUsuario.Text);
                        msgBoxOperacion.MostrarMessageBox("Usuario creado exitosamente");
                        LimpiaTextBox();
                    }
                    else if (result == DialogResult.No)
                    {
                        LimpiaTextBox();
                    }
                    else
                    {

                    }

                }
            }
            catch (Exception) //En caso de que se genere un error/excepción se comprueba si la datos ingresados ya existen la base de datos
            {
                if (claseUsuario.Verifica_Si_Existe_DNI_Usuario(txtDNI.Text) == true)
                {
                    DNIValido = false;
                    errorDNI.SetError(txtDNI, "El DNI ingresado ya existe");
                }

                if (claseUsuario.Verifica_Si_Existe_Email(txtEmail.Text) == true)
                {
                    EmailExiste = true;
                    errorEmail.SetError(txtEmail, "El Correo Electronico ingresado ya existe");
                }           

                if (claseUsuario.Verifica_Si_Existe_NombreUsuario(txtNombreUsuario) == true)
                {
                    NombreUsuarioValido = false;
                    errorNombreUsuario.SetError(txtNombreUsuario, "El Nombre de Usuario ingresado ya existe");
                }
            }
        }

        public void LimpiaTextBox()
        {
            txtNombreUsuario.Clear();
            txtNombre.Clear();
            txtApellido.Clear();
            txtDNI.Clear();
        }



        //Eventos KeyPress de TextBox
        #region Eventos KeyPress de TextBox
        private void txtNombreUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_NombreUsuario(e);
        }

        private void txtNombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Letras_Delete_Space(e);
        }

        private void txtApellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Letras_Delete_Space(e);
        }

        private void txtDNI_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Numeros(e);
        }

        #endregion Eventos KeyPress de TextBox


        //Comprueba si los datos existen al perder el foco el control
        #region Comprueba si los datos existen al perder el foco el control
        private void txtNombreUsuario_Leave(object sender, EventArgs e)
        {
            errorNombreUsuario.Clear();
            if (claseUsuario.Verifica_Si_Existe_NombreUsuario(txtNombreUsuario) == true)
            {                
                errorNombreUsuario.SetError(txtNombreUsuario, "El Nombre de Usuario ingresado ya existe");
            }
        }  
        private void txtDNI_Leave(object sender, EventArgs e)
        {
            errorDNI.Clear();
            if (claseUsuario.Verifica_Si_Existe_DNI_Usuario(txtDNI.Text) == true)
            {
                errorDNI.SetError(txtDNI, "El DNI ingresado ya existe");
            }
        }
        private void txtEmail_Leave(object sender, EventArgs e)
        {
            errorEmail.Clear();
            if (claseUsuario.Verifica_Si_Existe_Email(txtEmail.Text) == true)
            {
                errorEmail.SetError(txtEmail, "El Correo Electronico ingresado ya existe");
            }
        }
        #endregion Comprueba si los datos existen al perder el foco el control



        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //Mover el Formulario
        #region Mover el Formulario 

        ClaseMoverForm mover = new ClaseMoverForm();

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            mover.MoverForm(this.Handle);
        }
        private void lblCrearUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            mover.MoverForm(this.Handle);
        }
        private void iconCrearUsuario_MouseDown(object sender, MouseEventArgs e)
        {
            mover.MoverForm(this.Handle);
        }
        #endregion


    }

}