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
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaFormularios.Forms.FormUsuario
{
    public partial class frmActualizarUsuario : Form
    {
        public frmActualizarUsuario()
        {
            InitializeComponent();
        }
        

        ClaseUsuario claseUsuario = new ClaseUsuario();

        ValidacionErrProv ValidaErrProv = new ValidacionErrProv();

        MessageBoxOperacionFallida msgOperacionFallida = new MessageBoxOperacionFallida();


        string DNI_Usuario;
        string Email_Usuario;

        private void frmActualizarUsuario_Load(object sender, EventArgs e)
        {
            Actualizar_dtgListaUsuarios();

            txtContrasena.UseSystemPasswordChar = true;

            rbEmailNo.Checked = true;

            rbContraNo.Checked = true;

            cmbTipoUsuario.SelectedIndex = 0;
            cmbEstadoUsuario.SelectedIndex = 0;
            cmbBuscarUsuario.SelectedIndex = 0;

            txtContrasenaAdmin.UseSystemPasswordChar = true;
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            //No es necesario validar el Nombre de Usuario ya que no puede cambiar en la Actualizacion del Usuario

            bool NombreValido = ValidaErrProv.Valida_CampoVacio(errorNombre, txtNombre);

            bool ApellidoValido = ValidaErrProv.Valida_CampoVacio(errorApellido, txtApellido);

            bool DNIValido = claseUsuario.Verifica_Si_Existe_DNI_Usuario(txtDNI.Text);

            bool EmailValido = ValidaErrProv.Valida_Error_Email(errorEmail, txtEmail);

            errorContrasena.Clear();

            //Se guarda el DNI del usuario seleccionado en DNI_Usuario,
            if (txtDNI.Text == DNI_Usuario)
            {
                errorDNI.Clear();
            }

            try
            {
                //SE ACTUALIZA LA CONTRASEÑA
                #region Actualiza Contraseña
                if (rbContraSi.Checked)
                {
                    bool ContrasenaValida = ValidaErrProv.Valida_CampoVacio(errorContrasena, txtContrasena); // Valida la contraseña si esta chequedo el RadioButton rbContraSi

                    if (rbEmailSi.Checked)
                    {
                        if (txtEmail.Text == Email_Usuario)
                        {
                            errorEmail.Clear();
                        }
                        if (NombreValido == true && ApellidoValido == true && DNIValido == true && ContrasenaValida == true && EmailValido == true)
                        {
                            MetodoActualizarUsuario();
                            Actualizar_dtgListaUsuarios();
                        }
                    }

                    if (rbEmailNo.Checked)
                    {
                        if (NombreValido == true && ApellidoValido == true && DNIValido == true && ContrasenaValida == true)
                        {
                            errorEmail.Clear(); //Limpia el error ya que en este IF no se debe validar el Email
                            MetodoActualizarUsuario();
                            Actualizar_dtgListaUsuarios();
                        }
                    }
                }
                #endregion Actualiza Contraseña

                //NO SE ACTUALIZA LA CONTRASEÑA
                #region No Actualiza Contraseña
                if (rbContraNo.Checked)
                {
                    if (rbEmailSi.Checked)
                    {
                        if (NombreValido == true && ApellidoValido == true && DNIValido == true && EmailValido == true)
                        {
                            MetodoActualizarUsuario();
                            Actualizar_dtgListaUsuarios();
                        }
                    }

                    if (rbEmailNo.Checked)
                    {
                        if (NombreValido == true && ApellidoValido == true && DNIValido == true)
                        {
                            errorEmail.Clear(); //Limpia el error ya que en este IF no se debe validar el Email
                            MetodoActualizarUsuario();
                            Actualizar_dtgListaUsuarios();
                        }
                    }
                }
                #endregion No Actualiza Contraseña



            }
            catch (Exception)
            {

                if (claseUsuario.Verifica_Si_Existe_DNI_Usuario(txtDNI.Text) == true)
                {
                    DNIValido = false;
                    errorDNI.SetError(txtDNI, "El DNI ingresado ya existe");
                }

                if (claseUsuario.Verifica_Si_Existe_Email(txtEmail.Text) && txtEmail.Text != Email_Usuario)
                {
                    EmailValido = false;
                    errorEmail.SetError(txtEmail, "El Correo Electronico ingresado ya existe");
                }

            }

        }

        public void MetodoActualizarUsuario()
        {
            claseUsuario.ActualizarUsuario(Convert.ToInt32(txtDNI.Text), txtNombreUsuario.Text, txtContrasena.Text, txtNombre.Text, txtApellido.Text, cmbTipoUsuario.Text, txtEmail.Text.ToLower(), cmbEstadoUsuario.Text, rbContraSi, rbContraNo);
        }

        private void rbContraSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContraSi.Checked)
            {
                txtContrasena.Enabled = true;
            }

        }

        private void rbContraNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbContraNo.Checked)
            {
                txtContrasena.Enabled = false;
                txtContrasena.Clear();
            }
        }

        private void dtgListaUsuarios_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index != -1)
            {
                //Guarda en las variables el DNI y Email del usuario seleccionado
                DNI_Usuario = dtgListaUsuarios.Rows[index].Cells[0].Value.ToString();
                Email_Usuario = dtgListaUsuarios.Rows[index].Cells[3].Value.ToString();


                txtDNI.Text = dtgListaUsuarios.Rows[index].Cells[0].Value.ToString();
                txtNombreUsuario.Text = dtgListaUsuarios.Rows[index].Cells[1].Value.ToString();
                txtNombre.Text = dtgListaUsuarios.Rows[index].Cells[2].Value.ToString();
                txtApellido.Text = dtgListaUsuarios.Rows[index].Cells[3].Value.ToString();
                cmbTipoUsuario.Text = dtgListaUsuarios.Rows[index].Cells[4].Value.ToString();
                txtEmail.Text = dtgListaUsuarios.Rows[index].Cells[5].Value.ToString();
                cmbEstadoUsuario.Text = dtgListaUsuarios.Rows[index].Cells[6].Value.ToString();

                //if (txtEmail.Text == "No posee")
                //{
                //    rbEmailNo.Checked = true;
                //    txtEmail.Enabled = false;
                //    txtEmail.BackColor = Color.White;
                //}
                //else
                //{
                //    rbEmailSi.Checked = true;
                //    txtEmail.Enabled = true;
                //    txtEmail.BackColor = Color.LemonChiffon;
                //}

                rbEmailNo.Checked = true;


                txtDNI.BackColor = Color.LemonChiffon;
                txtNombreUsuario.BackColor = Color.LemonChiffon;
                txtNombre.BackColor = Color.LemonChiffon;
                txtApellido.BackColor = Color.LemonChiffon;
                txtEmail.BackColor = Color.LemonChiffon;

            }
        }

        public void Actualizar_dtgListaUsuarios()
        {
            dtgListaUsuarios.DataSource = claseUsuario.CargaDTG_ActualizarUsuario();
        }



        private void txtDNI_Leave(object sender, EventArgs e)
        {
            errorDNI.Clear();
            if (claseUsuario.Verifica_Si_Existe_DNI_Usuario(txtDNI.Text) == true && txtDNI.Text != DNI_Usuario)
            {
                errorDNI.SetError(txtDNI, "El DNI ingresado ya existe");
            }
        }

        #region Eventos btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.Black;
        }
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(232, 17, 35);
        }

        #endregion Eventos btnCerrar

        //Eventos para mover el Formulario
        #region Mover Formulario
        private void BarraTitulo_MouseDown_1(object sender, MouseEventArgs e)
        {
            ClaseMoverForm mover = new ClaseMoverForm();
            mover.MoverForm(this.Handle);
        }

        #endregion


        private void rbEmailSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmailSi.Checked == true)
            {
                txtEmail.Enabled = true;
            }
            else
            {
                txtEmail.Enabled = false;
            }
        }

        private void rbEmailNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmailNo.Checked == true)
            {
                txtEmail.Enabled = false;
            }
            else
            {
                txtEmail.Enabled = true;
            }
        }

        #region Buscar Usuario
        private void btnBuscarUsuario_Click(object sender, EventArgs e)
        {
            var resultado = claseUsuario.BuscarUsuario_DataGridView(cmbBuscarUsuario.Text, txtBuscarUsuario.Text);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                dtgListaUsuarios.DataSource = resultado;
            }
            else
            {
                msgOperacionFallida.MostrarMessageBox("No se encontraron registros");
            } 
        }

        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtBuscarUsuario.Clear();
        }

        private void cmbBuscarUsuario_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarUsuario.Clear();
            ActualizaLista_txtBuscarUsuario();
        }

        private void txtBuscarUsuario_TextChanged(object sender, EventArgs e)
        {
            if(txtBuscarUsuario.Text == "")
            {
                Actualizar_dtgListaUsuarios();
            }
        }

        public void ActualizaLista_txtBuscarUsuario()
        {
            txtBuscarUsuario.AutoCompleteCustomSource = claseUsuario.CargaTextBox_Usuario(cmbBuscarUsuario.Text);
        }
        #endregion


    }
}
