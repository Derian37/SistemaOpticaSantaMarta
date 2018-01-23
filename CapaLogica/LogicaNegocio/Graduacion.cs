/// <summary>
/// SistemaOpticaSantaMarta.CapaLogica.LogicaNegocio
/// </summary>
namespace ProyectoOptica.CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase encargadad de suministrar atributos a los servicios de Graduacion.
    /// </summary>
    public class Graduacion
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
        #region ATRIBUTOS
        private int id_graduacion;
        private int id_cliente;
        private float esfera;
        private float cilindro;
        private int eje;
        private float adiciones;
        private float esferader;
        private float cilindroder;
        private int ejeder;
        private float adicionesder;
        #endregion ATRIBUTOS

        /// <summary>
        /// Region de Constructores.
        /// </summary>
        #region CONSTRUCTOR

        /// <summary>
        /// Cosntructor Vacío.
        /// </summary>
        public Graduacion()
        {
        }
        /// <summary>
        /// Constructor de la clase graduacion para insertar datos.
        /// </summary>
        /// <param name="esferaiz">Parametro de tipo float</param>
        /// <param name="cilindroiz">Parametro de tipo float</param>
        /// <param name="ejeiz">Parametro de tipo entero</param>
        /// <param name="adicionesiz">Parametro de tipo float</param>
        /// <param name="esferader">Parametro de tipo float</param>
        /// <param name="cilindroder">Parametro de tipo float</param>
        /// <param name="ejeder">Parametro de tipo entero</param>
        /// <param name="adicionesder">Parametro de tipo float</param>
        public Graduacion(float esfera, float cilindro, int eje, float adiciones, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            this.Esfera = esfera;
            this.Cilindro = cilindro;
            this.Eje = eje;
            this.Adiciones = adiciones;

            this.Esferader = esferader;
            this.Cilindroder = cilindroder;
            this.Ejeder = ejeder;
            this.Adicionesder = adicionesder;
        }

        /// <summary>
        /// Constructor de la clase graduacion para modifica datos.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="esferaiz">Parametro de tipo float</param>
        /// <param name="cilindroiz">Parametro de tipo float</param>
        /// <param name="ejeiz">Parametro de tipo entero</param>
        /// <param name="adicionesiz">Parametro de tipo float</param>
        /// <param name="esferader">Parametro de tipo float</param>
        /// <param name="cilindroder">Parametro de tipo float</param>
        /// <param name="ejeder">Parametro de tipo entero</param>
        /// <param name="adicionesder">Parametro de tipo float</param>
        public Graduacion(int id_cliente, float esfera, float cilindro, int eje, float adiciones, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            this.Id_graduacion = id_graduacion;
            this.Id_cliente = id_cliente;

            this.Esfera = esfera;
            this.Cilindro = cilindro;
            this.Eje = eje;
            this.Adiciones = adiciones;

            this.Esferader = esferader;
            this.Cilindroder = cilindroder;
            this.Ejeder = ejeder;
            this.Adicionesder = adicionesder;
        }

        /// <summary>
        /// Constructos que se utiliza para consultar un dato.
        /// </summary>
        /// <param name="id_graduacion">Parametro de tipo entero</param>
        public Graduacion(int id_graduacion)
        {
           this.Id_graduacion = id_graduacion;
        }
        #endregion CONSTRUCTOR

        /// <summary>
        /// Region Set y Get.
        /// </summary>
        #region get y set
        public int Id_graduacion { get => id_graduacion; set => id_graduacion = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public float Esfera { get => esfera; set => esfera = value; }
        public float Cilindro { get => cilindro; set => cilindro = value; }
        public int Eje { get => eje; set => eje = value; }
        public float Adiciones { get => adiciones; set => adiciones = value; }
        public float Esferader { get => esferader; set => esferader = value; }
        public float Cilindroder { get => cilindroder; set => cilindroder = value; }
        public int Ejeder { get => ejeder; set => ejeder = value; }
        public float Adicionesder { get => adicionesder; set => adicionesder = value; }
        #endregion get y set
    }
}
