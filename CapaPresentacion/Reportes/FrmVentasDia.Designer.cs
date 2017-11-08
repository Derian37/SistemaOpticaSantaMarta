namespace CapaPresentacion.Reportes
{
    partial class FrmVentasDia
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmVentasDia));
            this.Dgv_reporte_ventas = new System.Windows.Forms.DataGridView();
            this.cmb_tipo_reporte = new System.Windows.Forms.ComboBox();
            this.dtp_fecha2 = new System.Windows.Forms.DateTimePicker();
            this.dtp_fecha1 = new System.Windows.Forms.DateTimePicker();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_fecha_inicial = new System.Windows.Forms.Label();
            this.lbl_fecha_final = new System.Windows.Forms.Label();
            this.lbl_mes = new System.Windows.Forms.Label();
            this.cmb_mes = new System.Windows.Forms.ComboBox();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_generar_reporte = new System.Windows.Forms.Button();
            this.btn_volver = new System.Windows.Forms.ToolStripMenuItem();
            this.lbl_dia = new System.Windows.Forms.Label();
            this.btn_guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_reporte_ventas)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Dgv_reporte_ventas
            // 
            this.Dgv_reporte_ventas.AllowUserToAddRows = false;
            this.Dgv_reporte_ventas.AllowUserToDeleteRows = false;
            this.Dgv_reporte_ventas.BackgroundColor = System.Drawing.Color.LightSteelBlue;
            this.Dgv_reporte_ventas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.Dgv_reporte_ventas.DefaultCellStyle = dataGridViewCellStyle1;
            this.Dgv_reporte_ventas.EditMode = System.Windows.Forms.DataGridViewEditMode.EditOnF2;
            this.Dgv_reporte_ventas.Location = new System.Drawing.Point(63, 125);
            this.Dgv_reporte_ventas.Name = "Dgv_reporte_ventas";
            this.Dgv_reporte_ventas.ReadOnly = true;
            this.Dgv_reporte_ventas.Size = new System.Drawing.Size(769, 409);
            this.Dgv_reporte_ventas.TabIndex = 0;
            // 
            // cmb_tipo_reporte
            // 
            this.cmb_tipo_reporte.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_tipo_reporte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_tipo_reporte.FormattingEnabled = true;
            this.cmb_tipo_reporte.Items.AddRange(new object[] {
            "Mensual",
            "Semanal",
            "Diario"});
            this.cmb_tipo_reporte.Location = new System.Drawing.Point(308, 56);
            this.cmb_tipo_reporte.Name = "cmb_tipo_reporte";
            this.cmb_tipo_reporte.Size = new System.Drawing.Size(121, 24);
            this.cmb_tipo_reporte.TabIndex = 1;
            // 
            // dtp_fecha2
            // 
            this.dtp_fecha2.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha2.Location = new System.Drawing.Point(977, 154);
            this.dtp_fecha2.Name = "dtp_fecha2";
            this.dtp_fecha2.Size = new System.Drawing.Size(107, 22);
            this.dtp_fecha2.TabIndex = 4;
            this.dtp_fecha2.Visible = false;
            // 
            // dtp_fecha1
            // 
            this.dtp_fecha1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dtp_fecha1.CustomFormat = "yyyy-MM-dd";
            this.dtp_fecha1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtp_fecha1.Location = new System.Drawing.Point(977, 122);
            this.dtp_fecha1.Name = "dtp_fecha1";
            this.dtp_fecha1.Size = new System.Drawing.Size(107, 22);
            this.dtp_fecha1.TabIndex = 3;
            this.dtp_fecha1.Visible = false;
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.White;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_volver});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1113, 30);
            this.menuStrip1.TabIndex = 68;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(60, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 18);
            this.label1.TabIndex = 69;
            this.label1.Text = "Seleccione un tipo de reporte:";
            // 
            // lbl_fecha_inicial
            // 
            this.lbl_fecha_inicial.AutoSize = true;
            this.lbl_fecha_inicial.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_inicial.Location = new System.Drawing.Point(864, 127);
            this.lbl_fecha_inicial.Name = "lbl_fecha_inicial";
            this.lbl_fecha_inicial.Size = new System.Drawing.Size(100, 16);
            this.lbl_fecha_inicial.TabIndex = 70;
            this.lbl_fecha_inicial.Text = "Fecha inicial:";
            this.lbl_fecha_inicial.Visible = false;
            // 
            // lbl_fecha_final
            // 
            this.lbl_fecha_final.AutoSize = true;
            this.lbl_fecha_final.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha_final.Location = new System.Drawing.Point(864, 159);
            this.lbl_fecha_final.Name = "lbl_fecha_final";
            this.lbl_fecha_final.Size = new System.Drawing.Size(88, 16);
            this.lbl_fecha_final.TabIndex = 71;
            this.lbl_fecha_final.Text = "Fecha final:";
            this.lbl_fecha_final.Visible = false;
            // 
            // lbl_mes
            // 
            this.lbl_mes.AutoSize = true;
            this.lbl_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mes.Location = new System.Drawing.Point(865, 193);
            this.lbl_mes.Name = "lbl_mes";
            this.lbl_mes.Size = new System.Drawing.Size(143, 16);
            this.lbl_mes.TabIndex = 72;
            this.lbl_mes.Text = "Seleccione un mes:";
            this.lbl_mes.Visible = false;
            // 
            // cmb_mes
            // 
            this.cmb_mes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmb_mes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmb_mes.FormattingEnabled = true;
            this.cmb_mes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Setiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cmb_mes.Location = new System.Drawing.Point(869, 221);
            this.cmb_mes.Name = "cmb_mes";
            this.cmb_mes.Size = new System.Drawing.Size(135, 24);
            this.cmb_mes.TabIndex = 5;
            this.cmb_mes.Visible = false;
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.BackgroundImage = global::CapaPresentacion.Properties.Resources.atras;
            this.btn_seleccionar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_seleccionar.Location = new System.Drawing.Point(483, 36);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(73, 63);
            this.btn_seleccionar.TabIndex = 2;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_generar_reporte
            // 
            this.btn_generar_reporte.BackgroundImage = global::CapaPresentacion.Properties.Resources.siguiente;
            this.btn_generar_reporte.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_generar_reporte.Location = new System.Drawing.Point(931, 260);
            this.btn_generar_reporte.Name = "btn_generar_reporte";
            this.btn_generar_reporte.Size = new System.Drawing.Size(73, 63);
            this.btn_generar_reporte.TabIndex = 6;
            this.btn_generar_reporte.Text = "Ver";
            this.btn_generar_reporte.UseVisualStyleBackColor = true;
            this.btn_generar_reporte.Visible = false;
            this.btn_generar_reporte.Click += new System.EventHandler(this.btn_generar_reporte_Click);
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
            // lbl_dia
            // 
            this.lbl_dia.AutoSize = true;
            this.lbl_dia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_dia.Location = new System.Drawing.Point(1005, 94);
            this.lbl_dia.Name = "lbl_dia";
            this.lbl_dia.Size = new System.Drawing.Size(41, 20);
            this.lbl_dia.TabIndex = 76;
            this.lbl_dia.Text = "Día:";
            this.lbl_dia.Visible = false;
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackgroundImage = global::CapaPresentacion.Properties.Resources.guardar;
            this.btn_guardar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btn_guardar.Location = new System.Drawing.Point(931, 329);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(73, 63);
            this.btn_guardar.TabIndex = 77;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Visible = false;
            // 
            // FrmVentasDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1113, 612);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.lbl_dia);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.btn_generar_reporte);
            this.Controls.Add(this.cmb_mes);
            this.Controls.Add(this.lbl_mes);
            this.Controls.Add(this.lbl_fecha_final);
            this.Controls.Add(this.lbl_fecha_inicial);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.dtp_fecha1);
            this.Controls.Add(this.dtp_fecha2);
            this.Controls.Add(this.cmb_tipo_reporte);
            this.Controls.Add(this.Dgv_reporte_ventas);
            this.DoubleBuffered = true;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmVentasDia";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reporte Ventas";
            this.Load += new System.EventHandler(this.FrmVentasDia_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Dgv_reporte_ventas)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView Dgv_reporte_ventas;
        private System.Windows.Forms.ComboBox cmb_tipo_reporte;
        private System.Windows.Forms.DateTimePicker dtp_fecha2;
        private System.Windows.Forms.DateTimePicker dtp_fecha1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btn_volver;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_fecha_inicial;
        private System.Windows.Forms.Label lbl_fecha_final;
        private System.Windows.Forms.Label lbl_mes;
        private System.Windows.Forms.ComboBox cmb_mes;
        private System.Windows.Forms.Button btn_generar_reporte;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Label lbl_dia;
        private System.Windows.Forms.Button btn_guardar;
    }
}