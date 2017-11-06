﻿namespace CapaPresentacion
{
    partial class frmCitas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCitas));
            this.grb_menuCita = new System.Windows.Forms.GroupBox();
            this.lblOpcionBusqueda = new System.Windows.Forms.Label();
            this.rbtn_nombreCita = new System.Windows.Forms.RadioButton();
            this.rbtn_CedulaCita = new System.Windows.Forms.RadioButton();
            this.lbl_agregarCita = new System.Windows.Forms.Label();
            this.btn_buscarCita = new System.Windows.Forms.Button();
            this.lbl_Cita_id = new System.Windows.Forms.Label();
            this.txt_valor_Cita = new System.Windows.Forms.TextBox();
            this.lblBuscar_Cita = new System.Windows.Forms.Label();
            this.btn_InsertarCita = new System.Windows.Forms.Button();
            this.gbx_datosCita = new System.Windows.Forms.GroupBox();
            this.txt_CedulaUsuario = new System.Windows.Forms.TextBox();
            this.lbl_CedulaUsuario = new System.Windows.Forms.Label();
            this.dtpFechaCita = new System.Windows.Forms.DateTimePicker();
            this.lbl_FechaCita = new System.Windows.Forms.Label();
            this.lbl_guardarCita = new System.Windows.Forms.Label();
            this.btn_guardarCita = new System.Windows.Forms.Button();
            this.lbl_editarCita = new System.Windows.Forms.Label();
            this.lbl_eliminarCita = new System.Windows.Forms.Label();
            this.txt_detalleCita = new System.Windows.Forms.TextBox();
            this.txt_telefonoUsuario = new System.Windows.Forms.TextBox();
            this.btn_EliminarCita = new System.Windows.Forms.Button();
            this.btn_EditarCita = new System.Windows.Forms.Button();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.lbl_telefonoUsuario = new System.Windows.Forms.Label();
            this.lbl_detalleCita = new System.Windows.Forms.Label();
            this.lbl_Usuario = new System.Windows.Forms.Label();
            this.lbl_Cita = new System.Windows.Forms.Label();
            this.gpBxCitasReservadas = new System.Windows.Forms.GroupBox();
            this.dgvCitas = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_volver = new System.Windows.Forms.ToolStripMenuItem();
            this.grb_menuCita.SuspendLayout();
            this.gbx_datosCita.SuspendLayout();
            this.gpBxCitasReservadas.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_menuCita
            // 
            this.grb_menuCita.BackColor = System.Drawing.Color.Transparent;
            this.grb_menuCita.Controls.Add(this.lblOpcionBusqueda);
            this.grb_menuCita.Controls.Add(this.rbtn_nombreCita);
            this.grb_menuCita.Controls.Add(this.rbtn_CedulaCita);
            this.grb_menuCita.Controls.Add(this.lbl_agregarCita);
            this.grb_menuCita.Controls.Add(this.btn_buscarCita);
            this.grb_menuCita.Controls.Add(this.lbl_Cita_id);
            this.grb_menuCita.Controls.Add(this.txt_valor_Cita);
            this.grb_menuCita.Controls.Add(this.lblBuscar_Cita);
            this.grb_menuCita.Controls.Add(this.btn_InsertarCita);
            this.grb_menuCita.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grb_menuCita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_menuCita.Location = new System.Drawing.Point(10, 24);
            this.grb_menuCita.Name = "grb_menuCita";
            this.grb_menuCita.Size = new System.Drawing.Size(314, 202);
            this.grb_menuCita.TabIndex = 65;
            this.grb_menuCita.TabStop = false;
            this.grb_menuCita.Text = "Menú";
            // 
            // lblOpcionBusqueda
            // 
            this.lblOpcionBusqueda.AutoSize = true;
            this.lblOpcionBusqueda.Location = new System.Drawing.Point(6, 26);
            this.lblOpcionBusqueda.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblOpcionBusqueda.Name = "lblOpcionBusqueda";
            this.lblOpcionBusqueda.Size = new System.Drawing.Size(131, 19);
            this.lblOpcionBusqueda.TabIndex = 74;
            this.lblOpcionBusqueda.Text = "Opción Busqueda:";
            // 
            // rbtn_nombreCita
            // 
            this.rbtn_nombreCita.AutoSize = true;
            this.rbtn_nombreCita.Location = new System.Drawing.Point(215, 24);
            this.rbtn_nombreCita.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_nombreCita.Name = "rbtn_nombreCita";
            this.rbtn_nombreCita.Size = new System.Drawing.Size(81, 23);
            this.rbtn_nombreCita.TabIndex = 73;
            this.rbtn_nombreCita.Text = "Nombre";
            this.rbtn_nombreCita.UseVisualStyleBackColor = true;
            // 
            // rbtn_CedulaCita
            // 
            this.rbtn_CedulaCita.AutoSize = true;
            this.rbtn_CedulaCita.Checked = true;
            this.rbtn_CedulaCita.Location = new System.Drawing.Point(144, 24);
            this.rbtn_CedulaCita.Margin = new System.Windows.Forms.Padding(2);
            this.rbtn_CedulaCita.Name = "rbtn_CedulaCita";
            this.rbtn_CedulaCita.Size = new System.Drawing.Size(74, 23);
            this.rbtn_CedulaCita.TabIndex = 72;
            this.rbtn_CedulaCita.TabStop = true;
            this.rbtn_CedulaCita.Text = "Cédula";
            this.rbtn_CedulaCita.UseVisualStyleBackColor = true;
            // 
            // lbl_agregarCita
            // 
            this.lbl_agregarCita.Location = new System.Drawing.Point(187, 148);
            this.lbl_agregarCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_agregarCita.Name = "lbl_agregarCita";
            this.lbl_agregarCita.Size = new System.Drawing.Size(62, 19);
            this.lbl_agregarCita.TabIndex = 69;
            this.lbl_agregarCita.Text = "Agregar";
            // 
            // btn_buscarCita
            // 
            this.btn_buscarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_buscarCita.BackgroundImage")));
            this.btn_buscarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_buscarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_buscarCita.Location = new System.Drawing.Point(82, 88);
            this.btn_buscarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btn_buscarCita.Name = "btn_buscarCita";
            this.btn_buscarCita.Size = new System.Drawing.Size(46, 46);
            this.btn_buscarCita.TabIndex = 62;
            this.btn_buscarCita.UseVisualStyleBackColor = true;
            this.btn_buscarCita.Click += new System.EventHandler(this.btn_buscarCita_Click);
            // 
            // lbl_Cita_id
            // 
            this.lbl_Cita_id.AutoSize = true;
            this.lbl_Cita_id.BackColor = System.Drawing.Color.Transparent;
            this.lbl_Cita_id.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_Cita_id.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cita_id.Location = new System.Drawing.Point(6, 61);
            this.lbl_Cita_id.Name = "lbl_Cita_id";
            this.lbl_Cita_id.Size = new System.Drawing.Size(42, 19);
            this.lbl_Cita_id.TabIndex = 59;
            this.lbl_Cita_id.Text = "Cita:";
            // 
            // txt_valor_Cita
            // 
            this.txt_valor_Cita.BackColor = System.Drawing.Color.White;
            this.txt_valor_Cita.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_valor_Cita.Location = new System.Drawing.Point(82, 57);
            this.txt_valor_Cita.Name = "txt_valor_Cita";
            this.txt_valor_Cita.ShortcutsEnabled = false;
            this.txt_valor_Cita.Size = new System.Drawing.Size(156, 26);
            this.txt_valor_Cita.TabIndex = 58;
            this.txt_valor_Cita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_valor_Cita_KeyPress);
            // 
            // lblBuscar_Cita
            // 
            this.lblBuscar_Cita.AutoSize = true;
            this.lblBuscar_Cita.BackColor = System.Drawing.Color.Transparent;
            this.lblBuscar_Cita.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lblBuscar_Cita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBuscar_Cita.Location = new System.Drawing.Point(79, 148);
            this.lblBuscar_Cita.Name = "lblBuscar_Cita";
            this.lblBuscar_Cita.Size = new System.Drawing.Size(56, 19);
            this.lblBuscar_Cita.TabIndex = 55;
            this.lblBuscar_Cita.Text = "Buscar";
            // 
            // btn_InsertarCita
            // 
            this.btn_InsertarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_InsertarCita.BackgroundImage")));
            this.btn_InsertarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_InsertarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_InsertarCita.Location = new System.Drawing.Point(190, 88);
            this.btn_InsertarCita.Name = "btn_InsertarCita";
            this.btn_InsertarCita.Size = new System.Drawing.Size(46, 45);
            this.btn_InsertarCita.TabIndex = 68;
            this.btn_InsertarCita.Text = " ";
            this.btn_InsertarCita.UseVisualStyleBackColor = true;
            this.btn_InsertarCita.Click += new System.EventHandler(this.btn_InsertarCita_Click);
            // 
            // gbx_datosCita
            // 
            this.gbx_datosCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_datosCita.Controls.Add(this.txt_CedulaUsuario);
            this.gbx_datosCita.Controls.Add(this.lbl_CedulaUsuario);
            this.gbx_datosCita.Controls.Add(this.dtpFechaCita);
            this.gbx_datosCita.Controls.Add(this.lbl_FechaCita);
            this.gbx_datosCita.Controls.Add(this.lbl_guardarCita);
            this.gbx_datosCita.Controls.Add(this.btn_guardarCita);
            this.gbx_datosCita.Controls.Add(this.lbl_editarCita);
            this.gbx_datosCita.Controls.Add(this.lbl_eliminarCita);
            this.gbx_datosCita.Controls.Add(this.txt_detalleCita);
            this.gbx_datosCita.Controls.Add(this.txt_telefonoUsuario);
            this.gbx_datosCita.Controls.Add(this.btn_EliminarCita);
            this.gbx_datosCita.Controls.Add(this.btn_EditarCita);
            this.gbx_datosCita.Controls.Add(this.txt_nombreUsuario);
            this.gbx_datosCita.Controls.Add(this.lbl_telefonoUsuario);
            this.gbx_datosCita.Controls.Add(this.lbl_detalleCita);
            this.gbx_datosCita.Controls.Add(this.lbl_Usuario);
            this.gbx_datosCita.Controls.Add(this.lbl_Cita);
            this.gbx_datosCita.Enabled = false;
            this.gbx_datosCita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosCita.Location = new System.Drawing.Point(346, 24);
            this.gbx_datosCita.Margin = new System.Windows.Forms.Padding(2);
            this.gbx_datosCita.Name = "gbx_datosCita";
            this.gbx_datosCita.Padding = new System.Windows.Forms.Padding(2);
            this.gbx_datosCita.Size = new System.Drawing.Size(448, 202);
            this.gbx_datosCita.TabIndex = 69;
            this.gbx_datosCita.TabStop = false;
            this.gbx_datosCita.Text = "Cita";
            this.gbx_datosCita.Visible = false;
            // 
            // txt_CedulaUsuario
            // 
            this.txt_CedulaUsuario.Location = new System.Drawing.Point(81, 51);
            this.txt_CedulaUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_CedulaUsuario.MaxLength = 15;
            this.txt_CedulaUsuario.Name = "txt_CedulaUsuario";
            this.txt_CedulaUsuario.Size = new System.Drawing.Size(141, 26);
            this.txt_CedulaUsuario.TabIndex = 84;
            this.txt_CedulaUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_CedulaUsuario_KeyPress);
            // 
            // lbl_CedulaUsuario
            // 
            this.lbl_CedulaUsuario.AutoSize = true;
            this.lbl_CedulaUsuario.Location = new System.Drawing.Point(8, 51);
            this.lbl_CedulaUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_CedulaUsuario.Name = "lbl_CedulaUsuario";
            this.lbl_CedulaUsuario.Size = new System.Drawing.Size(61, 19);
            this.lbl_CedulaUsuario.TabIndex = 83;
            this.lbl_CedulaUsuario.Text = "Cédula:";
            // 
            // dtpFechaCita
            // 
            this.dtpFechaCita.Checked = false;
            this.dtpFechaCita.CustomFormat = "dd-MM-yyyy";
            this.dtpFechaCita.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpFechaCita.Location = new System.Drawing.Point(81, 150);
            this.dtpFechaCita.Margin = new System.Windows.Forms.Padding(2);
            this.dtpFechaCita.Name = "dtpFechaCita";
            this.dtpFechaCita.Size = new System.Drawing.Size(189, 26);
            this.dtpFechaCita.TabIndex = 82;
            this.dtpFechaCita.Value = new System.DateTime(2017, 9, 9, 0, 0, 0, 0);
            // 
            // lbl_FechaCita
            // 
            this.lbl_FechaCita.AutoSize = true;
            this.lbl_FechaCita.Location = new System.Drawing.Point(8, 155);
            this.lbl_FechaCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_FechaCita.Name = "lbl_FechaCita";
            this.lbl_FechaCita.Size = new System.Drawing.Size(54, 19);
            this.lbl_FechaCita.TabIndex = 81;
            this.lbl_FechaCita.Text = "Fecha:";
            // 
            // lbl_guardarCita
            // 
            this.lbl_guardarCita.AutoSize = true;
            this.lbl_guardarCita.Location = new System.Drawing.Point(359, 176);
            this.lbl_guardarCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_guardarCita.Name = "lbl_guardarCita";
            this.lbl_guardarCita.Size = new System.Drawing.Size(65, 19);
            this.lbl_guardarCita.TabIndex = 80;
            this.lbl_guardarCita.Text = "Guardar";
            // 
            // btn_guardarCita
            // 
            this.btn_guardarCita.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btn_guardarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarCita.FlatAppearance.BorderSize = 0;
            this.btn_guardarCita.Location = new System.Drawing.Point(362, 133);
            this.btn_guardarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btn_guardarCita.Name = "btn_guardarCita";
            this.btn_guardarCita.Size = new System.Drawing.Size(43, 41);
            this.btn_guardarCita.TabIndex = 79;
            this.btn_guardarCita.UseVisualStyleBackColor = true;
            this.btn_guardarCita.Click += new System.EventHandler(this.btn_guardarCita_Click);
            // 
            // lbl_editarCita
            // 
            this.lbl_editarCita.Location = new System.Drawing.Point(363, 54);
            this.lbl_editarCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_editarCita.Name = "lbl_editarCita";
            this.lbl_editarCita.Size = new System.Drawing.Size(48, 19);
            this.lbl_editarCita.TabIndex = 71;
            this.lbl_editarCita.Text = "Editar";
            // 
            // lbl_eliminarCita
            // 
            this.lbl_eliminarCita.Location = new System.Drawing.Point(359, 118);
            this.lbl_eliminarCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_eliminarCita.Name = "lbl_eliminarCita";
            this.lbl_eliminarCita.Size = new System.Drawing.Size(62, 19);
            this.lbl_eliminarCita.TabIndex = 70;
            this.lbl_eliminarCita.Text = "Eliminar";
            // 
            // txt_detalleCita
            // 
            this.txt_detalleCita.Location = new System.Drawing.Point(81, 121);
            this.txt_detalleCita.Margin = new System.Windows.Forms.Padding(2);
            this.txt_detalleCita.MaxLength = 200;
            this.txt_detalleCita.Name = "txt_detalleCita";
            this.txt_detalleCita.Size = new System.Drawing.Size(189, 26);
            this.txt_detalleCita.TabIndex = 76;
            this.txt_detalleCita.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_detalleCita_KeyPress);
            // 
            // txt_telefonoUsuario
            // 
            this.txt_telefonoUsuario.Location = new System.Drawing.Point(81, 98);
            this.txt_telefonoUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_telefonoUsuario.MaxLength = 20;
            this.txt_telefonoUsuario.Name = "txt_telefonoUsuario";
            this.txt_telefonoUsuario.Size = new System.Drawing.Size(141, 26);
            this.txt_telefonoUsuario.TabIndex = 75;
            this.txt_telefonoUsuario.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_telefonoUsuario_KeyPress);
            // 
            // btn_EliminarCita
            // 
            this.btn_EliminarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarCita.BackgroundImage")));
            this.btn_EliminarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarCita.FlatAppearance.BorderSize = 0;
            this.btn_EliminarCita.Location = new System.Drawing.Point(362, 75);
            this.btn_EliminarCita.Margin = new System.Windows.Forms.Padding(2);
            this.btn_EliminarCita.Name = "btn_EliminarCita";
            this.btn_EliminarCita.Size = new System.Drawing.Size(44, 41);
            this.btn_EliminarCita.TabIndex = 61;
            this.btn_EliminarCita.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EliminarCita.UseVisualStyleBackColor = true;
            this.btn_EliminarCita.Click += new System.EventHandler(this.btn_EliminarCita_Click);
            // 
            // btn_EditarCita
            // 
            this.btn_EditarCita.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarCita.BackgroundImage")));
            this.btn_EditarCita.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarCita.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarCita.FlatAppearance.BorderSize = 0;
            this.btn_EditarCita.Location = new System.Drawing.Point(362, 13);
            this.btn_EditarCita.Margin = new System.Windows.Forms.Padding(0);
            this.btn_EditarCita.Name = "btn_EditarCita";
            this.btn_EditarCita.Size = new System.Drawing.Size(44, 41);
            this.btn_EditarCita.TabIndex = 60;
            this.btn_EditarCita.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EditarCita.UseVisualStyleBackColor = true;
            this.btn_EditarCita.Click += new System.EventHandler(this.btn_EditarCita_Click);
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Location = new System.Drawing.Point(81, 75);
            this.txt_nombreUsuario.Margin = new System.Windows.Forms.Padding(2);
            this.txt_nombreUsuario.MaxLength = 30;
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(141, 26);
            this.txt_nombreUsuario.TabIndex = 74;
            // 
            // lbl_telefonoUsuario
            // 
            this.lbl_telefonoUsuario.AutoSize = true;
            this.lbl_telefonoUsuario.Location = new System.Drawing.Point(8, 101);
            this.lbl_telefonoUsuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_telefonoUsuario.Name = "lbl_telefonoUsuario";
            this.lbl_telefonoUsuario.Size = new System.Drawing.Size(72, 19);
            this.lbl_telefonoUsuario.TabIndex = 71;
            this.lbl_telefonoUsuario.Text = "Telefono:";
            // 
            // lbl_detalleCita
            // 
            this.lbl_detalleCita.AutoSize = true;
            this.lbl_detalleCita.Location = new System.Drawing.Point(8, 124);
            this.lbl_detalleCita.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_detalleCita.Name = "lbl_detalleCita";
            this.lbl_detalleCita.Size = new System.Drawing.Size(63, 19);
            this.lbl_detalleCita.TabIndex = 70;
            this.lbl_detalleCita.Text = "Detalle:";
            // 
            // lbl_Usuario
            // 
            this.lbl_Usuario.AutoSize = true;
            this.lbl_Usuario.Location = new System.Drawing.Point(8, 77);
            this.lbl_Usuario.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_Usuario.Name = "lbl_Usuario";
            this.lbl_Usuario.Size = new System.Drawing.Size(66, 19);
            this.lbl_Usuario.TabIndex = 69;
            this.lbl_Usuario.Text = "Usuario:";
            // 
            // lbl_Cita
            // 
            this.lbl_Cita.AutoSize = true;
            this.lbl_Cita.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Cita.Location = new System.Drawing.Point(5, 21);
            this.lbl_Cita.Name = "lbl_Cita";
            this.lbl_Cita.Size = new System.Drawing.Size(90, 19);
            this.lbl_Cita.TabIndex = 67;
            this.lbl_Cita.Text = "Nueva Cita:";
            // 
            // gpBxCitasReservadas
            // 
            this.gpBxCitasReservadas.Controls.Add(this.dgvCitas);
            this.gpBxCitasReservadas.Location = new System.Drawing.Point(10, 230);
            this.gpBxCitasReservadas.Margin = new System.Windows.Forms.Padding(2);
            this.gpBxCitasReservadas.Name = "gpBxCitasReservadas";
            this.gpBxCitasReservadas.Padding = new System.Windows.Forms.Padding(2);
            this.gpBxCitasReservadas.Size = new System.Drawing.Size(881, 344);
            this.gpBxCitasReservadas.TabIndex = 70;
            this.gpBxCitasReservadas.TabStop = false;
            this.gpBxCitasReservadas.Text = "Citas Reservadas";
            // 
            // dgvCitas
            // 
            this.dgvCitas.AllowUserToAddRows = false;
            this.dgvCitas.AllowUserToDeleteRows = false;
            this.dgvCitas.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCitas.BackgroundColor = System.Drawing.Color.White;
            this.dgvCitas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCitas.Location = new System.Drawing.Point(9, 27);
            this.dgvCitas.Name = "dgvCitas";
            this.dgvCitas.ReadOnly = true;
            this.dgvCitas.Size = new System.Drawing.Size(860, 303);
            this.dgvCitas.TabIndex = 71;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_volver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(900, 28);
            this.menuStrip1.TabIndex = 71;
            this.menuStrip1.Text = "mStCitas";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(87, 24);
            this.btn_volver.Text = "Volver";
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // frmCitas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(900, 583);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gpBxCitasReservadas);
            this.Controls.Add(this.gbx_datosCita);
            this.Controls.Add(this.grb_menuCita);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmCitas";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Citas";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCitas_Load);
            this.grb_menuCita.ResumeLayout(false);
            this.grb_menuCita.PerformLayout();
            this.gbx_datosCita.ResumeLayout(false);
            this.gbx_datosCita.PerformLayout();
            this.gpBxCitasReservadas.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCitas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grb_menuCita;
        private System.Windows.Forms.RadioButton rbtn_nombreCita;
        private System.Windows.Forms.RadioButton rbtn_CedulaCita;
        private System.Windows.Forms.Label lbl_agregarCita;
        private System.Windows.Forms.Button btn_buscarCita;
        private System.Windows.Forms.Label lbl_Cita_id;
        private System.Windows.Forms.TextBox txt_valor_Cita;
        private System.Windows.Forms.Label lblBuscar_Cita;
        public System.Windows.Forms.Button btn_InsertarCita;
        private System.Windows.Forms.GroupBox gbx_datosCita;
        private System.Windows.Forms.DateTimePicker dtpFechaCita;
        private System.Windows.Forms.Label lbl_FechaCita;
        private System.Windows.Forms.Label lbl_guardarCita;
        private System.Windows.Forms.Button btn_guardarCita;
        private System.Windows.Forms.Label lbl_editarCita;
        private System.Windows.Forms.Label lbl_eliminarCita;
        private System.Windows.Forms.TextBox txt_detalleCita;
        private System.Windows.Forms.TextBox txt_telefonoUsuario;
        private System.Windows.Forms.Button btn_EliminarCita;
        private System.Windows.Forms.Button btn_EditarCita;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Label lbl_telefonoUsuario;
        private System.Windows.Forms.Label lbl_detalleCita;
        private System.Windows.Forms.Label lbl_Usuario;
        private System.Windows.Forms.Label lbl_Cita;
        private System.Windows.Forms.GroupBox gpBxCitasReservadas;
        private System.Windows.Forms.DataGridView dgvCitas;
        private System.Windows.Forms.TextBox txt_CedulaUsuario;
        private System.Windows.Forms.Label lbl_CedulaUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_volver;
        private System.Windows.Forms.Label lblOpcionBusqueda;
    }
}