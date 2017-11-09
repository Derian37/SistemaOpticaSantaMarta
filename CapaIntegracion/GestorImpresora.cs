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
    public class GestorImpresora : servicio, IDisposable

    {
        public GestorImpresora() { }

        public void Dispose() { }

        public string InsertarImpresora(string nombre, string tipo)
        {
            Impresora nuevoImpresora = new Impresora(nombre, tipo);
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.InsertarImpresora(nuevoImpresora);
        }

        public string ModificarImpresora(int id_Impresora, string nombre, string tipo)
        {
            Impresora nuevoImpresora = new Impresora(id_Impresora, nombre, tipo);
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.ModificarImpresora(nuevoImpresora);
        }

        public string InactivarImpresora(int id_Impresora)
         {
             Impresora nuevoImpresora = new Impresora(id_Impresora);

             using (ServicioImpresora elImpresora = new ServicioImpresora())
                 return elImpresora.InactivarImpresora(nuevoImpresora);
         }

        public string ListarImpresora(int id_Impresora)

        {
            Impresora nuevoImpresora = new Impresora();

            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.ListarImpresoras(nuevoImpresora);
        }
        public DataSet ConsultarImpresora(int id_Impresora)
        {
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.ConsultarImpresora(id_Impresora);
        }
        
        public DataTable ListarImpresora()
        {
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.ListarImpresoras();
        }

        
        public DataSet Consultar_cantidadImpresoras()
        {
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.Consultar_cantidadImpresoras();
        }
        public string Establecer_impresoraPredeterminada(int id_Impresora)
        {
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.Establecer_impresoraPredeterminada(id_Impresora);
        }

        public DataSet Consultar_impresoraPredeterminada()
        {
            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.Consultar_impresoraPredeterminada();
        }
        public string Quitar_impresorasPredeterminadas()
        {
            Impresora nuevoImpresora = new Impresora();

            using (ServicioImpresora elImpresora = new ServicioImpresora())
                return elImpresora.Quitar_impresorasPredeterminadas();
        }
        
    }
}
