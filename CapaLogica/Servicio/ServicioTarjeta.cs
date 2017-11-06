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
    public class ServicioTarjeta : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioTarjeta()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        //public string InsertarCliente(Cliente elCliente)
        //{
        //    miComando = new MySqlCommand();
        //    Console.WriteLine("Gestor insertar_cliente");

        //    miComando.CommandText = "insertar_cliente";

        //    miComando.Parameters.Add("@cedula", MySqlDbType.VarChar);
        //    miComando.Parameters["@cedula"].Value = elCliente.Cedula;

        //    miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
        //    miComando.Parameters["@nombre"].Value = elCliente.Nombre;

        //    miComando.Parameters.Add("@apellido1", MySqlDbType.VarChar);
        //    miComando.Parameters["@apellido1"].Value = elCliente.Apellido1;

        //    miComando.Parameters.Add("@apellido2", MySqlDbType.VarChar);
        //    miComando.Parameters["@apellido2"].Value = elCliente.Apellido2;

        //    miComando.Parameters.Add("@direccion", MySqlDbType.VarChar);
        //    miComando.Parameters["@direccion"].Value = elCliente.Direccion;

        //    miComando.Parameters.Add("@telefono", MySqlDbType.VarChar);
        //    miComando.Parameters["@telefono"].Value = elCliente.Telefono;

        //    miComando.Parameters.Add("@deuda", MySqlDbType.Int16);
        //    miComando.Parameters["@deuda"].Value = elCliente.Deuda;

        //    miComando.Parameters.Add("@id_Ojo", MySqlDbType.Int16);
        //    miComando.Parameters["@id_Ojo"].Value = elCliente.Id_ojo;

        //    respuesta = this.ejecutaSentencia(miComando);

        //    if (respuesta == "")
        //        respuesta += "Se ha realizado correctamente la transaccion";

        //    Console.WriteLine(respuesta);
        //    Console.WriteLine("FIN Gestor Insertar Cliente");

        //    return respuesta;

        //}

        public string ModificarTarjeta(Tarjeta elTarjeta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_tarjeta");

            miComando.CommandText = "modificar_tarjeta";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int64);
            miComando.Parameters["@id_cliente"].Value = elTarjeta.Id_cliente;

            miComando.Parameters.Add("@id_anteojos", MySqlDbType.Int64);
            miComando.Parameters["@id_anteojos"].Value = elTarjeta.Id_anteojos;

            miComando.Parameters.Add("@darm", MySqlDbType.VarChar);
            miComando.Parameters["@darm"].Value = elTarjeta.Detalle_armazon;

            miComando.Parameters.Add("@id_producto", MySqlDbType.Int64);
            miComando.Parameters["@id_producto"].Value = elTarjeta.Id_producto;

            miComando.Parameters.Add("@dlen", MySqlDbType.VarChar);
            miComando.Parameters["@dlen"].Value = elTarjeta.Detalle_lente;

            miComando.Parameters.Add("@fechE", MySqlDbType.DateTime);
            miComando.Parameters["@fechE"].Value = elTarjeta.Fecha_entrega;

            miComando.Parameters.Add("@fech", MySqlDbType.DateTime);
            miComando.Parameters["@fech"].Value = elTarjeta.Fecha;

            miComando.Parameters.Add("@di", MySqlDbType.Double);
            miComando.Parameters["@di"].Value = elTarjeta.Distancia;

            miComando.Parameters.Add("@res", MySqlDbType.VarChar);
            miComando.Parameters["@res"].Value = elTarjeta.Recibida;

            miComando.Parameters.Add("@seg", MySqlDbType.Double);
            miComando.Parameters["@seg"].Value = elTarjeta.Segineatos;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_tarjeta");

            return respuesta;
        }
        //public string InactivarCliente(Cliente elCliente)
        //{
        //    miComando = new MySqlCommand();
        //    Console.WriteLine("Gestor InactivarCliente");

        //    miComando.CommandText = "InactivarCliente";

        //    miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
        //    miComando.Parameters["@id_cliente"].Value = elCliente.Id_cliente;


        //    respuesta = this.ejecutaSentencia(miComando);

        //    if (respuesta == "")
        //        respuesta += "se ha realizado correctamente la inactivacion";

        //    Console.WriteLine(respuesta);
        //    Console.WriteLine("FIN Gestor Inactivar Estudiante ");
        //    return respuesta;
        //}



        //public string ConsultarTarjeta(Tarjeta elTarjeta)
        //{
        //    miComando = new MySqlCommand();
        //    Console.WriteLine("Gestor consultar_tarjeta");

        //    miComando.CommandText = "consultar_tarjeta";

        //    miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
        //    miComando.Parameters["@id_cliente"].Value = elTarjeta.Id_cliente;

        //    respuesta = this.ejecutaSentencia(miComando);

        //    if (respuesta == "")
        //        respuesta += "Se ha realizado correctamente la transaccion";

        //    Console.WriteLine(respuesta);
        //    Console.WriteLine("FIN Gestor consultar_tarjeta");

        //    return respuesta;
        //}

        public DataSet ConsultarTarjeta(int id_cliente)
        {

            miComando.CommandText = "consultar_tarjeta";

            miComando.Parameters.AddWithValue("@id_cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_cliente"].Value = id_cliente;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }


        //public string ListarCliente(Cliente elCliente)
        //{
        //    miComando = new MySqlCommand();
        //    Console.WriteLine("Gestor listar_cliente");

        //    miComando.CommandText = "listar_cliente";

        //    respuesta = this.ejecutaSentencia(miComando);

        //    if (respuesta == "")
        //        respuesta += "Se ha realizado correctamente la transaccion";

        //    Console.WriteLine(respuesta);
        //    Console.WriteLine("FIN Gestor listar_cliente");

        //    return respuesta;
        //}
        ////Metodo Listar Usuario
        //public DataTable ListarCliente()
        //{
        //    miComando = new MySqlCommand();
        //    Console.WriteLine("Gestor listar_cliente");

        //    miComando.CommandText = "listar_cliente";

        //    DataSet elCliente = new DataSet();
        //    this.abrirConexion();
        //    elCliente = this.seleccionarInformacion(miComando);
        //    DataTable miTablaDatos = elCliente.Tables[0];

        //    return miTablaDatos;
        //}

    }
}
