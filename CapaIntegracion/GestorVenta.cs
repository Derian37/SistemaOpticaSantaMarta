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
    public class GestorVenta : servicio, IDisposable
    {
        public GestorVenta () { }

        public void Dispose() { }


        public string InsertarVenta(int id_cliente, DateTime fecha, int id_usuario, int id_pago, char estado)
        {
            Venta nuevaVenta = new Venta(id_cliente, fecha, id_usuario, id_pago, estado);
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.InsertarVenta(nuevaVenta);
        }

        public string ModificarVenta(int id_Venta, int id_cliente, DateTime fecha, int id_usuario, int id_pago, char estado)
        {
            Venta modificarVenta = new Venta(id_Venta, id_cliente, fecha, id_usuario, id_pago, estado);
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ModificarVenta(modificarVenta);
        }

        /// <summary>
        /// Metodo Consultar Venta
        /// </summary>
        /// <param name="id_Venta"></param>
        /// <returns></returns>
        public DataSet ConsultarVenta(int id_Venta)
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ConsultarVenta(id_Venta);
        }

        /// <summary>
        /// Metodo ConsultarUltimoVenta
        /// </summary>
        /// <returns></returns>
        public DataSet ConsultarUltimoVenta()
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ConsultarUltimoVenta();
        }

        /// <summary>
        /// Metodo Listar Ventas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarVentas()
        {
            using (ServicioVenta elVenta = new ServicioVenta())
                return elVenta.ListarVentas();
        }
        

    }
}

