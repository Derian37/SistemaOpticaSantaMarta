using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Description of Impresora.
    /// </summary>

    public class Impresora
    {
        #region ATRIBUTOS
        private int Id_Impresora;
        private string Nombre;
        private string Tipo;
        private string Estado;


        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Impresora()
        {
        }
        //constructor para el procedimiento almacenado de insertar

        public Impresora(string PImpresora_nombre, string PTipo)
        {
            nombre = PImpresora_nombre;
            tipo = PTipo;
        }

        //constructor para el procedimiento almacenado de modificar

        public Impresora(int Pid_Impresora, string PImpresora_nombre, string PTipo)
        {
            id_Impresora = Pid_Impresora;
            nombre = PImpresora_nombre;
            tipo = PTipo;
        }
        //Constructor para el procedimiento almacenado de Inactivar, eliminar y consultar
        public Impresora(int Pid_Impresora)
        {
            id_Impresora = Pid_Impresora;
        }

        #endregion CONSTRUCTOR

        #region get y set

        public int id_Impresora
        {
            get
            {
                return Id_Impresora;
            }

            set
            {
                Id_Impresora = value;
            }
        }

        public string nombre
        {
            get
            {
                return Nombre;
            }

            set
            {
                Nombre = value;
            }
        }

        public string estado
        {
            get
            {
                return Estado;
            }

            set
            {
                Estado = value;
            }
        }

        public string tipo { get => Tipo; set => Tipo = value; }



        #endregion get y set


    }

}