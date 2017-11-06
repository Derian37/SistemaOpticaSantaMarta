using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoOptica.CapaLogica.LogicaNegocio
{
    public class Graduacion
    {
        #region ATRIBUTOS

        private int id_graduacion;
        private int id_cliente;
        private float esfera;
        private float cilindro;
        private int eje;
        private float adiciones;

      

        #endregion ATRIBUTOS

        #region CONSTRUCTOR
        public Graduacion()
        {
        }

        public Graduacion(float esfera, float cilindro, int eje, float adiciones)
        {
            this.Esfera = esfera;
            this.Cilindro = cilindro;
            this.Eje = eje;
            this.Adiciones = adiciones;
        }

        
        public Graduacion(int id_cliente, float esfera, float cilindro, int eje, float adiciones)
        {
            this.Id_graduacion = id_graduacion;
            this.Id_cliente = id_cliente;
            this.Esfera = esfera;
            this.Cilindro = cilindro;
            this.Eje = eje;
            this.Adiciones = adiciones;
        }

        
        public Graduacion(int id_graduacion)
        {
           this.Id_graduacion = id_graduacion;
        }

        #endregion CONSTRUCTOR
        #region get y set
        public int Id_graduacion { get => id_graduacion; set => id_graduacion = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public float Esfera { get => esfera; set => esfera = value; }
        public float Cilindro { get => cilindro; set => cilindro = value; }
        public int Eje { get => eje; set => eje = value; }
        public float Adiciones { get => adiciones; set => adiciones = value; }
        #endregion get y set
    }
}
