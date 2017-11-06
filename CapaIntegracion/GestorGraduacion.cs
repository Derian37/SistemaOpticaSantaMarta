using CapaLogica.LogicaNegocio;
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaLogica.LogicaNegocio;
using ProyectoOptica.CapaLogica.Servicio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOptica.CapaIntegracion
{
    
            public class GestorGraduacion : servicio, IDisposable
        {
            public GestorGraduacion() { }

            public void Dispose() { }

        //Metodo intermedio que consulta una cita por cedula por medio de la capa logica
        //public DataSet ConsultarGraduacion(string cliente_id)
        //{
        //    using (ServicioGraduacion laGraduacion = new ServicioGraduacion())
        //        return laGraduacion.ConsultarGraduacion(cliente_id);
        //}

        public string ModificarGraduacionOD(int id_cliente, float esfera, float cilindro, int eje, float adiciones)
        {
            Graduacion nuevoGraduacion = new Graduacion(id_cliente, esfera, cilindro, eje, adiciones);
            using (ServicioGraduacion elGraduacion = new ServicioGraduacion())
                return elGraduacion.ModificarGraduacionOD(nuevoGraduacion);
        }

        public string ModificarGraduacionOI(int id_cliente, float esfera, float cilindro, int eje, float adiciones)
        {
            Graduacion nuevoGraduacion = new Graduacion(id_cliente, esfera, cilindro, eje, adiciones);
            using (ServicioGraduacion elGraduacion = new ServicioGraduacion())
                return elGraduacion.ModificarGraduacionOI(nuevoGraduacion);
        }

        public DataTable ConsultarGraduacion(string cliente_id)
            {
                using (ServicioGraduacion laGraduacion = new ServicioGraduacion())
                    return laGraduacion.ConsultarGraduacion(cliente_id);
            }
          
        }

    
}
