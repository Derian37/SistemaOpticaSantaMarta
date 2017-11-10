using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase que se usa para el manejo de los datos de los recibos por dinero
    /// </summary>
    public class DetalleVenta
    {
        #region ATRIBUTOS
        private int id_DetalleVenta;
        private int id_venta;
        private int id_producto;
        private int cantidad;
        private float precio;
        private float total;

        #endregion ATRIBUTOS
        /// <summary>
        /// Constructor vacío 
        /// </summary>
        public DetalleVenta()
        {
        }

        public DetalleVenta(int Pid_venta, int Pid_producto, int Pcantidad, float Pprecio, float Ptotal)
        {
            Id_venta = Pid_venta;
            Id_producto = Pid_producto;
            Cantidad = Pcantidad;
            Precio = Pprecio;
            Total = Ptotal;
        }

        public DetalleVenta(int Pid_DetalleVenta, int Pid_venta, int Pid_producto, int Pcantidad, float Pprecio, float Ptotal)
        {
            Id_DetalleVenta = Pid_DetalleVenta;
            Id_venta = Pid_venta;
            Id_producto = Pid_producto;
            Cantidad = Pcantidad;
            Precio = Pprecio;
            Total = Ptotal;
        }

        public DetalleVenta(int Pid_DetalleVenta)
        {
            Id_DetalleVenta = Pid_DetalleVenta;
        }

        #region set and get
        public int Id_DetalleVenta { get => id_DetalleVenta; set => id_DetalleVenta = value; }
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public float Precio { get => precio; set => precio = value; }
        public float Total { get => total; private set => total = value; }

        #endregion

    }
}