using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOptica.CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Description of Producto.
    /// </summary>

    public class Expediente
    {
        #region ATRIBUTOS
        private int id_cliente;
        private string cedula;
        private string nombre;
        private string apellido1;
        private string apellido2;
        private string direccion;
        private string telefono;
        private int deuda;
        private int id_ojo;





        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Expediente()
        {
        }
        //constructor para el procedimiento almacenado de insertar y modificar



        public Expediente(int id_cliente, string cedula, string nombre, string apellido1, string apellido2, string direccion, string telefono, int deuda, int id_ojo)
        {
            this.Id_cliente = id_cliente;
            this.Cedula = cedula;
            this.Nombre = nombre;
            this.Apellido1 = apellido1;
            this.Apellido2 = apellido2;
            this.Direccion = direccion;
            this.Telefono = telefono;
            this.Deuda = deuda;
            this.Id_ojo = id_ojo;
        }

        //Constructor para el procedimiento almacenado de Inactivar, eliminar y consultar
        public Expediente(string cedula)
        {
            this.Cedula = cedula;
        }

        #endregion CONSTRUCTOR

        #region get y set


        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Deuda { get => deuda; set => deuda = value; }
        public int Id_ojo { get => id_ojo; set => id_ojo = value; }


        #endregion get y set


    }

}