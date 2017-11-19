using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaLogica.Servicio;
using ProyectoOptica.CapaLogica.LogicaNegocio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorTarjeta : servicio, IDisposable

    {
        public GestorTarjeta() { }

        public void Dispose() { }

        public string InsertarTarjeta(int id_cliente, int id_anteojos, string detalle_armazon, int id_producto, string detalle_lente, DateTime fecha_entrega, DateTime fecha,Double distancia, string recibida, Double segineatos)
        {
            CapaLogica.LogicaNegocio.Tarjeta nuevoTargeta = new Tarjeta(id_cliente, id_anteojos, detalle_armazon, id_producto, detalle_lente, fecha_entrega, fecha, distancia, recibida, segineatos);
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
                return elTarjeta.InsertarTarjeta(nuevoTargeta);
        }

        public string ModificarTarjeta(int id_cliente,int id_anteojos,string detalle_armazon, int id_producto,string detalle_lente,DateTime fecha_entrega, DateTime fecha,  Double distancia, string recibida, Double segineatos)
        {
            Tarjeta modificaTargeta = new Tarjeta(id_cliente, id_anteojos, detalle_armazon, id_producto, detalle_lente, fecha_entrega, fecha, distancia, recibida, segineatos);
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
                return elTarjeta.ModificarTarjeta(modificaTargeta);
        }

        public DataSet ConsultarTarjeta(int id_cliente)
        {
            using (ServicioTarjeta elTarjeta = new ServicioTarjeta())
                return elTarjeta.ConsultarTarjeta(id_cliente);
        }

    }
}
