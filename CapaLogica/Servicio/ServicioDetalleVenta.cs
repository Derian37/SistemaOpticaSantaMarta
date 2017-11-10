using System;
using System.Data;
//Librerias MySql
using MySql.Data.MySqlClient;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace ProyectoOptica.CapaLogica.Servicio
{
    /// <summary>
    /// 
    /// </summary>

    public class ServicioDetalleVenta : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioDetalleVenta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar DetalleVenta
        public string InsertarDetalleVenta(DetalleVenta elDetalleVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_DetalleVenta");

            miComando.CommandText = "insertar_detalleVenta";

            miComando.Parameters.Add("@id_venta", MySqlDbType.Int16);
            miComando.Parameters["@id_venta"].Value = elDetalleVenta.Id_venta;

            miComando.Parameters.Add("@id_producto", MySqlDbType.Int16);
            miComando.Parameters["@id_producto"].Value = elDetalleVenta.Id_producto;

            miComando.Parameters.Add("@cantidad", MySqlDbType.Float);
            miComando.Parameters["@cantidad"].Value = elDetalleVenta.Cantidad;

            miComando.Parameters.Add("@precio", MySqlDbType.Float);
            miComando.Parameters["@precio"].Value = elDetalleVenta.Precio;

            miComando.Parameters.Add("@monto_actual", MySqlDbType.Float);
            miComando.Parameters["@monto_actual"].Value = elDetalleVenta.Precio;

            miComando.Parameters.Add("@total", MySqlDbType.Float);
            miComando.Parameters["@total"].Value = elDetalleVenta.Total;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar DetalleVenta");

            return respuesta;

        }

        //metodo para la SP de Modificar DetalleVenta
        public string ModificarDetalleVenta(DetalleVenta elDetalleVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_DetalleVenta");

            miComando.CommandText = "modificar_detalleVenta";

            miComando.Parameters.Add("@id_DetalleVenta", MySqlDbType.Int16);
            miComando.Parameters["@id_DetalleVenta"].Value = elDetalleVenta.Id_DetalleVenta;

            miComando.Parameters.Add("@id_venta", MySqlDbType.Int16);
            miComando.Parameters["@id_venta"].Value = elDetalleVenta.Id_venta;

            miComando.Parameters.Add("@id_producto", MySqlDbType.Int16);
            miComando.Parameters["@id_producto"].Value = elDetalleVenta.Id_producto;

            miComando.Parameters.Add("@cantidad", MySqlDbType.Float);
            miComando.Parameters["@cantidad"].Value = elDetalleVenta.Cantidad;

            miComando.Parameters.Add("@precio", MySqlDbType.Float);
            miComando.Parameters["@precio"].Value = elDetalleVenta.Precio;

            miComando.Parameters.Add("@monto_actual", MySqlDbType.Float);
            miComando.Parameters["@monto_actual"].Value = elDetalleVenta.Precio;

            miComando.Parameters.Add("@total", MySqlDbType.Float);
            miComando.Parameters["@total"].Value = elDetalleVenta.Total;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar DetalleVenta");

            return respuesta;
        }


        //metodo para el SP de Consultar DetalleVenta 
        public DataSet ConsultarDetalleVenta(int id_DetalleVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarDetalleVenta");

            miComando.CommandText = "consultar_DetalleVenta";

            miComando.Parameters.Add("@id", MySqlDbType.VarChar, 128).Value = id_DetalleVenta;
            //miComando.Parameters["@cod"].Value = cod;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //metodo para el SP de ConsultarUltimoDetalleVenta 
        public DataSet ConsultarUltimoDetalleVenta()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarUltimoDetalleVenta");

            miComando.CommandText = "consultar_ultimoDetalleVenta";

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Usuario
        public DataTable ListarDetalleVentas()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarDetalleVentas");

            miComando.CommandText = "listar_DetalleVentas";

            DataSet elDetalleVenta = new DataSet();
            this.abrirConexion();
            elDetalleVenta = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elDetalleVenta.Tables[0];

            return miTablaDatos;
        }
    }
}
