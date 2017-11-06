using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.Servicio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorExpediente : servicio, IDisposable
    {
        public GestorExpediente() { }

        public void Dispose() { }

        ///// <summary>
        ///// Metodo Consultar Producto
        ///// </summary>
        ///// <param name="Cita_id"></param>
        ///// <returns></returns>
        public DataSet ConsultarExpediente(string cedula)
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.ConsultarExpediente(cedula);
        }

        /// <summary>
        /// Metodo Listar Productos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarExpediente()
        {
            using (ServicioExpediente elExpediente = new ServicioExpediente())
                return elExpediente.ListarExpediente();
        }

  

    }
}

