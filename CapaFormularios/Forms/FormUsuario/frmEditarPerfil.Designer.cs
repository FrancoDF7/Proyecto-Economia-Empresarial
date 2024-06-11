namespace CapaFormularios.Forms.FormUsuario
{
    partial class frmEditarPerfil
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
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContraNueva2 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtContraNueva1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContraActual = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.errorVerificaEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContraNueva1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorContrasenaActual = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnVerContrasena2 = new FontAwesome.Sharp.IconButton();
            this.btnVerContrasena1 = new FontAwesome.Sharp.IconButton();
            this.errorContraNueva2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.lblVerificaContrasena = new System.Windows.Forms.Label();
            this.btnVerContraActual = new FontAwesome.Sharp.IconButton();
            this.BarraTitulo = new System.Windows.Forms.Panel();
            this.lblSeccionClientes = new System.Windows.Forms.Label();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.btnCerrar = new FontAwesome.Sharp.IconButton();
            this.btnGuardar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificaEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraNueva1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasenaActual)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraNueva2)).BeginInit();
            this.BarraTitulo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtEmail
            // 
            this.txtEmail.Enabled = false;
            this.txtEmail.ForeColor = System.Drawing.Color.Black;
            this.txtEmail.Location = new System.Drawing.Point(16, 236);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtEmail.MaxLength = 150;
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ShortcutsEnabled = false;
            this.txtEmail.Size = new System.Drawing.Size(269, 22);
            this.txtEmail.TabIndex = 32;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(12, 212);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(171, 20);
            this.label8.TabIndex = 33;
            this.label8.Text = "Correo Electronico";
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Enabled = false;
            this.txtNombreUsuario.ForeColor = System.Drawing.Color.Black;
            this.txtNombreUsuario.Location = new System.Drawing.Point(16, 71);
            this.txtNombreUsuario.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.ReadOnly = true;
            this.txtNombreUsuario.ShortcutsEnabled = false;
            this.txtNombreUsuario.Size = new System.Drawing.Size(248, 22);
            this.txtNombreUsuario.TabIndex = 20;
            // 
            // txtApellido
            // 
            this.txtApellido.Enabled = false;
            this.txtApellido.ForeColor = System.Drawing.Color.Black;
            this.txtApellido.Location = new System.Drawing.Point(16, 180);
            this.txtApellido.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.ReadOnly = true;
            this.txtApellido.ShortcutsEnabled = false;
            this.txtApellido.Size = new System.Drawing.Size(248, 22);
            this.txtApellido.TabIndex = 23;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(12, 160);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 20);
            this.label6.TabIndex = 30;
            this.label6.Text = "Apellido";
            // 
            // txtContraNueva2
            // 
            this.txtContraNueva2.ForeColor = System.Drawing.Color.Black;
            this.txtContraNueva2.Location = new System.Drawing.Point(13, 448);
            this.txtContraNueva2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraNueva2.MaxLength = 32;
            this.txtContraNueva2.Name = "txtContraNueva2";
            this.txtContraNueva2.ShortcutsEnabled = false;
            this.txtContraNueva2.Size = new System.Drawing.Size(269, 22);
            this.txtContraNueva2.TabIndex = 28;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(12, 423);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 29;
            this.label5.Text = "Repetir Contraseña";
            // 
            // txtContraNueva1
            // 
            this.txtContraNueva1.ForeColor = System.Drawing.Color.Black;
            this.txtContraNueva1.Location = new System.Drawing.Point(13, 379);
            this.txtContraNueva1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraNueva1.MaxLength = 32;
            this.txtContraNueva1.Name = "txtContraNueva1";
            this.txtContraNueva1.ShortcutsEnabled = false;
            this.txtContraNueva1.Size = new System.Drawing.Size(269, 22);
            this.txtContraNueva1.TabIndex = 26;
            this.txtContraNueva1.TextChanged += new System.EventHandler(this.txtContraNueva1_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label4.ForeColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(12, 355);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(153, 20);
            this.label4.TabIndex = 27;
            this.label4.Text = "Contraseña Nueva";
            // 
            // txtNombre
            // 
            this.txtNombre.Enabled = false;
            this.txtNombre.ForeColor = System.Drawing.Color.Black;
            this.txtNombre.Location = new System.Drawing.Point(16, 130);
            this.txtNombre.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.ReadOnly = true;
            this.txtNombre.ShortcutsEnabled = false;
            this.txtNombre.Size = new System.Drawing.Size(248, 22);
            this.txtNombre.TabIndex = 22;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label3.ForeColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(12, 110);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 20);
            this.label3.TabIndex = 24;
            this.label3.Text = "Nombre";
            // 
            // txtContraActual
            // 
            this.txtContraActual.ForeColor = System.Drawing.Color.Black;
            this.txtContraActual.Location = new System.Drawing.Point(13, 320);
            this.txtContraActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtContraActual.MaxLength = 32;
            this.txtContraActual.Name = "txtContraActual";
            this.txtContraActual.ShortcutsEnabled = false;
            this.txtContraActual.Size = new System.Drawing.Size(269, 22);
            this.txtContraActual.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(12, 301);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(162, 20);
            this.label2.TabIndex = 21;
            this.label2.Text = "Contraseña Actual";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 10.2F);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(12, 52);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "Nombre Usuario";
            // 
            // errorVerificaEmail
            // 
            this.errorVerificaEmail.ContainerControl = this;
            // 
            // errorContraNueva1
            // 
            this.errorContraNueva1.ContainerControl = this;
            // 
            // errorContrasenaActual
            // 
            this.errorContrasenaActual.ContainerControl = this;
            // 
            // btnVerContrasena2
            // 
            this.btnVerContrasena2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerContrasena2.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerContrasena2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena2.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContrasena2.IconColor = System.Drawing.Color.White;
            this.btnVerContrasena2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena2.IconSize = 32;
            this.btnVerContrasena2.Location = new System.Drawing.Point(322, 445);
            this.btnVerContrasena2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerContrasena2.Name = "btnVerContrasena2";
            this.btnVerContrasena2.Size = new System.Drawing.Size(48, 28);
            this.btnVerContrasena2.TabIndex = 53;
            this.btnVerContrasena2.UseVisualStyleBackColor = true;
            this.btnVerContrasena2.Click += new System.EventHandler(this.btnVerContrasena2_Click);
            // 
            // btnVerContrasena1
            // 
            this.btnVerContrasena1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerContrasena1.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerContrasena1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContrasena1.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContrasena1.IconColor = System.Drawing.Color.White;
            this.btnVerContrasena1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContrasena1.IconSize = 32;
            this.btnVerContrasena1.Location = new System.Drawing.Point(322, 376);
            this.btnVerContrasena1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerContrasena1.Name = "btnVerContrasena1";
            this.btnVerContrasena1.Size = new System.Drawing.Size(48, 28);
            this.btnVerContrasena1.TabIndex = 52;
            this.btnVerContrasena1.UseVisualStyleBackColor = true;
            this.btnVerContrasena1.Click += new System.EventHandler(this.btnVerContrasena1_Click);
            // 
            // errorContraNueva2
            // 
            this.errorContraNueva2.ContainerControl = this;
            // 
            // lblVerificaContrasena
            // 
            this.lblVerificaContrasena.AccessibleDescription = "";
            this.lblVerificaContrasena.AutoSize = true;
            this.lblVerificaContrasena.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVerificaContrasena.ForeColor = System.Drawing.Color.Red;
            this.lblVerificaContrasena.Location = new System.Drawing.Point(12, 403);
            this.lblVerificaContrasena.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblVerificaContrasena.Name = "lblVerificaContrasena";
            this.lblVerificaContrasena.Size = new System.Drawing.Size(159, 17);
            this.lblVerificaContrasena.TabIndex = 54;
            this.lblVerificaContrasena.Text = "Contraseña Insegura";
            this.lblVerificaContrasena.Visible = false;
            // 
            // btnVerContraActual
            // 
            this.btnVerContraActual.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVerContraActual.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btnVerContraActual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVerContraActual.IconChar = FontAwesome.Sharp.IconChar.EyeSlash;
            this.btnVerContraActual.IconColor = System.Drawing.Color.White;
            this.btnVerContraActual.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnVerContraActual.IconSize = 32;
            this.btnVerContraActual.Location = new System.Drawing.Point(322, 320);
            this.btnVerContraActual.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnVerContraActual.Name = "btnVerContraActual";
            this.btnVerContraActual.Size = new System.Drawing.Size(48, 28);
            this.btnVerContraActual.TabIndex = 55;
            this.btnVerContraActual.UseVisualStyleBackColor = true;
            this.btnVerContraActual.Click += new System.EventHandler(this.btnVerContraActual_Click);
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
            this.BarraTitulo.Size = new System.Drawing.Size(402, 35);
            this.BarraTitulo.TabIndex = 56;
            this.BarraTitulo.MouseDown += new System.Windows.Forms.MouseEventHandler(this.BarraTitulo_MouseDown);
            // 
            // lblSeccionClientes
            // 
            this.lblSeccionClientes.AutoSize = true;
            this.lblSeccionClientes.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSeccionClientes.ForeColor = System.Drawing.Color.White;
            this.lblSeccionClientes.Location = new System.Drawing.Point(45, 4);
            this.lblSeccionClientes.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblSeccionClientes.Name = "lblSeccionClientes";
            this.lblSeccionClientes.Size = new System.Drawing.Size(153, 23);
            this.lblSeccionClientes.TabIndex = 90;
            this.lblSeccionClientes.Text = "Editar Perfil";
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(60)))), ((int)(((byte)(60)))));
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.iconPictureBox1.IconColor = System.Drawing.Color.White;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 35;
            this.iconPictureBox1.Location = new System.Drawing.Point(7, -1);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(49, 35);
            this.iconPictureBox1.TabIndex = 89;
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
            this.btnCerrar.Location = new System.Drawing.Point(352, 0);
            this.btnCerrar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnCerrar.Name = "btnCerrar";
            this.btnCerrar.Size = new System.Drawing.Size(50, 35);
            this.btnCerrar.TabIndex = 44;
            this.btnCerrar.UseVisualStyleBackColor = false;
            this.btnCerrar.Click += new System.EventHandler(this.btnCerrar_Click);
            // 
            // btnGuardar
            // 
            this.btnGuardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.btnGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGuardar.FlatAppearance.BorderColor = System.Drawing.Color.LawnGreen;
            this.btnGuardar.FlatAppearance.BorderSize = 2;
            this.btnGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardar.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGuardar.ForeColor = System.Drawing.Color.White;
            this.btnGuardar.IconChar = FontAwesome.Sharp.IconChar.UserEdit;
            this.btnGuardar.IconColor = System.Drawing.Color.White;
            this.btnGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardar.IconSize = 30;
            this.btnGuardar.Location = new System.Drawing.Point(63, 508);
            this.btnGuardar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnGuardar.Name = "btnGuardar";
            this.btnGuardar.Padding = new System.Windows.Forms.Padding(30, 0, 0, 0);
            this.btnGuardar.Size = new System.Drawing.Size(259, 37);
            this.btnGuardar.TabIndex = 57;
            this.btnGuardar.Text = "Editar Perfil";
            this.btnGuardar.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnGuardar.UseVisualStyleBackColor = false;
            this.btnGuardar.Click += new System.EventHandler(this.btnGuardar_Click);
            // 
            // frmEditarPerfil
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(402, 574);
            this.Controls.Add(this.btnGuardar);
            this.Controls.Add(this.BarraTitulo);
            this.Controls.Add(this.btnVerContraActual);
            this.Controls.Add(this.lblVerificaContrasena);
            this.Controls.Add(this.btnVerContrasena2);
            this.Controls.Add(this.btnVerContrasena1);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtNombreUsuario);
            this.Controls.Add(this.txtApellido);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtContraNueva2);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtContraNueva1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtNombre);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtContraActual);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmEditarPerfil";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmEditarPerfil";
            this.Load += new System.EventHandler(this.frmEditarPerfil_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorVerificaEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraNueva1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContrasenaActual)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorContraNueva2)).EndInit();
            this.BarraTitulo.ResumeLayout(false);
            this.BarraTitulo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContraNueva2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtContraNueva1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContraActual;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorVerificaEmail;
        private System.Windows.Forms.ErrorProvider errorContraNueva1;
        private System.Windows.Forms.ErrorProvider errorContrasenaActual;
        private FontAwesome.Sharp.IconButton btnVerContrasena2;
        private FontAwesome.Sharp.IconButton btnVerContrasena1;
        private System.Windows.Forms.ErrorProvider errorContraNueva2;
        private System.Windows.Forms.Label lblVerificaContrasena;
        private FontAwesome.Sharp.IconButton btnVerContraActual;
        private System.Windows.Forms.Panel BarraTitulo;
        private FontAwesome.Sharp.IconButton btnCerrar;
        private System.Windows.Forms.Label lblSeccionClientes;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private FontAwesome.Sharp.IconButton btnGuardar;
    }
}