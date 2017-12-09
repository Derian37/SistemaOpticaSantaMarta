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

 
        public string InsertarGraduacion(float esferaiz, float cilindroiz, int ejeiz, float adicionesiz, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            Graduacion nuevoGraduacion = new Graduacion(esferaiz, cilindroiz, ejeiz, adicionesiz, esferader, cilindroder, ejeder, adicionesder);
            using (ServicioGraduacion elGraduacion = new ServicioGraduacion())
                return elGraduacion.InsertarGraduacion(nuevoGraduacion);
        }

        public string ModificarGraduacion(int id_cliente, float esferaiz, float cilindroiz, int ejeiz, float adicionesiz, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            Graduacion nuevoGraduacion = new Graduacion(id_cliente, esferaiz, cilindroiz, ejeiz, adicionesiz, esferader, cilindroder, ejeder, adicionesder);
            using (ServicioGraduacion elGraduacion = new ServicioGraduacion())
                return elGraduacion.ModificarGraduacion(nuevoGraduacion);
        }



        public DataTable ConsultarGraduacion(string cliente_id)
        {
            using (ServicioGraduacion laGraduacion = new ServicioGraduacion())
            {
                return laGraduacion.ConsultarGraduacion(cliente_id);
            }

        }

        public DataSet UltimaGraduacion()
        {

            using (ServicioGraduacion laGraduacion = new ServicioGraduacion())
            {
                return laGraduacion.UltimaGraduacion();
            }
        }


    }
}
