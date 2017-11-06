using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;
using CapaLogica.Servicio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorGeneral : servicio, IDisposable
    {
        public GestorGeneral() { }

        public void Dispose()
        {
        }

        public DataTable ListarOjo()
        {
            using (ServicioGeneral elOjo = new ServicioGeneral())
                return elOjo.ListarOjo();
        }

    }
}
