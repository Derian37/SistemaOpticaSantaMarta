namespace CapaPresentacion
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.GrpPrincipal = new System.Windows.Forms.GroupBox();
            this.btnProductos = new System.Windows.Forms.Button();
            this.lbl_salir = new System.Windows.Forms.Label();
            this.btn_Salir = new System.Windows.Forms.Button();
            this.btnAbonos = new System.Windows.Forms.Button();
            this.btnVales = new System.Windows.Forms.Button();
            this.btnProforma = new System.Windows.Forms.Button();
            this.btnRecibos = new System.Windows.Forms.Button();
            this.btnControlTrabajo = new System.Windows.Forms.Button();
            this.lblVeterinario = new System.Windows.Forms.Label();
            this.btnCita = new System.Windows.Forms.Button();
            this.lblCita = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnExpediente = new System.Windows.Forms.Button();
            this.lblExpediente = new System.Windows.Forms.Label();
            this.pctUsuario = new System.Windows.Forms.PictureBox();
            this.lbl_usuarioCargo = new System.Windows.Forms.Label();
            this.lbl_usuarioNombre = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.configuraciónToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolstrip_usuarios = new System.Windows.Forms.ToolStripMenuItem();
            this.GrpPrincipal.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 16);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nombre de Usuario:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(66, 64);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.TabIndex = 8;
            this.label2.Text = "Cargo:";
            // 
            // GrpPrincipal
            // 
            this.GrpPrincipal.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GrpPrincipal.AutoSize = true;
            this.GrpPrincipal.BackColor = System.Drawing.Color.AliceBlue;
            this.GrpPrincipal.Controls.Add(this.btnProductos);
            this.GrpPrincipal.Controls.Add(this.lbl_salir);
            this.GrpPrincipal.Controls.Add(this.btn_Salir);
            this.GrpPrincipal.Controls.Add(this.btnAbonos);
            this.GrpPrincipal.Controls.Add(this.btnVales);
            this.GrpPrincipal.Controls.Add(this.btnProforma);
            this.GrpPrincipal.Controls.Add(this.btnRecibos);
            this.GrpPrincipal.Controls.Add(this.btnControlTrabajo);
            this.GrpPrincipal.Controls.Add(this.lblVeterinario);
            this.GrpPrincipal.Controls.Add(this.btnCita);
            this.GrpPrincipal.Controls.Add(this.lblCita);
            this.GrpPrincipal.Controls.Add(this.label5);
            this.GrpPrincipal.Controls.Add(this.btnExpediente);
            this.GrpPrincipal.Controls.Add(this.lblExpediente);
            this.GrpPrincipal.Location = new System.Drawing.Point(55, 83);
            this.GrpPrincipal.Name = "GrpPrincipal";
            this.GrpPrincipal.Size = new System.Drawing.Size(1091, 578);
            this.GrpPrincipal.TabIndex = 11;
            this.GrpPrincipal.TabStop = false;
            this.GrpPrincipal.Enter += new System.EventHandler(this.GrpPrincipal_Enter);
            // 
            // btnProductos
            // 
            this.btnProductos.BackColor = System.Drawing.Color.Transparent;
            this.btnProductos.BackgroundImage = global::CapaPresentacion.Properties.Resources.Productos1;
            this.btnProductos.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProductos.FlatAppearance.BorderSize = 0;
            this.btnProductos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProductos.Location = new System.Drawing.Point(167, 276);
            this.btnProductos.Name = "btnProductos";
            this.btnProductos.Size = new System.Drawing.Size(121, 126);
            this.btnProductos.TabIndex = 26;
            this.btnProductos.UseVisualStyleBackColor = false;
            this.btnProductos.Click += new System.EventHandler(this.btnProductos_Click);
            // 
            // lbl_salir
            // 
            this.lbl_salir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_salir.Location = new System.Drawing.Point(549, 535);
            this.lbl_salir.Name = "lbl_salir";
            this.lbl_salir.Size = new System.Drawing.Size(49, 23);
            this.lbl_salir.TabIndex = 25;
            this.lbl_salir.Text = "Salir";
            // 
            // btn_Salir
            // 
            this.btn_Salir.AutoSize = true;
            this.btn_Salir.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_Salir.BackgroundImage")));
            this.btn_Salir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_Salir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_Salir.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_Salir.FlatAppearance.BorderSize = 0;
            this.btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Salir.Location = new System.Drawing.Point(535, 472);
            this.btn_Salir.Margin = new System.Windows.Forms.Padding(0);
            this.btn_Salir.Name = "btn_Salir";
            this.btn_Salir.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_Salir.Size = new System.Drawing.Size(74, 63);
            this.btn_Salir.TabIndex = 12;
            this.btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Salir.UseVisualStyleBackColor = true;
            this.btn_Salir.Click += new System.EventHandler(this.Btn_SalirClick);
            // 
            // btnAbonos
            // 
            this.btnAbonos.AutoSize = true;
            this.btnAbonos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAbonos.FlatAppearance.BorderSize = 2;
            this.btnAbonos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAbonos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAbonos.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnAbonos.Location = new System.Drawing.Point(510, 358);
            this.btnAbonos.Name = "btnAbonos";
            this.btnAbonos.Size = new System.Drawing.Size(125, 52);
            this.btnAbonos.TabIndex = 23;
            this.btnAbonos.Text = "Factura";
            this.btnAbonos.UseVisualStyleBackColor = true;
            this.btnAbonos.Click += new System.EventHandler(this.btnAbonos_Click);
            // 
            // btnVales
            // 
            this.btnVales.AutoSize = true;
            this.btnVales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVales.FlatAppearance.BorderSize = 2;
            this.btnVales.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVales.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVales.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnVales.Location = new System.Drawing.Point(510, 265);
            this.btnVales.Name = "btnVales";
            this.btnVales.Size = new System.Drawing.Size(125, 52);
            this.btnVales.TabIndex = 22;
            this.btnVales.Text = "Vales";
            this.btnVales.UseVisualStyleBackColor = true;
            this.btnVales.Click += new System.EventHandler(this.btnVales_Click);
            // 
            // btnProforma
            // 
            this.btnProforma.AutoSize = true;
            this.btnProforma.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProforma.FlatAppearance.BorderSize = 2;
            this.btnProforma.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProforma.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProforma.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnProforma.Location = new System.Drawing.Point(510, 174);
            this.btnProforma.Name = "btnProforma";
            this.btnProforma.Size = new System.Drawing.Size(125, 52);
            this.btnProforma.TabIndex = 21;
            this.btnProforma.Text = "Proforma";
            this.btnProforma.UseVisualStyleBackColor = true;
            this.btnProforma.Click += new System.EventHandler(this.btnProforma_Click);
            // 
            // btnRecibos
            // 
            this.btnRecibos.AutoSize = true;
            this.btnRecibos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRecibos.FlatAppearance.BorderSize = 2;
            this.btnRecibos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecibos.Font = new System.Drawing.Font("Times New Roman", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRecibos.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnRecibos.Location = new System.Drawing.Point(510, 87);
            this.btnRecibos.Name = "btnRecibos";
            this.btnRecibos.Size = new System.Drawing.Size(125, 52);
            this.btnRecibos.TabIndex = 20;
            this.btnRecibos.Text = "Ventas";
            this.btnRecibos.UseVisualStyleBackColor = true;
            this.btnRecibos.Click += new System.EventHandler(this.btnRecibos_Click);
            // 
            // btnControlTrabajo
            // 
            this.btnControlTrabajo.AutoSize = true;
            this.btnControlTrabajo.BackColor = System.Drawing.Color.Transparent;
            this.btnControlTrabajo.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnControlTrabajo.BackgroundImage")));
            this.btnControlTrabajo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnControlTrabajo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnControlTrabajo.FlatAppearance.BorderSize = 0;
            this.btnControlTrabajo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnControlTrabajo.Location = new System.Drawing.Point(841, 276);
            this.btnControlTrabajo.Name = "btnControlTrabajo";
            this.btnControlTrabajo.Size = new System.Drawing.Size(108, 123);
            this.btnControlTrabajo.TabIndex = 18;
            this.btnControlTrabajo.UseVisualStyleBackColor = false;
            this.btnControlTrabajo.Click += new System.EventHandler(this.btnControlTrabajo_Click);
            // 
            // lblVeterinario
            // 
            this.lblVeterinario.AutoSize = true;
            this.lblVeterinario.BackColor = System.Drawing.Color.Transparent;
            this.lblVeterinario.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVeterinario.Location = new System.Drawing.Point(828, 402);
            this.lblVeterinario.Name = "lblVeterinario";
            this.lblVeterinario.Size = new System.Drawing.Size(142, 22);
            this.lblVeterinario.TabIndex = 17;
            this.lblVeterinario.Text = "Control de Trabajo";
            // 
            // btnCita
            // 
            this.btnCita.AutoSize = true;
            this.btnCita.BackColor = System.Drawing.Color.Transparent;
            this.btnCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCita.BackgroundImage")));
            this.btnCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCita.FlatAppearance.BorderSize = 0;
            this.btnCita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCita.Location = new System.Drawing.Point(841, 58);
            this.btnCita.Name = "btnCita";
            this.btnCita.Size = new System.Drawing.Size(93, 116);
            this.btnCita.TabIndex = 16;
            this.btnCita.UseVisualStyleBackColor = false;
            this.btnCita.Click += new System.EventHandler(this.btnCita_Click);
            // 
            // lblCita
            // 
            this.lblCita.AutoSize = true;
            this.lblCita.BackColor = System.Drawing.Color.Transparent;
            this.lblCita.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCita.Location = new System.Drawing.Point(866, 174);
            this.lblCita.Name = "lblCita";
            this.lblCita.Size = new System.Drawing.Size(47, 22);
            this.lblCita.TabIndex = 15;
            this.lblCita.Text = "Citas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(184, 402);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(83, 22);
            this.label5.TabIndex = 11;
            this.label5.Text = "Productos";
            // 
            // btnExpediente
            // 
            this.btnExpediente.AutoSize = true;
            this.btnExpediente.BackColor = System.Drawing.Color.Transparent;
            this.btnExpediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpediente.BackgroundImage")));
            this.btnExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpediente.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExpediente.FlatAppearance.BorderSize = 0;
            this.btnExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpediente.Location = new System.Drawing.Point(175, 52);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Size = new System.Drawing.Size(113, 119);
            this.btnExpediente.TabIndex = 10;
            this.btnExpediente.UseVisualStyleBackColor = false;
            this.btnExpediente.Click += new System.EventHandler(this.btnExpediente_Click);
            // 
            // lblExpediente
            // 
            this.lblExpediente.AutoSize = true;
            this.lblExpediente.BackColor = System.Drawing.Color.Transparent;
            this.lblExpediente.Font = new System.Drawing.Font("Impact", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblExpediente.ForeColor = System.Drawing.Color.Black;
            this.lblExpediente.Location = new System.Drawing.Point(184, 174);
            this.lblExpediente.Name = "lblExpediente";
            this.lblExpediente.Size = new System.Drawing.Size(96, 22);
            this.lblExpediente.TabIndex = 9;
            this.lblExpediente.Text = "Expedientes";
            // 
            // pctUsuario
            // 
            this.pctUsuario.BackColor = System.Drawing.Color.Transparent;
            this.pctUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pctUsuario.BackgroundImage")));
            this.pctUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pctUsuario.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pctUsuario.Location = new System.Drawing.Point(11, 36);
            this.pctUsuario.Name = "pctUsuario";
            this.pctUsuario.Size = new System.Drawing.Size(45, 42);
            this.pctUsuario.TabIndex = 6;
            this.pctUsuario.TabStop = false;
            // 
            // lbl_usuarioCargo
            // 
            this.lbl_usuarioCargo.AutoSize = true;
            this.lbl_usuarioCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioCargo.Location = new System.Drawing.Point(212, 61);
            this.lbl_usuarioCargo.Name = "lbl_usuarioCargo";
            this.lbl_usuarioCargo.Size = new System.Drawing.Size(0, 20);
            this.lbl_usuarioCargo.TabIndex = 14;
            // 
            // lbl_usuarioNombre
            // 
            this.lbl_usuarioNombre.AutoSize = true;
            this.lbl_usuarioNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioNombre.Location = new System.Drawing.Point(212, 37);
            this.lbl_usuarioNombre.Name = "lbl_usuarioNombre";
            this.lbl_usuarioNombre.Size = new System.Drawing.Size(0, 20);
            this.lbl_usuarioNombre.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.configuraciónToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1211, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // configuraciónToolStripMenuItem
            // 
            this.configuraciónToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolstrip_usuarios});
            this.configuraciónToolStripMenuItem.Name = "configuraciónToolStripMenuItem";
            this.configuraciónToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.configuraciónToolStripMenuItem.Text = "Configurar";
            // 
            // toolstrip_usuarios
            // 
            this.toolstrip_usuarios.Name = "toolstrip_usuarios";
            this.toolstrip_usuarios.Size = new System.Drawing.Size(119, 22);
            this.toolstrip_usuarios.Text = "Usuarios";
            this.toolstrip_usuarios.Click += new System.EventHandler(this.toolstrip_usuarios_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(1211, 696);
            this.Controls.Add(this.lbl_usuarioNombre);
            this.Controls.Add(this.lbl_usuarioCargo);
            this.Controls.Add(this.GrpPrincipal);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pctUsuario);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optica Santa Marta Beta V 1.0";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmPrincipalLoad);
            this.GrpPrincipal.ResumeLayout(false);
            this.GrpPrincipal.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctUsuario)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lbl_salir;
        private System.Windows.Forms.Button btn_Salir;

        #endregion

        private System.Windows.Forms.PictureBox pctUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox GrpPrincipal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.Label lblExpediente;
        private System.Windows.Forms.Button btnControlTrabajo;
        private System.Windows.Forms.Label lblVeterinario;
        private System.Windows.Forms.Button btnCita;
        private System.Windows.Forms.Label lblCita;
        private System.Windows.Forms.Button btnVales;
        private System.Windows.Forms.Button btnProforma;
        private System.Windows.Forms.Button btnRecibos;
        private System.Windows.Forms.Button btnProductos;
        private System.Windows.Forms.Label lbl_usuarioCargo;
        private System.Windows.Forms.Label lbl_usuarioNombre;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem configuraciónToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolstrip_usuarios;
        private System.Windows.Forms.Button btnAbonos;
    }
}