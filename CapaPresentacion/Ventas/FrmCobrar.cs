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
        int subtotal;
        int total;
        int pago;
        int efectivo;
        int tarjeta;
        int saldo;
        int abono;
        bool imprimir;

        #region set y get
        public int Total { get => total; set => total = value; }
        public int Pago { get => pago; set => pago = value; }
        public int Efectivo { get => efectivo; set => efectivo = value; }
        public int Tarjeta { get => tarjeta; set => tarjeta = value; }
        public int Saldo { get => saldo; set => saldo = value; }
        public int Abono { get => abono; set => abono = value; }
        public bool Imprimir { get => imprimir; set => imprimir = value; }
        #endregion


        public FrmCobrar(int id_usuario, string nombre, string cargo, int total, int pago)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
            this.Total = total;
            this.Pago = pago;
        }

        private void FrmCobrar_Load(object sender, EventArgs e)
        {
            lbl_cantPagar.Text = total.ToString();
            Lbl_efectivo.Text = pago.ToString();
            CalcularVuelto();
            btn_cobrar.Focus();
        }

        private void CalcularVuelto()
        {
            int subtotal = total - pago;

            if (subtotal >= 0)
            {
                Lbl_vuelto.Text = "El cambio es: ";
            }
            else if (subtotal < 0)
            {
                Lbl_vuelto.Text = "El saldo es: ";
            }
            lbl_Saldo.Text = subtotal.ToString();
        }

        

        private void btn_cobrar_Click(object sender, EventArgs e)
        {
            
                imprimir = true;
                this.Close();
            
        }
    }
}
