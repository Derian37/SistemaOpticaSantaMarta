using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica.LogicaNegocio
{
    public class General
    {

        #region ATRIBUTOSojo
        private int id_ojo;
        private string tipo;
        private int id_graduacion;
        #endregion ATRIBUTOSojo


        public General()
        {
        }

        public General(string tipo, int id_graduacion)
        {
            this.Tipo = tipo;
            this.Id_graduacion = id_graduacion;
        }



        public General( int id_ojo, string tipo, int id_graduacion)
        {
            this.Id_ojo = id_ojo;
            this.Tipo = tipo;
            this.Id_graduacion = id_graduacion;
        }

        public General(int id_ojo)
        {
            this.Id_ojo = id_ojo;
        }

        public int Id_ojo { get => id_ojo; set => id_ojo = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        public int Id_graduacion { get => id_graduacion; set => id_graduacion = value; }
    }


}
