namespace CapaPresentacion
{
    partial class frmUsuarios
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsuarios));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gbx_datosUsuario = new System.Windows.Forms.GroupBox();
            this.lbl_editarUsuario = new System.Windows.Forms.Label();
            this.lbl_guardarUsuario = new System.Windows.Forms.Label();
            this.btn_guardarUsuario = new System.Windows.Forms.Button();
            this.lbl_agregarUsuario = new System.Windows.Forms.Label();
            this.btn_EditarUsuario = new System.Windows.Forms.Button();
            this.txt_contrasenaUsuario2 = new System.Windows.Forms.TextBox();
            this.btnInsertarUsuario = new System.Windows.Forms.Button();
            this.lbl_eliminarUsuario = new System.Windows.Forms.Label();
            this.txt_contrasenaUsuario1 = new System.Windows.Forms.TextBox();
            this.txt_cargoUsuario = new System.Windows.Forms.TextBox();
            this.txt_nombreUsuario = new System.Windows.Forms.TextBox();
            this.btn_EliminarUsuario = new System.Windows.Forms.Button();
            this.txt_cedulaUsuario = new System.Windows.Forms.TextBox();
            this.lbl_contrasenaUsuario2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_Usuarios = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_volver = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_datosUsuario.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_datosUsuario
            // 
            this.gbx_datosUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_datosUsuario.Controls.Add(this.lbl_editarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.lbl_guardarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.btn_guardarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.lbl_agregarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.btn_EditarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.txt_contrasenaUsuario2);
            this.gbx_datosUsuario.Controls.Add(this.btnInsertarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.lbl_eliminarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.txt_contrasenaUsuario1);
            this.gbx_datosUsuario.Controls.Add(this.txt_cargoUsuario);
            this.gbx_datosUsuario.Controls.Add(this.txt_nombreUsuario);
            this.gbx_datosUsuario.Controls.Add(this.btn_EliminarUsuario);
            this.gbx_datosUsuario.Controls.Add(this.txt_cedulaUsuario);
            this.gbx_datosUsuario.Controls.Add(this.lbl_contrasenaUsuario2);
            this.gbx_datosUsuario.Controls.Add(this.label4);
            this.gbx_datosUsuario.Controls.Add(this.label3);
            this.gbx_datosUsuario.Controls.Add(this.label2);
            this.gbx_datosUsuario.Controls.Add(this.label1);
            this.gbx_datosUsuario.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosUsuario.Location = new System.Drawing.Point(46, 60);
            this.gbx_datosUsuario.Name = "gbx_datosUsuario";
            this.gbx_datosUsuario.Size = new System.Drawing.Size(712, 265);
            this.gbx_datosUsuario.TabIndex = 71;
            this.gbx_datosUsuario.TabStop = false;
            this.gbx_datosUsuario.Text = "Menú Usuario";
            // 
            // lbl_editarUsuario
            // 
            this.lbl_editarUsuario.Location = new System.Drawing.Point(474, 184);
            this.lbl_editarUsuario.Name = "lbl_editarUsuario";
            this.lbl_editarUsuario.Size = new System.Drawing.Size(58, 23);
            this.lbl_editarUsuario.TabIndex = 71;
            this.lbl_editarUsuario.Text = "Editar";
            this.lbl_editarUsuario.Visible = false;
            // 
            // lbl_guardarUsuario
            // 
            this.lbl_guardarUsuario.AutoSize = true;
            this.lbl_guardarUsuario.Location = new System.Drawing.Point(576, 184);
            this.lbl_guardarUsuario.Name = "lbl_guardarUsuario";
            this.lbl_guardarUsuario.Size = new System.Drawing.Size(65, 19);
            this.lbl_guardarUsuario.TabIndex = 80;
            this.lbl_guardarUsuario.Text = "Guardar";
            this.lbl_guardarUsuario.Visible = false;
            // 
            // btn_guardarUsuario
            // 
            this.btn_guardarUsuario.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btn_guardarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_guardarUsuario.Location = new System.Drawing.Point(579, 125);
            this.btn_guardarUsuario.Name = "btn_guardarUsuario";
            this.btn_guardarUsuario.Size = new System.Drawing.Size(62, 56);
            this.btn_guardarUsuario.TabIndex = 79;
            this.btn_guardarUsuario.UseVisualStyleBackColor = true;
            this.btn_guardarUsuario.Visible = false;
            this.btn_guardarUsuario.Click += new System.EventHandler(this.btn_guardarUsuario_Click);
            // 
            // lbl_agregarUsuario
            // 
            this.lbl_agregarUsuario.Location = new System.Drawing.Point(466, 100);
            this.lbl_agregarUsuario.Name = "lbl_agregarUsuario";
            this.lbl_agregarUsuario.Size = new System.Drawing.Size(72, 23);
            this.lbl_agregarUsuario.TabIndex = 69;
            this.lbl_agregarUsuario.Text = "Agregar";
            // 
            // btn_EditarUsuario
            // 
            this.btn_EditarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarUsuario.BackgroundImage")));
            this.btn_EditarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_EditarUsuario.Location = new System.Drawing.Point(470, 125);
            this.btn_EditarUsuario.Margin = new System.Windows.Forms.Padding(0);
            this.btn_EditarUsuario.Name = "btn_EditarUsuario";
            this.btn_EditarUsuario.Size = new System.Drawing.Size(62, 56);
            this.btn_EditarUsuario.TabIndex = 60;
            this.btn_EditarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EditarUsuario.UseVisualStyleBackColor = true;
            this.btn_EditarUsuario.Visible = false;
            this.btn_EditarUsuario.Click += new System.EventHandler(this.btn_EditarUsuario_Click);
            // 
            // txt_contrasenaUsuario2
            // 
            this.txt_contrasenaUsuario2.Enabled = false;
            this.txt_contrasenaUsuario2.Location = new System.Drawing.Point(262, 205);
            this.txt_contrasenaUsuario2.Name = "txt_contrasenaUsuario2";
            this.txt_contrasenaUsuario2.Size = new System.Drawing.Size(123, 26);
            this.txt_contrasenaUsuario2.TabIndex = 78;
            // 
            // btnInsertarUsuario
            // 
            this.btnInsertarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertarUsuario.BackgroundImage")));
            this.btnInsertarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarUsuario.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsertarUsuario.Location = new System.Drawing.Point(470, 40);
            this.btnInsertarUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarUsuario.Name = "btnInsertarUsuario";
            this.btnInsertarUsuario.Size = new System.Drawing.Size(62, 57);
            this.btnInsertarUsuario.TabIndex = 68;
            this.btnInsertarUsuario.Text = " ";
            this.btnInsertarUsuario.UseVisualStyleBackColor = true;
            this.btnInsertarUsuario.Click += new System.EventHandler(this.btnInsertarUsuario_Click);
            // 
            // lbl_eliminarUsuario
            // 
            this.lbl_eliminarUsuario.Location = new System.Drawing.Point(574, 100);
            this.lbl_eliminarUsuario.Name = "lbl_eliminarUsuario";
            this.lbl_eliminarUsuario.Size = new System.Drawing.Size(67, 23);
            this.lbl_eliminarUsuario.TabIndex = 70;
            this.lbl_eliminarUsuario.Text = "Eliminar";
            this.lbl_eliminarUsuario.Visible = false;
            // 
            // txt_contrasenaUsuario1
            // 
            this.txt_contrasenaUsuario1.Enabled = false;
            this.txt_contrasenaUsuario1.Location = new System.Drawing.Point(262, 164);
            this.txt_contrasenaUsuario1.Name = "txt_contrasenaUsuario1";
            this.txt_contrasenaUsuario1.Size = new System.Drawing.Size(123, 26);
            this.txt_contrasenaUsuario1.TabIndex = 77;
            // 
            // txt_cargoUsuario
            // 
            this.txt_cargoUsuario.Enabled = false;
            this.txt_cargoUsuario.Location = new System.Drawing.Point(134, 123);
            this.txt_cargoUsuario.Name = "txt_cargoUsuario";
            this.txt_cargoUsuario.Size = new System.Drawing.Size(251, 26);
            this.txt_cargoUsuario.TabIndex = 76;
            // 
            // txt_nombreUsuario
            // 
            this.txt_nombreUsuario.Enabled = false;
            this.txt_nombreUsuario.Location = new System.Drawing.Point(134, 83);
            this.txt_nombreUsuario.Name = "txt_nombreUsuario";
            this.txt_nombreUsuario.Size = new System.Drawing.Size(251, 26);
            this.txt_nombreUsuario.TabIndex = 75;
            // 
            // btn_EliminarUsuario
            // 
            this.btn_EliminarUsuario.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarUsuario.BackgroundImage")));
            this.btn_EliminarUsuario.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarUsuario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarUsuario.FlatAppearance.BorderSize = 0;
            this.btn_EliminarUsuario.Location = new System.Drawing.Point(578, 40);
            this.btn_EliminarUsuario.Name = "btn_EliminarUsuario";
            this.btn_EliminarUsuario.Size = new System.Drawing.Size(62, 57);
            this.btn_EliminarUsuario.TabIndex = 61;
            this.btn_EliminarUsuario.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EliminarUsuario.UseVisualStyleBackColor = true;
            this.btn_EliminarUsuario.Visible = false;
            this.btn_EliminarUsuario.Click += new System.EventHandler(this.btn_EliminarUsuario_Click);
            // 
            // txt_cedulaUsuario
            // 
            this.txt_cedulaUsuario.Enabled = false;
            this.txt_cedulaUsuario.Location = new System.Drawing.Point(134, 41);
            this.txt_cedulaUsuario.Name = "txt_cedulaUsuario";
            this.txt_cedulaUsuario.Size = new System.Drawing.Size(251, 26);
            this.txt_cedulaUsuario.TabIndex = 74;
            // 
            // lbl_contrasenaUsuario2
            // 
            this.lbl_contrasenaUsuario2.AutoSize = true;
            this.lbl_contrasenaUsuario2.Location = new System.Drawing.Point(37, 208);
            this.lbl_contrasenaUsuario2.Name = "lbl_contrasenaUsuario2";
            this.lbl_contrasenaUsuario2.Size = new System.Drawing.Size(219, 19);
            this.lbl_contrasenaUsuario2.TabIndex = 73;
            this.lbl_contrasenaUsuario2.Text = "Vuelva a escribir la contraseña:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Digite su nueva contraseña:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(37, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Cargo:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Cédula:";
            // 
            // dgv_Usuarios
            // 
            this.dgv_Usuarios.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_Usuarios.BackgroundColor = System.Drawing.Color.Beige;
            this.dgv_Usuarios.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgv_Usuarios.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            this.dgv_Usuarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_Usuarios.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgv_Usuarios.Location = new System.Drawing.Point(46, 332);
            this.dgv_Usuarios.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_Usuarios.MultiSelect = false;
            this.dgv_Usuarios.Name = "dgv_Usuarios";
            this.dgv_Usuarios.ReadOnly = true;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.dgv_Usuarios.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_Usuarios.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgv_Usuarios.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_Usuarios.Size = new System.Drawing.Size(853, 191);
            this.dgv_Usuarios.TabIndex = 70;
            this.dgv_Usuarios.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_Usuarios_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Transparent;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_volver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(945, 30);
            this.menuStrip1.TabIndex = 72;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // btn_volver
            // 
            this.btn_volver.Font = new System.Drawing.Font("Times New Roman", 13F);
            this.btn_volver.Image = ((System.Drawing.Image)(resources.GetObject("btn_volver.Image")));
            this.btn_volver.Name = "btn_volver";
            this.btn_volver.Size = new System.Drawing.Size(83, 24);
            this.btn_volver.Text = "Volver";
            this.btn_volver.Click += new System.EventHandler(this.btn_volver_Click);
            // 
            // frmUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(945, 553);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.gbx_datosUsuario);
            this.Controls.Add(this.dgv_Usuarios);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmUsuarios";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Usuarios";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmUsuarios_FormClosing);
            this.Load += new System.EventHandler(this.frmUsuarios_Load);
            this.gbx_datosUsuario.ResumeLayout(false);
            this.gbx_datosUsuario.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_Usuarios)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_datosUsuario;
        private System.Windows.Forms.Label lbl_guardarUsuario;
        private System.Windows.Forms.Button btn_guardarUsuario;
        private System.Windows.Forms.TextBox txt_contrasenaUsuario2;
        private System.Windows.Forms.Label lbl_eliminarUsuario;
        private System.Windows.Forms.TextBox txt_contrasenaUsuario1;
        private System.Windows.Forms.TextBox txt_cargoUsuario;
        private System.Windows.Forms.TextBox txt_nombreUsuario;
        private System.Windows.Forms.Button btn_EliminarUsuario;
        private System.Windows.Forms.TextBox txt_cedulaUsuario;
        private System.Windows.Forms.Label lbl_contrasenaUsuario2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_Usuarios;
        private System.Windows.Forms.Label lbl_editarUsuario;
        private System.Windows.Forms.Label lbl_agregarUsuario;
        public System.Windows.Forms.Button btnInsertarUsuario;
        private System.Windows.Forms.Button btn_EditarUsuario;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_volver;
    }
}