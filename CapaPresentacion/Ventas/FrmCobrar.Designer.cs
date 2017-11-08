namespace CapaPresentacion.Ventas
{
    partial class FrmCobrar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCobrar));
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_Saldo = new System.Windows.Forms.Label();
            this.lbl_cantPagar = new System.Windows.Forms.Label();
            this.btn_cobrar = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_Abono = new System.Windows.Forms.TextBox();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.SystemColors.Window;
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.lbl_Saldo);
            this.panel3.Controls.Add(this.lbl_cantPagar);
            this.panel3.Controls.Add(this.btn_cobrar);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txt_Abono);
            this.panel3.Location = new System.Drawing.Point(34, 25);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(302, 325);
            this.panel3.TabIndex = 26;
            // 
            // lbl_Saldo
            // 
            this.lbl_Saldo.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_Saldo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_Saldo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_Saldo.ForeColor = System.Drawing.Color.Red;
            this.lbl_Saldo.Location = new System.Drawing.Point(93, 203);
            this.lbl_Saldo.Name = "lbl_Saldo";
            this.lbl_Saldo.Size = new System.Drawing.Size(112, 31);
            this.lbl_Saldo.TabIndex = 24;
            this.lbl_Saldo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_cantPagar
            // 
            this.lbl_cantPagar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.lbl_cantPagar.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lbl_cantPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_cantPagar.Location = new System.Drawing.Point(93, 57);
            this.lbl_cantPagar.Name = "lbl_cantPagar";
            this.lbl_cantPagar.Size = new System.Drawing.Size(112, 31);
            this.lbl_cantPagar.TabIndex = 23;
            this.lbl_cantPagar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_cobrar
            // 
            this.btn_cobrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cobrar.Location = new System.Drawing.Point(101, 274);
            this.btn_cobrar.Name = "btn_cobrar";
            this.btn_cobrar.Size = new System.Drawing.Size(97, 29);
            this.btn_cobrar.TabIndex = 9;
            this.btn_cobrar.Text = "Aceptar";
            this.btn_cobrar.UseVisualStyleBackColor = true;
            this.btn_cobrar.Click += new System.EventHandler(this.btn_cobrar_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(82, 26);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(135, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "Cantidad a pagar:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(113, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 20);
            this.label8.TabIndex = 20;
            this.label8.Text = "Abono:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(116, 172);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Saldo:";
            // 
            // txt_Abono
            // 
            this.txt_Abono.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.txt_Abono.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Abono.ForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Abono.Location = new System.Drawing.Point(93, 130);
            this.txt_Abono.Name = "txt_Abono";
            this.txt_Abono.Size = new System.Drawing.Size(112, 31);
            this.txt_Abono.TabIndex = 8;
            this.txt_Abono.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_efectivo_KeyPress);
            // 
            // FrmCobrar
            // 
            this.AcceptButton = this.btn_cobrar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.GhostWhite;
            this.ClientSize = new System.Drawing.Size(370, 375);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmCobrar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cobrar";
            this.Load += new System.EventHandler(this.FrmCobrar_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btn_cobrar;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_Abono;
        private System.Windows.Forms.Label lbl_Saldo;
        private System.Windows.Forms.Label lbl_cantPagar;
    }
}