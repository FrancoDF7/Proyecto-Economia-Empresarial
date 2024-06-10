using CapaFormularios.Forms.FormUsuario;
using CapaSoporte.Extras;
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

namespace Software_Contable.MessageBoxs
{
    public partial class MessageBoxConfirmarEleccion : Form
    {
        public MessageBoxConfirmarEleccion()
        {
            InitializeComponent();
        }

        private void MessageBoxConfirmarEleccion_Load(object sender, EventArgs e)
        {

        }

        #region Botones
        private void btnSi_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Yes;
        }
        private void btnNo_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.No;
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
        #endregion


        public DialogResult MostrarMessageBox(string mensaje)
        {
            lblMensaje.Text = mensaje;
            return ShowDialog(null);
        }


        #region Mover Formulario
        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ClaseMoverForm mover = new ClaseMoverForm();
            mover.MoverForm(this.Handle);
        }
        #endregion

        #region Eventos btnCerrar
        private void btnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }        
        private void btnCerrar_MouseLeave(object sender, EventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(60, 60, 60);
        }
        private void btnCerrar_MouseMove(object sender, MouseEventArgs e)
        {
            btnCerrar.BackColor = Color.FromArgb(232, 17, 35);
        }

        #endregion Eventos btnCerrar

    }
}
