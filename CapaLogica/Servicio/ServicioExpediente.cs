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
//Bibliotecas del sistemaC:\Users\Derian Chavarría\Documents\Visual Studio 2017\Projects\ProyectoOptica\CapaLogica\Servicio\ServicioExpediente.cs
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace CapaLogica.Servicio
{
    /// <summary>
    /// Description of ServicioProducto.
    /// </summary>

    public class ServicioExpediente : servicio, IDisposable
    {
      private MySqlCommand miComando;

      public ServicioExpediente()
        {
          
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }
   
        //metodo para el SP de Consultar Producto
        public DataSet ConsultarExpediente(string ced)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarExpediente");

            miComando.CommandText = "consultar_expediente";

            miComando.Parameters.AddWithValue("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = ced;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        
        public DataTable ListarExpediente()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarExpediente");

            miComando.CommandText = "listar_expediente";

            DataSet elExpediente = new DataSet();
            this.abrirConexion();
            elExpediente = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elExpediente.Tables[0];

            return miTablaDatos;
        }
    }
}
