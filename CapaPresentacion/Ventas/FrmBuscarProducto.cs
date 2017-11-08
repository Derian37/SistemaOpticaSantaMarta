using ProyectoOptica.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmBuscarProducto : Form
    {
        int id_usuario;
        string nombre, cargo;
        private string codigoProducto;
        private DataTable dtVentas = new DataTable();
        private DataSet dsVentas = new DataSet();

        public string CodigoProducto { get => codigoProducto; set => codigoProducto = value; }

        public FrmBuscarProducto(int id_usuario, string nombre, string cargo)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
            cargarGrid();
        }

        private void cargarGrid()
        {
            using (GestorProducto producto = new GestorProducto())
            {
                dgv_Productos.DataSource = producto.ListarProductos();

                dgv_Productos.Columns["id_productos"].Visible = false;
                dgv_Productos.Columns["codigo"].HeaderText = "CODIGO";
                dgv_Productos.Columns["nombre"].HeaderText = "NOMBRE";
                dgv_Productos.Columns["detalle"].HeaderText = "DETALLE";
                dgv_Productos.Columns["monto"].HeaderText = "MONTO";
                dgv_Productos.Columns["cantidad"].HeaderText = "CANTIDAD";
            }
        }

        private void btn_buscar_Click_1(object sender, EventArgs e)
        {
            if (txt_codigo.Text == "")
            {
                MessageBox.Show("Inserte un dato valido ", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                try
                {
                    string cod = txt_codigo.Text;
                    using (GestorProducto producto = new GestorProducto())
                    {
                        dsVentas = producto.ConsultarProducto(cod);
                        dtVentas = this.dsVentas.Tables[0];
                        CodigoProducto = dtVentas.Rows[0]["codigo"].ToString();
                        dgv_Productos.DataSource = this.dtVentas;
                        dgv_Productos.Columns["id_productos"].Visible = false;
                        dgv_Productos.Columns["codigo"].HeaderText = "CODIGO";
                        dgv_Productos.Columns["nombre"].HeaderText = "NOMBRE";
                        dgv_Productos.Columns["detalle"].HeaderText = "DETALLE";
                        dgv_Productos.Columns["monto"].HeaderText = "MONTO";
                        dgv_Productos.Columns["cantidad"].HeaderText = "CANTIDAD";
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Producto no encontrado "+ex.Message, "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
        }

        private void btn_Agregar_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Productos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            CodigoProducto = dgv_Productos.CurrentRow.Cells[1].Value.ToString();
            this.Close();
        }

        private void FrmBuscarProducto_FormClosing(object sender, FormClosingEventArgs e)
        {

        }
    }
}
