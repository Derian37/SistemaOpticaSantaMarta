using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Librerias MySql
using MySql.Data;
using MySql.Data.MySqlClient;
//Bibliotecas del sistema
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;

namespace ProyectoOptica.CapaLogica.Servicio
{
    /// <summary>
    /// Description of ServicioUsuario.
    /// </summary>

    public class ServicioUsuario : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioUsuario()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar Usuario
        public string InsertarUsuario(Usuario elUsuario)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_usuario");

            miComando.CommandText = "insertar_usuario";

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = elUsuario.cedula;

            miComando.Parameters.Add("@nomb", MySqlDbType.VarChar);
            miComando.Parameters["@nomb"].Value = elUsuario.nombre;

            miComando.Parameters.Add("@contra", MySqlDbType.VarChar);
            miComando.Parameters["@contra"].Value = elUsuario.contrasenna;

            miComando.Parameters.Add("@carg", MySqlDbType.VarChar);
            miComando.Parameters["@carg"].Value = elUsuario.cargo;

            miComando.Parameters.Add("@est", MySqlDbType.VarChar);
            miComando.Parameters["@est"].Value = elUsuario.estado;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Usuario");

            return respuesta;

        }

        //metodo para la SP de Modificar Usuario
        public string ModificarUsuario(Usuario elUsuario)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_usuario");

            miComando.CommandText = "modificar_usuario";

            miComando.Parameters.Add("@id", MySqlDbType.VarChar);
            miComando.Parameters["@id"].Value = elUsuario.id_usuario;

            miComando.Parameters.Add("@cedula", MySqlDbType.VarChar);
            miComando.Parameters["@cedula"].Value = elUsuario.cedula;

            miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            miComando.Parameters["@nombre"].Value = elUsuario.nombre;

            miComando.Parameters.Add("@contrasena", MySqlDbType.VarChar);
            miComando.Parameters["@contrasena"].Value = elUsuario.contrasenna;

            miComando.Parameters.Add("@cargo", MySqlDbType.VarChar);
            miComando.Parameters["@cargo"].Value = elUsuario.cargo;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elUsuario.estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Usuario");

            return respuesta;
        }

        //metodo para la SP de Inactivar Usuario 
        public string InactivarUsuario(Usuario elUsuario)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor InactivarUsuario");

            miComando.CommandText = "inactivar_usuario";

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = elUsuario.cedula;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Usuario");

            return respuesta;
        }


        //metodo para el SP de Consultar Usuario
        public DataSet ConsultarUsuario(string cedula)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarUsuario");

            miComando.CommandText = "consultar_usuario";

            miComando.Parameters.Add("@cedula", MySqlDbType.VarChar);
            miComando.Parameters["@cedula"].Value = cedula;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Usuario
        public DataTable ListarUsuarios()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarUsuarios");

            miComando.CommandText = "listar_usuarios";

            DataSet elUsuario = new DataSet();
            this.abrirConexion();
            elUsuario = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elUsuario.Tables[0];

            return miTablaDatos;
        }
    }
}
