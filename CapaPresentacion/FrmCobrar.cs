using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Ventas
{
    public partial class FrmCobrar : Form
    {
        int id_usuario;
        string nombre, cargo, plata;
        double total;
        double abono;
        double saldo;
        bool imprimir;

        #region set y get
        public double Total { get => total; set => total = value; }
        public double Abono { get => abono; set => abono = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public bool Imprimir { get => imprimir; set => imprimir = value; }
        #endregion


        public FrmCobrar(int id_usuario, string nombre, string cargo, double total)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
            this.Total = total;
        }

        private void FrmCobrar_Load(object sender, EventArgs e)
        {
            lbl_cantPagar.Text = total.ToString();
            txt_Abono.Focus();
        }

        private void txt_efectivo_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                string digito = e.KeyChar.ToString();
                plata = string.Concat(plata, digito);
                abono = double.Parse(plata);
                saldo = (abono - total)*-1;
                lbl_Saldo.Text = saldo.ToString();
                imprimir = true;
            }
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
