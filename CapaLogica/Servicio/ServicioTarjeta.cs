using System;
using System.Data;
//Librerias MySql
using MySql.Data.MySqlClient;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaLogica.LogicaNegocio;
/// <summary>
/// SistemaOpticaSantaMarta.CapaLogica.Servicio
/// </summary>
namespace ProyectoOptica.CapaLogica.Servicio
{
    /// <summary>
    /// Clase que suministra los servicios al gestor de Tarjeta,
    /// esta clase contiene enlaze directo con la base de datos 
    /// y los procedimientos almacenados.
    /// </summary>
    public class ServicioTarjeta : servicio, IDisposable
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
        #region ATRIBUTOS
        private string respuesta;
        private MySqlCommand miComando;
        #endregion

        /// <summary>
        /// Constructor de la clase ServicioTarjeta, que inicializa una nueva instancia de la clase MysqlCommand.
        /// </summary>
        public ServicioTarjeta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        /// <summary>
        ///  Metodo es solicitado por la interface IDisposable
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// Función de tipo string encargada de insertar o guardar en la base de datos.
        /// </summary>
        /// <param name="elTarjeta">Parametro de tipo objeto Tarjeta que trae los atributos necesarios</param>
        /// <returns>Retorna el procedimiento almacenado Completado</returns>
        public string InsertarTarjeta(Tarjeta elTarjeta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_tarjeta_nueva");

            miComando.CommandText = "insertar_tarjeta_nueva";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_cliente"].Value = elTarjeta.Id_cliente;

            miComando.Parameters.Add("@id_producto_armazon", MySqlDbType.Int32);
            miComando.Parameters["@id_producto_armazon"].Value = elTarjeta.Id_producto;

            miComando.Parameters.Add("@detalle_armazon", MySqlDbType.VarChar);
            miComando.Parameters["@detalle_armazon"].Value = elTarjeta.Detalle_armazon;

            miComando.Parameters.Add("@id_producto_lente", MySqlDbType.Int32);
            miComando.Parameters["@id_producto_lente"].Value = elTarjeta.Id_anteojos;

            miComando.Parameters.Add("@detalle_lenten", MySqlDbType.VarChar);
            miComando.Parameters["@detalle_lenten"].Value = elTarjeta.Detalle_lente;

            miComando.Parameters.Add("@fecha_entrega", MySqlDbType.DateTime);
            miComando.Parameters["@fecha_entrega"].Value = elTarjeta.Fecha_entrega;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elTarjeta.Fecha;

            miComando.Parameters.Add("@id_graduacion", MySqlDbType.Int16);
            miComando.Parameters["@id_graduacion"].Value = elTarjeta.Id_graduacion;

            miComando.Parameters.Add("@distancia", MySqlDbType.Double);
            miComando.Parameters["@distancia"].Value = elTarjeta.Distancia;

            miComando.Parameters.Add("@recibida", MySqlDbType.VarChar);
            miComando.Parameters["@recibida"].Value = elTarjeta.Recibida;

            miComando.Parameters.Add("@segineatos", MySqlDbType.Double);
            miComando.Parameters["@segineatos"].Value = elTarjeta.Segineatos;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Tarjeta Nueva");

            return respuesta;

        }

        /// <summary>
        /// Función de tipo string encargada de modificar un registro en la base de datos.
        /// </summary>
        /// <param name="elTarjeta">Parametro de tipo objeto Tarjeta que trae los atributos necesarios</param>
        /// <returns>Retorna el procedimiento almacenado Completado</returns>
        public string ModificarTarjeta(Tarjeta elTarjeta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_tarjeta");

            miComando.CommandText = "modificar_tarjeta";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int64);
            miComando.Parameters["@id_cliente"].Value = elTarjeta.Id_cliente;

            miComando.Parameters.Add("@id_anteojos", MySqlDbType.Int64);
            miComando.Parameters["@id_anteojos"].Value = elTarjeta.Id_anteojos;

            miComando.Parameters.Add("@darm", MySqlDbType.VarChar);
            miComando.Parameters["@darm"].Value = elTarjeta.Detalle_armazon;

            miComando.Parameters.Add("@id_producto", MySqlDbType.Int64);
            miComando.Parameters["@id_producto"].Value = elTarjeta.Id_producto;

            miComando.Parameters.Add("@dlen", MySqlDbType.VarChar);
            miComando.Parameters["@dlen"].Value = elTarjeta.Detalle_lente;

            miComando.Parameters.Add("@fechE", MySqlDbType.DateTime);
            miComando.Parameters["@fechE"].Value = elTarjeta.Fecha_entrega;

            miComando.Parameters.Add("@fech", MySqlDbType.DateTime);
            miComando.Parameters["@fech"].Value = elTarjeta.Fecha;

            miComando.Parameters.Add("@di", MySqlDbType.Double);
            miComando.Parameters["@di"].Value = elTarjeta.Distancia;

            miComando.Parameters.Add("@res", MySqlDbType.VarChar);
            miComando.Parameters["@res"].Value = elTarjeta.Recibida;

            miComando.Parameters.Add("@seg", MySqlDbType.Double);
            miComando.Parameters["@seg"].Value = elTarjeta.Segineatos;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_tarjeta");

            return respuesta;
        }

        /// <summary>
        /// Función de tipo DataSet encargada de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="cliente_id">Parametro de tipo entero</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarTarjeta(int id_cliente)
        {

            miComando.CommandText = "consultar_tarjeta";

            miComando.Parameters.AddWithValue("@id_cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_cliente"].Value = id_cliente;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
    }
}
