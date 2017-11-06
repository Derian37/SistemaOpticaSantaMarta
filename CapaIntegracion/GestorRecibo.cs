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
    public class GestorRecibo : servicio, IDisposable
    {
        public GestorRecibo () { }

        public void Dispose() { }


        public string InsertarRecibo(DateTime fecha, int id_cliente, int id_usuario, string concepto, float cliente_deuda, float monto_abono, float monto_actual)
        {
            Recibo nuevoRecibo = new Recibo(fecha, id_cliente, id_usuario, concepto, cliente_deuda, monto_abono, monto_actual);
            using (ServicioRecibo elRecibo = new ServicioRecibo())
                return elRecibo.InsertarRecibo(nuevoRecibo);
        }

        public string ModificarRecibo(int id_recibo, DateTime fecha, int id_cliente, int id_usuario, string concepto, float cliente_deuda, float monto_abono, float monto_actual)
        {
            Recibo modificarRecibo = new Recibo(id_recibo, fecha, id_cliente, id_usuario, concepto, cliente_deuda, monto_abono, monto_actual);
            using (ServicioRecibo elRecibo = new ServicioRecibo())
                return elRecibo.ModificarRecibo(modificarRecibo);
        }

        /// <summary>
        /// Metodo Consultar Recibo
        /// </summary>
        /// <param name="id_recibo"></param>
        /// <returns></returns>
        public DataSet ConsultarRecibo(int id_recibo)
        {
            using (ServicioRecibo elRecibo = new ServicioRecibo())
                return elRecibo.ConsultarRecibo(id_recibo);
        }

        /// <summary>
        /// Metodo ConsultarUltimoRecibo
        /// </summary>
        /// <returns></returns>
        public DataSet ConsultarUltimoRecibo()
        {
            using (ServicioRecibo elRecibo = new ServicioRecibo())
                return elRecibo.ConsultarUltimoRecibo();
        }

        /// <summary>
        /// Metodo Listar Recibos
        /// </summary>
        /// <returns></returns>
        public DataTable ListarRecibos()
        {
            using (ServicioRecibo elRecibo = new ServicioRecibo())
                return elRecibo.ListarRecibos();
        }
        

    }
}

