using System;
using System.Data;
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaLogica.Servicio;
using ProyectoOptica.CapaLogica.LogicaNegocio;
/// <summary>
///  SistemaOpticaSantaMarta.CapaIntegracion
/// </summary>
namespace ProyectoOptica.CapaIntegracion
{

    /// <summary>
    /// Clase encargada de realizar el enalze de las funciones o metodos del sistema, relacionados con las tarjetas de los clientes, que posee la Base de datos.
    /// </summary>
    public class GestorTarjeta : servicio, IDisposable

    {
        /// <summary>
        /// Constructor Vacio.
        /// </summary>
        public GestorTarjeta() { }

        /// <summary>
        /// Metodo encargado de liberár mas rápido la memoria.
        /// </summary>
        public void Dispose() { }

        /// <summary>
        /// Función de tipo string encargada de enlazar datos al servicio encargado de insertar o guardar en la base de datos una tarjeta de un cliente.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="id_anteojos">Parametro de tipo entero</param>
        /// <param name="detalle_armazon">Parametro de tipo string</param>
        /// <param name="id_producto">Parametro de tipo entero</param>
        /// <param name="detalle_lente">Parametro de tipo string</param>
        /// <param name="fecha_entrega">Parametro de tipo DateTime</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="id_graduacion">Parametro de tipo entero</param>
        /// <param name="distancia">Parametro de tipo string</param>
        /// <param name="recibida">Parametro de tipo string</param>
        /// <param name="segineatos">Parametro de tipo Double</param>
        /// <returns>Un Registro nuevo de una tarjeta de cliente guardada en la Base de datos</returns>
        public string InsertarTarjeta(int id_cliente, int id_anteojos, string detalle_armazon, int id_producto, string detalle_lente, DateTime fecha_entrega, DateTime fecha,int id_graduacion, string distancia, string recibida, Double segineatos)
        {
            CapaLogica.LogicaNegocio.Tarjeta nuevoTargeta = new Tarjeta(id_cliente, id_anteojos, detalle_armazon, id_producto, detalle_lente, fecha_entrega, fecha, id_graduacion, distancia, recibida, segineatos);
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
                return elTarjeta.InsertarTarjeta(nuevoTargeta);
        }

        /// <summary>
        /// Función de tipo string encargada de enlazar datos al servicio encargado de modificar en la base de datos una tarjeta de un cliente.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="id_anteojos">Parametro de tipo entero</param>
        /// <param name="detalle_armazon">Parametro de tipo string</param>
        /// <param name="id_producto">Parametro de tipo entero</param>
        /// <param name="detalle_lente">Parametro de tipo string</param>
        /// <param name="fecha_entrega">Parametro de tipo DateTime</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="distancia">Parametro de tipo string</param>
        /// <param name="recibida">Parametro de tipo string</param>
        /// <param name="segineatos">Parametro de tipo Double</param>
        /// <returns>Una tarjeta Modificada</returns>
        public string ModificarTarjeta(int id_cliente,int id_anteojos,string detalle_armazon, int id_producto,string detalle_lente,DateTime fecha_entrega, DateTime fecha,  string distancia, string recibida, Double segineatos)
        {
            Tarjeta modificaTargeta = new Tarjeta(id_cliente, id_anteojos, detalle_armazon, id_producto, detalle_lente, fecha_entrega, fecha, distancia, recibida, segineatos);
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
                return elTarjeta.ModificarTarjeta(modificaTargeta);
        }

        /// <summary>
        /// Función de tipo DataSet encargada de enlazar datos al servicio encargado de realizar una consulta a la base de datos de una tarjeta de un cliente.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataSet ConsultarTarjeta(int id_cliente)
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
                return elTarjeta.ConsultarTarjeta(id_cliente);
        }

    }
}
