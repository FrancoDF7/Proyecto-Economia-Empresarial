using CapaSoporte.Cache;
using Software_Contable.Forms.FormUsuario;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//using Software_Contable.Forms.FormProveedor;
//using Software_Contable.Forms.FormCliente;
//using Software_Contable.Forms.FormCompras;
using System.Runtime.InteropServices;
using CapaFormularios.Forms.FormUsuario;
using CapaSoporte.Extras;
//using Software_Contable.Forms.FormProductos;
//using Software_Contable.Forms.FormContabilidad;

namespace Software_Contable.Forms.FormPrincipal
{
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
            InicializarSubmenus();
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            timerReloj.Start();
            CargarDatosUsuario();

            Permisos();


        }



        private void timerReloj_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToShortTimeString();
            lblFecha.Text = DateTime.Now.ToLongDateString();
        }

        #region Botones Principales

 

        #region Productos
        private void btnProductos_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProductoSubmenu);
            //AbrirFormHijo(new frmProductos());
        }
        private void btnProductoIngresar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();

        }
        private void btnVincularProveedor_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();

            //frmProveedoresProductos frmProveedoresProductos= new frmProveedoresProductos();
            //frmProveedoresProductos.ShowDialog();
        }
        private void btnProductoEliminar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        #endregion

        #region Clientes
        private void btnClientes_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelClienteSubmenu);
            //AbrirFormHijo(new frmClientes());
        }
        private void btnClienteIngresar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        private void btnClienteActualizar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        private void btnClienteEliminar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        #endregion

        #region Proveedores
        private void btnProveedores_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelProveedorSubmenu);
            //AbrirFormHijo(new frmProveedores());
        }
        private void btnProveedorIngresar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        private void btnProveedorActualizar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        private void btnProveedorEliminar_Click(object sender, EventArgs e)
        {
            OcultarSubmenu();
        }
        #endregion

        #region Compras

        private void btnCompras_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new frmCompras());
            MostrarSubmenu(panelComprasSubmenu);
        }

        #endregion

        #region Ventas
        private void btnVentas_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelVentasSubmenu);
            //AbrirFormHijo(new frmVentas());
        }

        #endregion

        #region Usuarios

        private void btnUsuarios_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelUsuariosSubmenu);
        }
        #endregion

        #region Contabilidad
        private void btnContabilidad_Click(object sender, EventArgs e)
        {
            MostrarSubmenu(panelContabilidadSubmenu);
        }
        private void btnPlanCuentas_Click(object sender, EventArgs e)
        {
            //AbrirFormHijo(new frmPlanCuentas());
        }

        #endregion

        #endregion Botones Principales


        

        private void btnCrearUsuario_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.ShowDialog();
        }

        private void btnActualizarUsuario_Click(object sender, EventArgs e)
        {
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnEditarPerfil_Click(object sender, EventArgs e)
        {
            
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUsuariosCrear_Click(object sender, EventArgs e)
        {
            frmCrearUsuario frmCrearUsuario = new frmCrearUsuario();
            frmCrearUsuario.ShowDialog();
        }

        private void btnUsuariosActualizar_Click(object sender, EventArgs e)
        {
            frmActualizarUsuario frmActualizarUsuario = new frmActualizarUsuario();
            frmActualizarUsuario.ShowDialog();
        }

        private void btnUsuariosPerfil_Click(object sender, EventArgs e)
        {
            frmEditarPerfil frmEditarPerfil = new frmEditarPerfil();
            frmEditarPerfil.ShowDialog();
        }

        private void btnCerrarSesion_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
            this.Hide();
        }

        private void frmPrincipal_Activated(object sender, EventArgs e)
        {

        }

        private void btnCerrarSesion_MouseLeave(object sender, EventArgs e)
        {
            btnCerrarSesion.BackColor = Color.FromArgb(11, 7, 17);
            btnCerrarSesion.ForeColor = Color.White;
            btnCerrarSesion.IconColor = Color.White;
        }

        private void btnCerrarSesion_MouseMove(object sender,MouseEventArgs e)
        {
            btnCerrarSesion.BackColor = Color.White;
            btnCerrarSesion.ForeColor = Color.Black;
            btnCerrarSesion.IconColor = Color.Black;
        }

        //Muestra el un formulario para cambiar la contraseña si detecta que todos los caracteres de la contraseña son numeros
        private void frmPrincipal_Shown(object sender, EventArgs e)
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
                else if(frmInicializarContrasena.DialogResult == DialogResult.Cancel)
                {
                    this.Close();
                }

            }
        }

        #region Mover Formulario

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ClaseMoverForm mover = new ClaseMoverForm();
            mover.MoverForm(this.Handle);
        }

        #endregion


        #region Metodos

        //Muestra los datos del usuario que se le logeo en los labels
        private void CargarDatosUsuario()
        {
            lblLoginTipoUsuario.Text = ClaseUsuarioCache.TipoUsuario_Cache;
            lblLoginNombreUsuario.Text = ClaseUsuarioCache.NombreUsuario_Cache;
        }
        private void MostrarSubmenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                OcultarSubmenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        private void OcultarSubmenu()
        {
            if (panelProductoSubmenu.Visible == true)
            {
                panelProductoSubmenu.Visible = false;
            }
            if (panelClienteSubmenu.Visible == true)
            {
                panelClienteSubmenu.Visible = false;
            }
            if (panelProveedorSubmenu.Visible == true)
            {
                panelProveedorSubmenu.Visible = false;
            }
            if (panelComprasSubmenu.Visible == true)
            {
                panelComprasSubmenu.Visible = false;
            }
            if (panelVentasSubmenu.Visible == true)
            {
                panelVentasSubmenu.Visible = false;
            }
            if (panelUsuariosSubmenu.Visible == true)
            {
                panelUsuariosSubmenu.Visible = false;
            }
        }
        private void InicializarSubmenus()
        {
            panelProductoSubmenu.Visible = false;
            panelClienteSubmenu.Visible = false;
            panelProveedorSubmenu.Visible = false;
            panelComprasSubmenu.Visible = false;
            panelVentasSubmenu.Visible = false;
            panelUsuariosSubmenu.Visible = false;
        }
        private void AbrirFormHijo(object formHijo)
        {
            // Verificar si el panel contenedor ya tiene un control
            if (this.panelContenedor.Controls.Count > 0)
            {
                // Obtener el control actualmente abierto en el panel contenedor
                var controlActual = this.panelContenedor.Controls[0];

                // Verificar si el control actualmente abierto es un formulario del mismo tipo que el formulario que se está abriendo
                if (controlActual.GetType() == formHijo.GetType())
                {
                    // El formulario ya está abierto, no hacer nada
                    return;
                }
                else
                {
                    // El formulario no está abierto, eliminar el control actualmente abierto en el panel contenedor
                    this.panelContenedor.Controls.RemoveAt(0);
                }
            }

            Form fh = formHijo as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(fh);
            this.panelContenedor.Tag = fh;
            fh.Show();
        }
        public void Permisos()
        {
            if (lblLoginTipoUsuario.Text == "Administrador")
            {

            }

            if (lblLoginTipoUsuario.Text == "Vendedor")
            {
                btnProductos.Visible = false;
                btnClientes.Visible = true;
                btnProveedores.Visible = false;
                btnVentas.Visible = true;
                btnCompras.Visible = false;

                btnUsuariosCrear.Visible = false;
                btnUsuariosActualizar.Visible = false;
                btnUsuariosPerfil.Visible = true;
            }
        }

        #endregion




    }
}
