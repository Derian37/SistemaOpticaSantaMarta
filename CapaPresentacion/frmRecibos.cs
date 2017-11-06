using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoOptica.CapaConexion;
using ProyectoOptica.CapaIntegracion;
using ProyectoOptica.CapaLogica.Servicio;
using CapaLogica.LogicaNegocio;

namespace CapaPresentacion
{
    public partial class frm_Recibos : Form
    {
        private string usuario;
        private int id_usuario;
        private string cargo;
        private int id_cliente;
        private int abono = 0;
        private string ultimoRecibo;
        string aux2 = "";
        private int deuda;
        private DataTable dtCliente = new DataTable();
        private DataSet dsCliente = new DataSet();
        private DataTable dtRecibo = new DataTable();
        private DataSet dsRecibo = new DataSet();
        private DataTable dtUsuario = new DataTable();
        private DataSet dsUsuario = new DataSet();

        public frm_Recibos(int id_usuario, string usuario, string cargo)
        {
            InitializeComponent();
            cargarNumeroRecibo();
            this.id_usuario = id_usuario;
            lbl_usuarioNombre.Text = this.usuario = usuario;
            this.cargo = cargo;
        }

        private void cargarNumeroRecibo()
        {
            using (GestorRecibo recibo = new GestorRecibo())
            {
                dsRecibo = recibo.ConsultarUltimoRecibo();
                dtRecibo = this.dsRecibo.Tables[0];

                ultimoRecibo = this.dtRecibo.Rows[0]["siguiente"].ToString();
                lbl_numeroRecibo.Text = ultimoRecibo;
            }
        }

        private void btn_buscarCliente_Click(object sender, EventArgs e)
        {
            string buscar = txt_clienteCedula.Text;
            try
            {
                using (GestorCliente cliente = new GestorCliente())
                {
                    string cedula = txt_clienteCedula.Text;
                    this.dsCliente = cliente.ConsultarClienteCedula(cedula);
                    this.dtCliente = this.dsCliente.Tables[0];

                    id_cliente = int.Parse(this.dtCliente.Rows[0]["id_cliente"].ToString());
                    string nombre = this.dtCliente.Rows[0]["nombre"].ToString();
                    string ape1 = this.dtCliente.Rows[0]["apellido1"].ToString();
                    string ape2 = this.dtCliente.Rows[0]["apellido2"].ToString();
                    deuda = int.Parse(this.dtCliente.Rows[0]["deuda"].ToString());
                    txt_saldoAnteriorRecibo.Text = deuda.ToString();

                    txt_nombreCliente.Text = nombre + " " + ape1 + " " + ape2;

                }
            }
            catch (Exception x)
            {
                MessageBox.Show("No se encontraron resultados ","Busqueda",MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_Recibos_FormClosing(object sender, FormClosingEventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
            principal.Show();
        }

        private void btn_ImprimirRecibo_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(txt_clienteCedula.Text) || string.IsNullOrWhiteSpace(txt_montoDigitos.Text) ||
                string.IsNullOrWhiteSpace(txt_conceptoRecibo.Text) || string.IsNullOrWhiteSpace(dtp_fechaRecibo.Text)
                || string.IsNullOrWhiteSpace(txt_saldoActualRecibo.Text))
                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                else
                {
                    using (GestorRecibo recibo = new GestorRecibo())
                    {
                        recibo.InsertarRecibo(dtp_fechaRecibo.Value, id_cliente, id_usuario, txt_conceptoRecibo.Text.ToUpper(), float.Parse(txt_saldoAnteriorRecibo.Text), float.Parse(txt_abonoRecibo.Text), float.Parse(txt_saldoActualRecibo.Text));
                    }
                    bloquearCamposRecibo();
                    MessageBox.Show("Datos Registrados Satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    limpiarCamposRecibo();
                    MessageBox.Show("¡ Impresión En Contrucción ¡", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                
            }
            catch (Exception x)
            {
                MessageBox.Show("Error de SQL: " + x.Message);
            }
        }

        private void txt_montoDigitos_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
            else
            {
                string aux = e.KeyChar.ToString();

                aux2 = string.Concat(aux2, aux);
                abono = int.Parse(aux2);
                txt_abonoRecibo.Text = aux2;
                int saldoAct = deuda - abono;
                txt_saldoActualRecibo.Text = saldoAct.ToString();
            }
        }

        /// <summary>
        /// Metodo que bloquea los campos para evitar modificaciones de usuarios que no sean administradores.
        /// </summary>
        private void bloquearCamposRecibo()
        {
            txt_clienteCedula.Enabled = false;
            txt_nombreCliente.Enabled = false;
            txt_montoLetras.Enabled = false;
            txt_montoDigitos.Enabled = false;
            txt_conceptoRecibo.Enabled = false;
            txt_saldoActualRecibo.Enabled = false;
            txt_saldoAnteriorRecibo.Enabled = false;
            txt_abonoRecibo.Enabled = false;
            dtp_fechaRecibo.Enabled = false;
        }
        private void desbloquearCamposRecibo()
        {
            txt_clienteCedula.Enabled = true;
            txt_nombreCliente.Enabled = true;
            txt_montoLetras.Enabled = true;
            txt_montoDigitos.Enabled = true;
            txt_conceptoRecibo.Enabled = true;
            txt_saldoActualRecibo.Enabled = true;
            txt_saldoAnteriorRecibo.Enabled = true;
            txt_abonoRecibo.Enabled = true;
            dtp_fechaRecibo.Enabled = true;
        }
        private void limpiarCamposRecibo()
        {
            txt_clienteCedula.Text = "";
            txt_nombreCliente.Text = "";
            txt_montoLetras.Text = "";
            txt_montoDigitos.Text = "";
            txt_conceptoRecibo.Text = "";
            txt_saldoActualRecibo.Text = "";
            txt_saldoAnteriorRecibo.Text = "";
            txt_abonoRecibo.Text = "";
        }

        private void txt_clienteCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;

            }
        }
    }
}
