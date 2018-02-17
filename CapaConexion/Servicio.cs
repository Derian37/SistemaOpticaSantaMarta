using System;
using System.Data;
//Bibliotecas MySQL
using MySql.Data;
using MySql.Data.MySqlClient;

/// <summary>
/// SistemaOpticaSantaMarta.CapaConexion
/// </summary>
namespace ProyectoOptica.CapaConexion
{
    /// <summary>
    /// Clase Servicio encargada de realizar la Conexion con la Base de Datos.
    /// </summary>
    public class servicio
    {
        /// <summary>
        /// Region de Atributos
        /// </summary>
        #region ATRIBUTOS
        protected MySqlConnection conexion;
        protected MySqlCommand cmd;
        #endregion

        /// <summary>
        /// Constructor de la clase Servicio, encargado de proveer la conexión con la base de tados Mysql.
        /// </summary>
        public servicio()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            //Conex Larry//
            builder.Port = 3307;
            /*******************/
            builder.Database = "bd_optica";
            conexion = new MySqlConnection(builder.ToString());
        }

        /// <summary>
        /// Metodo encarado de abrir una conexion.
        /// </summary>
        protected void abrirConexion()
        {
            conexion.Open();
        }

        /// <summary>
        /// Metodo encarado de cerrar la conexion.
        /// </summary>
        protected void cerrarConexion()
        {
            conexion.Close();
        }

        /// <summary>
        /// Metodo encarado de ejecutar la sentencia que se le envie.
        /// </summary>
        /// <param name="sentencia">Parametro de tipo string</param>
        /// <returns></returns>
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

        /// <summary>
        ///  Metodo encarado dela sentencia que se le envie de tipo MySqlCommand.
        /// </summary>
        /// <param name="comando">Parametro de tipo MySqlCommand</param>
        /// <returns></returns>
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

        /// <summary>
        /// Metodo encarado de selecciona la informacion que se le solicite dependiendo de la sentencia.
        /// </summary>
        /// <param name="sentencia">Parametro de tipo string</param>
        /// <returns>Un DataSet con la informacion que retorna la sentencia</returns>
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

        /// <summary>
        /// Metodo encarado de seleccionar la informacion que se le solicite dependiendo del comando MySQL
        /// </summary>
        /// <param name="comando">Parametro de tipo MySqlCommand</param>
        /// <returns>Un DataSet con la informacion que retorna la sentencia</returns>
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