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
    public class ServicioCita : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioCita()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar cita
        public string InsertarCita(Cita laCita)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_cita");

            miComando.CommandText = "insertar_cita";

            miComando.Parameters.Add("@cedula", MySqlDbType.VarChar);
            miComando.Parameters["@cedula"].Value = laCita.cedula;

            miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            miComando.Parameters["@nombre"].Value = laCita.nombre;

            miComando.Parameters.Add("@telefono", MySqlDbType.VarChar);
            miComando.Parameters["@telefono"].Value = laCita.telefono;

            miComando.Parameters.Add("@detalle", MySqlDbType.VarChar);
            miComando.Parameters["@detalle"].Value = laCita.detalle;

            miComando.Parameters.Add("@fecha", MySqlDbType.Date);
            miComando.Parameters["@fecha"].Value = laCita.fecha;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = laCita.estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Cita");

            return respuesta;

        }

        //metodo para la SP de Modificar Cita
        public string ModificarCita(Cita laCita)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_cita");

            miComando.CommandText = "modificar_cita";

            miComando.Parameters.Add("@val", MySqlDbType.VarChar);
            miComando.Parameters["@val"].Value = laCita.valor;

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = laCita.cedula;

            miComando.Parameters.Add("@nomb", MySqlDbType.VarChar);
            miComando.Parameters["@nomb"].Value = laCita.nombre;

            miComando.Parameters.Add("@tel", MySqlDbType.VarChar);
            miComando.Parameters["@tel"].Value = laCita.telefono;

            miComando.Parameters.Add("@det", MySqlDbType.VarChar);
            miComando.Parameters["@det"].Value = laCita.detalle;

            miComando.Parameters.Add("@fech", MySqlDbType.DateTime);
            miComando.Parameters["@fech"].Value = laCita.fecha;

            miComando.Parameters.Add("@est", MySqlDbType.VarChar);
            miComando.Parameters["@est"].Value = laCita.estado;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Cita");

            return respuesta;
        }

        //metodo para la SP de Inactivar Cita 
        public string InactivarCita(Cita laCita)
        {

            miComando = new MySqlCommand();
            Console.WriteLine("Gestor InactivarCita");

            miComando.CommandText = "inactivar_cita";

            miComando.Parameters.Add("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = laCita.cedula;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Cita");

            return respuesta;
        }

        //metodo para el SP de Consultar Cita por Cedula
        public DataSet ConsultarCitaCedula(string cedula)
        {
            Console.WriteLine("Gestor ConsultarCedula");

            miComando.CommandText = "consultar_CitaCedula";

            miComando.Parameters.AddWithValue("@ced", MySqlDbType.VarChar);
            miComando.Parameters["@ced"].Value = cedula;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }


        //metodo para el SP de Consultar Cita por Nombre
        public DataSet ConsultarCitaNombre(string nom)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarCita");

            miComando.CommandText = "consultar_CitaNombre";

            miComando.Parameters.AddWithValue("@nom", MySqlDbType.VarChar.ToString());
            miComando.Parameters["@nom"].Value = nom;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Cita
        public DataTable ListarCitas()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarCitas");

            miComando.CommandText = "listar_citas";

            DataSet laCita = new DataSet();
            this.abrirConexion();
            laCita = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = laCita.Tables[0];

            return miTablaDatos;
        }
    }
}
