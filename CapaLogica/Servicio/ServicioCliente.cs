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
    public class ServicioCliente : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioCliente()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_cliente");

            miComando.CommandText = "insertar_cliente";

            miComando.Parameters.Add("@cedula", MySqlDbType.VarChar);
            miComando.Parameters["@cedula"].Value = elCliente.Cedula;

            miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            miComando.Parameters["@nombre"].Value = elCliente.Nombre;

            miComando.Parameters.Add("@apellido1", MySqlDbType.VarChar);
            miComando.Parameters["@apellido1"].Value = elCliente.Apellido1;

            miComando.Parameters.Add("@apellido2", MySqlDbType.VarChar);
            miComando.Parameters["@apellido2"].Value = elCliente.Apellido2;

            miComando.Parameters.Add("@direccion", MySqlDbType.VarChar);
            miComando.Parameters["@direccion"].Value = elCliente.Direccion;

            miComando.Parameters.Add("@telefono", MySqlDbType.VarChar);
            miComando.Parameters["@telefono"].Value = elCliente.Telefono;

            miComando.Parameters.Add("@deuda", MySqlDbType.Int16);
            miComando.Parameters["@deuda"].Value = elCliente.Deuda;

           

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Cliente");

            return respuesta;

        }

        public string ModificarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_cliente");

            miComando.CommandText = "modificar_cliente";

            miComando.Parameters.Add("@id_client", MySqlDbType.VarChar);
            miComando.Parameters["@id_client"].Value = elCliente.Id_cliente;

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = elCliente.Cedula;

            miComando.Parameters.Add("@nom", MySqlDbType.VarChar);
            miComando.Parameters["@nom"].Value = elCliente.Nombre;

            miComando.Parameters.Add("@ape1", MySqlDbType.VarChar);
            miComando.Parameters["@ape1"].Value = elCliente.Apellido1;

            miComando.Parameters.Add("@ape2", MySqlDbType.VarChar);
            miComando.Parameters["@ape2"].Value = elCliente.Apellido2;

            miComando.Parameters.Add("@direc", MySqlDbType.VarChar);
            miComando.Parameters["@direc"].Value = elCliente.Direccion;

            miComando.Parameters.Add("@tel", MySqlDbType.VarChar);
            miComando.Parameters["@tel"].Value = elCliente.Telefono;

            miComando.Parameters.Add("@deu", MySqlDbType.Int16);
            miComando.Parameters["@deu"].Value = elCliente.Deuda;

        


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_cliente");

            return respuesta;
        }
        public string InactivarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor InactivarCliente");

            miComando.CommandText = "InactivarCliente";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
            miComando.Parameters["@id_cliente"].Value = elCliente.Id_cliente;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizado correctamente la inactivacion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Inactivar Estudiante ");
            return respuesta;
        }



        public string ConsultarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor consultar_cliente");

            miComando.CommandText = "consultar_cliente";

            miComando.Parameters.Add("@id_client", MySqlDbType.Int16);
            miComando.Parameters["@id_client"].Value = elCliente.Id_cliente;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor consultar_cliente");

            return respuesta;
        }

        public DataSet ConsultarCliente(int Id_cliente)
        {

            miComando.CommandText = "consultar_cliente";

            miComando.Parameters.AddWithValue("@id_client", MySqlDbType.Int16);
            miComando.Parameters["@id_client"].Value = Id_cliente;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public DataSet ConsultarClienteCedula(string cedula)
        {

            miComando.CommandText = "consultar_clienteCedula";

            miComando.Parameters.AddWithValue("@ced", MySqlDbType.Int16);
            miComando.Parameters["@ced"].Value = cedula;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }


        public string ListarCliente(Cliente elCliente)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_cliente");

            miComando.CommandText = "listar_cliente";

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor listar_cliente");

            return respuesta;
        }
        //Metodo Listar Usuario
        public DataTable ListarCliente()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_cliente");

            miComando.CommandText = "listar_cliente";

            DataSet elCliente = new DataSet();
            this.abrirConexion();
            elCliente = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elCliente.Tables[0];

            return miTablaDatos;
        }

        public DataTable ListarClienteSinTarjeta()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listarClienteSinTarjeta");

            miComando.CommandText = "listarClienteSinTarjeta";

            DataSet elCliente = new DataSet();
            this.abrirConexion();
            elCliente = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elCliente.Tables[0];

            return miTablaDatos;
        }

    }
}
