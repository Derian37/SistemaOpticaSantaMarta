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
    public class GestorDetalleVenta : servicio, IDisposable
    {
        public GestorDetalleVenta() { }

        public void Dispose() { }
        
        public string InsertarDetalleVenta(int id_venta, int id_producto, int cantidad, float precio, float total)
        {
            DetalleVenta nuevoDetalleVenta = new DetalleVenta(id_venta, id_producto, cantidad, precio, total);
            using (ServicioDetalleVenta elDetalleVenta = new ServicioDetalleVenta())
                return elDetalleVenta.InsertarDetalleVenta(nuevoDetalleVenta);
        }

        public string ModificarDetalleVenta(int id_DetalleVenta, int id_venta, int id_producto, int cantidad, float precio, float total)
        {
            DetalleVenta modificarDetalleVenta = new DetalleVenta(id_DetalleVenta, id_venta, id_producto, cantidad, precio, total);
            using (ServicioDetalleVenta elDetalleVenta = new ServicioDetalleVenta())
                return elDetalleVenta.ModificarDetalleVenta(modificarDetalleVenta);
        }

        /// <summary>
        /// Metodo Consultar DetalleVenta
        /// </summary>
        /// <param name="id_DetalleVenta"></param>
        /// <returns></returns>
        public DataSet ConsultarDetalleVenta(int id_DetalleVenta)
        {
            using (ServicioDetalleVenta elDetalleVenta = new ServicioDetalleVenta())
                return elDetalleVenta.ConsultarDetalleVenta(id_DetalleVenta);
        }

        /// <summary>
        /// Metodo ConsultarUltimoDetalleVenta
        /// </summary>
        /// <returns></returns>
        public DataSet ConsultarUltimoDetalleVenta()
        {
            using (ServicioDetalleVenta elDetalleVenta = new ServicioDetalleVenta())
                return elDetalleVenta.ConsultarUltimoDetalleVenta();
        }

        /// <summary>
        /// Metodo Listar DetalleVentas
        /// </summary>
        /// <returns></returns>
        public DataTable ListarDetalleVentas()
        {
            using (ServicioDetalleVenta elDetalleVenta = new ServicioDetalleVenta())
                return elDetalleVenta.ListarDetalleVentas();
        }


    }
}

