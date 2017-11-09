﻿using System;
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
    /// <summary>
    /// Description of ServicioReporte.
    /// </summary>

    public class ServicioReporte : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioReporte()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }
        //metodo para el SP de Consultar Reporte por codigo
        public DataSet ReporteSemanal(string fecha1, string fecha2)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor Reporte Semanal");

            miComando.CommandText = "reporte_ventas_semanal";

            miComando.Parameters.Add("@fecha1", MySqlDbType.VarChar,48).Value = fecha1;
            //miComando.Parameters["@cod"].Value = cod;
            miComando.Parameters.Add("@fecha2", MySqlDbType.VarChar, 48).Value = fecha2;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
        
    }
}
