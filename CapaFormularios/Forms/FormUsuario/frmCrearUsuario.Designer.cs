namespace Software_Contable.Forms.FormUsuario
{
    partial class frmCrearUsuario
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
            this.label12 = new System.Windows.Forms.Label();
            this.cmbEstadoUsuario = new System.Windows.Forms.ComboBox();
            this.txtContrasena1 = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtDNI = new System.Windows.Forms.TextBox();
            this.cmbTipoUsuario = new System.Windows.Forms.ComboBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.lblContrasena1 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblTipoUsuario = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.txtContrasena2 = new System.Windows.Forms.TextBox();
            this.btnCrearUsuario = new FontAwesome.Sharp.IconButton();
            this.errorNombreUsuario = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorNombre = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorApellido = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorDNI = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContrasena1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVerificaContrasena = new System.Windows.Forms.Label();
            this.errorContrasena2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVerContrasena1 = new FontAwesome.Sharp.IconButton();
            this.btnVerContrasena2 = new FontAwesome.Sharp.IconButton();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblSeccionClientes = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreUsuario)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena2)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label12.Location = new System.Drawing.Point(306, 115);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(63, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Estado";
            // 
            // cmbEstadoUsuario
            // 
            this.cmbEstadoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEstadoUsuario.FormattingEnabled = true;
            this.cmbEstadoUsuario.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cmbEstadoUsuario.Location = new System.Drawing.Point(310, 137);
            this.cmbEstadoUsuario.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cmbEstadoUsuario.Name = "cmbEstadoUsuario";
            this.cmbEstadoUsuario.Size = new System.Drawing.Size(284, 24);
            this.cmbEstadoUsuario.TabIndex = 7;
            // 
            // txtContrasena1
            // 
            this.txtContrasena1.Location = new System.Drawing.Point(310, 220);
            this.txtContrasena1.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena1.MaxLength = 32;
            this.txtContrasena1.Name = "txtContrasena1";
            this.txtContrasena1.ShortcutsEnabled = false;
            this.txtContrasena1.Size = new System.Drawing.Size(211, 22);
            this.txtContrasena1.TabIndex = 8;
            this.txtContrasena1.Tag = "";
            this.txtContrasena1.TextChanged += new System.EventHandler(this.txtContrasena_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(17, 347);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4);
            this.txtEmail.MaxLength = 50;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(253, 22);
            this.txtEmail.TabIndex = 5;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // txtDNI
            // 
            this.txtDNI.Location = new System.Drawing.Point(16, 186);
            this.txtDNI.Margin = new System.Windows.Forms.Padding(4);
            this.txtDNI.MaxLength = 8;
            this.txtDNI.Name = "txtDNI";
            this.txtDNI.ShortcutsEnabled = false;
            this.txtDNI.Size = new System.Drawing.Size(254, 22);
            this.txtDNI.TabIndex = 2;
            this.txtDNI.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDNI_KeyPress);
            this.txtDNI.Leave += new System.EventHandler(this.txtDNI_Leave);
            // 
            // cmbTipoUsuario
            // 
            this.cmbTipoUsuario.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTipoUsuario.FormattingEnabled = true;
            this.cmbTipoUsuario.Items.AddRange(new object[] {
            "Vendedor",
            "Administrador"});
            this.cmbTipoUsuario.Location = new System.Drawing.Point(310, 89);
            this.cmbTipoUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.cmbTipoUsuario.Name = "cmbTipoUsuario";
            this.cmbTipoUsuario.Size = new System.Drawing.Size(284, 24);
            this.cmbTipoUsuario.TabIndex = 6;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(16, 290);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4);
            this.txtApellido.MaxLength = 50;
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(254, 22);
            this.txtApellido.TabIndex = 4;
            this.txtApellido.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtApellido_KeyPress);
            // 
            // lblContrasena1
            // 
            this.lblContrasena1.AutoSize = true;
            this.lblContrasena1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.lblContrasena1.Location = new System.Drawing.Point(310, 197);
            this.lblContrasena1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblContrasena1.Name = "lblContrasena1";
            this.lblContrasena1.Size = new System.Drawing.Size(99, 20);
            this.lblContrasena1.TabIndex = 34;
            this.lblContrasena1.Text = "Contraseña";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(16, 235);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombre.MaxLength = 50;
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(254, 22);
            this.txtNombre.TabIndex = 3;
            this.txtNombre.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombre_KeyPress);
            // 
            // lblTipoUsuario
            // 
            this.lblTipoUsuario.AutoSize = true;
            this.lblTipoUsuario.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.lblTipoUsuario.Location = new System.Drawing.Point(306, 69);
            this.lblTipoUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTipoUsuario.Name = "lblTipoUsuario";
            this.lblTipoUsuario.Size = new System.Drawing.Size(144, 20);
            this.lblTipoUsuario.TabIndex = 31;
            this.lblTipoUsuario.Text = "Tipo de Usuario";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(16, 91);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.txtNombreUsuario.MaxLength = 32;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ShortcutsEnabled = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(254, 22);
            this.txtNombreUsuario.TabIndex = 1;
            this.txtNombreUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNombreUsuario_KeyPress);
            this.txtNombreUsuario.Leave += new System.EventHandler(this.txtNombreUsuario_Leave);
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.lblNombreUsuario.Location = new System.Drawing.Point(12, 69);
            this.lblNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(162, 20);
            this.lblNombreUsuario.TabIndex = 28;
            this.lblNombreUsuario.Text = "Nombre de Usuario";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label2.Location = new System.Drawing.Point(311, 267);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(171, 20);
            this.label2.TabIndex = 36;
            this.label2.Text = "Repetir Contraseña";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label4.Location = new System.Drawing.Point(13, 323);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(171, 20);
            this.label4.TabIndex = 39;
            this.label4.Text = "Correo Electrónico";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.lblNombre.Location = new System.Drawing.Point(12, 213);
            this.lblNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 20);
            this.lblNombre.TabIndex = 24;
            this.lblNombre.Text = "Nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 165);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 20);
            this.label3.TabIndex = 38;
            this.label3.Text = "DNI";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.lblApellido.Location = new System.Drawing.Point(12, 269);
            this.lblApellido.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(81, 20);
            this.lblApellido.TabIndex = 37;
            this.lblApellido.Text = "Apellido";
            // 
            // txtContrasena2
            // 
            this.txtContrasena2.Location = new System.Drawing.Point(311, 286);
            this.txtContrasena2.Margin = new System.Windows.Forms.Padding(4);
            this.txtContrasena2.MaxLength = 32;
            this.txtContrasena2.Name = "txtContrasena2";
            this.txtContrasena2.ShortcutsEnabled = false;
            this.txtContrasena2.Size = new System.Drawing.Size(211, 22);
            this.txtContrasena2.TabIndex = 9;
            // 
            // btnCrearUsuario
            // 
            this.btnCrearUsuario.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnCrearUsuario.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnCrearUsuario.FlatAppearance.BorderSize = 2;
            this.btnCrearUsuario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCrearUsuario.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCrearUsuario.ForeColor = System.Drawing.Color.White;
            this.btnCrearUsuario.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.btnCrearUsuario.IconColor = System.Drawing.Color.White;
            this.btnCrearUsuario.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCrearUsuario.IconSize = 30;
            this.btnCrearUsuario.Location = new System.Drawing.Point(325, 334);
            this.btnCrearUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnCrearUsuario.Name = "btnCrearUsuario";
            this.btnCrearUsuario.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnCrearUsuario.Size = new System.Drawing.Size(259, 37);
            this.btnCrearUsuario.TabIndex = 10;
            this.btnCrearUsuario.Text = "Crear Usuario";
            this.btnCrearUsuario.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnCrearUsuario.UseVisualStyleBackColor = false;
            this.btnCrearUsuario.Click += new System.EventHandler(this.btnCrearUsuario_Click);
            // 
            // errorNombreUsuario
            // 
            this.errorNombreUsuario.ContainerControl = this;
            // 
            // errorNombre
            // 
            this.errorNombre.ContainerControl = this;
            // 
            // errorApellido
            // 
            this.errorApellido.ContainerControl = this;
            // 
            // errorDNI
            // 
            this.errorDNI.ContainerControl = this;
            // 
            // errorContrasena1
            // 
            this.errorContrasena1.ContainerControl = this;
            // 
            // errorEmail
            // 
            this.errorEmail.ContainerControl = this;
            // 
            // lblVerificaContrasena
            // 
            this.lblVerificaContrasena.AccessibleDescription = "";
            this.lblVerificaContrasena.AutoSize = true;
            this.lblVerificaContrasena.Font = new System.Drawing.Font("Consolas", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificaContrasena.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaContrasena.Location = new System.Drawing.Point(311, 245);
            this.lblVerificaContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificaContrasena.Name = "lblVerificaContrasena";
            this.lblVerificaContrasena.Size = new System.Drawing.Size(160, 18);
            this.lblVerificaContrasena.TabIndex = 46;
            this.lblVerificaContrasena.Text = "Contraseña Insegura";
            this.lblVerificaContrasena.Visible = false;
            // 
            // errorContrasena2
            // 
            this.errorContrasena2.ContainerControl = this;
            // 
            // btnVerContrasena1
            // 
            this.btnVerContrasena1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContrasena1.IconColor = System.Drawing.Color.White;
            this.btnVerContrasena1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena1.IconSize = 32;
            this.btnVerContrasena1.Location = new System.Drawing.Point(546, 217);
            this.btnVerContrasena1.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerContrasena1.Name = "btnVerContrasena1";
            this.btnVerContrasena1.Size = new System.Drawing.Size(48, 28);
            this.btnVerContrasena1.TabIndex = 50;
            this.btnVerContrasena1.UseVisualStyleBackColor = true;
            this.btnVerContrasena1.Click += new System.EventHandler(this.btnVerContrasena1_Click);
            // 
            // btnVerContrasena2
            // 
            this.btnVerContrasena2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContrasena2.IconColor = System.Drawing.Color.White;
            this.btnVerContrasena2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena2.IconSize = 32;
            this.btnVerContrasena2.Location = new System.Drawing.Point(546, 284);
            this.btnVerContrasena2.Margin = new System.Windows.Forms.Padding(4);
            this.btnVerContrasena2.Name = "btnVerContrasena2";
            this.btnVerContrasena2.Size = new System.Drawing.Size(48, 28);
            this.btnVerContrasena2.TabIndex = 51;
            this.btnVerContrasena2.UseVisualStyleBackColor = true;
            this.btnVerContrasena2.Click += new System.EventHandler(this.btnVerContrasena2_Click);
            // 
            // BarraTitulo
            // 
            this.BarraTitulo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.BarraTitulo.Controls.Add(this.lblSeccionClientes);
            this.BarraTitulo.Controls.Add(this.iconPictureBox1);
            this.BarraTitulo.Controls.Add(this.btnCerrar);
            this.BarraTitulo.Dock = System.Windows.Forms.DockStyle.Top;
            this.BarraTitulo.Location = new System.Drawing.Point(0, 0);
            this.BarraTitulo.Name = "BarraTitulo";
            this.BarraTitulo.Size = new System.Drawing.Size(641, 35);
            this.BarraTitulo.TabIndex = 52;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblSeccionClientes
            // 
            this.lblSeccionClientes.AutoSize = true;
            this.lblSeccionClientes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionClientes.ForeColor = System.Drawing.Color.White;
            this.lblSeccionClientes.Location = new System.Drawing.Point(43, 4);
            this.lblSeccionClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccionClientes.Name = "lblSeccionClientes";
            this.lblSeccionClientes.Size = new System.Drawing.Size(153, 23);
            this.lblSeccionClientes.TabIndex = 92;
            this.lblSeccionClientes.Text = "Crear Usuario";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserPlus;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(5, -1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 35);
            this.iconPictureBox1.TabIndex = 91;
            this.iconPictureBox1.TabStop = false;
            // 
            // btnCerrar
            // 
            this.btnCerrar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.btnCerrar.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnCerrar.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnCerrar.FlatAppearance.BorderSize = 0;
            this.btnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCerrar.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnCerrar.IconColor = System.Drawing.Color.White;
            this.btnCerrar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnCerrar.IconSize = 23;
            this.btnCerrar.Location = new System.Drawing.Point(591, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 35);
            this.btnCerrar.TabIndex = 44;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.LawnGreen;
            this.label9.Location = new System.Drawing.Point(11, 43);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(80, 22);
            this.label9.TabIndex = 92;
            this.label9.Text = "USUARIO";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))));
            this.label7.ForeColor = System.Drawing.Color.LawnGreen;
            this.label7.Location = new System.Drawing.Point(306, 175);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 22);
            this.label7.TabIndex = 91;
            this.label7.Text = "CONTRASEÑA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LawnGreen;
            this.label6.Location = new System.Drawing.Point(306, 43);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(130, 22);
            this.label6.TabIndex = 90;
            this.label6.Text = "ROL Y ESTADO";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.LawnGreen;
            this.label8.Location = new System.Drawing.Point(12, 140);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(170, 22);
            this.label8.TabIndex = 89;
            this.label8.Text = "DETALLES USUARIO";
            // 
            // frmCrearUsuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(641, 401);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnVerContrasena2);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.btnVerContrasena1);
            this.Controls.Add(this.lblVerificaContrasena);
            this.Controls.Add(this.btnCrearUsuario);
            this.Controls.Add(this.txtContrasena2);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.cmbEstadoUsuario);
            this.Controls.Add(this.txtContrasena1);
            this.Controls.Add(this.txtDNI);
            this.Controls.Add(this.cmbTipoUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.lblContrasena1);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.lblTipoUsuario);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.lblNombreUsuario);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblApellido);
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmCrearUsuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmCrearUsuario";
            this.Load += new System.EventHandler(this.frmCrearUsuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorNombreUsuario)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorNombre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorApellido)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorDNI)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasena2)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbEstadoUsuario;
        private System.Windows.Forms.TextBox txtContrasena1;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtDNI;
        private System.Windows.Forms.ComboBox cmbTipoUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label lblContrasena1;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblTipoUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.TextBox txtContrasena2;
        private FontAwesome.Sharp.IconButton btnCrearUsuario;
        private System.Windows.Forms.ErrorProvider errorNombreUsuario;
        private System.Windows.Forms.ErrorProvider errorNombre;
        private System.Windows.Forms.ErrorProvider errorApellido;
        private System.Windows.Forms.ErrorProvider errorDNI;
        private System.Windows.Forms.ErrorProvider errorContrasena1;
        private System.Windows.Forms.ErrorProvider errorEmail;
        private System.Windows.Forms.Label lblVerificaContrasena;
        private System.Windows.Forms.ErrorProvider errorContrasena2;
        private FontAwesome.Sharp.IconButton btnVerContrasena1;
        private FontAwesome.Sharp.IconButton btnVerContrasena2;
        private System.Windows.Forms.Panel BarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSeccionClientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
    }
}