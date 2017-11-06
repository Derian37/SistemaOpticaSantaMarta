using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase que se usa para el manejo de los datos de los recibos por dinero
    /// </summary>
    public class Recibo
    {
        #region ATRIBUTOS
        private int id_recibo;
        private DateTime fecha;
        private int id_cliente;
        private int id_usuario;
        private string concepto;
        private float cliente_deuda;
        private float monto_abono;
        private float monto_actual;

        #endregion ATRIBUTOS
        /// <summary>
        /// Constructor vacío 
        /// </summary>
        public Recibo()
        {
        }

        /// <summary>
        /// constructor para el procedimiento almacenado de insertar
        /// </summary>
        /// <param name="Pfecha"></param>
        /// <param name="Pid_cliente"></param>
        /// <param name="Pid_usuario"></param>
        /// <param name="Pconcepto"></param>
        /// <param name="Pcliente_deuda"></param>
        /// <param name="Pmonto_abono"></param>
        /// <param name="Pmonto_actual"></param>
        public Recibo(DateTime Pfecha, int Pid_cliente, int Pid_usuario,string Pconcepto, float Pcliente_deuda, float Pmonto_abono, float Pmonto_actual)
        {
            fecha = Pfecha;
            Id_cliente = Pid_cliente;
            Id_usuario = Pid_usuario;
            Concepto = Pconcepto;
            Cliente_deuda = Pcliente_deuda;
            Monto_abono = Pmonto_abono;
            Monto_actual = Pmonto_actual;
        }
        /// <summary>
        /// constructor para el procedimiento almacenado de modificar
        /// </summary>
        /// <param name="Pid_recibo"></param>
        /// <param name="Pfecha"></param>
        /// <param name="Pid_cliente"></param>
        /// <param name="Pid_usuario"></param>
        /// <param name="Pconcepto"></param>
        /// <param name="Pcliente_deuda"></param>
        /// <param name="Pmonto_abono"></param>
        /// <param name="Pmonto_actual"></param>
        public Recibo(int Pid_recibo, DateTime Pfecha, int Pid_cliente, int Pid_usuario, string Pconcepto, float Pcliente_deuda, float Pmonto_abono, float Pmonto_actual)
        {
            Id_recibo = Pid_recibo;
            fecha = Pfecha;
            Id_cliente = Pid_cliente;
            Id_usuario = Pid_usuario;
            Concepto = Pconcepto;
            Cliente_deuda = Pcliente_deuda;
            Monto_abono = Pmonto_abono;
            Monto_actual = Pmonto_actual;
        }
        /// <summary>
        /// constructor para los procedimientos almacenados de eliminar, buscar
        /// </summary>
        /// <param name="id_recibo"></param>
        public Recibo(int id_recibo)
        {
            this.Id_recibo = id_recibo;
        }

        #region set and get
        public int Id_recibo { get => id_recibo; set => id_recibo = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_usuario { get => id_usuario; set => id_usuario = value; }
        public string Concepto { get => concepto; set => concepto = value; }
        public float Cliente_deuda { get => cliente_deuda; set => cliente_deuda = value; }
        public float Monto_abono { get => monto_abono; set => monto_abono = value; }
        public float Monto_actual { get => monto_actual; set => monto_actual = value; }
        #endregion

    }
}