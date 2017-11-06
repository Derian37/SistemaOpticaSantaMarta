using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias MySql
using MySql.Data;
using MySql.Data.MySqlClient;
using MySql.Data.Types;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace CapaLogica.Servicio
{
    public class ServicioGeneral : servicio, IDisposable
    {
       // private string respuesta;
        private MySqlCommand miComando;

        public ServicioGeneral()
        {
       // respuesta = "";
        miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public DataTable ListarOjo()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarOjo");

            miComando.CommandText = "listar_ojo";

            DataSet elOjo= new DataSet();
            this.abrirConexion();
            elOjo = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elOjo.Tables[0];

            return miTablaDatos;
        }
    }
}
