using CapaPresentacion.Ventas;
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
    public partial class FrmVentas : Form
    {
        int id_usuario;
        string nombre, cargo, nombreImpresora;
        int id_cliente;
        int id_producto = 0;
        int numRecibo;
        string cod_producto = "";
        string tipo = "";
        float monto;
        int cantidad;
        public static int cont_fila = 0;
        public static double total;
        public static double subtotal;
        public static double iva;
        double abono;
        double saldo;
        double efectivo;
        double tarjeta;
        private DataTable dtVentas = new DataTable();
        private DataSet dsVentas = new DataSet();
        public FrmVentas(int id_usuario, string nombre, string cargo, string nombreImpresora)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
            this.nombreImpresora = nombreImpresora;
        }

        private void FrmFacturacion_Load(object sender, EventArgs e)
        {
            CargarNumFactura();
            lbl_usuario.Text = nombre;
        }
        
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        private void FrmFacturacion_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
            else if (e.KeyCode == Keys.F1)
            {
                BuscarProducto();
            }
            else if (e.KeyCode == Keys.F5)
            {
                RealizarVenta();
            }
            else if (e.KeyCode == Keys.F6)
            {
                AgregarNombreProducto();
            }

        }

        private void AgregarNombreProducto()
        {
            try
            {
                using (GestorProducto producto = new GestorProducto())
                {
                    dsVentas = producto.ConsultarProductoCodigo(txt_codigoProducto.Text);
                    dtVentas = dsVentas.Tables[0];

                    id_producto = int.Parse(dtVentas.Rows[0]["id_productos"].ToString());
                    cod_producto = dtVentas.Rows[0]["codigo"].ToString();
                    monto = float.Parse(dtVentas.Rows[0]["monto"].ToString());
                    cantidad = int.Parse(dtVentas.Rows[0]["cantidad"].ToString());
                    tipo = dtVentas.Rows[0]["iva"].ToString();

                    if (cantidad == 0)
                    {
                        MessageBox.Show("Existencias del Producto agotadas", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                    }
                    else
                    {
                        lbl_nombreProducto.Text = dtVentas.Rows[0]["nombre"].ToString();
                        txt_cantidad.Focus();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Digite un código de producto valido"+ex, caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
            }
        }

        private void BuscarProducto()
        {
            try
            {
                FrmBuscarProducto producto = new FrmBuscarProducto(id_usuario, nombre, cargo);
                producto.ShowDialog();
                if (!(producto.CodigoProducto == ""))
                {
                    txt_codigoProducto.Text = producto.CodigoProducto;
                    btn_AgregarNombre.Focus();
                }
                producto.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btn_buscarProducto", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_codigoProducto.Text = "";
            }
        }

        private void RealizarVenta()
        {
            try
            {
                FrmCobrar cobrar = new FrmCobrar(id_usuario, nombre, cargo, total);
                cobrar.ShowDialog();
                if (cobrar.Imprimir)
                {
                    abono = cobrar.Abono;
                    saldo = cobrar.Saldo;
                    efectivo = cobrar.Efectivo;
                    tarjeta = cobrar.Tarjeta;
                    Cobrar();
                }
                cobrar.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btn_realizarVenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saldo = 0;
            }
            GuardarVenta();
            GuardarDetalleVenta();
        }

        private void GuardarVenta()
        {
            int id_pago = 0;
            string fecha = DateTime.Now.ToShortDateString();
            if (efectivo > 0)
            {
                id_pago = 1;
            }
            else if (tarjeta > 0)
            {
                id_pago = 2;
            }
            try
            {
                using (GestorVenta venta = new GestorVenta())
                {
                    venta.InsertarVenta(id_cliente, id_usuario, fecha, id_pago, saldo, "A");
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }

        }

        private void GuardarDetalleVenta()
        {
            string fecha = DateTime.Now.ToShortDateString();
            try
            {
                using (GestorVenta venta = new GestorVenta())
                {
                    dsVentas = venta.ConsultarUltimoVenta();
                    dtVentas = this.dsVentas.Tables[0];

                    foreach (DataGridViewRow fila in dgv_ventas.Rows)
                    {
                        //agregamos la cantidad, el precio y subtotal
                        int id_prod = Convert.ToInt32(fila.Cells[0].Value);
                        int canti = Convert.ToInt32(fila.Cells[2].Value);
                        double prec = Convert.ToDouble(fila.Cells[4].Value);
                        double subtotal = Convert.ToDouble(fila.Cells[5].Value);
                        //int canti = int.Parse(fila.Cells[2].Value.ToString());
                        //float prec = float.Parse(fila.Cells[4].Value.ToString());
                        //float subtotal = float.Parse(fila.Cells[5].Value.ToString());
                        MessageBox.Show("recibo " + numRecibo + " prod " + id_producto + " cant " + canti + " prec " + prec + " subt " + subtotal);
                        venta.InsertarDetalleVenta(numRecibo, id_producto, canti, prec, subtotal, "A");

                    }

                   
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
        }

        

        private void Cobrar()
        {
            //creamos una instancia de la clase CreaTicket para imprimir los recibos
            CrearTicket ticket = new CrearTicket();

            //ticket.AbreCajon(); //para abrir el cajón del dinero

            //agregamos datos del encabezado 
            ticket.TextoCentro("OPTICA SANTA MARTA");
            ticket.TextoCentro("Comprometidos por tu Salud Visual");
            ticket.TextoCentro("Exámenes de la Vista por Computadora");
            ticket.TextoCentro("Dr. Guillermo Romero Mendoza");
            ticket.TextoCentro("Cédula: 4 0193 0824");
            ticket.TextoCentro("Teléfono: 2783-30-21");
            ticket.TextoCentro("Entrada Principal a ciudad Neilly");
            ticket.TextoIzquierda("");
            ticket.LineasGuion();
            //agregamos numero de recibo y fecha
            ticket.TextoIzquierda("");
            string fecha = DateTime.Now.ToShortDateString();
            string hora = DateTime.Now.ToShortTimeString();
            ticket.TextoIzquierda("RECIBO N° " + numRecibo);
            ticket.TextoExtremos("Fecha: " + fecha, "Hora: " + hora);
            //agregamos nombre del usuario
            ticket.TextoIzquierda("Le atendió: " + lbl_usuario.Text);
            ticket.TextoIzquierda("");
            //agregamos nombre del cliente
            ticket.TextoIzquierda("Cliente: " + txt_nombreCliente.Text);
            ticket.LineasAsteriscos();

            //agregamos el encabezado de la tabla
            ticket.EncabezadoVenta(); //NOMBRE CANT PRECIO IMPORTE

            //agregamos los articulos de la tabla
            foreach (DataGridViewRow fila in dgv_ventas.Rows)
            {
                //agregamos el nombre, la cantidad, el precio y total
                string nombr = Convert.ToString(fila.Cells[1].Value);
                string canti = Convert.ToString(fila.Cells[2].Value);
                string precio = Convert.ToString(fila.Cells[4].Value);
                string total = Convert.ToString(fila.Cells[5].Value);

                ticket.AgregaArticulo(nombr, canti, precio, total);

            }

            ticket.TextoIzquierda("");
            ticket.LineasIgual();
            //agregamos los totales de la venta
            ticket.AgregarTotales("Subtotal.....", lbl_subtotal.Text);
            ticket.AgregarTotales("IVA..........", lbl_iva.Text);
            ticket.AgregarTotales("Total........", lbl_total.Text);
            ticket.TextoIzquierda("");
            ticket.AgregarTotales("Efectivo.....", efectivo.ToString());
            ticket.AgregarTotales("Tarjeta.....", tarjeta.ToString());
            ticket.AgregarTotales("Saldo.......", saldo.ToString());

            //texto final 
            ticket.TextoIzquierda("");
            ticket.TextoCentro("Gracias por su compra");
            //ticket.CortaTicket(); //corta el ticket
            ticket.ImprimirTicket("Microsoft XPS Document Writer"); //nombre de la impresora
        }
        private void CargarNumFactura()
        {
            using (GestorVenta recibo = new GestorVenta())
            {
                dsVentas = recibo.ConsultarUltimoVenta();
                dtVentas = this.dsVentas.Tables[0];

                numRecibo = int.Parse(this.dtVentas.Rows[0]["siguiente"].ToString());
            }             
        }

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
        }

        private void btn_realizarVenta_Click(object sender, EventArgs e)
        {
            RealizarVenta();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txt_cantidad.Text);
            if (cod_producto != "" && cant > 0 && cant <= cantidad)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    float total = cant * monto;
                    dgv_ventas.Rows.Add(cod_producto, lbl_nombreProducto.Text, cant, tipo, monto, total);
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dgv_ventas.Rows)
                    {
                        if (Convert.ToString(fila.Cells[0].Value) == cod_producto)
                        {
                            existe = true;
                            num_fila = fila.Index;
                        }
                    }
                    if (existe == true)
                    {
                        dgv_ventas.Rows[num_fila].Cells[2].Value = (Convert.ToDouble(txt_cantidad.Text) + Convert.ToDouble(dgv_ventas.Rows[num_fila].Cells[2].Value)).ToString();
                        double total = Convert.ToDouble(dgv_ventas.Rows[num_fila].Cells[2].Value) * Convert.ToDouble(dgv_ventas.Rows[num_fila].Cells[4].Value);
                        dgv_ventas.Rows[num_fila].Cells[4].Value = total;
                    }
                    else
                    {
                        float total = cant * monto;
                        dgv_ventas.Rows.Add(cod_producto, lbl_nombreProducto.Text, cant, tipo, monto, total);
                        cont_fila++;
                    }
                }
               
                CalcularTotales();
                
            }
            else if (cod_producto == "")
            {
                MessageBox.Show("Debe agregar un producto primero", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                txt_codigoProducto.Focus();
            }
            else if (cant == 0)
            {
                MessageBox.Show("Debe agregar una cantidad", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                txt_cantidad.Focus();
            }
            else if (cant > cantidad)
            {
                MessageBox.Show("Solo hay "+cantidad+" unidades en existencia de ese producto", caption: "Alerta", buttons: MessageBoxButtons.OK, icon: MessageBoxIcon.Error);
                txt_cantidad.Focus();
            }
            txt_codigoProducto.Text = "";
            lbl_nombreProducto.Text = "";
            txt_cantidad.Text = "0";
            cod_producto = "";
            monto = 0;
            cantidad = 0;
            txt_codigoProducto.Focus();
        }

        private void CalcularTotales()
        {
            total = 0;
            subtotal = 0;
            iva = 0;
            foreach (DataGridViewRow fila in dgv_ventas.Rows)
            {
                string tipo = Convert.ToString(fila.Cells[3].Value);
                if (tipo == "GRAVADO")
                {
                    iva += Convert.ToDouble(fila.Cells[5].Value) * 0.13;
                }
                subtotal += Convert.ToDouble(fila.Cells[5].Value);
            }
            lbl_subtotal.Text = subtotal.ToString();
            lbl_iva.Text = iva.ToString();
            lbl_total.Text = (iva + subtotal).ToString();
            total = iva + subtotal;
        }

        private void dgv_ventas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
        }

        private void btn_AgregarNombre_Click(object sender, EventArgs e)
        {
            AgregarNombreProducto();
        }

        private void btn_buscar_Click(object sender, EventArgs e)
        {
            try
            {
                FrmBuscarCliente cliente = new FrmBuscarCliente(id_usuario, nombre, cargo);
                cliente.ShowDialog();
                if (!(cliente.NombreCompleto == ""))
                {
                    txt_nombreCliente.Text = cliente.NombreCompleto;
                    id_cliente = cliente.Id_cliente;
                    txt_codigoProducto.Focus();
                }
                cliente.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btn_buscarCliente", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_nombreCliente.Text = "";
            }
            
        }
    }
}
