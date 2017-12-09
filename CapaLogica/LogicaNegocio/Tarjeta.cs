using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProyectoOptica.CapaLogica.LogicaNegocio
{

    public class Tarjeta
    {
        #region ATRIBUTOS
        private int id_tarjeta;
        private int id_cliente;
        private int id_anteojos;
        private string detalle_armazon;
        private int id_producto;
        private string detalle_lente;
        private DateTime fecha_entrega;
        private DateTime fecha;
        private int id_graduacion;
        private Double distancia;
        private string recibida;
        private Double segineatos;

        #endregion ATRIBUTOS

     
        public Tarjeta(int id_cliente, int id_anteojos,string detalle_armazon, int id_producto,string detalle_lente, DateTime fecha_entrega, DateTime fecha,int id_graduacion ,double distancia, string recibida, double segineatos)
        {
           
            this.Id_cliente = id_cliente;
            this.Id_anteojos = id_anteojos;
            this.Detalle_armazon = detalle_armazon;
            this.Id_producto = id_producto;
            this.Detalle_lente = detalle_lente;
            this.Fecha_entrega = fecha_entrega;
            this.Fecha = fecha;
            this.Id_graduacion = id_graduacion;
            this.Distancia = distancia;
            this.Recibida = recibida;
            this.Segineatos = segineatos;
        }
        public Tarjeta(int id_cliente, int id_anteojos, string detalle_armazon, int id_producto, string detalle_lente, DateTime fecha_entrega, DateTime fecha, double distancia, string recibida, double segineatos)
        {
            this.Id_cliente = id_cliente;
            this.Id_anteojos = id_anteojos;
            this.Detalle_armazon = detalle_armazon;
            this.Id_producto = id_producto;
            this.Detalle_lente = detalle_lente;
            this.Fecha_entrega = fecha_entrega;
            this.Fecha = fecha;
            this.Distancia = distancia;
            this.Recibida = recibida;
            this.Segineatos = segineatos;
        }




        #region Get y Set
        public int Id_tarjeta { get => id_tarjeta; set => id_tarjeta = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_anteojos { get => id_anteojos; set => id_anteojos = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public DateTime Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_graduacion { get => id_graduacion; set => id_graduacion = value; }
        public double Distancia { get => distancia; set => distancia = value; }
        public string Recibida { get => recibida; set => recibida = value; }
        public double Segineatos { get => segineatos; set => segineatos = value; }
        public string Detalle_lente { get => detalle_lente; set => detalle_lente = value; }
        public string Detalle_armazon { get => detalle_armazon; set => detalle_armazon = value; }
        #endregion Get y Set
    }
}