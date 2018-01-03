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
    public class GestorReportes : servicio, IDisposable
    {
        public GestorReportes() { }

        public void Dispose()
        {
        }

        public DataSet ReporteSemanal(string fecha1, string fecha2)
        {
            using (ServicioReporte reporte = new ServicioReporte())
                return reporte.ReporteSemanal(fecha1, fecha2);
        }

        public DataSet ReporteDia(string fecha)
        {
            using (ServicioReporte reporte = new ServicioReporte())
                return reporte.ReporteDia(fecha);
        }

    }
}
