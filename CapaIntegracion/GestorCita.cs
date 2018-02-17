using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;
using ProyectoOptica.CapaLogica.Servicio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorCita : servicio, IDisposable
    {
        public GestorCita() { }

        public void Dispose() { }

        /// <summary>
        /// Metodo intermedio que negocia con la capa logica para insertar una cita
        /// </summary>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="telefono"></param>
        /// <param name="detalle"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public string InsertarCita(string cedula, string nombre, string telefono, string detalle, DateTime fecha, string estado)
        {
            Cita nuevaCita = new Cita(cedula, nombre, telefono, detalle, fecha, estado);
            using (ServicioCita laCita = new ServicioCita())
                return laCita.InsertarCita(nuevaCita);
        }

        /// <summary>
        /// Metodo intermedio que negocia con la capa logica para modificar una cita
        /// </summary>
        /// <param name="valor"></param>
        /// <param name="cedula"></param>
        /// <param name="nombre"></param>
        /// <param name="telefono"></param>
        /// <param name="detalle"></param>
        /// <param name="fecha"></param>
        /// <param name="estado"></param>
        /// <returns></returns>
        public string ModificarCita(string valor, string cedula, string nombre, string telefono, string detalle, DateTime fecha, string estado)
        {
            Cita modificarCita = new Cita(valor, cedula, nombre, telefono, detalle, fecha, estado);
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ModificarCita(modificarCita);
        }
        /// <summary>
        /// Metodo intermedio que negocia con la capa logica para inactivar una cita
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public string InactivarCita(string cedula)
        {

            Cita inactivarCita = new Cita(cedula);
            using (ServicioCita laCita = new ServicioCita())
                return laCita.InactivarCita(inactivarCita);
        }
        /// <summary>
        /// Metodo intermedio que consulta una cita por cedula por medio de la capa logica
        /// </summary>
        /// <param name="cedula"></param>
        /// <returns></returns>
        public DataSet ConsultarCitaCedula(string cedula)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ConsultarCitaCedula(cedula);
        }
        /// <summary>
        /// Metodo intermedio que consulta una cita por nombre por medio de la capa logica
        /// </summary>
        /// <param name="nombre"></param>
        /// <returns></returns>
        public DataSet ConsultarCitaNombre(string nombre)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ConsultarCitaNombre(nombre);
        }
        /// <summary>
        /// Metodo que lista las citas activas por medio de la capa logica
        /// </summary>
        /// <returns></returns>
        public DataTable ListarCitas()
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ListarCitas();
        }
        /// <summary>
        /// Metodo que lista las citas cercanas a vencer en un periodo de un año
        /// </summary>
        /// <returns></returns>
        public DataTable ListarCitasAnio()
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ListarCitasAnio();
        }
        /// <summary>
        /// Metodo prueba eliminar
        /// </summary>
        /// <param name="buscar1"></param>
        /// <returns></returns>
       /* public string Consultar_cita_eliminar(string buscar1)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ListarCitas();
        }*/
    }

}
