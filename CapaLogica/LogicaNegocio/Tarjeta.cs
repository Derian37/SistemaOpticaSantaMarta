﻿using System;
/// <summary>
/// SistemaOpticaSantaMarta.CapaLogica.LogicaNegocio
/// </summary>
namespace ProyectoOptica.CapaLogica.LogicaNegocio
{
    /// <summary>
    /// Clase encargadad de suministrar atributos a los servicios de Tarjeta.
    /// </summary>
    public class Tarjeta
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
        #region ATRIBUTOS
        private int id_tarjeta;
        private int id_cliente;
        private int id_anteojos;
        private string detalle_armazon;
        private int id_producto;
        private string detalle_lente;
        private DateTime fecha_entrega;
        private DateTime fecha;
        private int id_graduacion;
        private string distancia;
        private string recibida;
        private Double segineatos;
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
        public Tarjeta() { }

        /// <summary>
        /// Constructor de la clase tarjeta para insertar datos.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="id_anteojos">Parametro de tipo entero</param>
        /// <param name="detalle_armazon">Parametro de tipo string</param>
        /// <param name="id_producto">Parametro de tipo entero</param>
        /// <param name="detalle_lente">Parametro de tipo string</param>
        /// <param name="fecha_entrega">Parametro de tipo DateTime</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="id_graduacion">Parametro de tipo entero</param>
        /// <param name="distancia">Parametro de tipo string</param>
        /// <param name="recibida">Parametro de tipo string</param>
        /// <param name="segineatos">Parametro de tipo Double</param>
        public Tarjeta(int id_cliente, int id_anteojos,string detalle_armazon, int id_producto,string detalle_lente, DateTime fecha_entrega, DateTime fecha, string distancia, string recibida, double segineatos, float esfera, float cilindro, int eje, float adiciones, float esferader, float cilindroder, int ejeder, float adicionesder)
        {
            this.Id_cliente = id_cliente;
            this.Id_anteojos = id_anteojos;
            this.Detalle_armazon = detalle_armazon;
            this.Id_producto = id_producto;
            this.Detalle_lente = detalle_lente;
            this.Fecha_entrega = fecha_entrega;
            this.Fecha = fecha;
            this.Id_graduacion = id_graduacion;
            this.Distancia = distancia;
            this.Recibida = recibida;
            this.Segineatos = segineatos;
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
        /// Constructor de la clase tarjeta para modifica datos.
        /// </summary>
        /// <param name="id_cliente">Parametro de tipo entero</param>
        /// <param name="id_anteojos">Parametro de tipo entero</param>
        /// <param name="detalle_armazon">Parametro de tipo string</param>
        /// <param name="id_producto">Parametro de tipo entero</param>
        /// <param name="detalle_lente">Parametro de tipo string</param>
        /// <param name="fecha_entrega">Parametro de tipo DateTime</param>
        /// <param name="fecha">Parametro de tipo DateTime</param>
        /// <param name="distancia">Parametro de tipo Double</param>
        /// <param name="recibida">Parametro de tipo string</param>
        /// <param name="segineatos">Parametro de tipo Double</param>
        //public Tarjeta(int id_cliente, int id_anteojos, string detalle_armazon, int id_producto, string detalle_lente, DateTime fecha_entrega, DateTime fecha, string distancia, string recibida, double segineatos, float esfera, float cilindro, int eje, float adiciones, float esferader, float cilindroder, int ejeder, float adicionesder)
        //{
        //    this.Id_cliente = id_cliente;
        //    this.Id_anteojos = id_anteojos;
        //    this.Detalle_armazon = detalle_armazon;
        //    this.Id_producto = id_producto;
        //    this.Detalle_lente = detalle_lente;
        //    this.Fecha_entrega = fecha_entrega;
        //    this.Fecha = fecha;
        //    this.Distancia = distancia;
        //    this.Recibida = recibida;
        //    this.Segineatos = segineatos;
        //    this.Esfera = esfera;
        //    this.Cilindro = cilindro;
        //    this.Eje = eje;
        //    this.Adiciones = adiciones;
        //    this.Esferader = esferader;
        //    this.Cilindroder = cilindroder;
        //    this.Ejeder = ejeder;
        //    this.Adicionesder = adicionesder;
        //}

        /// <summary>
        /// Constructos que se utiliza para consultar un dato.
        /// </summary>
        /// <param name="id_tarjeta">Parametro de tipo entero</param>
        public Tarjeta(int id_tarjeta)
        {
            this.Id_tarjeta = id_tarjeta;
        }
        #endregion
        
        /// <summary>
        /// Region Set y Get.
        /// </summary>
        #region Get y Set
        public int Id_tarjeta { get => id_tarjeta; set => id_tarjeta = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public int Id_anteojos { get => id_anteojos; set => id_anteojos = value; }
        public int Id_producto { get => id_producto; set => id_producto = value; }
        public DateTime Fecha_entrega { get => fecha_entrega; set => fecha_entrega = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public int Id_graduacion { get => id_graduacion; set => id_graduacion = value; }
        public string Distancia { get => distancia; set => distancia = value; }
        public string Recibida { get => recibida; set => recibida = value; }
        public double Segineatos { get => segineatos; set => segineatos = value; }
        public string Detalle_lente { get => detalle_lente; set => detalle_lente = value; }
        public string Detalle_armazon { get => detalle_armazon; set => detalle_armazon = value; }
        public float Esfera { get => esfera; set => esfera = value; }
        public float Cilindro { get => cilindro; set => cilindro = value; }
        public int Eje { get => eje; set => eje = value; }
        public float Adiciones { get => adiciones; set => adiciones = value; }
        public float Esferader { get => esferader; set => esferader = value; }
        public float Cilindroder { get => cilindroder; set => cilindroder = value; }
        public int Ejeder { get => ejeder; set => ejeder = value; }
        public float Adicionesder { get => adicionesder; set => adicionesder = value; }
        #endregion Get y Set
    }
}