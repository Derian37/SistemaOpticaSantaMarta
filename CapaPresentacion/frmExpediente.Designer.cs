namespace CapaPresentacion
{
    partial class frmExpediente
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExpediente));
            this.dgvExpediente = new System.Windows.Forms.DataGridView();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.txt_Cliente_Cedula = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.lblDuenno_nombre = new System.Windows.Forms.Label();
            this.grbInformacion = new System.Windows.Forms.GroupBox();
            this.label_id = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnExpediente = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnRecuperarDuenno = new System.Windows.Forms.Button();
            this.grbAparienciaUsuario = new System.Windows.Forms.GroupBox();
            this.btnCargar = new System.Windows.Forms.Button();
            this.btnInsertarDuenno = new System.Windows.Forms.Button();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblTUser = new System.Windows.Forms.Label();
            this.lblUNombre = new System.Windows.Forms.Label();
            this.lbl_usuarioCargo = new System.Windows.Forms.Label();
            this.grbPanelUsuario = new System.Windows.Forms.GroupBox();
            this.pcbAdmi = new System.Windows.Forms.PictureBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.volverToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).BeginInit();
            this.grbInformacion.SuspendLayout();
            this.grbAparienciaUsuario.SuspendLayout();
            this.grbPanelUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmi)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvExpediente
            // 
            this.dgvExpediente.AllowUserToAddRows = false;
            this.dgvExpediente.AllowUserToDeleteRows = false;
            this.dgvExpediente.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvExpediente.BackgroundColor = System.Drawing.Color.White;
            this.dgvExpediente.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvExpediente.Location = new System.Drawing.Point(123, 435);
            this.dgvExpediente.Name = "dgvExpediente";
            this.dgvExpediente.ReadOnly = true;
            this.dgvExpediente.Size = new System.Drawing.Size(1063, 214);
            this.dgvExpediente.TabIndex = 73;
            this.dgvExpediente.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpediente_CellClick);
            this.dgvExpediente.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvExpediente_CellDoubleClick);
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar.Location = new System.Drawing.Point(372, 21);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(56, 19);
            this.lblBuscar.TabIndex = 55;
            this.lblBuscar.Text = "Buscar";
            // 
            // txt_Cliente_Cedula
            // 
            this.txt_Cliente_Cedula.BackColor = System.Drawing.Color.White;
            this.txt_Cliente_Cedula.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_Cliente_Cedula.Location = new System.Drawing.Point(159, 41);
            this.txt_Cliente_Cedula.Name = "txt_Cliente_Cedula";
            this.txt_Cliente_Cedula.Size = new System.Drawing.Size(169, 26);
            this.txt_Cliente_Cedula.TabIndex = 58;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 78);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(99, 19);
            this.label5.TabIndex = 67;
            this.label5.Text = "Nuevo Cliente:";
            // 
            // lblDuenno_nombre
            // 
            this.lblDuenno_nombre.AutoSize = true;
            this.lblDuenno_nombre.BackColor = System.Drawing.Color.Transparent;
            this.lblDuenno_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblDuenno_nombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDuenno_nombre.Location = new System.Drawing.Point(6, 44);
            this.lblDuenno_nombre.Name = "lblDuenno_nombre";
            this.lblDuenno_nombre.Size = new System.Drawing.Size(137, 19);
            this.lblDuenno_nombre.TabIndex = 66;
            this.lblDuenno_nombre.Text = "Cédula del Cliente:";
            // 
            // grbInformacion
            // 
            this.grbInformacion.Controls.Add(this.label_id);
            this.grbInformacion.Controls.Add(this.label4);
            this.grbInformacion.Controls.Add(this.textBox2);
            this.grbInformacion.Controls.Add(this.btnExpediente);
            this.grbInformacion.Controls.Add(this.textBox1);
            this.grbInformacion.Controls.Add(this.label3);
            this.grbInformacion.Controls.Add(this.label2);
            this.grbInformacion.Controls.Add(this.btnRecuperarDuenno);
            this.grbInformacion.Location = new System.Drawing.Point(6, 132);
            this.grbInformacion.Name = "grbInformacion";
            this.grbInformacion.Size = new System.Drawing.Size(451, 116);
            this.grbInformacion.TabIndex = 71;
            this.grbInformacion.TabStop = false;
            this.grbInformacion.Text = "Informacion del cliente";
            this.grbInformacion.Visible = false;
            // 
            // label_id
            // 
            this.label_id.AutoSize = true;
            this.label_id.Location = new System.Drawing.Point(6, 29);
            this.label_id.Name = "label_id";
            this.label_id.Size = new System.Drawing.Size(21, 19);
            this.label_id.TabIndex = 75;
            this.label_id.Text = "id";
            this.label_id.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(291, 85);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 19);
            this.label4.TabIndex = 74;
            this.label4.Text = "Ver Tarjeta";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.White;
            this.textBox2.Enabled = false;
            this.textBox2.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox2.Location = new System.Drawing.Point(79, 78);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(169, 26);
            this.textBox2.TabIndex = 72;
            // 
            // btnExpediente
            // 
            this.btnExpediente.BackColor = System.Drawing.Color.Transparent;
            this.btnExpediente.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnExpediente.BackgroundImage")));
            this.btnExpediente.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnExpediente.FlatAppearance.BorderSize = 0;
            this.btnExpediente.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExpediente.Location = new System.Drawing.Point(295, 29);
            this.btnExpediente.Name = "btnExpediente";
            this.btnExpediente.Size = new System.Drawing.Size(51, 53);
            this.btnExpediente.TabIndex = 73;
            this.btnExpediente.UseVisualStyleBackColor = false;
            this.btnExpediente.Click += new System.EventHandler(this.btnExpediente_Click);
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.White;
            this.textBox1.Enabled = false;
            this.textBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.Location = new System.Drawing.Point(79, 46);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 71;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label3.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(5, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(61, 19);
            this.label3.TabIndex = 70;
            this.label3.Text = "Cédula:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(5, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 19);
            this.label2.TabIndex = 69;
            this.label2.Text = "Nombre:";
            // 
            // btnRecuperarDuenno
            // 
            this.btnRecuperarDuenno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnRecuperarDuenno.BackgroundImage")));
            this.btnRecuperarDuenno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnRecuperarDuenno.FlatAppearance.BorderSize = 0;
            this.btnRecuperarDuenno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRecuperarDuenno.Location = new System.Drawing.Point(395, 13);
            this.btnRecuperarDuenno.Name = "btnRecuperarDuenno";
            this.btnRecuperarDuenno.Size = new System.Drawing.Size(17, 18);
            this.btnRecuperarDuenno.TabIndex = 68;
            this.btnRecuperarDuenno.UseVisualStyleBackColor = true;
            this.btnRecuperarDuenno.Visible = false;
            // 
            // grbAparienciaUsuario
            // 
            this.grbAparienciaUsuario.BackColor = System.Drawing.Color.Transparent;
            this.grbAparienciaUsuario.Controls.Add(this.grbInformacion);
            this.grbAparienciaUsuario.Controls.Add(this.lblDuenno_nombre);
            this.grbAparienciaUsuario.Controls.Add(this.txt_Cliente_Cedula);
            this.grbAparienciaUsuario.Controls.Add(this.btnCargar);
            this.grbAparienciaUsuario.Controls.Add(this.lblBuscar);
            this.grbAparienciaUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAparienciaUsuario.Location = new System.Drawing.Point(723, 171);
            this.grbAparienciaUsuario.Name = "grbAparienciaUsuario";
            this.grbAparienciaUsuario.Size = new System.Drawing.Size(463, 254);
            this.grbAparienciaUsuario.TabIndex = 72;
            this.grbAparienciaUsuario.TabStop = false;
            this.grbAparienciaUsuario.Text = "Buscar Cliente";
            // 
            // btnCargar
            // 
            this.btnCargar.BackColor = System.Drawing.Color.Transparent;
            this.btnCargar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCargar.BackgroundImage")));
            this.btnCargar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnCargar.FlatAppearance.BorderSize = 0;
            this.btnCargar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnCargar.Location = new System.Drawing.Point(376, 41);
            this.btnCargar.Name = "btnCargar";
            this.btnCargar.Size = new System.Drawing.Size(52, 42);
            this.btnCargar.TabIndex = 52;
            this.btnCargar.UseVisualStyleBackColor = false;
            this.btnCargar.Click += new System.EventHandler(this.btnCargar_Click);
            // 
            // btnInsertarDuenno
            // 
            this.btnInsertarDuenno.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertarDuenno.BackgroundImage")));
            this.btnInsertarDuenno.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarDuenno.FlatAppearance.BorderSize = 0;
            this.btnInsertarDuenno.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInsertarDuenno.Location = new System.Drawing.Point(127, 72);
            this.btnInsertarDuenno.Name = "btnInsertarDuenno";
            this.btnInsertarDuenno.Size = new System.Drawing.Size(40, 30);
            this.btnInsertarDuenno.TabIndex = 68;
            this.btnInsertarDuenno.Text = " ";
            this.btnInsertarDuenno.UseVisualStyleBackColor = true;
            this.btnInsertarDuenno.Click += new System.EventHandler(this.btnInsertarDuenno_Click);
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(112, 30);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(144, 19);
            this.lblUser.TabIndex = 0;
            this.lblUser.Text = "Nombre de Usuario:";
            // 
            // lblTUser
            // 
            this.lblTUser.AutoSize = true;
            this.lblTUser.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTUser.Location = new System.Drawing.Point(112, 77);
            this.lblTUser.Name = "lblTUser";
            this.lblTUser.Size = new System.Drawing.Size(55, 19);
            this.lblTUser.TabIndex = 1;
            this.lblTUser.Text = "Cargo:";
            // 
            // lblUNombre
            // 
            this.lblUNombre.AutoSize = true;
            this.lblUNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUNombre.Location = new System.Drawing.Point(262, 30);
            this.lblUNombre.Name = "lblUNombre";
            this.lblUNombre.Size = new System.Drawing.Size(101, 19);
            this.lblUNombre.TabIndex = 2;
            this.lblUNombre.Text = "¡ Contrucción !";
            // 
            // lbl_usuarioCargo
            // 
            this.lbl_usuarioCargo.AutoSize = true;
            this.lbl_usuarioCargo.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_usuarioCargo.Location = new System.Drawing.Point(180, 77);
            this.lbl_usuarioCargo.Name = "lbl_usuarioCargo";
            this.lbl_usuarioCargo.Size = new System.Drawing.Size(101, 19);
            this.lbl_usuarioCargo.TabIndex = 38;
            this.lbl_usuarioCargo.Text = "¡ Contrucción !";
            // 
            // grbPanelUsuario
            // 
            this.grbPanelUsuario.BackColor = System.Drawing.Color.Transparent;
            this.grbPanelUsuario.Controls.Add(this.lbl_usuarioCargo);
            this.grbPanelUsuario.Controls.Add(this.lblUNombre);
            this.grbPanelUsuario.Controls.Add(this.lblTUser);
            this.grbPanelUsuario.Controls.Add(this.lblUser);
            this.grbPanelUsuario.Controls.Add(this.pcbAdmi);
            this.grbPanelUsuario.Location = new System.Drawing.Point(123, 171);
            this.grbPanelUsuario.Name = "grbPanelUsuario";
            this.grbPanelUsuario.Size = new System.Drawing.Size(430, 115);
            this.grbPanelUsuario.TabIndex = 71;
            this.grbPanelUsuario.TabStop = false;
            // 
            // pcbAdmi
            // 
            this.pcbAdmi.BackColor = System.Drawing.Color.Transparent;
            this.pcbAdmi.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbAdmi.BackgroundImage")));
            this.pcbAdmi.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pcbAdmi.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pcbAdmi.Location = new System.Drawing.Point(9, 20);
            this.pcbAdmi.Name = "pcbAdmi";
            this.pcbAdmi.Size = new System.Drawing.Size(97, 87);
            this.pcbAdmi.TabIndex = 37;
            this.pcbAdmi.TabStop = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.volverToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1277, 28);
            this.menuStrip1.TabIndex = 74;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // volverToolStripMenuItem
            // 
            this.volverToolStripMenuItem.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.volverToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("volverToolStripMenuItem.Image")));
            this.volverToolStripMenuItem.Name = "volverToolStripMenuItem";
            this.volverToolStripMenuItem.Size = new System.Drawing.Size(83, 24);
            this.volverToolStripMenuItem.Text = "Volver";
            this.volverToolStripMenuItem.Click += new System.EventHandler(this.volverToolStripMenuItem_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btnInsertarDuenno);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(123, 310);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(430, 115);
            this.groupBox1.TabIndex = 72;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(8, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 19);
            this.label1.TabIndex = 80;
            this.label1.Text = "Nuevo Tarjeta:";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(116, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(51, 53);
            this.button1.TabIndex = 81;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.grbPanelUsuario);
            this.panel1.Controls.Add(this.dgvExpediente);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grbAparienciaUsuario);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1277, 661);
            this.panel1.TabIndex = 75;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.pictureBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox2.Location = new System.Drawing.Point(389, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(612, 144);
            this.groupBox2.TabIndex = 81;
            this.groupBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(443, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 91);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 76;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(38, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(306, 24);
            this.label6.TabIndex = 75;
            this.label6.Text = "Comprometidos por tu Salud Visual";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(54, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(265, 31);
            this.label7.TabIndex = 74;
            this.label7.Text = "Óptica Santa Marta";
            // 
            // frmExpediente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1277, 689);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmExpediente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Optica Santa Marta";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmExpediente_FormClosing);
            this.Load += new System.EventHandler(this.frmExpediente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvExpediente)).EndInit();
            this.grbInformacion.ResumeLayout(false);
            this.grbInformacion.PerformLayout();
            this.grbAparienciaUsuario.ResumeLayout(false);
            this.grbAparienciaUsuario.PerformLayout();
            this.grbPanelUsuario.ResumeLayout(false);
            this.grbPanelUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbAdmi)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvExpediente;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.Button btnCargar;
        private System.Windows.Forms.TextBox txt_Cliente_Cedula;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.Button btnInsertarDuenno;
        private System.Windows.Forms.Label lblDuenno_nombre;
        private System.Windows.Forms.GroupBox grbInformacion;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnExpediente;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnRecuperarDuenno;
        private System.Windows.Forms.GroupBox grbAparienciaUsuario;
        private System.Windows.Forms.PictureBox pcbAdmi;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblTUser;
        private System.Windows.Forms.Label lblUNombre;
        private System.Windows.Forms.Label lbl_usuarioCargo;
        private System.Windows.Forms.GroupBox grbPanelUsuario;
        private System.Windows.Forms.ToolStripMenuItem volverToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Label label_id;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox2;
    }
}