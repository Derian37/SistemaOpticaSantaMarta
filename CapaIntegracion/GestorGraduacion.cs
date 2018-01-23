using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaLogica.LogicaNegocio;
using ProyectoOptica.CapaLogica.Servicio;
using System;
using System.Data;
/// <summary>
///  SistemaOpticaSantaMarta.CapaIntegracion
/// </summary>
namespace ProyectoOptica.CapaIntegracion
{
    /// <summary>
    /// Clase encargada de realizar el enalze de las funciones o metodos del sistema, relacionados con la graduacion de los ojos, que posee la Base de datos.
    /// </summary>
    public class GestorGraduacion : servicio, IDisposable
    {
        /// <summary>
        /// Constructor Vacio.
        /// </summary>
        public GestorGraduacion() { }

        /// <summary>
        /// Metodo encargado de liberár mas rápido la memoria.
        /// </summary>
        public void Dispose() { }

        /// <summary>
        /// Función de tipo string encargada de enlazar datos al servicio encargado de insertar o guardar en la base de datos la graduacion de los ojos.
        /// </summary>
        /// <param name="esferaiz">Parametro de tipo float</param>
        /// <param name="cilindroiz">Parametro de tipo float</param>
        /// <param name="ejeiz">Parametro de tipo entero</param>
        /// <param name="adicionesiz">Parametro de tipo float</param>
        /// <param name="esferader">Parametro de tipo float</param>
        /// <param name="cilindroder">Parametro de tipo float</param>
        /// <param name="ejeder">Parametro de tipo entero</param>
        /// <param name="adicionesder">Parametro de tipo float</param>
        /// <returns>Un Registro nuevo de graduación en los ojos, guardado en la Base de datos</returns>
        public string InsertarGraduacion(float esferaiz, float cilindroiz, int ejeiz, float adicionesiz, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            Graduacion nuevoGraduacion = new Graduacion(esferaiz, cilindroiz, ejeiz, adicionesiz, esferader, cilindroder, ejeder, adicionesder);
            using (ServicioGraduacion elGraduacion = new ServicioGraduacion())
                return elGraduacion.InsertarGraduacion(nuevoGraduacion);
        }

        /// <summary>
        /// Función de tipo string encargada de enlazar datos al servicio encargado de modificar en la base de datos una graduación de los ojos.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="esferaiz">Parametro de tipo float</param>
        /// <param name="cilindroiz">Parametro de tipo float</param>
        /// <param name="ejeiz">Parametro de tipo entero</param>
        /// <param name="adicionesiz">Parametro de tipo float</param>
        /// <param name="esferader">Parametro de tipo float</param>
        /// <param name="cilindroder">Parametro de tipo float</param>
        /// <param name="ejeder">Parametro de tipo entero</param>
        /// <param name="adicionesder">Parametro de tipo float</param>
        /// <returns>Una Graduación Modificada</returns>
        public string ModificarGraduacion(int id_cliente, float esferaiz, float cilindroiz, int ejeiz, float adicionesiz, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            Graduacion nuevoGraduacion = new Graduacion(id_cliente, esferaiz, cilindroiz, ejeiz, adicionesiz, esferader, cilindroder, ejeder, adicionesder);
            using (ServicioGraduacion elGraduacion = new ServicioGraduacion())
                return elGraduacion.ModificarGraduacion(nuevoGraduacion);
        }

        /// <summary>
        /// Función de tipo DataSet encargada de enlazar datos al servicio encargado de realizar una consulta a la base de datos de una graduación.
        /// </summary>
        /// <param name="cliente_id">Parametro de tipo entero</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
        public DataTable ConsultarGraduacion(string cliente_id)
        {
            using (ServicioGraduacion laGraduacion = new ServicioGraduacion())
            {
                return laGraduacion.ConsultarGraduacion(cliente_id);
            }

        }

        /// <summary>
        /// Función de tipo DataSet encargada de enlazar datos al servicio encargado de realizar una consulta a la base de datos, y que trae la ultima graduación ingresada.
        /// </summary>
        /// <returns>La ultima graduación ingresada</returns>
        public DataSet UltimaGraduacion()
        {

            using (ServicioGraduacion laGraduacion = new ServicioGraduacion())
            {
                return laGraduacion.UltimaGraduacion();
            }
        }


    }
}
