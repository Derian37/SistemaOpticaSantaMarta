using System;
using System.Data;
//Librerias MySql
using MySql.Data.MySqlClient;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaLogica.LogicaNegocio;
/// <summary>
/// SistemaOpticaSantaMarta.CapaLogica.Servicio
/// </summary>
namespace ProyectoOptica.CapaLogica.Servicio
{
    /// <summary>
    /// Clase que suministra los servicios al gestor de Graduación,
    /// esta clase contiene enlaze directo con la base de datos 
    /// y los procedimientos almacenados.
    /// </summary>
    public class ServicioGraduacion : servicio, IDisposable
    {
        /// <summary>
        /// Region de Atributos.
        /// </summary>
        #region ATRIBUTOS
        private string respuesta;
        private MySqlCommand miComando;
        #endregion
        /// <summary>
        /// Constructor de la clase ServicioGraduacion, que inicializa una nueva instancia de la clase MysqlCommand.
        /// </summary>
        public ServicioGraduacion()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        /// <summary>
        ///  Metodo es solicitado por la interface IDisposable
        /// </summary>
        public void Dispose()
        {

        }

        /// <summary>
        ///  Función de tipo string encargada de insertar o guardar en la base de datos.
        /// </summary>
        /// <param name="elGraduacion">Parametro de tipo objeto Graduacion que trae los atributos necesarios</param>
        /// <returns>Retorna el procedimiento almacenado Completado</returns>
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

        /// <summary>
        /// Función de tipo string encargada de modificar un registro en la base de datos.
        /// </summary>
        /// <param name="elGraduacion">Parametro de tipo objeto Graduacion que trae los atributos necesarios</param>
        /// <returns>Retorna el procedimiento almacenado Completado</returns>
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
        /// <summary>
        ///  Función de tipo DataSet encargada de realizar una consulta a la base de datos.
        /// </summary>
        /// <param name="cliente_id">Parametro de tipo entero</param>
        /// <returns>Un DataSet con datos de la consulta</returns>
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

        /// <summary>
        /// Función de tipo DataSet encargada de realizar una consulta a la base de datos que trae la ultima graduacion ingresada.
        /// </summary>
        /// <returns>Un Dataset con la ultima graduacion ingresada</returns>
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
