using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class Cita
    {
        #region ATRIBUTOS

        private string Cedula;
        private string Nombre;
        private string Telefono;
        private string Detalle;
        private DateTime Fecha;
        private string Estado;
        private string Valor;
        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Cita()
        {
        }

        //constructor para el procedimiento almacenado de insertar
        public Cita(string Ccedula, string Cnombre, string Ctelefono, string Cdetalle, DateTime Cfecha, string Cestado)
        {
            cedula = Ccedula;
            nombre = Cnombre;
            telefono = Ctelefono;
            detalle = Cdetalle;
            fecha = Cfecha;
            estado = Cestado;
        }

        //constructor para el procedimiento almacenado de modificar
        public Cita(string Cvalor, string Ccedula, string Cnombre, string Ctelefono, string Cdetalle, DateTime Cfecha, string Cestado)
        {
            valor = Cvalor;
            cedula = Ccedula;
            nombre = Cnombre;
            telefono = Ctelefono;
            detalle = Cdetalle;
            fecha = Cfecha;
            estado = Cestado;
        }

        //Constructor para el procedimiento almacenado de Inactivar, eliminar y consultar
        public Cita(string Ccedula)
        {
            cedula = Ccedula;
        }
        #endregion CONSTRUCTOR

        #region get y set
        public string valor
        {
            get
            {
                return Valor;
            }

            set
            {
                Valor = value;
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

        public string telefono
        {
            get
            {
                return Telefono;
            }

            set
            {
                Telefono = value;
            }
        }

        public string detalle
        {
            get
            {
                return Detalle;
            }

            set
            {
                Detalle = value;
            }
        }

        public DateTime fecha
        {
            get
            {
                return Fecha;
            }

            set
            {
                Fecha = value;
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
