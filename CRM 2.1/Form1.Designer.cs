namespace CRM_2._1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalir = new FontAwesome.Sharp.IconPictureBox();
            this.Usuarios = new FontAwesome.Sharp.IconButton();
            this.Pautas = new FontAwesome.Sharp.IconButton();
            this.Servicios = new FontAwesome.Sharp.IconButton();
            this.Clientes = new FontAwesome.Sharp.IconButton();
            this.Consultas = new FontAwesome.Sharp.IconButton();
            this.Asesores = new FontAwesome.Sharp.IconButton();
            this.panellogo = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.PictureBox();
            this.panelShadow = new System.Windows.Forms.Panel();
            this.HoraFecha = new System.Windows.Forms.Timer(this.components);
            this.IconCurrentChildForm = new FontAwesome.Sharp.IconPictureBox();
            this.lblTitleChildForm = new System.Windows.Forms.Label();
            this.btnMinimize = new FontAwesome.Sharp.IconPictureBox();
            this.btnExit = new FontAwesome.Sharp.IconPictureBox();
            this.btnMaximize = new FontAwesome.Sharp.IconPictureBox();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblHora = new System.Windows.Forms.Label();
            this.lblFecha = new System.Windows.Forms.Label();
            this.panelDesktop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).BeginInit();
            this.panellogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelDesktop.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.Black;
            this.panelMenu.Controls.Add(this.label1);
            this.panelMenu.Controls.Add(this.btnSalir);
            this.panelMenu.Controls.Add(this.Usuarios);
            this.panelMenu.Controls.Add(this.Pautas);
            this.panelMenu.Controls.Add(this.Servicios);
            this.panelMenu.Controls.Add(this.Clientes);
            this.panelMenu.Controls.Add(this.Consultas);
            this.panelMenu.Controls.Add(this.Asesores);
            this.panelMenu.Controls.Add(this.panellogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(156, 717);
            this.panelMenu.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(60, 677);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 18);
            this.label1.TabIndex = 8;
            this.label1.Text = "Exit";
            // 
            // btnSalir
            // 
            this.btnSalir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSalir.IconChar = FontAwesome.Sharp.IconChar.SignOut;
            this.btnSalir.IconColor = System.Drawing.Color.White;
            this.btnSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSalir.IconSize = 39;
            this.btnSalir.Location = new System.Drawing.Point(12, 666);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(42, 39);
            this.btnSalir.TabIndex = 7;
            this.btnSalir.TabStop = false;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // Usuarios
            // 
            this.Usuarios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Usuarios.FlatAppearance.BorderSize = 0;
            this.Usuarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Usuarios.ForeColor = System.Drawing.Color.White;
            this.Usuarios.IconChar = FontAwesome.Sharp.IconChar.UserCheck;
            this.Usuarios.IconColor = System.Drawing.Color.White;
            this.Usuarios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Usuarios.IconSize = 32;
            this.Usuarios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.Location = new System.Drawing.Point(0, 440);
            this.Usuarios.Name = "Usuarios";
            this.Usuarios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Usuarios.Size = new System.Drawing.Size(156, 60);
            this.Usuarios.TabIndex = 6;
            this.Usuarios.Text = "Usuarios";
            this.Usuarios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Usuarios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Usuarios.UseVisualStyleBackColor = true;
            this.Usuarios.Click += new System.EventHandler(this.Usuarios_Click);
            // 
            // Pautas
            // 
            this.Pautas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Pautas.FlatAppearance.BorderSize = 0;
            this.Pautas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Pautas.ForeColor = System.Drawing.Color.White;
            this.Pautas.IconChar = FontAwesome.Sharp.IconChar.FilePen;
            this.Pautas.IconColor = System.Drawing.Color.White;
            this.Pautas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Pautas.IconSize = 32;
            this.Pautas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pautas.Location = new System.Drawing.Point(0, 380);
            this.Pautas.Name = "Pautas";
            this.Pautas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Pautas.Size = new System.Drawing.Size(156, 60);
            this.Pautas.TabIndex = 5;
            this.Pautas.Text = "Pautas";
            this.Pautas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Pautas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Pautas.UseVisualStyleBackColor = true;
            this.Pautas.Click += new System.EventHandler(this.Pautas_Click);
            // 
            // Servicios
            // 
            this.Servicios.Dock = System.Windows.Forms.DockStyle.Top;
            this.Servicios.FlatAppearance.BorderSize = 0;
            this.Servicios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Servicios.ForeColor = System.Drawing.Color.White;
            this.Servicios.IconChar = FontAwesome.Sharp.IconChar.Desktop;
            this.Servicios.IconColor = System.Drawing.Color.White;
            this.Servicios.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Servicios.IconSize = 32;
            this.Servicios.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Servicios.Location = new System.Drawing.Point(0, 320);
            this.Servicios.Name = "Servicios";
            this.Servicios.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Servicios.Size = new System.Drawing.Size(156, 60);
            this.Servicios.TabIndex = 4;
            this.Servicios.Text = "Servicios";
            this.Servicios.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Servicios.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Servicios.UseVisualStyleBackColor = true;
            this.Servicios.Click += new System.EventHandler(this.Servicios_Click);
            // 
            // Clientes
            // 
            this.Clientes.Dock = System.Windows.Forms.DockStyle.Top;
            this.Clientes.FlatAppearance.BorderSize = 0;
            this.Clientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Clientes.ForeColor = System.Drawing.Color.White;
            this.Clientes.IconChar = FontAwesome.Sharp.IconChar.PeopleGroup;
            this.Clientes.IconColor = System.Drawing.Color.White;
            this.Clientes.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Clientes.IconSize = 32;
            this.Clientes.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.Location = new System.Drawing.Point(0, 260);
            this.Clientes.Name = "Clientes";
            this.Clientes.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Clientes.Size = new System.Drawing.Size(156, 60);
            this.Clientes.TabIndex = 3;
            this.Clientes.Text = "Clientes";
            this.Clientes.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Clientes.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Clientes.UseVisualStyleBackColor = true;
            this.Clientes.Click += new System.EventHandler(this.Clientes_Click);
            // 
            // Consultas
            // 
            this.Consultas.Dock = System.Windows.Forms.DockStyle.Top;
            this.Consultas.FlatAppearance.BorderSize = 0;
            this.Consultas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Consultas.ForeColor = System.Drawing.Color.White;
            this.Consultas.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.Consultas.IconColor = System.Drawing.Color.White;
            this.Consultas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Consultas.IconSize = 32;
            this.Consultas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultas.Location = new System.Drawing.Point(0, 200);
            this.Consultas.Name = "Consultas";
            this.Consultas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Consultas.Size = new System.Drawing.Size(156, 60);
            this.Consultas.TabIndex = 2;
            this.Consultas.Text = "Consultas";
            this.Consultas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Consultas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Consultas.UseVisualStyleBackColor = true;
            this.Consultas.Click += new System.EventHandler(this.Consultas_Click);
            // 
            // Asesores
            // 
            this.Asesores.Dock = System.Windows.Forms.DockStyle.Top;
            this.Asesores.FlatAppearance.BorderSize = 0;
            this.Asesores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Asesores.ForeColor = System.Drawing.Color.White;
            this.Asesores.IconChar = FontAwesome.Sharp.IconChar.Headset;
            this.Asesores.IconColor = System.Drawing.Color.White;
            this.Asesores.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Asesores.IconSize = 32;
            this.Asesores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Asesores.Location = new System.Drawing.Point(0, 140);
            this.Asesores.Name = "Asesores";
            this.Asesores.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Asesores.Size = new System.Drawing.Size(156, 60);
            this.Asesores.TabIndex = 1;
            this.Asesores.Text = "Asesores";
            this.Asesores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.Asesores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.Asesores.UseVisualStyleBackColor = true;
            this.Asesores.Click += new System.EventHandler(this.Asesores_Click);
            // 
            // panellogo
            // 
            this.panellogo.Controls.Add(this.btnHome);
            this.panellogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panellogo.Location = new System.Drawing.Point(0, 0);
            this.panellogo.Name = "panellogo";
            this.panellogo.Size = new System.Drawing.Size(156, 140);
            this.panellogo.TabIndex = 0;
            // 
            // btnHome
            // 
            this.btnHome.Image = global::CRM_2._1.Properties.Resources.logo;
            this.btnHome.Location = new System.Drawing.Point(12, 12);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(125, 103);
            this.btnHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnHome.TabIndex = 0;
            this.btnHome.TabStop = false;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click);
            // 
            // panelShadow
            // 
            this.panelShadow.BackColor = System.Drawing.Color.DarkBlue;
            this.panelShadow.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelShadow.Location = new System.Drawing.Point(156, 75);
            this.panelShadow.Name = "panelShadow";
            this.panelShadow.Size = new System.Drawing.Size(1167, 9);
            this.panelShadow.TabIndex = 2;
            // 
            // HoraFecha
            // 
            this.HoraFecha.Enabled = true;
            this.HoraFecha.Tick += new System.EventHandler(this.HoraFecha_Tick);
            // 
            // IconCurrentChildForm
            // 
            this.IconCurrentChildForm.BackColor = System.Drawing.Color.DarkBlue;
            this.IconCurrentChildForm.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.IconCurrentChildForm.IconColor = System.Drawing.Color.White;
            this.IconCurrentChildForm.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconCurrentChildForm.Location = new System.Drawing.Point(15, 31);
            this.IconCurrentChildForm.Name = "IconCurrentChildForm";
            this.IconCurrentChildForm.Size = new System.Drawing.Size(32, 32);
            this.IconCurrentChildForm.TabIndex = 0;
            this.IconCurrentChildForm.TabStop = false;
            // 
            // lblTitleChildForm
            // 
            this.lblTitleChildForm.AutoSize = true;
            this.lblTitleChildForm.ForeColor = System.Drawing.Color.White;
            this.lblTitleChildForm.Location = new System.Drawing.Point(53, 40);
            this.lblTitleChildForm.Name = "lblTitleChildForm";
            this.lblTitleChildForm.Size = new System.Drawing.Size(39, 13);
            this.lblTitleChildForm.TabIndex = 1;
            this.lblTitleChildForm.Text = "INICIO";
            // 
            // btnMinimize
            // 
            this.btnMinimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMinimize.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMinimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btnMinimize.IconColor = System.Drawing.Color.White;
            this.btnMinimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMinimize.IconSize = 15;
            this.btnMinimize.Location = new System.Drawing.Point(1098, 3);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(15, 15);
            this.btnMinimize.TabIndex = 2;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // btnExit
            // 
            this.btnExit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExit.BackColor = System.Drawing.Color.DarkBlue;
            this.btnExit.IconChar = FontAwesome.Sharp.IconChar.Multiply;
            this.btnExit.IconColor = System.Drawing.Color.White;
            this.btnExit.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnExit.IconSize = 15;
            this.btnExit.Location = new System.Drawing.Point(1140, 3);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(15, 15);
            this.btnExit.TabIndex = 3;
            this.btnExit.TabStop = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMaximize
            // 
            this.btnMaximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnMaximize.BackColor = System.Drawing.Color.DarkBlue;
            this.btnMaximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btnMaximize.IconColor = System.Drawing.Color.White;
            this.btnMaximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnMaximize.IconSize = 15;
            this.btnMaximize.Location = new System.Drawing.Point(1119, 3);
            this.btnMaximize.Name = "btnMaximize";
            this.btnMaximize.Size = new System.Drawing.Size(15, 15);
            this.btnMaximize.TabIndex = 4;
            this.btnMaximize.TabStop = false;
            this.btnMaximize.Click += new System.EventHandler(this.btnMaximize_Click);
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.DarkBlue;
            this.panelTitleBar.Controls.Add(this.btnMaximize);
            this.panelTitleBar.Controls.Add(this.btnExit);
            this.panelTitleBar.Controls.Add(this.btnMinimize);
            this.panelTitleBar.Controls.Add(this.lblTitleChildForm);
            this.panelTitleBar.Controls.Add(this.IconCurrentChildForm);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(156, 0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1167, 75);
            this.panelTitleBar.TabIndex = 1;
            this.panelTitleBar.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panelTitleBar_MouseDown);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox1.Image = global::CRM_2._1.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(370, 128);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(404, 186);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // lblHora
            // 
            this.lblHora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblHora.AutoSize = true;
            this.lblHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHora.ForeColor = System.Drawing.Color.White;
            this.lblHora.Location = new System.Drawing.Point(458, 317);
            this.lblHora.Name = "lblHora";
            this.lblHora.Size = new System.Drawing.Size(118, 42);
            this.lblHora.TabIndex = 2;
            this.lblHora.Text = "label1";
            this.lblHora.Click += new System.EventHandler(this.lblHora_Click_1);
            // 
            // lblFecha
            // 
            this.lblFecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblFecha.AutoSize = true;
            this.lblFecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFecha.ForeColor = System.Drawing.Color.White;
            this.lblFecha.Location = new System.Drawing.Point(425, 368);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(86, 31);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "label2";
            this.lblFecha.Click += new System.EventHandler(this.lblFecha_Click);
            // 
            // panelDesktop
            // 
            this.panelDesktop.BackColor = System.Drawing.Color.Black;
            this.panelDesktop.Controls.Add(this.lblFecha);
            this.panelDesktop.Controls.Add(this.lblHora);
            this.panelDesktop.Controls.Add(this.pictureBox1);
            this.panelDesktop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktop.Location = new System.Drawing.Point(156, 84);
            this.panelDesktop.Name = "panelDesktop";
            this.panelDesktop.Size = new System.Drawing.Size(1167, 633);
            this.panelDesktop.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1323, 717);
            this.Controls.Add(this.panelDesktop);
            this.Controls.Add(this.panelShadow);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panelMenu.ResumeLayout(false);
            this.panelMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnSalir)).EndInit();
            this.panellogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnHome)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IconCurrentChildForm)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnExit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btnMaximize)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelDesktop.ResumeLayout(false);
            this.panelDesktop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private FontAwesome.Sharp.IconButton Asesores;
        private System.Windows.Forms.Panel panellogo;
        private FontAwesome.Sharp.IconButton Usuarios;
        private FontAwesome.Sharp.IconButton Pautas;
        private FontAwesome.Sharp.IconButton Servicios;
        private FontAwesome.Sharp.IconButton Clientes;
        private FontAwesome.Sharp.IconButton Consultas;
        private System.Windows.Forms.PictureBox btnHome;
        private System.Windows.Forms.Panel panelShadow;
        private System.Windows.Forms.Timer HoraFecha;
        private FontAwesome.Sharp.IconPictureBox btnSalir;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconPictureBox IconCurrentChildForm;
        private System.Windows.Forms.Label lblTitleChildForm;
        private FontAwesome.Sharp.IconPictureBox btnMinimize;
        private FontAwesome.Sharp.IconPictureBox btnExit;
        private FontAwesome.Sharp.IconPictureBox btnMaximize;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblHora;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.Panel panelDesktop;
    }
}

