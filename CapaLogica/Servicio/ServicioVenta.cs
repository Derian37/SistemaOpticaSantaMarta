using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias MySql
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace ProyectoOptica.CapaLogica.Servicio
{
    /// <summary>
    /// 
    /// </summary>

    public class ServicioVenta : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioVenta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar Venta
        public string InsertarVenta(Venta elVenta)
        {
            miComando = new MySqlCommand();

            Console.WriteLine("Gestor insertar_venta");

            miComando.CommandText = "insertar_venta";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
            miComando.Parameters["@id_cliente"].Value = elVenta.Id_cliente;

            miComando.Parameters.Add("@id_usuario", MySqlDbType.Int16);
            miComando.Parameters["@id_usuario"].Value = elVenta.Id_usuario;

            miComando.Parameters.Add("@fecha", MySqlDbType.VarChar);
            miComando.Parameters["@fecha"].Value = elVenta.Fecha;

            miComando.Parameters.Add("@modo_pago", MySqlDbType.Int16);
            miComando.Parameters["@modo_pago"].Value = elVenta.Modo_pago;

            miComando.Parameters.Add("@saldo", MySqlDbType.Double);
            miComando.Parameters["@saldo"].Value = elVenta.Saldo;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elVenta.Estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Venta");

            return respuesta;

        }

        //metodo para la SP de Modificar Venta
        public string InsertarDetalleVenta(Venta elVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_Venta");

            miComando.CommandText = "insertar_DetalleVenta";

            miComando.Parameters.Add("@id_venta", MySqlDbType.Int16);
            miComando.Parameters["@id_venta"].Value = elVenta.Id_venta;

            miComando.Parameters.Add("@id_producto", MySqlDbType.Int16);
            miComando.Parameters["@id_producto"].Value = elVenta.Id_producto;

            miComando.Parameters.Add("@cantidad", MySqlDbType.Int16);
            miComando.Parameters["@cantidad"].Value = elVenta.Cantidad;

            miComando.Parameters.Add("@precio", MySqlDbType.Double);
            miComando.Parameters["@precio"].Value = elVenta.Precio;

            miComando.Parameters.Add("@subtotal", MySqlDbType.Double);
            miComando.Parameters["@subtotal"].Value = elVenta.Subtotal;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elVenta.Estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Venta");

            return respuesta;
        }


        //metodo para el SP de Consultar Venta 
        public DataSet ConsultarVenta(int id_Venta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarVenta");

            miComando.CommandText = "consultar_Venta";

            miComando.Parameters.Add("@id", MySqlDbType.VarChar, 128).Value = id_Venta;
            //miComando.Parameters["@cod"].Value = cod;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //metodo para el SP de ConsultarUltimoVenta 
        public DataSet ConsultarUltimoVenta()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarUltimoVenta");

            miComando.CommandText = "consultar_ultimoVenta";

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Usuario
        public DataTable ListarVentas()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarVentas");

            miComando.CommandText = "listar_Ventas";

            DataSet elVenta = new DataSet();
            this.abrirConexion();
            elVenta = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elVenta.Tables[0];

            return miTablaDatos;
        }
    }
}
