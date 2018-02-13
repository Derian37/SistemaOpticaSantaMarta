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
                dgvProductos.Columns["marca"].HeaderText = "MARCA";
                dgvProductos.Columns["tipo"].HeaderText = "TIPO";
                dgvProductos.Columns["iva"].HeaderText = "IVA";
                dgvProductos.Columns["estado"].Visible = false;
            }
        }

        private void CargarDatosProducto()
        {
            try
            {
                txt_codigoProducto.Text = this.dtProductos.Rows[0]["codigo"].ToString();
                txt_nombreProducto.Text = this.dtProductos.Rows[0]["nombre"].ToString();
                txt_detalleProducto.Text = this.dtProductos.Rows[0]["detalle"].ToString();
                txt_montoProducto.Text = this.dtProductos.Rows[0]["monto"].ToString();
                txt_cantidadProducto.Text = this.dtProductos.Rows[0]["cantidad"].ToString();
                txt_marcaProducto.Text = this.dtProductos.Rows[0]["marca"].ToString();
                cbx_tipoProducto.Text = this.dtProductos.Rows[0]["tipo"].ToString();
                cbx_ivaProducto.Text = this.dtProductos.Rows[0]["iva"].ToString();
            }
            catch (Exception e)
            {
                MessageBox.Show("Producto no encontrado", "Buscar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txt_codigo_Producto.Text = "";
                txt_codigo_Producto.Focus();
                cargarGridProductos();
                bloquearCamposProducto();
                limpiarCamposProducto();
            }           
        }
        private void btnInsertarProducto_Click(object sender, EventArgs e)
        {
			gbx_datosProducto.Visible = true;
			gbx_datosProducto.Enabled = true;
            limpiarCamposProducto();
            btn_EliminarProducto.Visible = false;
            lbl_eliminarProducto.Visible = false;
            btn_EditarProducto.Visible = false;
            btn_guardarProducto.Visible = true;
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
                        || string.IsNullOrWhiteSpace(txt_montoProducto.Text) || string.IsNullOrWhiteSpace(txt_marcaProducto.Text) || string.IsNullOrWhiteSpace(cbx_tipoProducto.SelectedItem.ToString())
                        || string.IsNullOrWhiteSpace(cbx_ivaProducto.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (GestorProducto producto = new GestorProducto())
                        {
                            producto.ModificarProducto(codig.ToUpper(), txt_codigoProducto.Text.ToUpper(), txt_nombreProducto.Text.ToUpper(), 
                            txt_detalleProducto.Text.ToUpper(), int.Parse(txt_montoProducto.Text), int.Parse(txt_cantidadProducto.Text),
                            txt_marcaProducto.Text.ToUpper(), cbx_tipoProducto.SelectedItem.ToString().ToUpper(),
                            cbx_ivaProducto.SelectedItem.ToString().ToUpper(), "A");
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
                    || string.IsNullOrWhiteSpace(txt_montoProducto.Text) || string.IsNullOrWhiteSpace(txt_marcaProducto.Text) || string.IsNullOrWhiteSpace(cbx_tipoProducto.SelectedItem.ToString())
                    || string.IsNullOrWhiteSpace(cbx_ivaProducto.SelectedItem.ToString()))
                    {
                        MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    else
                    {
                        using (GestorProducto producto = new GestorProducto())
                        {
                            producto.InsertarProducto(txt_codigoProducto.Text.ToUpper(), txt_nombreProducto.Text.ToUpper(), txt_detalleProducto.Text.ToUpper(), 
                            int.Parse(txt_montoProducto.Text), int.Parse(txt_cantidadProducto.Text), txt_marcaProducto.Text.ToUpper(), cbx_tipoProducto.SelectedItem.ToString().ToUpper(),
                            cbx_ivaProducto.SelectedItem.ToString().ToUpper(), "A");
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
            txt_marcaProducto.Enabled = false;
            cbx_tipoProducto.Enabled = false;
            cbx_ivaProducto.Enabled = false;
        }
        private void desbloquearCamposProducto()
        {
            txt_codigoProducto.Enabled = true;
            txt_nombreProducto.Enabled = true;
            txt_detalleProducto.Enabled = true;
            txt_cantidadProducto.Enabled = true;
            txt_montoProducto.Enabled = true;
            txt_marcaProducto.Enabled = true;
            cbx_tipoProducto.Enabled = true;
            cbx_ivaProducto.Enabled = true;
        }
        private void limpiarCamposProducto()
        {
            txt_codigoProducto.Enabled = true;
            txt_nombreProducto.Enabled = true;
            txt_detalleProducto.Enabled = true;
            txt_cantidadProducto.Enabled = true;
            txt_montoProducto.Enabled = true;
            txt_marcaProducto.Enabled = true;
            cbx_tipoProducto.Enabled = true;
            cbx_ivaProducto.Enabled = true;
            txt_codigoProducto.Text = "";
            txt_nombreProducto.Text = "";
            txt_detalleProducto.Text = "";
            txt_cantidadProducto.Text = "";
            txt_montoProducto.Text = "";
            txt_marcaProducto.Text = "";
            cbx_ivaProducto.SelectedItem = "";
            cbx_tipoProducto.SelectedItem = "";
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
            txt_marcaProducto.Text = dgvProductos.CurrentRow.Cells[6].Value.ToString();
            cbx_tipoProducto.SelectedItem = dgvProductos.CurrentRow.Cells[7].Value.ToString();
            cbx_ivaProducto.SelectedItem = dgvProductos.CurrentRow.Cells[8].Value.ToString();

            bloquearCamposProducto();
            btn_guardarProducto.Visible = false;
            lbl_guardarProducto.Visible = false;
            btn_EliminarProducto.Visible = true;
            lbl_eliminarProducto.Visible = true;
            btn_EditarProducto.Visible = true;
            lbl_editarProducto.Visible = true;
        }
        

        private void frmProductos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
            principal.Show();
        }

        private void txt_codigo_Producto_KeyUp(object sender, KeyEventArgs e)
        {
            bloquearCamposProducto();
            string buscar = txt_codigo_Producto.Text;
            gbx_datosProducto.Visible = true;
            gbx_datosProducto.Enabled = true;
            btn_guardarProducto.Visible = false;
            lbl_guardarProducto.Visible = false;

            using (GestorProducto producto = new GestorProducto())
            {
                this.dsProductos = producto.ConsultarProducto(buscar);
                this.dtProductos = this.dsProductos.Tables[0];
                dgvProductos.DataSource = this.dtProductos;

                dgvProductos.Columns["id_productos"].Visible = false;
                dgvProductos.Columns["codigo"].HeaderText = "CODIGO";
                dgvProductos.Columns["nombre"].HeaderText = "NOMBRE";
                dgvProductos.Columns["detalle"].HeaderText = "DETALLE";
                dgvProductos.Columns["monto"].HeaderText = "MONTO";
                dgvProductos.Columns["cantidad"].HeaderText = "CANTIDAD";
                dgvProductos.Columns["marca"].HeaderText = "MARCA";
                dgvProductos.Columns["tipo"].HeaderText = "TIPO";
                dgvProductos.Columns["iva"].HeaderText = "IVA";
                dgvProductos.Columns["estado"].Visible = false;
            }
            CargarDatosProducto();
        }
    }
}
