using System;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.Servicio;
/// <summary>
///  SistemaOpticaSantaMarta.CapaIntegracion
/// </summary>
namespace ProyectoOptica.CapaIntegracion
{
    /// <summary>
    /// Clase encargada de realizar el enalze de las funciones o metodos del sistema, con relacin a los expedientes, que posee la Base de datos.
    /// </summary>
    public class GestorExpediente : servicio, IDisposable
    {
        /// <summary>
        /// Constructor Vacio.
        /// </summary>
        public GestorExpediente() { }

        /// <summary>
        /// Metodo encargado de liberár mas rápido la memoria.
        /// </summary>
        public void Dispose() { }

        /// <summary>
        ///  Función de tipo Dataset encargada de enlazar datos al servicio que se encarga de extraer un cliente mediante su cedula, que poseen una tarjeta, desde la base de datos.
        /// </summary>
        /// <param name="cedula">Parametro de tipo string</param>
        /// <returns>Un Registro de cliente que poseen tarjeta, que está guardado en la Base de datos</returns>
        public DataSet ConsultarExpediente(string cedula)
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.ConsultarExpediente(cedula);
        }

        /// <summary>
        ///  Metodo Listar Expediente de la base de datos de tipo datatable, encargado de extraer o listar a los clientes que poseen una tarjeta, desde la Base de datos.
        /// </summary>
        /// <returns>Un Registro de clientes que poseen tarjeta, que están guardados en la Base de datos</returns>
        public DataTable ListarExpediente()
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.ListarExpediente();
        }

  

    }
}

