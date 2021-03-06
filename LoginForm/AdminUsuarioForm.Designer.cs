﻿namespace LoginForm
{
    partial class AdminUsuarioForm
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
            this.lklSalir = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.gpbDatos = new System.Windows.Forms.GroupBox();
            this.cboTipoPerfil = new System.Windows.Forms.ComboBox();
            this.cboPiloto = new System.Windows.Forms.ComboBox();
            this.dtFechNac = new System.Windows.Forms.DateTimePicker();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblFechNac = new System.Windows.Forms.Label();
            this.lblTipoPerfil = new System.Windows.Forms.Label();
            this.lblPiloto = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.lblUser = new System.Windows.Forms.Label();
            this.txtRut = new System.Windows.Forms.TextBox();
            this.txtApellido = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblRut = new System.Windows.Forms.Label();
            this.lblApellido = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblVechaMae = new System.Windows.Forms.Label();
            this.fecVencMae = new System.Windows.Forms.DateTimePicker();
            this.btnBuscar = new System.Windows.Forms.Panel();
            this.btnEliminar = new System.Windows.Forms.Panel();
            this.btnModificar = new System.Windows.Forms.Panel();
            this.btnRegistrar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.gpbDatos.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // lklSalir
            // 
            this.lklSalir.AutoSize = true;
            this.lklSalir.Location = new System.Drawing.Point(-36, 131);
            this.lklSalir.Name = "lklSalir";
            this.lklSalir.Size = new System.Drawing.Size(27, 13);
            this.lklSalir.TabIndex = 13;
            this.lklSalir.TabStop = true;
            this.lklSalir.Text = "Salir";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.label1.Location = new System.Drawing.Point(282, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(273, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "Registro de Usuario";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(819, 153);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(27, 13);
            this.linkLabel1.TabIndex = 14;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Salir";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // gpbDatos
            // 
            this.gpbDatos.Controls.Add(this.fecVencMae);
            this.gpbDatos.Controls.Add(this.lblVechaMae);
            this.gpbDatos.Controls.Add(this.cboTipoPerfil);
            this.gpbDatos.Controls.Add(this.cboPiloto);
            this.gpbDatos.Controls.Add(this.dtFechNac);
            this.gpbDatos.Controls.Add(this.txtEmail);
            this.gpbDatos.Controls.Add(this.txtPassword);
            this.gpbDatos.Controls.Add(this.txtUserName);
            this.gpbDatos.Controls.Add(this.lblFechNac);
            this.gpbDatos.Controls.Add(this.lblTipoPerfil);
            this.gpbDatos.Controls.Add(this.lblPiloto);
            this.gpbDatos.Controls.Add(this.lblEmail);
            this.gpbDatos.Controls.Add(this.lblPassword);
            this.gpbDatos.Controls.Add(this.lblUser);
            this.gpbDatos.Controls.Add(this.txtRut);
            this.gpbDatos.Controls.Add(this.txtApellido);
            this.gpbDatos.Controls.Add(this.txtNombre);
            this.gpbDatos.Controls.Add(this.lblRut);
            this.gpbDatos.Controls.Add(this.lblApellido);
            this.gpbDatos.Controls.Add(this.lblNombre);
            this.gpbDatos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.gpbDatos.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpbDatos.Location = new System.Drawing.Point(43, 169);
            this.gpbDatos.Name = "gpbDatos";
            this.gpbDatos.Size = new System.Drawing.Size(803, 206);
            this.gpbDatos.TabIndex = 15;
            this.gpbDatos.TabStop = false;
            this.gpbDatos.Text = "Datos";
            // 
            // cboTipoPerfil
            // 
            this.cboTipoPerfil.FormattingEnabled = true;
            this.cboTipoPerfil.Location = new System.Drawing.Point(398, 143);
            this.cboTipoPerfil.Name = "cboTipoPerfil";
            this.cboTipoPerfil.Size = new System.Drawing.Size(173, 21);
            this.cboTipoPerfil.TabIndex = 17;
            this.cboTipoPerfil.SelectedValueChanged += new System.EventHandler(this.cboTipoPerfil_SelectedValueChanged);
            // 
            // cboPiloto
            // 
            this.cboPiloto.FormattingEnabled = true;
            this.cboPiloto.Location = new System.Drawing.Point(134, 143);
            this.cboPiloto.Name = "cboPiloto";
            this.cboPiloto.Size = new System.Drawing.Size(173, 21);
            this.cboPiloto.TabIndex = 16;
            // 
            // dtFechNac
            // 
            this.dtFechNac.Location = new System.Drawing.Point(584, 67);
            this.dtFechNac.Name = "dtFechNac";
            this.dtFechNac.Size = new System.Drawing.Size(200, 20);
            this.dtFechNac.TabIndex = 15;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(398, 106);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(173, 20);
            this.txtEmail.TabIndex = 14;
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(398, 66);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(173, 20);
            this.txtPassword.TabIndex = 13;
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(398, 27);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(173, 20);
            this.txtUserName.TabIndex = 12;
            // 
            // lblFechNac
            // 
            this.lblFechNac.AutoSize = true;
            this.lblFechNac.Enabled = false;
            this.lblFechNac.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFechNac.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblFechNac.Location = new System.Drawing.Point(607, 27);
            this.lblFechNac.Name = "lblFechNac";
            this.lblFechNac.Size = new System.Drawing.Size(133, 16);
            this.lblFechNac.TabIndex = 11;
            this.lblFechNac.Text = "Fecha Nacimiento";
            // 
            // lblTipoPerfil
            // 
            this.lblTipoPerfil.AutoSize = true;
            this.lblTipoPerfil.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTipoPerfil.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblTipoPerfil.Location = new System.Drawing.Point(317, 144);
            this.lblTipoPerfil.Name = "lblTipoPerfil";
            this.lblTipoPerfil.Size = new System.Drawing.Size(80, 16);
            this.lblTipoPerfil.TabIndex = 10;
            this.lblTipoPerfil.Text = "Tipo Perfil";
            // 
            // lblPiloto
            // 
            this.lblPiloto.AutoSize = true;
            this.lblPiloto.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPiloto.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPiloto.Location = new System.Drawing.Point(18, 146);
            this.lblPiloto.Name = "lblPiloto";
            this.lblPiloto.Size = new System.Drawing.Size(117, 16);
            this.lblPiloto.TabIndex = 9;
            this.lblPiloto.Text = "Piloto asignado";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblEmail.Location = new System.Drawing.Point(318, 106);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(47, 16);
            this.lblEmail.TabIndex = 8;
            this.lblEmail.Text = "Email";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblPassword.Location = new System.Drawing.Point(318, 66);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(76, 16);
            this.lblPassword.TabIndex = 7;
            this.lblPassword.Text = "Password";
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblUser.Location = new System.Drawing.Point(317, 27);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(82, 16);
            this.lblUser.TabIndex = 6;
            this.lblUser.Text = "UserName";
            // 
            // txtRut
            // 
            this.txtRut.Location = new System.Drawing.Point(133, 108);
            this.txtRut.Name = "txtRut";
            this.txtRut.Size = new System.Drawing.Size(173, 20);
            this.txtRut.TabIndex = 5;
            // 
            // txtApellido
            // 
            this.txtApellido.Location = new System.Drawing.Point(134, 67);
            this.txtApellido.Name = "txtApellido";
            this.txtApellido.Size = new System.Drawing.Size(173, 20);
            this.txtApellido.TabIndex = 4;
            // 
            // txtNombre
            // 
            this.txtNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNombre.Location = new System.Drawing.Point(135, 27);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(173, 22);
            this.txtNombre.TabIndex = 3;
            // 
            // lblRut
            // 
            this.lblRut.AutoSize = true;
            this.lblRut.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRut.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblRut.Location = new System.Drawing.Point(19, 108);
            this.lblRut.Name = "lblRut";
            this.lblRut.Size = new System.Drawing.Size(31, 16);
            this.lblRut.TabIndex = 2;
            this.lblRut.Text = "Rut";
            // 
            // lblApellido
            // 
            this.lblApellido.AutoSize = true;
            this.lblApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellido.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblApellido.Location = new System.Drawing.Point(17, 68);
            this.lblApellido.Name = "lblApellido";
            this.lblApellido.Size = new System.Drawing.Size(66, 16);
            this.lblApellido.TabIndex = 1;
            this.lblApellido.Text = "Apellido";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombre.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblNombre.Location = new System.Drawing.Point(17, 26);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(63, 16);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnBuscar);
            this.groupBox1.Controls.Add(this.btnEliminar);
            this.groupBox1.Controls.Add(this.btnModificar);
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Location = new System.Drawing.Point(43, 375);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(803, 91);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "OPCIONES";
            // 
            // lblVechaMae
            // 
            this.lblVechaMae.AutoSize = true;
            this.lblVechaMae.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVechaMae.ForeColor = System.Drawing.SystemColors.ActiveCaption;
            this.lblVechaMae.Location = new System.Drawing.Point(607, 109);
            this.lblVechaMae.Name = "lblVechaMae";
            this.lblVechaMae.Size = new System.Drawing.Size(174, 16);
            this.lblVechaMae.TabIndex = 18;
            this.lblVechaMae.Text = "Fecha Vencimiento Mae";
            // 
            // fecVencMae
            // 
            this.fecVencMae.Enabled = false;
            this.fecVencMae.Location = new System.Drawing.Point(584, 143);
            this.fecVencMae.Name = "fecVencMae";
            this.fecVencMae.Size = new System.Drawing.Size(200, 20);
            this.fecVencMae.TabIndex = 19;
            // 
            // btnBuscar
            // 
            this.btnBuscar.BackgroundImage = global::LoginForm.Properties.Resources.Buscar;
            this.btnBuscar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnBuscar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnBuscar.Location = new System.Drawing.Point(610, 27);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(170, 34);
            this.btnBuscar.TabIndex = 3;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackgroundImage = global::LoginForm.Properties.Resources.MenuEliminar;
            this.btnEliminar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnEliminar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnEliminar.Location = new System.Drawing.Point(409, 27);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(170, 34);
            this.btnEliminar.TabIndex = 2;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackgroundImage = global::LoginForm.Properties.Resources.MenuModificar;
            this.btnModificar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnModificar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnModificar.Location = new System.Drawing.Point(210, 27);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(170, 34);
            this.btnModificar.TabIndex = 1;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.BackgroundImage = global::LoginForm.Properties.Resources.MenuRegistrar;
            this.btnRegistrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRegistrar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.btnRegistrar.Location = new System.Drawing.Point(14, 27);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(170, 34);
            this.btnRegistrar.TabIndex = 0;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::LoginForm.Properties.Resources.LogoIntra;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.pictureBox1.Location = new System.Drawing.Point(8, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 124);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::LoginForm.Properties.Resources.front;
            this.pictureBox2.Location = new System.Drawing.Point(115, -4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(770, 128);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 11;
            this.pictureBox2.TabStop = false;
            // 
            // AdminUsuarioForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(883, 468);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.gpbDatos);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.lklSalir);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Location = new System.Drawing.Point(220, 193);
            this.Name = "AdminUsuarioForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Administracion de Usuarios";
            this.gpbDatos.ResumeLayout(false);
            this.gpbDatos.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.LinkLabel lklSalir;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.GroupBox gpbDatos;
        private System.Windows.Forms.ComboBox cboTipoPerfil;
        private System.Windows.Forms.ComboBox cboPiloto;
        private System.Windows.Forms.DateTimePicker dtFechNac;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblFechNac;
        private System.Windows.Forms.Label lblTipoPerfil;
        private System.Windows.Forms.Label lblPiloto;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.TextBox txtRut;
        private System.Windows.Forms.TextBox txtApellido;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblRut;
        private System.Windows.Forms.Label lblApellido;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel btnRegistrar;
        private System.Windows.Forms.Panel btnModificar;
        private System.Windows.Forms.Panel btnEliminar;
        private System.Windows.Forms.Label lblVechaMae;
        private System.Windows.Forms.DateTimePicker fecVencMae;
        private System.Windows.Forms.Panel btnBuscar;
    }
}