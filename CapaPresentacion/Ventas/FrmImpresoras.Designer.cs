namespace CapaPresentacion.Ventas
{
    partial class FrmImpresoras
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmImpresoras));
            this.label1 = new System.Windows.Forms.Label();
            this.btn_cancelar = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_seleccionar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.pbx_impresora3 = new System.Windows.Forms.PictureBox();
            this.pbx_impresora2 = new System.Windows.Forms.PictureBox();
            this.pbx_impresora1 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.rdb_impresora1 = new System.Windows.Forms.RadioButton();
            this.rdb_impresora2 = new System.Windows.Forms.RadioButton();
            this.rdb_impresora3 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_impresora3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_impresora2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_impresora1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Panel de Impresoras";
            // 
            // btn_cancelar
            // 
            this.btn_cancelar.Location = new System.Drawing.Point(66, 359);
            this.btn_cancelar.Name = "btn_cancelar";
            this.btn_cancelar.Size = new System.Drawing.Size(102, 31);
            this.btn_cancelar.TabIndex = 5;
            this.btn_cancelar.Text = "Cancelar";
            this.btn_cancelar.UseVisualStyleBackColor = true;
            this.btn_cancelar.Click += new System.EventHandler(this.btn_cancelar_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(148, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(172, 20);
            this.label2.TabIndex = 5;
            this.label2.Text = "Seleccionar Impresora:";
            // 
            // btn_seleccionar
            // 
            this.btn_seleccionar.Location = new System.Drawing.Point(197, 359);
            this.btn_seleccionar.Name = "btn_seleccionar";
            this.btn_seleccionar.Size = new System.Drawing.Size(102, 31);
            this.btn_seleccionar.TabIndex = 4;
            this.btn_seleccionar.Text = "Seleccionar";
            this.btn_seleccionar.UseVisualStyleBackColor = true;
            this.btn_seleccionar.Click += new System.EventHandler(this.btn_seleccionar_Click);
            // 
            // btn_agregar
            // 
            this.btn_agregar.Location = new System.Drawing.Point(322, 359);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(77, 28);
            this.btn_agregar.TabIndex = 6;
            this.btn_agregar.Text = "Agregar";
            this.btn_agregar.UseVisualStyleBackColor = true;
            // 
            // pbx_impresora3
            // 
            this.pbx_impresora3.Image = global::CapaPresentacion.Properties.Resources.impresora;
            this.pbx_impresora3.Location = new System.Drawing.Point(40, 272);
            this.pbx_impresora3.Name = "pbx_impresora3";
            this.pbx_impresora3.Size = new System.Drawing.Size(100, 50);
            this.pbx_impresora3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_impresora3.TabIndex = 10;
            this.pbx_impresora3.TabStop = false;
            this.pbx_impresora3.Visible = false;
            // 
            // pbx_impresora2
            // 
            this.pbx_impresora2.Image = global::CapaPresentacion.Properties.Resources.impresora;
            this.pbx_impresora2.Location = new System.Drawing.Point(40, 193);
            this.pbx_impresora2.Name = "pbx_impresora2";
            this.pbx_impresora2.Size = new System.Drawing.Size(100, 50);
            this.pbx_impresora2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_impresora2.TabIndex = 9;
            this.pbx_impresora2.TabStop = false;
            this.pbx_impresora2.Visible = false;
            // 
            // pbx_impresora1
            // 
            this.pbx_impresora1.Image = global::CapaPresentacion.Properties.Resources.impresora;
            this.pbx_impresora1.Location = new System.Drawing.Point(40, 116);
            this.pbx_impresora1.Name = "pbx_impresora1";
            this.pbx_impresora1.Size = new System.Drawing.Size(100, 50);
            this.pbx_impresora1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbx_impresora1.TabIndex = 8;
            this.pbx_impresora1.TabStop = false;
            this.pbx_impresora1.Visible = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::CapaPresentacion.Properties.Resources.LogoOptica;
            this.pictureBox1.Location = new System.Drawing.Point(342, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // rdb_impresora1
            // 
            this.rdb_impresora1.AutoSize = true;
            this.rdb_impresora1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_impresora1.Location = new System.Drawing.Point(175, 135);
            this.rdb_impresora1.Name = "rdb_impresora1";
            this.rdb_impresora1.Size = new System.Drawing.Size(14, 13);
            this.rdb_impresora1.TabIndex = 1;
            this.rdb_impresora1.UseVisualStyleBackColor = true;
            this.rdb_impresora1.Visible = false;
            // 
            // rdb_impresora2
            // 
            this.rdb_impresora2.AutoSize = true;
            this.rdb_impresora2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_impresora2.Location = new System.Drawing.Point(175, 212);
            this.rdb_impresora2.Name = "rdb_impresora2";
            this.rdb_impresora2.Size = new System.Drawing.Size(14, 13);
            this.rdb_impresora2.TabIndex = 2;
            this.rdb_impresora2.UseVisualStyleBackColor = true;
            this.rdb_impresora2.Visible = false;
            // 
            // rdb_impresora3
            // 
            this.rdb_impresora3.AutoSize = true;
            this.rdb_impresora3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_impresora3.Location = new System.Drawing.Point(175, 291);
            this.rdb_impresora3.Name = "rdb_impresora3";
            this.rdb_impresora3.Size = new System.Drawing.Size(14, 13);
            this.rdb_impresora3.TabIndex = 3;
            this.rdb_impresora3.UseVisualStyleBackColor = true;
            this.rdb_impresora3.Visible = false;
            // 
            // FrmImpresoras
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(465, 420);
            this.Controls.Add(this.rdb_impresora3);
            this.Controls.Add(this.rdb_impresora2);
            this.Controls.Add(this.rdb_impresora1);
            this.Controls.Add(this.pbx_impresora3);
            this.Controls.Add(this.pbx_impresora2);
            this.Controls.Add(this.pbx_impresora1);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.btn_seleccionar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_cancelar);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmImpresoras";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Impresoras";
            this.Load += new System.EventHandler(this.FrmImpresoras_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbx_impresora3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_impresora2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbx_impresora1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_cancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_seleccionar;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.PictureBox pbx_impresora1;
        private System.Windows.Forms.PictureBox pbx_impresora2;
        private System.Windows.Forms.PictureBox pbx_impresora3;
        private System.Windows.Forms.RadioButton rdb_impresora1;
        private System.Windows.Forms.RadioButton rdb_impresora2;
        private System.Windows.Forms.RadioButton rdb_impresora3;
    }
}