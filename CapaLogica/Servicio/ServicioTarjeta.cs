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

        public string InsertarTarjeta(Tarjeta elTarjeta)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_tarjeta_nueva");

            miComando.CommandText = "insertar_tarjeta_nueva";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int32);
            miComando.Parameters["@id_cliente"].Value = elTarjeta.Id_cliente;

            miComando.Parameters.Add("@id_producto_armazon", MySqlDbType.Int32);
            miComando.Parameters["@id_producto_armazon"].Value = elTarjeta.Id_producto;

            miComando.Parameters.Add("@detalle_armazon", MySqlDbType.VarChar);
            miComando.Parameters["@detalle_armazon"].Value = elTarjeta.Detalle_armazon;

            miComando.Parameters.Add("@id_producto_lente", MySqlDbType.Int32);
            miComando.Parameters["@id_producto_lente"].Value = elTarjeta.Id_anteojos;

            miComando.Parameters.Add("@detalle_lenten", MySqlDbType.VarChar);
            miComando.Parameters["@detalle_lenten"].Value = elTarjeta.Detalle_lente;

            miComando.Parameters.Add("@fecha_entrega", MySqlDbType.DateTime);
            miComando.Parameters["@fecha_entrega"].Value = elTarjeta.Fecha_entrega;

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elTarjeta.Fecha;

            miComando.Parameters.Add("@id_graduacion", MySqlDbType.Int16);
            miComando.Parameters["@id_graduacion"].Value = elTarjeta.Id_graduacion;

            miComando.Parameters.Add("@distancia", MySqlDbType.Double);
            miComando.Parameters["@distancia"].Value = elTarjeta.Distancia;

            miComando.Parameters.Add("@recibida", MySqlDbType.VarChar);
            miComando.Parameters["@recibida"].Value = elTarjeta.Recibida;

            miComando.Parameters.Add("@segineatos", MySqlDbType.Double);
            miComando.Parameters["@segineatos"].Value = elTarjeta.Segineatos;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Tarjeta Nueva");

            return respuesta;

        }

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
