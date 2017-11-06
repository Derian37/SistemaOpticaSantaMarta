using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ProyectoOptica.CapaConexion;
using CapaLogica.LogicaNegocio;
using CapaLogica.Servicio;

namespace ProyectoOptica.CapaIntegracion
{
    public class GestorCliente : servicio, IDisposable

    {
        public GestorCliente() { }

        public void Dispose() { }

        public string InsertarCliente(string cedula, string nombre, string apellido1, string apellido2, string direccion, string telefono, int deuda)
        {
            Cliente nuevoCliente = new Cliente(cedula, nombre, apellido1, apellido2, direccion, telefono, deuda);
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.InsertarCliente(nuevoCliente);
        }

        public string ModificarCliente(int id_cliente, string cedula, string nombre, string apellido1, string apellido2, string direccion, string telefono, int deuda)
        {
            Cliente nuevoCliente = new Cliente(id_cliente, cedula, nombre, apellido1, apellido2, direccion, telefono, deuda);
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ModificarCliente(nuevoCliente);
        }

        /* public string InactivarCliente(int id_cliente)
         {
             Cliente nuevoCliente = new Cliente(id_cliente);

             using (ServicioCliente elCliente = new ServicioCliente())
                 return elCliente.InactivarCliente(nuevoCliente);
         }*/

        public string ListarCliente(int Estudiante_id)

        {
            Cliente nuevoCliente = new Cliente();

            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ListarCliente(nuevoCliente);
        }
        public DataSet ConsultarCliente(int id_cliente)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ConsultarCliente(id_cliente);
        }

        public DataSet ConsultarClienteCedula(string cedula)
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ConsultarClienteCedula(cedula);
        }

        public DataTable ListarCliente()
        {
            using (ServicioCliente elCliente = new ServicioCliente())
                return elCliente.ListarCliente();
        }
    }
}
