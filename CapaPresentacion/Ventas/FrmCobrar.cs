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
        string nombre, cargo, dinero, tarj;
        double subtotal;
        double total;
        double efectivo;
        double tarjeta;
        double saldo;
        double abono;
        bool imprimir;

        #region set y get
        public double Total { get => total; set => total = value; }
        public double Efectivo { get => efectivo; set => efectivo = value; }
        public double Tarjeta { get => tarjeta; set => tarjeta = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public double Abono { get => abono; set => abono = value; }
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
            subtotal = 0;
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
                dinero = string.Concat(dinero, digito);
                efectivo = double.Parse(dinero);
                abono = efectivo;
                subtotal = total - efectivo;
                saldo = subtotal;
                lbl_Saldo.Text = saldo.ToString();
            }
        }

        private void txt_Tarjeta_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {
                string digito = e.KeyChar.ToString();
                tarj = string.Concat(tarj, digito);
                tarjeta = double.Parse(tarj);
                if (subtotal > 0)
                {
                    subtotal -= tarjeta;
                }
                else
                {
                    subtotal = total - tarjeta;
                }
                saldo = subtotal;
                lbl_Saldo.Text = saldo.ToString();
            }
        }

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            imprimir = true;
            this.Close();
        }
    }
}
