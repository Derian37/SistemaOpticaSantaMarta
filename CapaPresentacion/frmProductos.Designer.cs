namespace CapaPresentacion
{
    partial class frmProductos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductos));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.grb_menuProducto = new System.Windows.Forms.GroupBox();
            this.lbl_editarProducto = new System.Windows.Forms.Label();
            this.lbl_agregarProducto = new System.Windows.Forms.Label();
            this.lbl_productoNombre = new System.Windows.Forms.Label();
            this.txt_codigo_Producto = new System.Windows.Forms.TextBox();
            this.btnInsertarProducto = new System.Windows.Forms.Button();
            this.btn_EditarProducto = new System.Windows.Forms.Button();
            this.lbl_eliminarProducto = new System.Windows.Forms.Label();
            this.dgvProductos = new System.Windows.Forms.DataGridView();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btn_volver = new System.Windows.Forms.ToolStripMenuItem();
            this.gbx_datosProducto = new System.Windows.Forms.GroupBox();
            this.cbx_tipoProducto = new System.Windows.Forms.ComboBox();
            this.cbx_ivaProducto = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txt_marcaProducto = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.lbl_guardarProducto = new System.Windows.Forms.Label();
            this.btn_guardarProducto = new System.Windows.Forms.Button();
            this.txt_montoProducto = new System.Windows.Forms.TextBox();
            this.txt_cantidadProducto = new System.Windows.Forms.TextBox();
            this.txt_detalleProducto = new System.Windows.Forms.TextBox();
            this.txt_nombreProducto = new System.Windows.Forms.TextBox();
            this.btn_EliminarProducto = new System.Windows.Forms.Button();
            this.txt_codigoProducto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grb_menuProducto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.gbx_datosProducto.SuspendLayout();
            this.SuspendLayout();
            // 
            // grb_menuProducto
            // 
            this.grb_menuProducto.BackColor = System.Drawing.Color.Transparent;
            this.grb_menuProducto.Controls.Add(this.lbl_editarProducto);
            this.grb_menuProducto.Controls.Add(this.lbl_agregarProducto);
            this.grb_menuProducto.Controls.Add(this.lbl_productoNombre);
            this.grb_menuProducto.Controls.Add(this.txt_codigo_Producto);
            this.grb_menuProducto.Controls.Add(this.btnInsertarProducto);
            this.grb_menuProducto.Controls.Add(this.btn_EditarProducto);
            this.grb_menuProducto.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.grb_menuProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grb_menuProducto.Location = new System.Drawing.Point(60, 33);
            this.grb_menuProducto.Margin = new System.Windows.Forms.Padding(4);
            this.grb_menuProducto.Name = "grb_menuProducto";
            this.grb_menuProducto.Padding = new System.Windows.Forms.Padding(4);
            this.grb_menuProducto.Size = new System.Drawing.Size(324, 239);
            this.grb_menuProducto.TabIndex = 64;
            this.grb_menuProducto.TabStop = false;
            this.grb_menuProducto.Text = "Menú";
            // 
            // lbl_editarProducto
            // 
            this.lbl_editarProducto.Location = new System.Drawing.Point(199, 178);
            this.lbl_editarProducto.Name = "lbl_editarProducto";
            this.lbl_editarProducto.Size = new System.Drawing.Size(58, 23);
            this.lbl_editarProducto.TabIndex = 71;
            this.lbl_editarProducto.Text = "Editar";
            // 
            // lbl_agregarProducto
            // 
            this.lbl_agregarProducto.Location = new System.Drawing.Point(94, 178);
            this.lbl_agregarProducto.Name = "lbl_agregarProducto";
            this.lbl_agregarProducto.Size = new System.Drawing.Size(72, 23);
            this.lbl_agregarProducto.TabIndex = 69;
            this.lbl_agregarProducto.Text = "Agregar";
            // 
            // lbl_productoNombre
            // 
            this.lbl_productoNombre.AutoSize = true;
            this.lbl_productoNombre.BackColor = System.Drawing.Color.Transparent;
            this.lbl_productoNombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.lbl_productoNombre.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_productoNombre.Location = new System.Drawing.Point(8, 75);
            this.lbl_productoNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_productoNombre.Name = "lbl_productoNombre";
            this.lbl_productoNombre.Size = new System.Drawing.Size(73, 19);
            this.lbl_productoNombre.TabIndex = 59;
            this.lbl_productoNombre.Text = "Producto:";
            // 
            // txt_codigo_Producto
            // 
            this.txt_codigo_Producto.BackColor = System.Drawing.Color.White;
            this.txt_codigo_Producto.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txt_codigo_Producto.Location = new System.Drawing.Point(89, 68);
            this.txt_codigo_Producto.Margin = new System.Windows.Forms.Padding(4);
            this.txt_codigo_Producto.Name = "txt_codigo_Producto";
            this.txt_codigo_Producto.Size = new System.Drawing.Size(190, 26);
            this.txt_codigo_Producto.TabIndex = 58;
            this.txt_codigo_Producto.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_codigo_Producto_KeyUp);
            // 
            // btnInsertarProducto
            // 
            this.btnInsertarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnInsertarProducto.BackgroundImage")));
            this.btnInsertarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnInsertarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnInsertarProducto.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnInsertarProducto.Location = new System.Drawing.Point(98, 118);
            this.btnInsertarProducto.Margin = new System.Windows.Forms.Padding(4);
            this.btnInsertarProducto.Name = "btnInsertarProducto";
            this.btnInsertarProducto.Size = new System.Drawing.Size(62, 57);
            this.btnInsertarProducto.TabIndex = 68;
            this.btnInsertarProducto.Text = " ";
            this.btnInsertarProducto.UseVisualStyleBackColor = true;
            this.btnInsertarProducto.Click += new System.EventHandler(this.btnInsertarProducto_Click);
            // 
            // btn_EditarProducto
            // 
            this.btn_EditarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EditarProducto.BackgroundImage")));
            this.btn_EditarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EditarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EditarProducto.FlatAppearance.BorderSize = 0;
            this.btn_EditarProducto.Location = new System.Drawing.Point(195, 119);
            this.btn_EditarProducto.Margin = new System.Windows.Forms.Padding(0);
            this.btn_EditarProducto.Name = "btn_EditarProducto";
            this.btn_EditarProducto.Size = new System.Drawing.Size(62, 56);
            this.btn_EditarProducto.TabIndex = 60;
            this.btn_EditarProducto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EditarProducto.UseVisualStyleBackColor = true;
            this.btn_EditarProducto.Click += new System.EventHandler(this.Btn_EditarProductoClick);
            // 
            // lbl_eliminarProducto
            // 
            this.lbl_eliminarProducto.Location = new System.Drawing.Point(668, 96);
            this.lbl_eliminarProducto.Name = "lbl_eliminarProducto";
            this.lbl_eliminarProducto.Size = new System.Drawing.Size(67, 23);
            this.lbl_eliminarProducto.TabIndex = 70;
            this.lbl_eliminarProducto.Text = "Eliminar";
            // 
            // dgvProductos
            // 
            this.dgvProductos.AllowUserToDeleteRows = false;
            this.dgvProductos.AllowUserToResizeColumns = false;
            this.dgvProductos.AllowUserToResizeRows = false;
            this.dgvProductos.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProductos.BackgroundColor = System.Drawing.Color.White;
            this.dgvProductos.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvProductos.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvProductos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProductos.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvProductos.Location = new System.Drawing.Point(60, 281);
            this.dgvProductos.Margin = new System.Windows.Forms.Padding(4);
            this.dgvProductos.MultiSelect = false;
            this.dgvProductos.Name = "dgvProductos";
            this.dgvProductos.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvProductos.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvProductos.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.MediumTurquoise;
            this.dgvProductos.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvProductos.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvProductos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvProductos.Size = new System.Drawing.Size(1185, 371);
            this.dgvProductos.TabIndex = 65;
            this.dgvProductos.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProductos_CellDoubleClick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_volver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1317, 30);
            this.menuStrip1.TabIndex = 67;
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
            // gbx_datosProducto
            // 
            this.gbx_datosProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.gbx_datosProducto.Controls.Add(this.cbx_tipoProducto);
            this.gbx_datosProducto.Controls.Add(this.cbx_ivaProducto);
            this.gbx_datosProducto.Controls.Add(this.label8);
            this.gbx_datosProducto.Controls.Add(this.txt_marcaProducto);
            this.gbx_datosProducto.Controls.Add(this.label5);
            this.gbx_datosProducto.Controls.Add(this.label7);
            this.gbx_datosProducto.Controls.Add(this.lbl_guardarProducto);
            this.gbx_datosProducto.Controls.Add(this.btn_guardarProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_montoProducto);
            this.gbx_datosProducto.Controls.Add(this.lbl_eliminarProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_cantidadProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_detalleProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_nombreProducto);
            this.gbx_datosProducto.Controls.Add(this.btn_EliminarProducto);
            this.gbx_datosProducto.Controls.Add(this.txt_codigoProducto);
            this.gbx_datosProducto.Controls.Add(this.label6);
            this.gbx_datosProducto.Controls.Add(this.label4);
            this.gbx_datosProducto.Controls.Add(this.label3);
            this.gbx_datosProducto.Controls.Add(this.label2);
            this.gbx_datosProducto.Controls.Add(this.label1);
            this.gbx_datosProducto.Enabled = false;
            this.gbx_datosProducto.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_datosProducto.Location = new System.Drawing.Point(409, 34);
            this.gbx_datosProducto.Name = "gbx_datosProducto";
            this.gbx_datosProducto.Size = new System.Drawing.Size(748, 240);
            this.gbx_datosProducto.TabIndex = 68;
            this.gbx_datosProducto.TabStop = false;
            this.gbx_datosProducto.Text = "Producto";
            this.gbx_datosProducto.Visible = false;
            // 
            // cbx_tipoProducto
            // 
            this.cbx_tipoProducto.FormattingEnabled = true;
            this.cbx_tipoProducto.Items.AddRange(new object[] {
            "ARO\t",
            "LENTE\t",
            "OTRO"});
            this.cbx_tipoProducto.Location = new System.Drawing.Point(203, 195);
            this.cbx_tipoProducto.Name = "cbx_tipoProducto";
            this.cbx_tipoProducto.Size = new System.Drawing.Size(158, 27);
            this.cbx_tipoProducto.TabIndex = 5;
            // 
            // cbx_ivaProducto
            // 
            this.cbx_ivaProducto.FormattingEnabled = true;
            this.cbx_ivaProducto.Items.AddRange(new object[] {
            "GRAVADO",
            "EXENTO"});
            this.cbx_ivaProducto.Location = new System.Drawing.Point(504, 115);
            this.cbx_ivaProducto.Name = "cbx_ivaProducto";
            this.cbx_ivaProducto.Size = new System.Drawing.Size(121, 27);
            this.cbx_ivaProducto.TabIndex = 8;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(407, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 19);
            this.label8.TabIndex = 85;
            this.label8.Text = "IVA:";
            // 
            // txt_marcaProducto
            // 
            this.txt_marcaProducto.Location = new System.Drawing.Point(110, 154);
            this.txt_marcaProducto.Name = "txt_marcaProducto";
            this.txt_marcaProducto.Size = new System.Drawing.Size(251, 26);
            this.txt_marcaProducto.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(13, 155);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(59, 19);
            this.label5.TabIndex = 82;
            this.label5.Text = "Marca:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(13, 195);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(44, 19);
            this.label7.TabIndex = 81;
            this.label7.Text = "Tipo:";
            // 
            // lbl_guardarProducto
            // 
            this.lbl_guardarProducto.AutoSize = true;
            this.lbl_guardarProducto.Location = new System.Drawing.Point(668, 177);
            this.lbl_guardarProducto.Name = "lbl_guardarProducto";
            this.lbl_guardarProducto.Size = new System.Drawing.Size(65, 19);
            this.lbl_guardarProducto.TabIndex = 80;
            this.lbl_guardarProducto.Text = "Guardar";
            // 
            // btn_guardarProducto
            // 
            this.btn_guardarProducto.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btn_guardarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_guardarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_guardarProducto.FlatAppearance.BorderSize = 0;
            this.btn_guardarProducto.Location = new System.Drawing.Point(672, 124);
            this.btn_guardarProducto.Name = "btn_guardarProducto";
            this.btn_guardarProducto.Size = new System.Drawing.Size(57, 50);
            this.btn_guardarProducto.TabIndex = 9;
            this.btn_guardarProducto.UseVisualStyleBackColor = true;
            this.btn_guardarProducto.Click += new System.EventHandler(this.btn_guardarProducto_Click);
            // 
            // txt_montoProducto
            // 
            this.txt_montoProducto.Location = new System.Drawing.Point(504, 73);
            this.txt_montoProducto.Name = "txt_montoProducto";
            this.txt_montoProducto.Size = new System.Drawing.Size(121, 26);
            this.txt_montoProducto.TabIndex = 7;
            // 
            // txt_cantidadProducto
            // 
            this.txt_cantidadProducto.Location = new System.Drawing.Point(504, 31);
            this.txt_cantidadProducto.Name = "txt_cantidadProducto";
            this.txt_cantidadProducto.Size = new System.Drawing.Size(121, 26);
            this.txt_cantidadProducto.TabIndex = 6;
            // 
            // txt_detalleProducto
            // 
            this.txt_detalleProducto.Location = new System.Drawing.Point(110, 113);
            this.txt_detalleProducto.Name = "txt_detalleProducto";
            this.txt_detalleProducto.Size = new System.Drawing.Size(251, 26);
            this.txt_detalleProducto.TabIndex = 3;
            // 
            // txt_nombreProducto
            // 
            this.txt_nombreProducto.Location = new System.Drawing.Point(110, 72);
            this.txt_nombreProducto.Name = "txt_nombreProducto";
            this.txt_nombreProducto.Size = new System.Drawing.Size(251, 26);
            this.txt_nombreProducto.TabIndex = 2;
            // 
            // btn_EliminarProducto
            // 
            this.btn_EliminarProducto.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_EliminarProducto.BackgroundImage")));
            this.btn_EliminarProducto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_EliminarProducto.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_EliminarProducto.FlatAppearance.BorderSize = 0;
            this.btn_EliminarProducto.Location = new System.Drawing.Point(672, 43);
            this.btn_EliminarProducto.Name = "btn_EliminarProducto";
            this.btn_EliminarProducto.Size = new System.Drawing.Size(59, 50);
            this.btn_EliminarProducto.TabIndex = 61;
            this.btn_EliminarProducto.TextAlign = System.Drawing.ContentAlignment.BottomLeft;
            this.btn_EliminarProducto.UseVisualStyleBackColor = true;
            this.btn_EliminarProducto.Click += new System.EventHandler(this.Btn_EliminarProductoClick);
            // 
            // txt_codigoProducto
            // 
            this.txt_codigoProducto.Location = new System.Drawing.Point(110, 31);
            this.txt_codigoProducto.Name = "txt_codigoProducto";
            this.txt_codigoProducto.Size = new System.Drawing.Size(251, 26);
            this.txt_codigoProducto.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(407, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 19);
            this.label6.TabIndex = 73;
            this.label6.Text = "Monto:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(407, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 19);
            this.label4.TabIndex = 72;
            this.label4.Text = "Cantidad:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(13, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 19);
            this.label3.TabIndex = 71;
            this.label3.Text = "Nombre:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 115);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 19);
            this.label2.TabIndex = 70;
            this.label2.Text = "Detalle:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 19);
            this.label1.TabIndex = 69;
            this.label1.Text = "Código:";
            // 
            // frmProductos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1317, 733);
            this.Controls.Add(this.gbx_datosProducto);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dgvProductos);
            this.Controls.Add(this.grb_menuProducto);
            this.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmProductos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmProductos_FormClosing);
            this.Load += new System.EventHandler(this.FrmProductosLoad);
            this.grb_menuProducto.ResumeLayout(false);
            this.grb_menuProducto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProductos)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.gbx_datosProducto.ResumeLayout(false);
            this.gbx_datosProducto.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label lbl_agregarProducto;
        private System.Windows.Forms.Label lbl_eliminarProducto;
        private System.Windows.Forms.Label lbl_editarProducto;

        #endregion

        private System.Windows.Forms.GroupBox grb_menuProducto;
        public System.Windows.Forms.Button btnInsertarProducto;
        private System.Windows.Forms.Label lbl_productoNombre;
        private System.Windows.Forms.TextBox txt_codigo_Producto;
        private System.Windows.Forms.DataGridView dgvProductos;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_volver;
        private System.Windows.Forms.GroupBox gbx_datosProducto;
        private System.Windows.Forms.TextBox txt_montoProducto;
        private System.Windows.Forms.TextBox txt_cantidadProducto;
        private System.Windows.Forms.TextBox txt_detalleProducto;
        private System.Windows.Forms.TextBox txt_nombreProducto;
        private System.Windows.Forms.TextBox txt_codigoProducto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_EliminarProducto;
        private System.Windows.Forms.Button btn_EditarProducto;
        private System.Windows.Forms.Button btn_guardarProducto;
        private System.Windows.Forms.Label lbl_guardarProducto;
        private System.Windows.Forms.ComboBox cbx_tipoProducto;
        private System.Windows.Forms.ComboBox cbx_ivaProducto;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txt_marcaProducto;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
    }
}