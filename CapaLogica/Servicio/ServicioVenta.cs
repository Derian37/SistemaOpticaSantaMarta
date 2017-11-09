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
            Console.WriteLine("Gestor insertar_Venta");

            miComando.CommandText = "insertar_Venta";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
            miComando.Parameters["@id_cliente"].Value = elVenta.Id_cliente;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elVenta.Fecha;

            miComando.Parameters.Add("@id_usuario", MySqlDbType.Int16);
            miComando.Parameters["@id_usuario"].Value = elVenta.Id_usuario;

            miComando.Parameters.Add("@id_pago", MySqlDbType.Int16);
            miComando.Parameters["@id_pago"].Value = elVenta.Id_pago;

            miComando.Parameters.Add("@estado", MySqlDbType.Int16);
            miComando.Parameters["@estado"].Value = elVenta.Estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Venta");

            return respuesta;

        }

        //metodo para la SP de Modificar Venta
        public string ModificarVenta(Venta elVenta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_Venta");

            miComando.CommandText = "modificar_Venta";

            miComando.Parameters.Add("@id_venta", MySqlDbType.Int16);
            miComando.Parameters["@id_venta"].Value = elVenta.Id_venta;

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
            miComando.Parameters["@id_cliente"].Value = elVenta.Id_cliente;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elVenta.Fecha;

            miComando.Parameters.Add("@id_usuario", MySqlDbType.Int16);
            miComando.Parameters["@id_usuario"].Value = elVenta.Id_usuario;

            miComando.Parameters.Add("@id_pago", MySqlDbType.Int16);
            miComando.Parameters["@id_pago"].Value = elVenta.Id_pago;

            miComando.Parameters.Add("@estado", MySqlDbType.Int16);
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
