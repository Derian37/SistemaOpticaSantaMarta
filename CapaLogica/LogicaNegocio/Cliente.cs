using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CapaLogica.LogicaNegocio
{

    public class Cliente
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
 

        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Cedula { get => cedula; set => cedula = value; }
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido1 { get => apellido1; set => apellido1 = value; }
        public string Apellido2 { get => apellido2; set => apellido2 = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Telefono { get => telefono; set => telefono = value; }
        public int Deuda { get => deuda; set => deuda = value; }
      
        #endregion ATRIBUTOS

        public Cliente()
        {
        }

        public Cliente(string Pcedula, string Pnombre, string Papellido1, string Papellido2, string Pdireccion, string Ptelefono, int Pdeuda)
        {
            Id_cliente = 0;
            Cedula = Pcedula;
            Nombre = Pnombre;
            Apellido1 = Papellido1;
            Apellido2 = Papellido2;
            Direccion = Pdireccion;
            Telefono = Ptelefono;
            Deuda = Pdeuda;
            
        }

        public Cliente(int Pid_cedula, string Pcedula, string Pnombre, string Papellido1, string Papellido2, string Pdireccion, string Ptelefono, int Pdeuda)
        {
            Id_cliente = Pid_cedula;
            Cedula = Pcedula;
            Nombre = Pnombre;
            Apellido1 = Papellido1;
            Apellido2 = Papellido2;
            Direccion = Pdireccion;
            Telefono = Ptelefono;
            Deuda = Pdeuda;
        }

        public Cliente(int id_cliente)
        {
            this.Id_cliente = id_cliente;
        }


    }
}