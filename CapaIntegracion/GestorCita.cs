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

        //Metodo intermedio que negocia con la capa logica para insertar una cita
        public string InsertarCita(string cedula, string nombre, string telefono, string detalle, DateTime fecha, string estado)
        {
            Cita nuevaCita = new Cita(cedula, nombre, telefono, detalle, fecha, estado);
            using (ServicioCita laCita = new ServicioCita())
                return laCita.InsertarCita(nuevaCita);
        }

        //Metodo intermedio que negocia con la capa logica para modificar una cita
        public string ModificarCita(string valor, string cedula, string nombre, string telefono, string detalle, DateTime fecha, string estado)
        {
            Cita modificarCita = new Cita(valor, cedula, nombre, telefono, detalle, fecha, estado);
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ModificarCita(modificarCita);
        }
        //Metodo intermedio que negocia con la capa logica para inactivar una cita
        public string InactivarCita(string cedula)
        {

            Cita inactivarCita = new Cita(cedula);
            using (ServicioCita laCita = new ServicioCita())
                return laCita.InactivarCita(inactivarCita);
        }
        //Metodo intermedio que consulta una cita por cedula por medio de la capa logica
        public DataSet ConsultarCitaCedula(string cedula)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ConsultarCitaCedula(cedula);
        }
        //Metodo intermedio que consulta una cita por nombre por medio de la capa logica
        public DataSet ConsultarCitaNombre(string nombre)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ConsultarCitaNombre(nombre);
        }
        //Metodo que lista las citas activas por medio de la capa logica
        public DataTable ListarCitas()
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ListarCitas();
        }
        //Metodo prueba eliminar
        /*public string Consultar_cita_eliminar(string buscar1)
        {
            using (ServicioCita laCita = new ServicioCita())
                return laCita.ListarCitas(
        }*/
    }

}
