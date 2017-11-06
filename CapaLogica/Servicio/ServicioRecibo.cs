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

namespace ProyectoOptica.CapaLogica.Servicio
{
    /// <summary>
    /// 
    /// </summary>

    public class ServicioRecibo : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioRecibo()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar Recibo
        public string InsertarRecibo(Recibo elRecibo)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_Recibo");

            miComando.CommandText = "insertar_Recibo";

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elRecibo.Fecha;

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
            miComando.Parameters["@id_cliente"].Value = elRecibo.Id_cliente;

            miComando.Parameters.Add("@id_usuario", MySqlDbType.Int16);
            miComando.Parameters["@id_usuario"].Value = elRecibo.Id_usuario;

            miComando.Parameters.Add("@concepto", MySqlDbType.VarChar);
            miComando.Parameters["@concepto"].Value = elRecibo.Concepto;

            miComando.Parameters.Add("@cliente_deuda", MySqlDbType.Float);
            miComando.Parameters["@cliente_deuda"].Value = elRecibo.Cliente_deuda;

            miComando.Parameters.Add("@monto_abono", MySqlDbType.Float);
            miComando.Parameters["@monto_abono"].Value = elRecibo.Monto_abono;

            miComando.Parameters.Add("@monto_actual", MySqlDbType.Float);
            miComando.Parameters["@monto_actual"].Value = elRecibo.Monto_actual;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Recibo");

            return respuesta;

        }

        //metodo para la SP de Modificar Recibo
        public string ModificarRecibo(Recibo elRecibo)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_Recibo");

            miComando.CommandText = "modificar_Recibo";

            miComando.Parameters.Add("@fecha", MySqlDbType.DateTime);
            miComando.Parameters["@fecha"].Value = elRecibo.Fecha;

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int16);
            miComando.Parameters["@id_cliente"].Value = elRecibo.Id_cliente;

            miComando.Parameters.Add("@id_usuario", MySqlDbType.Int16);
            miComando.Parameters["@id_usuario"].Value = elRecibo.Id_usuario;

            miComando.Parameters.Add("@concepto", MySqlDbType.VarChar);
            miComando.Parameters["@concepto"].Value = elRecibo.Concepto;

            miComando.Parameters.Add("@cliente_deuda", MySqlDbType.Float);
            miComando.Parameters["@cliente_deuda"].Value = elRecibo.Cliente_deuda;

            miComando.Parameters.Add("@monto_abono", MySqlDbType.Float);
            miComando.Parameters["@monto_abono"].Value = elRecibo.Monto_abono;

            miComando.Parameters.Add("@monto_actual", MySqlDbType.Float);
            miComando.Parameters["@monto_actual"].Value = elRecibo.Monto_actual;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Recibo");

            return respuesta;
        }


        //metodo para el SP de Consultar Recibo 
        public DataSet ConsultarRecibo(int id_recibo)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarRecibo");

            miComando.CommandText = "consultar_Recibo";

            miComando.Parameters.Add("@id", MySqlDbType.VarChar, 128).Value = id_recibo;
            //miComando.Parameters["@cod"].Value = cod;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //metodo para el SP de ConsultarUltimoRecibo 
        public DataSet ConsultarUltimoRecibo()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarUltimoRecibo");

            miComando.CommandText = "consultar_ultimoRecibo";

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Usuario
        public DataTable ListarRecibos()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarRecibos");

            miComando.CommandText = "listar_Recibos";

            DataSet elRecibo = new DataSet();
            this.abrirConexion();
            elRecibo = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elRecibo.Tables[0];

            return miTablaDatos;
        }
    }
}
