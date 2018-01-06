using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase que se usa para el manejo de los datos de los recibos por dinero
    /// </summary>
    public class Venta
    {
        #region ATRIBUTOS
        private int id_venta;
        private string fecha;
        private int id_cliente;
        private int id_usuario;
        private int modo_pago;
        private double saldo;
        private int id_producto;
        private string codigo;
        private int cantidad;
        private double precio;
        private double subtotal;
        private string estado;

        #endregion ATRIBUTOS
        /// <summary>
        /// Constructor vacío 
        /// </summary>
        public Venta()
        {
        }
        
        public Venta(int Pid_cliente, int Pid_usuario, string Pfecha, int Pmodo_pago, double Psaldo, string Pestado)
        {
            Id_cliente = Pid_cliente;
            fecha = Pfecha;
            Id_usuario = Pid_usuario;
            Modo_pago = Pmodo_pago;
            Saldo = Psaldo;
            Estado = Pestado;
        }

        public Venta(int Pid_venta, string Pcodigo, int Pcantidad, double Pprecio, double Psubtotal, string Pestado)
        {
            Id_venta = Pid_venta;
            Codigo = Pcodigo;
            Cantidad = Pcantidad;
            Precio = Pprecio;
            Subtotal = Psubtotal;
            Estado = Pestado;
        }

        public Venta(int Pid_venta, int Pid_cliente, int Pid_usuario, string Pfecha, int Pmodo_pago, float Psaldo, string Pestado)
        {
            Id_venta = Pid_venta;
            Id_cliente = Pid_cliente;
            fecha = Pfecha;
            Id_usuario = Pid_usuario;
            Modo_pago = Pmodo_pago;
            Saldo = Psaldo;
            Estado = Pestado;
        }

        public Venta(int Pid_venta)
        {
            Id_venta = Pid_venta;
        }

        #region set and get
        public int Id_venta { get => id_venta; set => id_venta = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public int Modo_pago { get => modo_pago; set => modo_pago = value; }
        public double Saldo { get => saldo; set => saldo = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public int Cantidad { get => cantidad; set => cantidad = value; }
        public double Precio { get => precio; set => precio = value; }
        public double Subtotal { get => subtotal; set => subtotal = value; }
        public string Estado { get => estado;  set => estado = value; }
        
        #endregion

    }
}