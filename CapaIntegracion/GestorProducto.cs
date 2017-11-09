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
    public class GestorProducto : servicio, IDisposable
    {
        public GestorProducto() { }

        public void Dispose() { }


        public string InsertarProducto(string codigo, string nombre, string detalle, float monto, int cantidad, string estado)
        {
            Producto nuevoProducto = new Producto(codigo, nombre, detalle, monto, cantidad, estado);
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.InsertarProducto(nuevoProducto);
        }

        public string ModificarProducto(string codig, string codigo, string nombre, string detalle, float monto, int cantidad, string estado)
        {
            Producto modificarProducto = new Producto(codig, codigo, nombre, detalle, monto, cantidad, "A");
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ModificarProducto(modificarProducto);
        }


        public string InactivarProducto(string codigo)
        {
            Producto inactivarProducto = new Producto(codigo);
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.InactivarProducto(inactivarProducto);
        }

        //        public string ActivarProducto(string codigo)
        //        {
        //            Producto activar = new Producto(codigo);
        //            using (ServicioProducto elProducto = new ServicioProducto())
        //                return elProducto.ActivarProducto(activar);
        //        }
        //
        //
        //        public string EliminarProducto(string codigo)
        //        {
        //            Producto eliminar = new Producto(codigo);
        //            using (ServicioProducto elProducto = new ServicioProducto())
        //                return elProducto.EliminarProducto(eliminar);
        //        }

        public DataSet ConsultarProducto(string parametro)
        {
            string codigo = '%' + parametro + '%';
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ConsultarProducto(codigo);
        }
        /// <summary>
        /// Metodo Consultar Producto
        /// </summary>
        /// <param name="Cita_id"></param>
        /// <returns></returns>
        public DataSet ConsultarProductoCodigo(string codigo)
        {
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ConsultarProductoCodigo(codigo);
        }

        /// <summary>
        /// Metodo Consultar Producto
        /// </summary>
        /// <param name="Cita_id"></param>
        /// <returns></returns>
        public DataSet ConsultarProductoNombre(string nombre)
        {
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ConsultarProductoNombre(nombre);
        }
        /// <summary>
        /// Metodo Listar Productos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarProductos()
        {
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ListarProductos();
        }
        public DataTable ListarProductosLentes()
        {
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ListarProductosLentes();
        }
        public DataTable ListarProductosArmazon()
        {
            using (ServicioProducto elProducto = new ServicioProducto())
                return elProducto.ListarProductosArmazon();
        }

        /// <summary>
        /// Metodo Listar Productos Inactivos
        /// </summary>
        /// <returns></returns>
        //        public DataTable ListarProductosInactivos()
        //        {
        //            using (ServicioProducto elProducto = new ServicioProducto())
        //                return elProducto.ListarProductosInactivos();
        //        }

    }
}

