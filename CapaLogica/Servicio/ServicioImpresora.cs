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
    public class ServicioImpresora : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioImpresora()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        public void Dispose()
        {

        }

        public string InsertarImpresora(Impresora elImpresora)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_Impresora");

            miComando.CommandText = "insertar_impresora";

            miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            miComando.Parameters["@nombre"].Value = elImpresora.nombre;

            miComando.Parameters.Add("@tipo", MySqlDbType.VarChar);
            miComando.Parameters["@tipo"].Value = elImpresora.tipo;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Impresora");

            return respuesta;

        }

        public string ModificarImpresora(Impresora elImpresora)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_Impresora");

            miComando.CommandText = "modificar_impresora";

            miComando.Parameters.Add("@id_impresora", MySqlDbType.Int16);
            miComando.Parameters["@id_impresora"].Value = elImpresora.id_Impresora;

            miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            miComando.Parameters["@nombre"].Value = elImpresora.nombre;

            miComando.Parameters.Add("@tipo", MySqlDbType.VarChar);
            miComando.Parameters["@tipo"].Value = elImpresora.tipo;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_Impresora");

            return respuesta;
        }
        public string InactivarImpresora(Impresora elImpresora)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor InactivarImpresora");

            miComando.CommandText = "inactivar_impresora";

            miComando.Parameters.Add("@id_impresora", MySqlDbType.Int16);
            miComando.Parameters["@id_Impresora"].Value = elImpresora.id_Impresora;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizado correctamente la inactivacion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor InactivarImpresora ");
            return respuesta;
        }
        
        public string ConsultarImpresora(Impresora elImpresora)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor consultar_Impresora");

            miComando.CommandText = "consultar_impresora";

            miComando.Parameters.Add("@id_impresora", MySqlDbType.Int16);
            miComando.Parameters["@id_impresora"].Value = elImpresora.id_Impresora;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor consultar_Impresora");

            return respuesta;
        }

        public DataSet ConsultarImpresora(int Id_Impresora)
        {

            miComando.CommandText = "consultar_impresora";

            miComando.Parameters.AddWithValue("@id_impresora", MySqlDbType.Int16);
            miComando.Parameters["@id_impresora"].Value = Id_Impresora;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string ListarImpresoras(Impresora elImpresora)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_Impresora");

            miComando.CommandText = "listar_impresora";

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor listar_Impresora");

            return respuesta;
        }
        //Metodo Listar impresora
        public DataTable ListarImpresoras()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor listar_Impresora");

            miComando.CommandText = "listar_impresora";

            DataSet elImpresora = new DataSet();
            this.abrirConexion();
            elImpresora = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elImpresora.Tables[0];

            return miTablaDatos;
        }
        public DataSet Consultar_cantidadImpresoras()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Consultar_cantidadImpresoras");

            miComando.CommandText = "consultar_cantidadImpresoras";

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
        public DataSet Consultar_impresoraPredeterminada()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Consultar_impresoraPredeterminada");

            miComando.CommandText = "consultar_impresoraPredeterminada";

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        public string Establecer_impresoraPredeterminada(int id_impresora)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor establecer_impresoraPredeterminada");

            miComando.CommandText = "establecer_impresoraPredeterminada";

            miComando.Parameters.Add("@id_impresora", MySqlDbType.Int16);
            miComando.Parameters["@id_Impresora"].Value = id_impresora;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizado correctamente la inactivacion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor establecer_impresoraPredeterminada ");
            return respuesta;
        }

        public string Quitar_impresorasPredeterminadas()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Quitar_impresorasPredeterminadas");

            miComando.CommandText = "quitar_impresorasPredeterminadas";
            
            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "se ha realizado correctamente la inactivacion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Quitar_impresorasPredeterminadas");
            return respuesta;
        }
    }
}
