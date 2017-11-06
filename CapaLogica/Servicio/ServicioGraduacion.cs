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
    public class ServicioGraduacion : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioGraduacion()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        public string ModificarGraduacionOD(Graduacion elGraduacion)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_graduacion_ojoDerecho");

            miComando.CommandText = "modificar_graduacion_ojoDerecho";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int64);
            miComando.Parameters["@id_cliente"].Value = elGraduacion.Id_cliente;

            miComando.Parameters.Add("@esp", MySqlDbType.Float);
            miComando.Parameters["@esp"].Value = elGraduacion.Esfera;

            miComando.Parameters.Add("@cil", MySqlDbType.Float);
            miComando.Parameters["@cil"].Value = elGraduacion.Cilindro;

            miComando.Parameters.Add("@eje", MySqlDbType.Int64);
            miComando.Parameters["@eje"].Value = elGraduacion.Eje;

            miComando.Parameters.Add("@adi", MySqlDbType.Float);
            miComando.Parameters["@adi"].Value = elGraduacion.Adiciones;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_graduacion_ojoDerecho");

            return respuesta;
        }

        public string ModificarGraduacionOI(Graduacion elGraduacion)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_graduacion_ojoIzquierdo");

            miComando.CommandText = "modificar_graduacion_ojoIzquierdo";

            miComando.Parameters.Add("@id_cliente", MySqlDbType.Int64);
            miComando.Parameters["@id_cliente"].Value = elGraduacion.Id_cliente;

            miComando.Parameters.Add("@esfe", MySqlDbType.Float);
            miComando.Parameters["@esfe"].Value = elGraduacion.Esfera;

            miComando.Parameters.Add("@cili", MySqlDbType.Float);
            miComando.Parameters["@cili"].Value = elGraduacion.Cilindro;

            miComando.Parameters.Add("@ejee", MySqlDbType.Int64);
            miComando.Parameters["@ejee"].Value = elGraduacion.Eje;

            miComando.Parameters.Add("@adis", MySqlDbType.Float);
            miComando.Parameters["@adis"].Value = elGraduacion.Adiciones;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor modificar_graduacion_ojoIzquierdo");

            return respuesta;
        }


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
    }
}
