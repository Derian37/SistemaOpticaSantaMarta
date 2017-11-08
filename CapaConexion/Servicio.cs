using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Bibliotecas MySQL
using MySql.Data;
using MySql.Data.MySqlClient;


namespace ProyectoOptica.CapaConexion
{
    public class servicio
    {

        protected MySqlConnection conexion;
        protected MySqlCommand cmd;

        public servicio()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "jiandro1997";
            builder.Database = "bd_optica";
            builder.AllowZeroDateTime = true;

            //conexión
            conexion = new MySqlConnection(builder.ToString());

        }

        //abrir la conexion
        protected void abrirConexion()
        {
            conexion.Open();
        }

        //Cerrar la conexion
        protected void cerrarConexion()
        {
            conexion.Close();
        }

        //Para ejecutar la sentencia que se le envie
        protected string ejecutaSentencia(string sentencia)
        {
            MySqlCommand comando = conexion.CreateCommand();
            comando.CommandText = sentencia;
            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception Error)
            {
                this.cerrarConexion();
                return Error.Message;
            }

            this.cerrarConexion();
            return "";

        }

        protected string ejecutaSentencia(MySqlCommand comando)
        {
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            comando.CommandTimeout = 6000;

            try
            {
                this.abrirConexion();
                comando.ExecuteScalar();
            }
            catch (Exception Error)
            {
                this.cerrarConexion();
                return Error.Message;
            }
            this.cerrarConexion();
            return "";
        }

        //Para selecciona la informacion que se le solicite dependiendo de la sentencia
        protected DataSet seleccionarInformacion(string sentencia)
        {
            DataSet miDataSet = new DataSet();
            MySqlCommand miSqlCommand = conexion.CreateCommand();

            miSqlCommand.CommandText = sentencia;
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();

            miSqlDataAdapter.SelectCommand = miSqlCommand;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }

        //Para seleccionar la informacion que se le solicite dependiendo del comando SQL
        protected DataSet seleccionarInformacion(MySqlCommand comando)
        {
            DataSet miDataSet = new DataSet();
            MySqlDataAdapter miSqlDataAdapter = new MySqlDataAdapter();
            comando.CommandTimeout = 2000;
            comando.Connection = conexion;
            comando.CommandType = CommandType.StoredProcedure;
            miSqlDataAdapter.SelectCommand = comando;
            miSqlDataAdapter.Fill(miDataSet);

            return miDataSet;
        }
    }
}