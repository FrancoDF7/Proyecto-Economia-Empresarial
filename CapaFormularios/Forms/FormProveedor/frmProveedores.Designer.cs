namespace CapaFormularios.Forms.FormProveedor
{
    partial class frmProveedores
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel_superior = new System.Windows.Forms.Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.lblSeccionProveedores = new System.Windows.Forms.Label();
            this.lblCUIT = new System.Windows.Forms.Label();
            this.txtCUIT2 = new System.Windows.Forms.TextBox();
            this.txtNombreProveedor = new System.Windows.Forms.TextBox();
            this.lblNombreRazon = new System.Windows.Forms.Label();
            this.panelLista = new System.Windows.Forms.Panel();
            this.btnRecargar = new FontAwesome.Sharp.IconButton();
            this.btnBuscarProveedor = new FontAwesome.Sharp.IconButton();
            this.txtBuscarProveedor = new System.Windows.Forms.TextBox();
            this.dtgProveedores = new System.Windows.Forms.DataGridView();
            this.lblListaProveedores = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbBuscarProveedor = new System.Windows.Forms.ComboBox();
            this.grpbCorreo = new System.Windows.Forms.GroupBox();
            this.rbPersonaJuridica = new System.Windows.Forms.RadioButton();
            this.rbPersonaFisica = new System.Windows.Forms.RadioButton();
            this.txtDomicilio = new System.Windows.Forms.TextBox();
            this.lblDomicilio = new System.Windows.Forms.Label();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.txtCUIT3 = new System.Windows.Forms.TextBox();
            this.txtCUIT1 = new System.Windows.Forms.TextBox();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            this.btnEliminar = new FontAwesome.Sharp.IconButton();
            this.btnLimpiar = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblDetallesProveedor = new System.Windows.Forms.Label();
            this.panelDetalles = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbEmailNo = new System.Windows.Forms.RadioButton();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.rbEmailSi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.errorNomApe_RazSoc = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDomicilio = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorTelefono = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorCuit = new System.Windows.Forms.ErrorProvider(this.components);
            this.grpbCondicionIVA = new System.Windows.Forms.GroupBox();
            this.cmbCondicionIVA = new System.Windows.Forms.ComboBox();
            this.panel_superior.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panelLista.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).BeginInit();
            this.grpbCorreo.SuspendLayout();
            this.panelDetalles.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomApe_RazSoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDomicilio)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCuit)).BeginInit();
            this.grpbCondicionIVA.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_superior
            // 
            this.panel_superior.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.panel_superior.Controls.Add(this.iconPictureBox1);
            this.panel_superior.Controls.Add(this.lblSeccionProveedores);
            this.panel_superior.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_superior.Location = new System.Drawing.Point(0, 0);
            this.panel_superior.Name = "panel_superior";
            this.panel_superior.Size = new System.Drawing.Size(1297, 41);
            this.panel_superior.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(25)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.TruckMoving;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 49;
            this.iconPictureBox1.Location = new System.Drawing.Point(302, 0);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 55);
            this.iconPictureBox1.TabIndex = 46;
            this.iconPictureBox1.TabStop = false;
            // 
            // lblSeccionProveedores
            // 
            this.lblSeccionProveedores.AutoSize = true;
            this.lblSeccionProveedores.Font = new System.Drawing.Font("Calibri", 18F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionProveedores.ForeColor = System.Drawing.Color.White;
            this.lblSeccionProveedores.Location = new System.Drawing.Point(16, 2);
            this.lblSeccionProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccionProveedores.Name = "lblSeccionProveedores";
            this.lblSeccionProveedores.Size = new System.Drawing.Size(273, 37);
            this.lblSeccionProveedores.TabIndex = 45;
            this.lblSeccionProveedores.Text = "Sección Proveedores";
            // 
            // lblCUIT
            // 
            this.lblCUIT.AutoSize = true;
            this.lblCUIT.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCUIT.Location = new System.Drawing.Point(19, 55);
            this.lblCUIT.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCUIT.Name = "lblCUIT";
            this.lblCUIT.Size = new System.Drawing.Size(59, 22);
            this.lblCUIT.TabIndex = 63;
            this.lblCUIT.Text = "CUIT *";
            // 
            // txtCUIT2
            // 
            this.txtCUIT2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT2.Location = new System.Drawing.Point(78, 82);
            this.txtCUIT2.MaxLength = 8;
            this.txtCUIT2.Name = "txtCUIT2";
            this.txtCUIT2.ShortcutsEnabled = false;
            this.txtCUIT2.Size = new System.Drawing.Size(192, 27);
            this.txtCUIT2.TabIndex = 2;
            this.txtCUIT2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCUIT2.TextChanged += new System.EventHandler(this.txtCUIT2_TextChanged);
            this.txtCUIT2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT2_KeyPress);
            // 
            // txtNombreProveedor
            // 
            this.txtNombreProveedor.BackColor = System.Drawing.SystemColors.Window;
            this.txtNombreProveedor.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombreProveedor.Location = new System.Drawing.Point(24, 135);
            this.txtNombreProveedor.MaxLength = 50;
            this.txtNombreProveedor.Name = "txtNombreProveedor";
            this.txtNombreProveedor.ShortcutsEnabled = false;
            this.txtNombreProveedor.Size = new System.Drawing.Size(301, 27);
            this.txtNombreProveedor.TabIndex = 4;
            // 
            // lblNombreRazon
            // 
            this.lblNombreRazon.AutoSize = true;
            this.lblNombreRazon.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreRazon.Location = new System.Drawing.Point(19, 115);
            this.lblNombreRazon.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreRazon.Name = "lblNombreRazon";
            this.lblNombreRazon.Size = new System.Drawing.Size(253, 21);
            this.lblNombreRazon.TabIndex = 69;
            this.lblNombreRazon.Text = "Nombre y Apellido / Razon Social *";
            // 
            // panelLista
            // 
            this.panelLista.Controls.Add(this.btnRecargar);
            this.panelLista.Controls.Add(this.btnBuscarProveedor);
            this.panelLista.Controls.Add(this.txtBuscarProveedor);
            this.panelLista.Controls.Add(this.dtgProveedores);
            this.panelLista.Controls.Add(this.lblListaProveedores);
            this.panelLista.Controls.Add(this.label4);
            this.panelLista.Controls.Add(this.cmbBuscarProveedor);
            this.panelLista.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelLista.Location = new System.Drawing.Point(373, 41);
            this.panelLista.Name = "panelLista";
            this.panelLista.Size = new System.Drawing.Size(924, 707);
            this.panelLista.TabIndex = 71;
            // 
            // btnRecargar
            // 
            this.btnRecargar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnRecargar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecargar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnRecargar.FlatAppearance.BorderSize = 2;
            this.btnRecargar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnRecargar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecargar.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecargar.ForeColor = System.Drawing.Color.White;
            this.btnRecargar.IconChar = FontAwesome.Sharp.IconChar.RotateForward;
            this.btnRecargar.IconColor = System.Drawing.Color.White;
            this.btnRecargar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRecargar.IconSize = 20;
            this.btnRecargar.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRecargar.Location = new System.Drawing.Point(780, 66);
            this.btnRecargar.Name = "btnRecargar";
            this.btnRecargar.Size = new System.Drawing.Size(112, 34);
            this.btnRecargar.TabIndex = 88;
            this.btnRecargar.Text = "Recargar";
            this.btnRecargar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRecargar.UseVisualStyleBackColor = false;
            this.btnRecargar.Click += new System.EventHandler(this.btnRecargar_Click);
            // 
            // btnBuscarProveedor
            // 
            this.btnBuscarProveedor.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnBuscarProveedor.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBuscarProveedor.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.FlatAppearance.BorderSize = 2;
            this.btnBuscarProveedor.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnBuscarProveedor.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBuscarProveedor.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarProveedor.ForeColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlass;
            this.btnBuscarProveedor.IconColor = System.Drawing.Color.White;
            this.btnBuscarProveedor.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnBuscarProveedor.IconSize = 20;
            this.btnBuscarProveedor.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBuscarProveedor.Location = new System.Drawing.Point(653, 66);
            this.btnBuscarProveedor.Name = "btnBuscarProveedor";
            this.btnBuscarProveedor.Size = new System.Drawing.Size(112, 34);
            this.btnBuscarProveedor.TabIndex = 87;
            this.btnBuscarProveedor.Text = "Buscar";
            this.btnBuscarProveedor.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBuscarProveedor.UseVisualStyleBackColor = false;
            this.btnBuscarProveedor.Click += new System.EventHandler(this.btnBuscarProveedor_Click);
            // 
            // txtBuscarProveedor
            // 
            this.txtBuscarProveedor.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.txtBuscarProveedor.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.CustomSource;
            this.txtBuscarProveedor.Location = new System.Drawing.Point(443, 73);
            this.txtBuscarProveedor.MaxLength = 50;
            this.txtBuscarProveedor.Name = "txtBuscarProveedor";
            this.txtBuscarProveedor.Size = new System.Drawing.Size(200, 22);
            this.txtBuscarProveedor.TabIndex = 86;
            this.txtBuscarProveedor.TextChanged += new System.EventHandler(this.txtBuscarProveedor_TextChanged);
            // 
            // dtgProveedores
            // 
            this.dtgProveedores.AllowUserToAddRows = false;
            this.dtgProveedores.AllowUserToDeleteRows = false;
            this.dtgProveedores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtgProveedores.BackgroundColor = System.Drawing.Color.White;
            this.dtgProveedores.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dtgProveedores.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(5);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(234)))), ((int)(((byte)(42)))), ((int)(((byte)(83)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dtgProveedores.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dtgProveedores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProveedores.EnableHeadersVisualStyles = false;
            this.dtgProveedores.GridColor = System.Drawing.Color.White;
            this.dtgProveedores.Location = new System.Drawing.Point(25, 110);
            this.dtgProveedores.Margin = new System.Windows.Forms.Padding(4);
            this.dtgProveedores.MultiSelect = false;
            this.dtgProveedores.Name = "dtgProveedores";
            this.dtgProveedores.ReadOnly = true;
            this.dtgProveedores.RowHeadersVisible = false;
            this.dtgProveedores.RowHeadersWidth = 51;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            this.dtgProveedores.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dtgProveedores.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtgProveedores.Size = new System.Drawing.Size(867, 573);
            this.dtgProveedores.TabIndex = 85;
            this.dtgProveedores.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProveedores_CellClick);
            // 
            // lblListaProveedores
            // 
            this.lblListaProveedores.AutoSize = true;
            this.lblListaProveedores.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblListaProveedores.Location = new System.Drawing.Point(20, 25);
            this.lblListaProveedores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblListaProveedores.Name = "lblListaProveedores";
            this.lblListaProveedores.Size = new System.Drawing.Size(176, 28);
            this.lblListaProveedores.TabIndex = 84;
            this.lblListaProveedores.Text = "Lista Proveedores";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(157, 73);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 22);
            this.label4.TabIndex = 72;
            this.label4.Text = "Buscar por:";
            // 
            // cmbBuscarProveedor
            // 
            this.cmbBuscarProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBuscarProveedor.FormattingEnabled = true;
            this.cmbBuscarProveedor.Items.AddRange(new object[] {
            "CUIT",
            "Nombre Proveedor",
            "Domicilio",
            "Correo Electrónico",
            "Teléfono"});
            this.cmbBuscarProveedor.Location = new System.Drawing.Point(255, 72);
            this.cmbBuscarProveedor.Name = "cmbBuscarProveedor";
            this.cmbBuscarProveedor.Size = new System.Drawing.Size(172, 24);
            this.cmbBuscarProveedor.TabIndex = 71;
            this.cmbBuscarProveedor.SelectedIndexChanged += new System.EventHandler(this.cmbBuscarProveedor_SelectedIndexChanged);
            // 
            // grpbCorreo
            // 
            this.grpbCorreo.Controls.Add(this.rbPersonaJuridica);
            this.grpbCorreo.Controls.Add(this.rbPersonaFisica);
            this.grpbCorreo.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCorreo.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpbCorreo.Location = new System.Drawing.Point(24, 468);
            this.grpbCorreo.Margin = new System.Windows.Forms.Padding(4);
            this.grpbCorreo.Name = "grpbCorreo";
            this.grpbCorreo.Padding = new System.Windows.Forms.Padding(4);
            this.grpbCorreo.Size = new System.Drawing.Size(302, 53);
            this.grpbCorreo.TabIndex = 77;
            this.grpbCorreo.TabStop = false;
            this.grpbCorreo.Text = "Tipo de persona";
            // 
            // rbPersonaJuridica
            // 
            this.rbPersonaJuridica.AutoSize = true;
            this.rbPersonaJuridica.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonaJuridica.Location = new System.Drawing.Point(151, 25);
            this.rbPersonaJuridica.Margin = new System.Windows.Forms.Padding(4);
            this.rbPersonaJuridica.Name = "rbPersonaJuridica";
            this.rbPersonaJuridica.Size = new System.Drawing.Size(143, 25);
            this.rbPersonaJuridica.TabIndex = 8;
            this.rbPersonaJuridica.Text = "Persona Jurídica";
            this.rbPersonaJuridica.UseVisualStyleBackColor = true;
            // 
            // rbPersonaFisica
            // 
            this.rbPersonaFisica.AutoSize = true;
            this.rbPersonaFisica.Checked = true;
            this.rbPersonaFisica.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbPersonaFisica.Location = new System.Drawing.Point(13, 25);
            this.rbPersonaFisica.Margin = new System.Windows.Forms.Padding(4);
            this.rbPersonaFisica.Name = "rbPersonaFisica";
            this.rbPersonaFisica.Size = new System.Drawing.Size(129, 25);
            this.rbPersonaFisica.TabIndex = 7;
            this.rbPersonaFisica.TabStop = true;
            this.rbPersonaFisica.Text = "Persona Física";
            this.rbPersonaFisica.UseVisualStyleBackColor = true;
            // 
            // txtDomicilio
            // 
            this.txtDomicilio.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDomicilio.Location = new System.Drawing.Point(24, 190);
            this.txtDomicilio.MaxLength = 50;
            this.txtDomicilio.Name = "txtDomicilio";
            this.txtDomicilio.ShortcutsEnabled = false;
            this.txtDomicilio.Size = new System.Drawing.Size(301, 27);
            this.txtDomicilio.TabIndex = 5;
            // 
            // lblDomicilio
            // 
            this.lblDomicilio.AutoSize = true;
            this.lblDomicilio.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDomicilio.Location = new System.Drawing.Point(20, 166);
            this.lblDomicilio.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDomicilio.Name = "lblDomicilio";
            this.lblDomicilio.Size = new System.Drawing.Size(87, 21);
            this.lblDomicilio.TabIndex = 76;
            this.lblDomicilio.Text = "Domicilio *";
            // 
            // txtTelefono
            // 
            this.txtTelefono.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTelefono.ForeColor = System.Drawing.Color.DimGray;
            this.txtTelefono.Location = new System.Drawing.Point(23, 245);
            this.txtTelefono.MaxLength = 15;
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.ShortcutsEnabled = false;
            this.txtTelefono.Size = new System.Drawing.Size(302, 27);
            this.txtTelefono.TabIndex = 7;
            this.txtTelefono.Text = "Ej: (011) 1010-1010";
            this.txtTelefono.Enter += new System.EventHandler(this.txtTelefono_Enter);
            this.txtTelefono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTelefono_KeyPress);
            this.txtTelefono.Leave += new System.EventHandler(this.txtTelefono_Leave);
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTelefono.Location = new System.Drawing.Point(19, 221);
            this.lblTelefono.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(80, 21);
            this.lblTelefono.TabIndex = 74;
            this.lblTelefono.Text = "Teléfono *";
            // 
            // txtCUIT3
            // 
            this.txtCUIT3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT3.Location = new System.Drawing.Point(275, 82);
            this.txtCUIT3.MaxLength = 1;
            this.txtCUIT3.Name = "txtCUIT3";
            this.txtCUIT3.ShortcutsEnabled = false;
            this.txtCUIT3.Size = new System.Drawing.Size(50, 27);
            this.txtCUIT3.TabIndex = 3;
            this.txtCUIT3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCUIT3.TextChanged += new System.EventHandler(this.txtCUIT3_TextChanged);
            this.txtCUIT3.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT3_KeyPress);
            // 
            // txtCUIT1
            // 
            this.txtCUIT1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCUIT1.Location = new System.Drawing.Point(23, 82);
            this.txtCUIT1.MaxLength = 2;
            this.txtCUIT1.Name = "txtCUIT1";
            this.txtCUIT1.ShortcutsEnabled = false;
            this.txtCUIT1.Size = new System.Drawing.Size(49, 27);
            this.txtCUIT1.TabIndex = 1;
            this.txtCUIT1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCUIT1.TextChanged += new System.EventHandler(this.txtCUIT1_TextChanged);
            this.txtCUIT1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCUIT1_KeyPress);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(163)))), ((int)(((byte)(94)))));
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.FloppyDisk;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnGuardar.Location = new System.Drawing.Point(78, 545);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(200, 40);
            this.btnGuardar.TabIndex = 9;
            this.btnGuardar.Text = "Guardar";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnEliminar.FlatAppearance.BorderSize = 2;
            this.btnEliminar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(90)))), ((int)(((byte)(15)))), ((int)(((byte)(15)))));
            this.btnEliminar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEliminar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.ForeColor = System.Drawing.Color.White;
            this.btnEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            this.btnEliminar.IconColor = System.Drawing.Color.White;
            this.btnEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnEliminar.IconSize = 30;
            this.btnEliminar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEliminar.Location = new System.Drawing.Point(78, 599);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnEliminar.Size = new System.Drawing.Size(200, 40);
            this.btnEliminar.TabIndex = 10;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnLimpiar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLimpiar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnLimpiar.FlatAppearance.BorderSize = 2;
            this.btnLimpiar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Gray;
            this.btnLimpiar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpiar.Font = new System.Drawing.Font("Calibri", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiar.ForeColor = System.Drawing.Color.White;
            this.btnLimpiar.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.btnLimpiar.IconColor = System.Drawing.Color.White;
            this.btnLimpiar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnLimpiar.IconSize = 30;
            this.btnLimpiar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLimpiar.Location = new System.Drawing.Point(78, 653);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Padding = new System.Windows.Forms.Padding(40, 0, 0, 0);
            this.btnLimpiar.Size = new System.Drawing.Size(200, 40);
            this.btnLimpiar.TabIndex = 11;
            this.btnLimpiar.Text = "Limpiar";
            this.btnLimpiar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnLimpiar.UseVisualStyleBackColor = false;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.panel1.Location = new System.Drawing.Point(357, 25);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(10, 659);
            this.panel1.TabIndex = 73;
            // 
            // lblDetallesProveedor
            // 
            this.lblDetallesProveedor.AutoSize = true;
            this.lblDetallesProveedor.Font = new System.Drawing.Font("Calibri", 13.8F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetallesProveedor.Location = new System.Drawing.Point(19, 22);
            this.lblDetallesProveedor.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblDetallesProveedor.Name = "lblDetallesProveedor";
            this.lblDetallesProveedor.Size = new System.Drawing.Size(187, 28);
            this.lblDetallesProveedor.TabIndex = 83;
            this.lblDetallesProveedor.Text = "Detalles Proveedor";
            // 
            // panelDetalles
            // 
            this.panelDetalles.Controls.Add(this.grpbCondicionIVA);
            this.panelDetalles.Controls.Add(this.groupBox1);
            this.panelDetalles.Controls.Add(this.lblDetallesProveedor);
            this.panelDetalles.Controls.Add(this.panel1);
            this.panelDetalles.Controls.Add(this.txtCUIT1);
            this.panelDetalles.Controls.Add(this.btnLimpiar);
            this.panelDetalles.Controls.Add(this.lblCUIT);
            this.panelDetalles.Controls.Add(this.btnEliminar);
            this.panelDetalles.Controls.Add(this.txtCUIT3);
            this.panelDetalles.Controls.Add(this.btnGuardar);
            this.panelDetalles.Controls.Add(this.txtNombreProveedor);
            this.panelDetalles.Controls.Add(this.grpbCorreo);
            this.panelDetalles.Controls.Add(this.lblTelefono);
            this.panelDetalles.Controls.Add(this.txtCUIT2);
            this.panelDetalles.Controls.Add(this.txtDomicilio);
            this.panelDetalles.Controls.Add(this.txtTelefono);
            this.panelDetalles.Controls.Add(this.lblNombreRazon);
            this.panelDetalles.Controls.Add(this.lblDomicilio);
            this.panelDetalles.Location = new System.Drawing.Point(0, 41);
            this.panelDetalles.Name = "panelDetalles";
            this.panelDetalles.Size = new System.Drawing.Size(376, 707);
            this.panelDetalles.TabIndex = 85;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbEmailNo);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.rbEmailSi);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Location = new System.Drawing.Point(24, 277);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(300, 123);
            this.groupBox1.TabIndex = 86;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "¿Posee correo electrónico?";
            // 
            // rbEmailNo
            // 
            this.rbEmailNo.AutoSize = true;
            this.rbEmailNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmailNo.Location = new System.Drawing.Point(103, 25);
            this.rbEmailNo.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmailNo.Name = "rbEmailNo";
            this.rbEmailNo.Size = new System.Drawing.Size(49, 21);
            this.rbEmailNo.TabIndex = 41;
            this.rbEmailNo.TabStop = true;
            this.rbEmailNo.Text = "No";
            this.rbEmailNo.UseVisualStyleBackColor = true;
            this.rbEmailNo.CheckedChanged += new System.EventHandler(this.rbEmailNo_CheckedChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(7, 74);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(274, 27);
            this.txtEmail.TabIndex = 6;
            // 
            // rbEmailSi
            // 
            this.rbEmailSi.AutoSize = true;
            this.rbEmailSi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbEmailSi.Location = new System.Drawing.Point(31, 25);
            this.rbEmailSi.Margin = new System.Windows.Forms.Padding(4);
            this.rbEmailSi.Name = "rbEmailSi";
            this.rbEmailSi.Size = new System.Drawing.Size(43, 21);
            this.rbEmailSi.TabIndex = 7;
            this.rbEmailSi.TabStop = true;
            this.rbEmailSi.Text = "Si";
            this.rbEmailSi.UseVisualStyleBackColor = true;
            this.rbEmailSi.CheckedChanged += new System.EventHandler(this.rbEmailSi_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(4, 58);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 17);
            this.label1.TabIndex = 39;
            this.label1.Text = "Correo Electrónico";
            // 
            // errorNomApe_RazSoc
            // 
            this.errorNomApe_RazSoc.ContainerControl = this;
            // 
            // errorDomicilio
            // 
            this.errorDomicilio.ContainerControl = this;
            // 
            // errorTelefono
            // 
            this.errorTelefono.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // errorCuit
            // 
            this.errorCuit.ContainerControl = this;
            // 
            // grpbCondicionIVA
            // 
            this.grpbCondicionIVA.Controls.Add(this.cmbCondicionIVA);
            this.grpbCondicionIVA.Font = new System.Drawing.Font("Calibri", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpbCondicionIVA.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.grpbCondicionIVA.Location = new System.Drawing.Point(24, 403);
            this.grpbCondicionIVA.Margin = new System.Windows.Forms.Padding(4);
            this.grpbCondicionIVA.Name = "grpbCondicionIVA";
            this.grpbCondicionIVA.Padding = new System.Windows.Forms.Padding(4);
            this.grpbCondicionIVA.Size = new System.Drawing.Size(301, 61);
            this.grpbCondicionIVA.TabIndex = 87;
            this.grpbCondicionIVA.TabStop = false;
            this.grpbCondicionIVA.Text = "Condición IVA *";
            // 
            // cmbCondicionIVA
            // 
            this.cmbCondicionIVA.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCondicionIVA.FormattingEnabled = true;
            this.cmbCondicionIVA.Items.AddRange(new object[] {
            "Consumidor Final",
            "Monotributista",
            "Responsable Inscripto"});
            this.cmbCondicionIVA.Location = new System.Drawing.Point(8, 24);
            this.cmbCondicionIVA.Name = "cmbCondicionIVA";
            this.cmbCondicionIVA.Size = new System.Drawing.Size(274, 29);
            this.cmbCondicionIVA.TabIndex = 72;
            // 
            // frmProveedores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(1297, 748);
            this.Controls.Add(this.panelLista);
            this.Controls.Add(this.panel_superior);
            this.Controls.Add(this.panelDetalles);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmProveedores";
            this.Text = "frmProveedores";
            this.Load += new System.EventHandler(this.frmProveedores_Load);
            this.panel_superior.ResumeLayout(false);
            this.panel_superior.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panelLista.ResumeLayout(false);
            this.panelLista.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProveedores)).EndInit();
            this.grpbCorreo.ResumeLayout(false);
            this.grpbCorreo.PerformLayout();
            this.panelDetalles.ResumeLayout(false);
            this.panelDetalles.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorNomApe_RazSoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDomicilio)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorTelefono)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorCuit)).EndInit();
            this.grpbCondicionIVA.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_superior;
        private System.Windows.Forms.Label lblSeccionProveedores;
        private System.Windows.Forms.Label lblCUIT;
        private System.Windows.Forms.TextBox txtCUIT2;
        private System.Windows.Forms.TextBox txtNombreProveedor;
        private System.Windows.Forms.Label lblNombreRazon;
        private System.Windows.Forms.Panel panelLista;
        private System.Windows.Forms.TextBox txtCUIT3;
        private System.Windows.Forms.TextBox txtCUIT1;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.TextBox txtDomicilio;
        private System.Windows.Forms.Label lblDomicilio;
        private System.Windows.Forms.GroupBox grpbCorreo;
        private System.Windows.Forms.RadioButton rbPersonaFisica;
        private System.Windows.Forms.RadioButton rbPersonaJuridica;
        private FontAwesome.Sharp.IconButton btnGuardar;
        private FontAwesome.Sharp.IconButton btnEliminar;
        private FontAwesome.Sharp.IconButton btnLimpiar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cmbBuscarProveedor;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblListaProveedores;
        private System.Windows.Forms.Label lblDetallesProveedor;
        private System.Windows.Forms.Panel panelDetalles;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dtgProveedores;
        private System.Windows.Forms.ErrorProvider errorNomApe_RazSoc;
        private System.Windows.Forms.ErrorProvider errorDomicilio;
        private System.Windows.Forms.ErrorProvider errorTelefono;
        private FontAwesome.Sharp.IconButton btnBuscarProveedor;
        private System.Windows.Forms.TextBox txtBuscarProveedor;
        private FontAwesome.Sharp.IconButton btnRecargar;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rbEmailNo;
        private System.Windows.Forms.RadioButton rbEmailSi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorCuit;
        private System.Windows.Forms.GroupBox grpbCondicionIVA;
        private System.Windows.Forms.ComboBox cmbCondicionIVA;
    }
}