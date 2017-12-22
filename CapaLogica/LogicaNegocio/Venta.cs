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
        private int id_pago;
        private char estado;

        #endregion ATRIBUTOS
        /// <summary>
        /// Constructor vacío 
        /// </summary>
        public Venta()
        {
        }
        
        public Venta(int Pid_cliente, string Pfecha, int Pid_usuario, int Pid_pago, char Pestado)
        {
            Id_cliente = Pid_cliente;
            fecha = Pfecha;
            Id_usuario = Pid_usuario;
            Id_pago = Pid_pago;
            Estado = Pestado;
        }

        public Venta(int Pid_venta, int Pid_cliente, string Pfecha, int Pid_usuario, int Pid_pago, char Pestado)
        {
            Id_venta = Pid_venta;
            Id_cliente = Pid_cliente;
            fecha = Pfecha;
            Id_usuario = Pid_usuario;
            Id_pago = Pid_pago;
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
        public int Id_pago { get => id_pago; set => id_pago = value; }
        public char Estado { get => estado;  set => estado = value; }
        
        #endregion

    }
}