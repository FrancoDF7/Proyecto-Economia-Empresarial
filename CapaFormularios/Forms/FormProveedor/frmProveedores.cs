using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaLogica.Proveedores;
using CapaSoporte.Validaciones;
using CapaFormularios.MessageBoxs;

namespace CapaFormularios.Forms.FormProveedor
{
    public partial class frmProveedores : Form
    {
        ClaseProveedores claseProveedores = new ClaseProveedores();
        
        ValidacionErrProv ValidaErrProv = new ValidacionErrProv();

        MessageBoxConfirmarEleccion msgBoxConfirmar = new MessageBoxConfirmarEleccion();
        MessageBoxOperacionFallida msgOperacionFallida = new MessageBoxOperacionFallida();

        public frmProveedores()
        {
            InitializeComponent();
        }

        private void frmProveedores_Load(object sender, EventArgs e)
        {
            //Inicializa combobox
            cmbBuscarProveedor.SelectedIndex = 0;
            cmbCondicionIVA.SelectedIndex = 0;

            rbEmailNo.Checked = true;

            ActualizarDataGrid();
        }

        #region Botones
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string cuit = txtCUIT1.Text + "-" + txtCUIT2.Text + "-" + txtCUIT3.Text;

            bool CUIT_LongitudValida = ValidaErrProv.ValidaLongitud_CUIT(errorCuit, txtCUIT1, txtCUIT2, txtCUIT3);
            bool CUIT_Existe = true;
            if (claseProveedores.Valida_Si_Existe_CUIT(cuit) == false)
            {
                CUIT_Existe = false;
            }
            else
            {
                CUIT_Existe = true;
                errorCuit.SetError(txtCUIT3, "Error: El CUIT ingresado ya se encuentra registrado");
            }

            bool NomApe_RazSoc = ValidaErrProv.Valida_CampoVacio(errorNomApe_RazSoc, txtNombreProveedor);
            bool DomicilioValido = ValidaErrProv.Valida_CampoVacio(errorDomicilio, txtDomicilio);
            bool TelefonoValido = ValidaErrProv.Valida_CampoTelefono(errorTelefono, txtTelefono);
            bool EmailValido; errorEmail.Clear();

            //Crear Proveedor
            #region Crear Proveedor
            try
            {
                if (rbEmailSi.Checked == true) //Si el RadioButton Si esta chequedo se Valida si el formato de correo es valido
                {
                    
                    EmailValido = ValidaErrProv.Valida_Error_Email(errorEmail, txtEmail);
                    if (txtCUIT1.Enabled == true && txtCUIT2.Enabled == true && txtCUIT3.Enabled == true)
                    {
                        if (CUIT_LongitudValida == true && CUIT_Existe == false && NomApe_RazSoc == true && DomicilioValido == true && TelefonoValido == true && EmailValido == true)
                        {
                            DialogResult result = msgBoxConfirmar.MostrarMessageBox("¿Está seguro de crear este proveedor?");

                            if (result == DialogResult.Yes)
                            {
                                claseProveedores.CrearProveedor(cuit, txtNombreProveedor.Text, txtDomicilio.Text, txtEmail.Text, txtTelefono.Text, cmbCondicionIVA, rbPersonaFisica, rbPersonaJuridica);
                            }
                            else if (result == DialogResult.No)
                            {
                                LimpiarFormulario();
                            }
                            else
                            {

                            }
                            
                            LimpiarFormulario();
                            ActualizaLista_txtBuscarProveedor();
                            ActualizarDataGrid();
                        }
                    }
                }

                if (rbEmailNo.Checked == true)
                {
                    if (txtCUIT1.Enabled == true && txtCUIT2.Enabled == true && txtCUIT3.Enabled == true)
                    {
                        if (CUIT_LongitudValida == true && CUIT_Existe == false && NomApe_RazSoc == true && DomicilioValido == true && TelefonoValido == true)
                        {
                            DialogResult result = msgBoxConfirmar.MostrarMessageBox("¿Está seguro de crear este proveedor?");

                            if (result == DialogResult.Yes)
                            {
                                claseProveedores.CrearProveedor(cuit, txtNombreProveedor.Text, txtDomicilio.Text, txtEmail.Text, txtTelefono.Text, cmbCondicionIVA, rbPersonaFisica, rbPersonaJuridica);
                            }
                            else if (result == DialogResult.No)
                            {
                                LimpiarFormulario();
                            }
                            else
                            {

                            }

                            LimpiarFormulario();
                            ActualizaLista_txtBuscarProveedor();
                            ActualizarDataGrid();
                        }
                    }
                }
                                
            }
            catch (Exception)
            {
                if (claseProveedores.Valida_Si_Existe_CUIT(cuit) == true)
                {
                    errorCuit.SetError(txtCUIT3, "Error: El CUIT ingresado ya se encuentra registrado");
                }                
            }
            #endregion

            //Actualizar Proveedor
            #region Actualizar Proveedor
            try
            {
                if (rbEmailSi.Checked == true)
                {
                    if (txtCUIT1.Enabled == false && txtCUIT2.Enabled == false && txtCUIT3.Enabled == false) //Valida que los texbox de cuit este desactivados para que no se pueda modificar el CUIT durante la actualizacion del registro
                    {
                        errorCuit.Clear(); //Limpiar el errorProvider de CUIT repetido, ya que al actualizar debe existir en la base de base datos

                        EmailValido = ValidaErrProv.Valida_Error_Email(errorEmail, txtEmail);
                        if (NomApe_RazSoc == true && DomicilioValido == true && TelefonoValido == true && EmailValido == true)
                        {
                            DialogResult result = msgBoxConfirmar.MostrarMessageBox("¿Está seguro de actualizar este proveedor?");

                            if (result == DialogResult.Yes)
                            {
                                claseProveedores.ActualizarProveedor(cuit, txtNombreProveedor.Text, txtDomicilio.Text, txtEmail.Text, txtTelefono.Text, rbPersonaFisica, rbPersonaJuridica);

                                LimpiarFormulario();
                                ActualizaLista_txtBuscarProveedor();
                                ActualizarDataGrid();
                            }
                            else if (result == DialogResult.No)
                            {
                                LimpiarFormulario();
                            }
                            else
                            {

                            }
                        }
                    }
                }

                if (rbEmailNo.Checked == true)
                {
                    if (txtCUIT1.Enabled == false && txtCUIT2.Enabled == false && txtCUIT3.Enabled == false) //Valida que los texbox de cuit este desactivados para que no se pueda modificar el CUIT durante la actualizacion del registro
                    {
                        errorCuit.Clear(); //Limpiar el errorProvider de CUIT repetido, ya que al actualizar debe existir en la base de base datos
                        if (NomApe_RazSoc == true && DomicilioValido == true && TelefonoValido == true)
                        {
                            DialogResult result = msgBoxConfirmar.MostrarMessageBox("¿Está seguro de crear este proveedor?");

                            if (result == DialogResult.Yes)
                            {
                                claseProveedores.ActualizarProveedor(cuit, txtNombreProveedor.Text, txtDomicilio.Text, txtEmail.Text, txtTelefono.Text, rbPersonaFisica, rbPersonaJuridica);

                                LimpiarFormulario();
                                ActualizaLista_txtBuscarProveedor();
                                ActualizarDataGrid();
                            }
                            else if (result == DialogResult.No)
                            {
                                LimpiarFormulario();
                            }
                            else
                            {

                            }
                        }
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            #endregion

        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string cuit = txtCUIT1.Text + "-" + txtCUIT2.Text + "-" + txtCUIT3.Text;

            claseProveedores.BorrarProveedor(cuit);
            LimpiarFormulario();
            ActualizaLista_txtBuscarProveedor();
            ActualizarDataGrid();
        }
        private void btnBuscarProveedor_Click(object sender, EventArgs e)
        {
            var resultado = claseProveedores.BuscarProveedor_DataGridView(cmbBuscarProveedor.Text, txtBuscarProveedor.Text);

            if (resultado != null && resultado.Rows.Count > 0)
            {
                dtgProveedores.DataSource = resultado;
                dtgProveedores.Columns["CodTipoPersona"].Visible = false; //Oculta la columna CodTipoPersona
            }
            else
            {                
                msgOperacionFallida.MostrarMessageBox("No se encontraron registros");
            }
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarFormulario();
        }

        #region Volver a cargar DataGridView
        private void btnRecargar_Click(object sender, EventArgs e)
        {
            txtBuscarProveedor.Clear(); //Al limpiarse el textbox se dispara el evento de textChanged del mismo textBox
        }
        private void txtBuscarProveedor_TextChanged(object sender, EventArgs e)
        {
            if (txtBuscarProveedor.Text == "")
            {
                ActualizarDataGrid();
            }
        }
        #endregion

        #endregion

        #region RadioButtons
        private void rbEmailSi_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmailSi.Checked)
            {
                txtEmail.Enabled = true;
                if (txtEmail.Text == "No posee")
                {
                    txtEmail.Clear();
                }
            }
        }
        private void rbEmailNo_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmailNo.Checked)
            {
                txtEmail.Enabled = false;
                txtEmail.Text = "No posee";
                errorEmail.Clear();
            }
        }
        #endregion

        #region ComboBox
        private void cmbBuscarProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtBuscarProveedor.Clear();
            ActualizaLista_txtBuscarProveedor();
        }
        #endregion

        #region Envia datos de la grilla a los campos correspondientes

        int index;
        private void dtgProveedores_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            index = e.RowIndex;

            txtCUIT1.Enabled = false;
            txtCUIT2.Enabled = false;
            txtCUIT3.Enabled = false;

            if (index != -1)
            {
                string Cuit = dtgProveedores.Rows[index].Cells[0].Value.ToString();
                string[] partesCuit = Cuit.Split('-');

                txtCUIT1.Text = partesCuit[0];
                txtCUIT2.Text = partesCuit[1];
                txtCUIT3.Text = partesCuit[2];

                txtNombreProveedor.Text = dtgProveedores.Rows[index].Cells[1].Value.ToString();
                txtDomicilio.Text = dtgProveedores.Rows[index].Cells[2].Value.ToString();
                txtEmail.Text = dtgProveedores.Rows[index].Cells[3].Value.ToString();
                txtTelefono.Text = dtgProveedores.Rows[index].Cells[4].Value.ToString();

                txtTelefono.ForeColor = Color.Black;

                if (txtEmail.Text == "No posee")
                {
                    rbEmailNo.Checked = true;
                    txtEmail.Enabled = false;
                    txtEmail.BackColor = Color.White;
                }
                else
                {
                    rbEmailSi.Checked = true;
                    txtEmail.Enabled = true;
                    txtEmail.BackColor = Color.LemonChiffon;
                }

                if (dtgProveedores.Rows[index].Cells[5].Value.ToString() == "1")
                {
                    rbPersonaFisica.Checked = true;
                }
                else
                {
                    rbPersonaJuridica.Checked = true;
                }

                txtNombreProveedor.BackColor = Color.LemonChiffon;
                txtDomicilio.BackColor = Color.LemonChiffon;                                
                txtTelefono.BackColor = Color.LemonChiffon;


            }
            
        }

        #endregion

        #region Eventos Textboxs

        //Eventos txtTelefono
        private void txtTelefono_Enter(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "Ej: (011) 1010-1010")
            {
                txtTelefono.Text = "";
                txtTelefono.ForeColor = Color.Black;
            }
        }
        private void txtTelefono_Leave(object sender, EventArgs e)
        {
            if (txtTelefono.Text == "")
            {
                txtTelefono.Text = "Ej: (011) 1010-1010";
                txtTelefono.ForeColor = Color.Gray;
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Numeros(e);
        }

        //Eventos CUIT
        private void txtCUIT1_TextChanged(object sender, EventArgs e)
        {
            if (txtCUIT1.Text.Length >= 2)
            {
                txtCUIT2.Focus();
            }
        }
        private void txtCUIT2_TextChanged(object sender, EventArgs e)
        {
            if (txtCUIT2.Text.Length >= 8)
            {
                txtCUIT3.Focus();
            }
        }
        private void txtCUIT3_TextChanged(object sender, EventArgs e)
        {
            if (txtCUIT3.Text.Length >= 1)
            {
                txtNombreProveedor.Focus();
            }
        }

        //Valida CUIT
        private void txtCUIT1_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Numeros(e);
            //if (Convert.ToInt32(txtCUIT1.Text) == 2)
            //{

            //}
        }
        private void txtCUIT2_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Numeros(e);
        }
        private void txtCUIT3_KeyPress(object sender, KeyPressEventArgs e)
        {
            ValidacionKeyPress.Valida_Numeros(e);
        }

        #endregion

        #region Metodos

        private void LimpiarFormulario()
        {
            //Habilita txtCuit
            txtCUIT1.Enabled = true;
            txtCUIT2.Enabled = true;
            txtCUIT3.Enabled = true;

            //Limpia y devuelva a sus valores por defecto a los textbox
            txtCUIT1.Clear();
            txtCUIT2.Clear();
            txtCUIT3.Clear();
            txtNombreProveedor.Clear();
            txtDomicilio.Clear();
            txtEmail.Text = "No posee";
            txtTelefono.Text = "Ej: (011) 1010-1010";
            txtTelefono.ForeColor = Color.Gray;

            //Inicializa Colores
            txtNombreProveedor.BackColor = Color.White;
            txtDomicilio.BackColor = Color.White;
            txtEmail.BackColor = Color.White;
            txtTelefono.BackColor = Color.White;

            //Limpia ErrorProviders
            errorCuit.Clear();
            errorNomApe_RazSoc.Clear();
            errorDomicilio.Clear();
            errorTelefono.Clear();

            //Inicialiaza RadioButtonEmail
            rbEmailNo.PerformClick();
        }
        public void ActualizarDataGrid()
        {
            dtgProveedores.DataSource = claseProveedores.CargaDTG_Proveedores();
            dtgProveedores.Columns["CodTipoPersona"].Visible = false;
        }
        public void ActualizaLista_txtBuscarProveedor()
        {
            txtBuscarProveedor.AutoCompleteCustomSource = claseProveedores.CargaTextBox_Proveedor(cmbBuscarProveedor.Text);
        }

        #endregion


    }
}
