using ProyectoOptica.CapaIntegracion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmNuevaTargea : Form
    {
        int id_usuario;
        string id_cliente;
        string usuario;
        string cargo;

        public frmNuevaTargea(int id_usuario, string id_cliente,  string usuario, string cargo)
        {
            this.id_usuario = id_usuario;
            this.id_cliente = id_cliente;
            this.usuario = usuario;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void cargarCombos()
        {
            try
            {
                using (GestorProducto elLente = new GestorProducto())
                {
                    cbx_Prod_Lentes.DataSource = elLente.ListarProductosLentes();
                    cbx_Prod_Lentes.ValueMember = "id_productos";
                    cbx_Prod_Lentes.DisplayMember = "nombre";
                    label21.Text = (string)elLente.ListarProductosLentes().Rows[0][4].ToString();
                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }

            try
            {
                using (GestorProducto elArmazon = new GestorProducto())
                {
                    cbx_Prod_Armazon.DataSource = elArmazon.ListarProductosArmazon();
                    cbx_Prod_Armazon.ValueMember = "id_productos";
                    cbx_Prod_Armazon.DisplayMember = "nombre";
                    label22.Text = (string)elArmazon.ListarProductosArmazon().Rows[0][4].ToString();

                }

            }

            catch (Exception e)
            {
                MessageBox.Show("Error de SQL: " + e.Message);
            }
        }

        private void cargarInformacionCliente()
        {
            lbl_usuer.Text = usuario;
            lbl_Cargo.Text = cargo;
            txt_doctor.Text = usuario;
            int Id_cliente = int.Parse(id_cliente);

            using (GestorCliente Cliente = new GestorCliente())
            {
                lblUNombre.Text = (string)Cliente.ConsultarCliente(Id_cliente).Tables[0].Rows[0][2];
                lblDireccion.Text = (string)Cliente.ConsultarCliente(Id_cliente).Tables[0].Rows[0][5];
                lblTelefono.Text = (string)Cliente.ConsultarCliente(Id_cliente).Tables[0].Rows[0][6];
                lblCedula.Text = (string)Cliente.ConsultarCliente(Id_cliente).Tables[0].Rows[0][1];
            }



        }

        private void grbPanelUsuario_Enter(object sender, EventArgs e)
        {

        }

        private void frmNuevaTargea_Load_1(object sender, EventArgs e)
        {

            cargarInformacionCliente();
            cargarCombos();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            
        }

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpediente frm_Expediente = new frmExpediente(id_usuario, usuario, cargo);
            frm_Expediente.Show();
            this.SetVisibleCore(false);
        }

        private void btn_Crear_Click(object sender, EventArgs e)
        {
            int Id_cliente = int.Parse(id_cliente);
            using (GestorTarjeta elTarjeta = new GestorTarjeta())
            {
                elTarjeta.InsertarTarjeta(Id_cliente, int.Parse(cbx_Prod_Lentes.SelectedValue.ToString()), txt_armason.Text, int.Parse(cbx_Prod_Armazon.SelectedValue.ToString()), txt_lente.Text, dateTimePicker1.Value, dateTimePicker1.Value,double.Parse(txt_DI.Text), txt_recibida.Text, double.Parse(txt_Seg.Text));
            }
            MessageBox.Show("¡ Se han guardado los Datos ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            cargarCombos();
           
        }

 
    }
}
