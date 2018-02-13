
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Description of Producto.
    /// </summary>

    public class Producto
    {
        #region ATRIBUTOS
        private int Monto;
        private string Codig;
        private string Codigo;
        private string Detalle;
        private string Nombre;
        private int Cantidad;
        private string Marca;
        private string Tipo;
        private string Iva;
        private string Estado;


        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Producto()
        {
        }
        //constructor para el procedimiento almacenado de insertar

        public Producto(string Pcodigo, string Pnombre, string Pdetalle, int Pmonto, int Pcantidad, string Pmarca, string Ptipo, string Piva, string Pestado)
        {
            codigo = Pcodigo;
            nombre = Pnombre;
            detalle = Pdetalle;
            monto = Pmonto;
            cantidad = Pcantidad;
            marca = Pmarca;
            tipo = Ptipo;
            iva = Piva;
            estado = Pestado;
        }

        //constructor para el procedimiento almacenado de modificar

        public Producto(string Pcodig, string Pcodigo, string Pnombre, string Pdetalle, int Pmonto, int Pcantidad, string Pmarca, string Ptipo, string Piva, string Pestado)
        {
            codig = Pcodig;
            codigo = Pcodigo;
            nombre = Pnombre;
            detalle = Pdetalle;
            monto = Pmonto;
            cantidad = Pcantidad;
            marca = Pmarca;
            tipo = Ptipo;
            iva = Piva;
            estado = Pestado;
        }
        //Constructor para el procedimiento almacenado de Inactivar, eliminar y consultar
        public Producto(string Pcodigo)
        {
            codigo = Pcodigo;
        }

        #endregion CONSTRUCTOR

        #region get y set

        public string codig
        {
            get
            {
                return Codig;
            }

            set
            {
                Codig = value;
            }
        }

        public string codigo
        {
            get
            {
                return Codigo;
            }

            set
            {
                Codigo = value;
            }
        }
        public int monto
        {
            get
            {
                return Monto;
            }

            set
            {
                Monto = value;
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

        public int cantidad
        {
            get
            {
                return Cantidad;
            }

            set
            {
                Cantidad = value;
            }
        }

        public string marca
        {
            get
            {
                return Marca;
            }

            set
            {
                Marca = value;
            }
        }

        public string tipo
        {
            get
            {
                return Tipo;
            }

            set
            {
                Tipo = value;
            }
        }

        public string iva
        {
            get
            {
                return Iva;
            }

            set
            {
                Iva = value;
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