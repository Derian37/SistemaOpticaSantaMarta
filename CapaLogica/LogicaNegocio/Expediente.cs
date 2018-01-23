/// <summary>
/// SistemaOpticaSantaMarta.CapaLogica.LogicaNegocio
/// </summary>
namespace ProyectoOptica.CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase encargadad de suministrar atributos a los servicios de Expediente.
    /// </summary>
    public class Expediente
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
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

        /// <summary>
        /// Region de Constructores.
        /// </summary>
        #region CONSTRUCTOR

        /// <summary>
        /// Cosntructor Vacío.
        /// </summary>
        public Expediente()
        {
        }

        /// <summary>
        /// Constructor de la clase Expediente para insertar datos y modifica datos.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="cedula">Parametro de tipo cadena o string</param>
        /// <param name="nombre">Parametro de tipo cadena o string</param>
        /// <param name="apellido1">Parametro de tipo cadena o string</param>
        /// <param name="apellido2">Parametro de tipo cadena o string</param>
        /// <param name="direccion">Parametro de tipo cadena o string</param>
        /// <param name="telefono">Parametro de tipo cadena o string</param>
        /// <param name="deuda">Parametro de tipo entero</param>
        /// <param name="id_ojo">Parametro de tipo entero</param>
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

        /// <summary>
        /// Constructos que se utiliza para consultar un dato.
        /// </summary>
        /// <param name="cedula">Parametro de tipo cadena o string</param>
        public Expediente(string cedula)
        {
            this.Cedula = cedula;
        }

        #endregion CONSTRUCTOR

        /// <summary>
        /// Region Set y Get.
        /// </summary>
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