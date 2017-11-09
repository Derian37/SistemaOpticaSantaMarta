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
    /// Description of ServicioProducto.
    /// </summary>

    public class ServicioProducto : servicio, IDisposable
    {
        private string respuesta;
        private MySqlCommand miComando;

        public ServicioProducto()
        {
            respuesta = "";
            miComando = new MySqlCommand();
        }

        //Este metodo es solicitado por la interface IDisposable
        public void Dispose()
        {

        }

        //Metodo para la SP de insertar producto
        public string InsertarProducto(Producto elProducto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor insertar_producto");

            miComando.CommandText = "insertar_producto";

            miComando.Parameters.Add("@codigo", MySqlDbType.VarChar);
            miComando.Parameters["@codigo"].Value = elProducto.codigo;

            miComando.Parameters.Add("@nombre", MySqlDbType.VarChar);
            miComando.Parameters["@nombre"].Value = elProducto.nombre;

            miComando.Parameters.Add("@detalle", MySqlDbType.VarChar);
            miComando.Parameters["@detalle"].Value = elProducto.detalle;

            miComando.Parameters.Add("@monto", MySqlDbType.Float);
            miComando.Parameters["@monto"].Value = elProducto.monto;

            miComando.Parameters.Add("@cantidad", MySqlDbType.Int16);
            miComando.Parameters["@cantidad"].Value = elProducto.cantidad;

            miComando.Parameters.Add("@estado", MySqlDbType.VarChar);
            miComando.Parameters["@estado"].Value = elProducto.estado;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transaccion";

            Console.WriteLine(respuesta);
            Console.WriteLine("FIN Gestor Insertar Producto");

            return respuesta;

        }

        //metodo para la SP de Modificar Producto
        public string ModificarProducto(Producto elProducto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor modificar_producto");

            miComando.CommandText = "modificar_producto";

            miComando.Parameters.Add("@codi", MySqlDbType.VarChar);
            miComando.Parameters["@codi"].Value = elProducto.codig;

            miComando.Parameters.Add("@cod", MySqlDbType.VarChar);
            miComando.Parameters["@cod"].Value = elProducto.codigo;

            miComando.Parameters.Add("@nomb", MySqlDbType.VarChar);
            miComando.Parameters["@nomb"].Value = elProducto.nombre;

            miComando.Parameters.Add("@detal", MySqlDbType.VarChar);
            miComando.Parameters["@detal"].Value = elProducto.detalle;

            miComando.Parameters.Add("@mont", MySqlDbType.Float);
            miComando.Parameters["@mont"].Value = elProducto.monto;

            miComando.Parameters.Add("@cant", MySqlDbType.Int16);
            miComando.Parameters["@cant"].Value = elProducto.cantidad;

            miComando.Parameters.Add("@est", MySqlDbType.VarChar);
            miComando.Parameters["@est"].Value = elProducto.estado;


            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Modificar Producto");

            return respuesta;
        }

        //metodo para la SP de Inactivar Producto 
        public string InactivarProducto(Producto elProducto)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor InactivarProducto");

            miComando.CommandText = "inactivar_producto";

            miComando.Parameters.Add("@cod", MySqlDbType.VarChar);
            miComando.Parameters["@cod"].Value = elProducto.codigo;

            respuesta = this.ejecutaSentencia(miComando);

            if (respuesta == "")
                respuesta += "Se ha realizado correctamente la transacción";

            Console.WriteLine(respuesta);
            Console.WriteLine("Fin Gestor Inactivar Producto");

            return respuesta;
        }
        //metodo para el SP de Consultar Producto 
        public DataSet ConsultarProducto(string parametro)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarProducto");
            miComando.CommandText = "consultar_producto";

            miComando.Parameters.Add("@parametro", MySqlDbType.VarChar, 128).Value = parametro;
            //miComando.Parameters["@cod"].Value = cod;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //metodo para el SP de Consultar Producto por codigo
        public DataSet ConsultarProductoCodigo(string cod)
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarProducto");

            miComando.CommandText = "consultar_productoCodigo";

            miComando.Parameters.Add("@cod", MySqlDbType.VarChar,128).Value = cod;
            //miComando.Parameters["@cod"].Value = cod;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }
        //metodo para el SP de Consultar Producto por nombre
        public DataSet ConsultarProductoNombre(string nom)
        {
            string nomb = "%"+nom+"%";
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ConsultarProducto");

            miComando.CommandText = "consultar_productoNombre";

            miComando.Parameters.Add("@nomb", MySqlDbType.VarChar,128).Value = nomb;
            //miComando.Parameters["@nom"].Value = nom;

            DataSet miDataSet = new DataSet();
            this.abrirConexion();

            miDataSet = this.seleccionarInformacion(miComando);
            this.cerrarConexion();

            return miDataSet;
        }

        //Metodo Listar Usuario
        public DataTable ListarProductos()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarProductos");

            miComando.CommandText = "listar_productos";

            DataSet elProducto = new DataSet();
            this.abrirConexion();
            elProducto = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elProducto.Tables[0];

            return miTablaDatos;
        }
        //Metodo Listar Usuario
        public DataTable ListarProductosLentes()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarProductos");

            miComando.CommandText = "listar_productos_lentes";

            DataSet elProducto = new DataSet();
            this.abrirConexion();
            elProducto = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elProducto.Tables[0];

            return miTablaDatos;
        }
        //Metodo Listar Usuario
        public DataTable ListarProductosArmazon()
        {
            miComando = new MySqlCommand();
            Console.WriteLine("Gestor ListarProductos");

            miComando.CommandText = "listar_productos_Armazon";

            DataSet elProducto = new DataSet();
            this.abrirConexion();
            elProducto = this.seleccionarInformacion(miComando);
            DataTable miTablaDatos = elProducto.Tables[0];

            return miTablaDatos;
        }
    }
}
