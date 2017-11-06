using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;
using ProyectoOptica.CapaLogica.Servicio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorUsuario : servicio, IDisposable
    {
        public GestorUsuario() { }

        public void Dispose() { }

        /// <summary>
        /// Metodo Insertar Usuario
        /// </summary>
        /// <param name="Usuario_cedula"></param>
        /// <param name="Usuario_nombre"></param>
        /// <param name="Usuario_contrasena"></param>
        /// <returns></returns>
        public string InsertarUsuario(string cedula, string nombre, string contrasenna, string cargo, string estado)
        {
            Usuario nuevoUsuario = new Usuario(cedula, nombre, contrasenna, cargo, estado);
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.InsertarUsuario(nuevoUsuario);
        }
        /// <summary>
        /// Metodo Modificar Usuario
        /// </summary>
        /// <param name="Usuario_cedula"></param>
        /// <param name="Usuario_nombre"></param>
        /// <param name="Usuario_contrasena"></param>
        /// <returns></returns>
        public string ModificarUsuario(int id_usuario, string cedula, string nombre, string contrasenna, string cargo, string estado)
        {
            Usuario modificarUsuario = new Usuario(id_usuario, cedula, nombre, contrasenna, cargo, estado);
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.ModificarUsuario(modificarUsuario);
        }
        /// <summary>
        /// Metodo Inactivar Usuario
        /// </summary>
        /// <param name="Usuario_cedula"></param>
        /// <returns></returns>
        public string InactivarUsuario(string cedula)
        {
            Usuario inactivarUsuario = new Usuario(cedula);
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.InactivarUsuario(inactivarUsuario);
        }

        /// <summary>
        /// Metodo Consultar Usuario
        /// </summary>
        /// <param name="Usuario_cedula"></param>
        /// <returns></returns>
        public DataSet ConsultarUsuario(string cedula)
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.ConsultarUsuario(cedula);
        }

        /// <summary>
        /// Metodo Listar Usuarios
        /// </summary>
        /// <returns></returns>
     	public DataTable ListarUsuarios()
        {
            using (ServicioUsuario elUsuario = new ServicioUsuario())
                return elUsuario.ListarUsuarios();
        }

    }
}

