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
using ProyectoOptica.CapaLogica.LogicaNegocio;

namespace ProyectoOptica.CapaLogica.Servicio
{
    public class ServicioGraduacion : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioGraduacion()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        public string InsertarGraduacion(Graduacion elGraduacion)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_graduacion");

            miComando.CommandText = "insertar_graduacion";
            
            miComando.Parameters.Add("@esiz", MySqlDbType.Float);
            miComando.Parameters["@esiz"].Value = elGraduacion.Esfera;

            miComando.Parameters.Add("@ciliz", MySqlDbType.Float);
            miComando.Parameters["@ciliz"].Value = elGraduacion.Cilindro;

            miComando.Parameters.Add("@ejeiz", MySqlDbType.Int64);
            miComando.Parameters["@ejeiz"].Value = elGraduacion.Eje;

            miComando.Parameters.Add("@adiz", MySqlDbType.Float);
            miComando.Parameters["@adiz"].Value = elGraduacion.Adiciones;

            miComando.Parameters.Add("@esder", MySqlDbType.Float);
            miComando.Parameters["@esder"].Value = elGraduacion.Esferader;

            miComando.Parameters.Add("@cilder", MySqlDbType.Float);
            miComando.Parameters["@cilder"].Value = elGraduacion.Cilindroder;

            miComando.Parameters.Add("@ejeder", MySqlDbType.Int64);
            miComando.Parameters["@ejeder"].Value = elGraduacion.Ejeder;

            miComando.Parameters.Add("@ader", MySqlDbType.Float);
            miComando.Parameters["@ader"].Value = elGraduacion.Adicionesder;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor insertar_graduacion");

            return respuesta;
        }

        public string ModificarGraduacion(Graduacion elGraduacion)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_graduacion");

            miComando.CommandText = "modificar_graduacion";

            miComando.Parameters.Add("@id_client", MySqlDbType.Int64);
            miComando.Parameters["@id_client"].Value = elGraduacion.Id_cliente;

            miComando.Parameters.Add("@esiz", MySqlDbType.Float);
            miComando.Parameters["@esiz"].Value = elGraduacion.Esfera;

            miComando.Parameters.Add("@ciliz", MySqlDbType.Float);
            miComando.Parameters["@ciliz"].Value = elGraduacion.Cilindro;

            miComando.Parameters.Add("@ejeiz", MySqlDbType.Int64);
            miComando.Parameters["@ejeiz"].Value = elGraduacion.Eje;

            miComando.Parameters.Add("@adiz", MySqlDbType.Float);
            miComando.Parameters["@adiz"].Value = elGraduacion.Adiciones;

            miComando.Parameters.Add("@esder", MySqlDbType.Float);
            miComando.Parameters["@esder"].Value = elGraduacion.Esferader;

            miComando.Parameters.Add("@cilder", MySqlDbType.Float);
            miComando.Parameters["@cilder"].Value = elGraduacion.Cilindroder;

            miComando.Parameters.Add("@ejeder", MySqlDbType.Int64);
            miComando.Parameters["@ejeder"].Value = elGraduacion.Ejeder;

            miComando.Parameters.Add("@adder", MySqlDbType.Float);
            miComando.Parameters["@adder"].Value = elGraduacion.Adicionesder;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_graduacion");

            return respuesta;
        }

       public DataTable ConsultarGraduacion(string cliente_id)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarGraduacion");

            miComando.CommandText = "consultar_Graduacion";
            miComando.Parameters.AddWithValue("@cliente_id", MySqlDbType.Int16);
            miComando.Parameters["@cliente_id"].Value = cliente_id;

            DataSet laGraduacion = new DataSet();
            this.abrirConexion();
            laGraduacion = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = laGraduacion.Tables[0];

            return miTablaDatos;
        }
     
        public DataSet UltimaGraduacion()
        {
            miComando.CommandText = "mostrar_ultima_graduacion";
                

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
    }
}
