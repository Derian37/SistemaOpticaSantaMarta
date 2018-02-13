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
        int id_usuario;                     //variable local para registrar el usuario
        string nombre, cargo;               //variables para el nombre y cargo del usuario
        string fecha, hora;                 //variables locales para la fecha y hora, usadas para la fecha y hora del ticket y de la base de datos
        string nombreImpresora;             //
        int id_cliente, id_producto;
        string codigoProd;
        int numRecibo;
        string tipo = "";
        int monto;
        int cantidad;
        public static int cont_fila = 0;
        public static int total;
        public static int subtotal;
        public static int iva;
        int abono;
        int saldo;
        int efectivo;
        int tarjeta;
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
        /// <summary>
        /// 
        /// </summary>
        private void CargarNumFactura()
        {
            using (GestorVenta recibo = new GestorVenta())
            {
                dsVentas = recibo.ConsultarUltimoVenta();
                dtVentas = this.dsVentas.Tables[0];

                numRecibo = int.Parse(this.dtVentas.Rows[0]["siguiente"].ToString());
            }
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
                BuscarCliente();
            }
        }

        private void btn_AgregarNombre_Click(object sender, EventArgs e)
        {
            AgregarNombreProducto();
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
                    codigoProd = dtVentas.Rows[0]["codigo"].ToString();
                    monto = int.Parse(dtVentas.Rows[0]["monto"].ToString());
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

        private void btn_buscarProducto_Click(object sender, EventArgs e)
        {
            BuscarProducto();
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

        private void btn_realizarVenta_Click(object sender, EventArgs e)
        {
            if (txt_pago.Text == "")
            {
                MessageBox.Show("Debe digitar un monto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            else
            {
                RealizarVenta();
            }
            
        }

        private void RealizarVenta()
        {
            int pago = int.Parse(txt_pago.Text);
            try
            {
                FrmCobrar cobrar = new FrmCobrar(id_usuario, nombre, cargo, total, pago);
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
                GuardarVenta();
                GuardarDetalleVenta();
                LimpiarCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "btn_realizarVenta", MessageBoxButtons.OK, MessageBoxIcon.Error);
                saldo = 0;
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
            fecha = DateTime.Now.ToShortDateString();
            hora = DateTime.Now.ToShortTimeString();
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

        /// <summary>
        /// Guardamos la venta en la base de datos
        /// </summary>
        private void GuardarVenta()
        {
            int id_pago = 0;    //variable que almacena la forma de pago 1 = efectivo, 2 = tarjeta y 3 = ambos
            if (efectivo > 0)
            {
                id_pago = 1;
            }
            else if (tarjeta > 0)
            {
                id_pago = 2;
            }
            else if (tarjeta > 0 && efectivo > 0 )
            {
                id_pago = 3;
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
                        string codProd = Convert.ToString(fila.Cells[0].Value);
                        int canti = Convert.ToInt32(fila.Cells[2].Value);
                        string tipo = Convert.ToString(fila.Cells[3].Value);
                        int prec = Convert.ToInt16(fila.Cells[4].Value);
                        int subt = Convert.ToInt16(fila.Cells[5].Value);
                        if (tipo.Equals("GRAVADO"))
                        {
                            double aux = subt * 0.13 + subt;
                            subtotal = int.Parse(aux.ToString());
                        }
                        else
                        {
                            subtotal = subt;
                        }
                        venta.InsertarDetalleVenta(numRecibo, codProd, canti, prec, subtotal, "A");
                        subtotal = 0;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show("Error " + e);
            }
        }

        private void LimpiarCampos()
        {
            numRecibo = 0;
            txt_nombreCliente.Text = "";
            lbl_subtotal.Text = "";
            lbl_iva.Text = "";
            lbl_total.Text = "";
            txt_pago.Text = "";
            dgv_ventas.Rows.Clear();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            int cant = int.Parse(txt_cantidad.Text);
            if (codigoProd != "" && cant > 0 && cant <= cantidad)
            {
                bool existe = false;
                int num_fila = 0;

                if (cont_fila == 0)
                {
                    float total = cant * monto;
                    dgv_ventas.Rows.Add(codigoProd, lbl_nombreProducto.Text, cant, tipo, monto, total);
                    cont_fila++;
                }
                else
                {
                    foreach (DataGridViewRow fila in dgv_ventas.Rows)
                    {
                        if (Convert.ToString(fila.Cells[0].Value) == codigoProd)
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
                        dgv_ventas.Rows.Add(codigoProd, lbl_nombreProducto.Text, cant, tipo, monto, total);
                        cont_fila++;
                    }
                }
                CalcularTotales();
            }
            else if (codigoProd == "")
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
            codigoProd = "";
            monto = 0;
            cantidad = 0;
            txt_codigoProducto.Focus();
        }
        /// <summary>
        /// Calcula el total sumando todos los subtotales y el impuesto
        /// </summary>
        private void CalcularTotales()
        {
            total = 0;      //variable para el total de toda la venta más el impuesto
            subtotal = 0;   //variable que acumula la suma de toda la venta
            iva = 0;        //variable que acumula el impuesto de ventas
            double aux = 0;
            //se recorre cada fila del data grid
            foreach (DataGridViewRow fila in dgv_ventas.Rows)
            {
                string tipo = Convert.ToString(fila.Cells[3].Value);
                if (tipo == "GRAVADO") 
                {
                    //iva += int.Parse(fila.Cells[5].ToString()) * 0.13;
                }
                subtotal += Convert.ToInt16(fila.Cells[5].Value);
            }
            lbl_subtotal.Text = subtotal.ToString();
            lbl_iva.Text = iva.ToString();
            lbl_total.Text = (iva + subtotal).ToString();
            total = iva + subtotal;
        }
        /// <summary>
        /// Cuando se borra una foto fila se vuelven a calcular los totales
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgv_ventas_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
        {
            CalcularTotales();
        }

        /// <summary>
        /// Al hacer click en el botón buscar se abre una ventana para buscar el cliente por número de cédula
        /// o buscandolo en el grid 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscar_Click(object sender, EventArgs e)
        {
            BuscarCliente();
        }

        private void BuscarCliente()
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
        /// <summary>
        /// Cierra la ventana al dar click en el botón
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_cerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
