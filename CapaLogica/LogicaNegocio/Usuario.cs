using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Description of Usuario.
    /// </summary>

    public class Usuario
    {
        #region ATRIBUTOS
        private int Id_usuario;
        private string Cedula;
        private string Nombre;
        private string Contrasenna;
        private string Cargo;
        private string Estado;


        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Usuario()
        {
        }
        //constructor para el procedimiento almacenado de insertar

        public Usuario(string Pusuario_cedula, string Pusuario_nombre, string Pusuario_contrasena, string Pcargo, string Pusuario_estado)
        {
            cedula = Pusuario_cedula;
            nombre = Pusuario_nombre;
            contrasenna = Pusuario_contrasena;
            Cargo = Pcargo;
            estado = Pusuario_estado;
        }

        //constructor para el procedimiento almacenado de insertar

        public Usuario(int Pid_usuario, string Pusuario_cedula, string Pusuario_nombre, string Pusuario_contrasena, string Pcargo, string Pusuario_estado)
        {
            id_usuario = Pid_usuario;
            cedula = Pusuario_cedula;
            nombre = Pusuario_nombre;
            contrasenna = Pusuario_contrasena;
            Cargo = Pcargo;
            estado = Pusuario_estado;
        }
        //Constructor para el procedimiento almacenado de Inactivar, eliminar y consultar
        public Usuario(string Pusuario_cedula)
        {
            cedula = Pusuario_cedula;
        }

        #endregion CONSTRUCTOR

        #region get y set

        public int id_usuario
        {
            get
            {
                return Id_usuario;
            }

            set
            {
                Id_usuario = value;
            }
        }
        public string cedula
        {
            get
            {
                return Cedula;
            }

            set
            {
                Cedula = value;
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

        public string contrasenna
        {
            get
            {
                return Contrasenna;
            }

            set
            {
                Contrasenna = value;
            }
        }

        public string cargo
        {
            get
            {
                return Cargo;
            }

            set
            {
                Cargo = value;
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



        #endregion get y set


    }

}