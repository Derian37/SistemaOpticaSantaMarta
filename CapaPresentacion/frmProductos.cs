using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaIntegracion;
using ProyectoOptica.CapaLogica.Servicio;
using CapaLogica.LogicaNegocio;

namespace CapaPresentacion
{
    public partial class frmProductos : Form
    {
        int id_usuario;
    	string usuario;
        string cargo;
        string accion;
        string codig;
    	DataTable dtProducto = new DataTable();
        DataSet dsProducto = new DataSet();
        DataTable dtProductos = new DataTable();
        DataSet dsProductos = new DataSet();
        public frmProductos(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
        	usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }
         void FrmProductosLoad(object sender, EventArgs e)
        {
        	cargarGridProductos();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        void Btn_buscarProductoClick(object sender, EventArgs e)
        {
            bloquearCamposProducto();
        	string buscar = txt_codigo_Producto.Text;
			gbx_datosProducto.Visible = true;
        	gbx_datosProducto.Enabled = true;
            btn_guardarProducto.Visible = false;
            lbl_guardarProducto.Visible = false;

            using (GestorProducto producto = new GestorProducto())
            {
                if (rbtn_codigoProducto.Checked == true)
                {
                    codig = txt_codigo_Producto.Text;
                    this.dsProductos = producto.ConsultarProductoCodigo(buscar);
                    this.dtProductos = this.dsProductos.Tables[0];
                    dgvProductos.DataSource = this.dtProductos;

                        dgvProductos.Columns["id_productos"].Visible = false;
                        dgvProductos.Columns["codigo"].HeaderText = "CODIGO";
                        dgvProductos.Columns["nombre"].HeaderText = "NOMBRE";
                        dgvProductos.Columns["detalle"].HeaderText = "DETALLE";
                        dgvProductos.Columns["monto"].HeaderText = "MONTO";
                        dgvProductos.Columns["cantidad"].HeaderText = "CANTIDAD";
                        dgvProductos.Columns["estado"].Visible = false;
                    
                }
                else
                {
                    this.dsProductos = producto.ConsultarProductoNombre(buscar);
                    this.dtProductos = this.dsProductos.Tables[0];
                    dgvProductos.DataSource = this.dtProductos;

                    dgvProductos.Columns["id_productos"].Visible = false;
                    dgvProductos.Columns["codigo"].HeaderText = "CODIGO";
                    dgvProductos.Columns["nombre"].HeaderText = "NOMBRE";
                    dgvProductos.Columns["detalle"].HeaderText = "DETALLE";
                    dgvProductos.Columns["monto"].HeaderText = "MONTO";
                    dgvProductos.Columns["cantidad"].HeaderText = "CANTIDAD";
                    dgvProductos.Columns["estado"].Visible = false;
                }


            }
            CargarDatosProducto();
        }

        private void CargarDatosProducto()
        {
            txt_codigoProducto.Text = this.dtProductos.Rows[0]["codigo"].ToString();
            txt_nombreProducto.Text = this.dtProductos.Rows[0]["nombre"].ToString();
            txt_detalleProducto.Text = this.dtProductos.Rows[0]["detalle"].ToString();
            txt_montoProducto.Text = this.dtProductos.Rows[0]["monto"].ToString();
            txt_cantidadProducto.Text = this.dtProductos.Rows[0]["cantidad"].ToString();

        }

        // Se carga el grid con los datos de la tabla de sql citas

        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
			gbx_datosProducto.Visible = true;
			gbx_datosProducto.Enabled = true;
            limpiarCamposProducto();
            btn_EliminarProducto.Visible = false;
            lbl_eliminarProducto.Visible = false;
            btn_EditarProducto.Visible = false;
            lbl_editarProducto.Visible = false;
            accion = "insertar";
        }
        
        void Btn_EditarProductoClick(object sender, EventArgs e)
        {
            codig = txt_codigoProducto.Text;
            desbloquearCamposProducto();
            btn_EliminarProducto.Visible = false;
            lbl_eliminarProducto.Visible = false;
            btn_guardarProducto.Visible = true;
            lbl_guardarProducto.Visible = true;
            accion = "editar";
        }
        private void btn_guardarProducto_Click(object sender, EventArgs e)
        {
            switch (accion)
            {
                case "editar":
                    if (string.IsNullOrWhiteSpace(txt_codigoProducto.Text) || string.IsNullOrWhiteSpace(txt_nombreProducto.Text) ||
                        string.IsNullOrWhiteSpace(txt_detalleProducto.Text) || string.IsNullOrWhiteSpace(txt_cantidadProducto.Text)
                        || string.IsNullOrWhiteSpace(txt_montoProducto.Text))
                        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    else
                    {
                        using (GestorProducto producto = new GestorProducto())
                        {
                            producto.ModificarProducto(codig.ToUpper(), txt_codigoProducto.Text.ToUpper(), txt_nombreProducto.Text.ToUpper(), txt_detalleProducto.Text.ToUpper(), int.Parse(txt_montoProducto.Text), int.Parse(txt_cantidadProducto.Text), "A");
                        }

                        bloquearCamposProducto();
                        MessageBox.Show("Datos Modificados Satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbx_datosProducto.Visible = false;
                        limpiarCamposProducto();
                        cargarGridProductos();
                    }
                    break;
                case "insertar":
                    if (string.IsNullOrWhiteSpace(txt_codigoProducto.Text) || string.IsNullOrWhiteSpace(txt_nombreProducto.Text) ||
                    string.IsNullOrWhiteSpace(txt_detalleProducto.Text) || string.IsNullOrWhiteSpace(txt_cantidadProducto.Text)
                    || string.IsNullOrWhiteSpace(txt_montoProducto.Text))
                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                    else
                    {
                        using (GestorProducto producto = new GestorProducto())
                        {
                            producto.InsertarProducto(txt_codigoProducto.Text.ToUpper(), txt_nombreProducto.Text.ToUpper(), txt_detalleProducto.Text.ToUpper(), int.Parse(txt_montoProducto.Text), int.Parse(txt_cantidadProducto.Text), "A");
                        }
                        bloquearCamposProducto();
                        MessageBox.Show("Datos Registrados Satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbx_datosProducto.Visible = false;
                        limpiarCamposProducto();
                        cargarGridProductos();
                    }
                    break;
                default:
                    break;
            }
        }

        void Btn_EliminarProductoClick(object sender, EventArgs e)
        {
        	gbx_datosProducto.Visible = true;
        	gbx_datosProducto.Enabled = true;

            if (string.IsNullOrWhiteSpace(txt_codigoProducto.Text) || string.IsNullOrWhiteSpace(txt_nombreProducto.Text) ||
                string.IsNullOrWhiteSpace(txt_detalleProducto.Text) || string.IsNullOrWhiteSpace(txt_cantidadProducto.Text)
                || string.IsNullOrWhiteSpace(txt_montoProducto.Text))
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                using (GestorProducto producto = new GestorProducto())
                {
                    DialogResult result = MessageBox.Show("Seguro que desea eliminar el producto", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);
                    if (result == DialogResult.Yes)
                    {
                        producto.InactivarProducto(txt_codigoProducto.Text);
                    }
                }
                bloquearCamposProducto();
                
                gbx_datosProducto.Visible = false;
                limpiarCamposProducto();
                cargarGridProductos();
                grb_menuProducto.Visible = true;
            }
        }

        private void cargarGridProductos()
        {
            using (GestorProducto producto = new GestorProducto())
            {
                dgvProductos.DataSource = producto.ListarProductos();

                dgvProductos.Columns["id_productos"].Visible = false;
                dgvProductos.Columns["codigo"].HeaderText = "CODIGO";
                dgvProductos.Columns["nombre"].HeaderText = "NOMBRE";
                dgvProductos.Columns["detalle"].HeaderText = "DETALLE";
                dgvProductos.Columns["monto"].HeaderText = "MONTO";
                dgvProductos.Columns["cantidad"].HeaderText = "CANTIDAD";
                dgvProductos.Columns["estado"].Visible = false;
            }
        }

        /// <summary>
        /// Metodo que bloquea los campos para evitar modificaciones de usuarios que no sean administradores.
        /// </summary>
        private void bloquearCamposProducto()
        {
            txt_codigoProducto.Enabled = false;
            txt_nombreProducto.Enabled = false;
            txt_detalleProducto.Enabled = false;
            txt_cantidadProducto.Enabled = false;
            txt_montoProducto.Enabled = false;
        }
        private void desbloquearCamposProducto()
        {
            txt_codigoProducto.Enabled = true;
            txt_nombreProducto.Enabled = true;
            txt_detalleProducto.Enabled = true;
            txt_cantidadProducto.Enabled = true;
            txt_montoProducto.Enabled = true;
        }
        private void limpiarCamposProducto()
        {
            txt_codigoProducto.Enabled = true;
            txt_nombreProducto.Enabled = true;
            txt_detalleProducto.Enabled = true;
            txt_cantidadProducto.Enabled = true;
            txt_montoProducto.Enabled = true;
            txt_codigoProducto.Text = "";
            txt_nombreProducto.Text = "";
            txt_detalleProducto.Text = "";
            txt_cantidadProducto.Text = "";
            txt_montoProducto.Text = "";
        }

        private void dgvProductos_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            gbx_datosProducto.Visible = true;
            gbx_datosProducto.Enabled = true;

            txt_codigoProducto.Text = dgvProductos.CurrentRow.Cells[1].Value.ToString();
            txt_nombreProducto.Text = dgvProductos.CurrentRow.Cells[2].Value.ToString();
            txt_detalleProducto.Text = dgvProductos.CurrentRow.Cells[3].Value.ToString();
            txt_montoProducto.Text = dgvProductos.CurrentRow.Cells[4].Value.ToString();
            txt_cantidadProducto.Text = dgvProductos.CurrentRow.Cells[5].Value.ToString();
            bloquearCamposProducto();
            btn_guardarProducto.Visible = false;
            lbl_guardarProducto.Visible = false;
        }
        

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
            principal.Show();
        }

        private void lblBuscar_Click(object sender, EventArgs e)
        {

        }
    }
}
