using System;
using System.Data;
//Librerias MySql
using MySql.Data.MySqlClient;
//Bibliotecas del sistemaC:\Users\Derian Chavarría\Documents\Visual Studio 2017\Projects\ProyectoOptica\CapaLogica\Servicio\ServicioExpediente.cs
using ProyectoOptica.CapaConexion;
/// <summary>
/// SistemaOpticaSantaMarta.CapaLogica.Servicio
/// </summary>
namespace CapaLogica.Servicio
{
    /// <summary>
    /// Clase que suministra los servicios al gestor de Expediente,
    /// esta clase contiene enlaze directo con la base de datos 
    /// y los procedimientos almacenados.
    /// </summary>
    public class ServicioExpediente : servicio, IDisposable
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
        #region ATRIBUTOS
        private MySqlCommand miComando;
        #endregion

        /// <summary>
        /// Constructor de la clase ServicioExpediente, que inicializa una nueva instancia de la clase MysqlCommand.
        /// </summary>
        public ServicioExpediente()
        {
            miComando = new MySqlCommand();
        }

        /// <summary>
        ///  Metodo es solicitado por la interface IDisposable
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        /// Función de tipo DataSet encargada de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="ced">Parametro de tipo string</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
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

        /// <summary>
        ///  Metodo que lista expedientes de la base de datos de tipo datatable.
        /// </summary>
        /// <returns>Un DataTable con datos de la consulta</returns>
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
