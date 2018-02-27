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
    public partial class frmTarjeta : Form
    {
        int id_usuario;
        string id_cliente;
        string usuario;
        string cargo;
      
        public frmTarjeta(int id_usuario, string id_cliente, string usuario, string cargo)
        {
            this.id_usuario = id_usuario;
            this.id_cliente = id_cliente;
            this.usuario = usuario;
            this.cargo = cargo;
           
            InitializeComponent();
        }

        private void frm_Tarjeta_Load(object sender, EventArgs e)
        {
            cargarNombres();
            cargarInformacionCliente();
            cargarGridgraduacionDatos();
            cargarCombos();
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

        private void cargarGridgraduacionDatos()
        {
                using (GestorGraduacion graduacion = new GestorGraduacion())
                {
                    dgvtargeta.DataSource = graduacion.ConsultarGraduacion(id_cliente);
                }
                using (GestorTarjeta tarjeta = new GestorTarjeta()) {
                    txt_DI.Text = tarjeta.ConsultarTarjeta(int.Parse(id_cliente)).Tables[0].Rows[0][0].ToString();
                    txt_Seg.Text = tarjeta.ConsultarTarjeta(int.Parse(id_cliente)).Tables[0].Rows[0][1].ToString();
                    txt_lente.Text = tarjeta.ConsultarTarjeta(int.Parse(id_cliente)).Tables[0].Rows[0][5].ToString();
                    txt_armason.Text = tarjeta.ConsultarTarjeta(int.Parse(id_cliente)).Tables[0].Rows[0][3].ToString();
                    cbx_recibido.SelectedItem = tarjeta.ConsultarTarjeta(int.Parse(id_cliente)).Tables[0].Rows[0][7].ToString();
                    txt_fecha.Text = tarjeta.ConsultarTarjeta(int.Parse(id_cliente)).Tables[0].Rows[0][6].ToString();
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

        private void volverToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmExpediente frm_Expediente = new frmExpediente(id_usuario,usuario, cargo);
            frm_Expediente.Show();
            this.SetVisibleCore(false);
        }

        private void lblUNombre_Click(object sender, EventArgs e)
        {

        }

        void cargarNombres()
        {
           
            
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Guardar();
        }

        private void Guardar()
        {
            try
            {
                if (txt_armason.Text != "" && txt_DI.Text != "" && txt_lente.Text != "" && cbx_recibido.SelectedItem.ToString() != "" && txt_Seg.Text != "" && txt_fecha.Text != "")
                {
                    using (GestorTarjeta elTargeta = new GestorTarjeta())
                    {
                        elTargeta.ModificarTarjeta(int.Parse(id_cliente), int.Parse(cbx_Prod_Lentes.SelectedValue.ToString()), txt_armason.Text, int.Parse(cbx_Prod_Armazon.SelectedValue.ToString()), txt_lente.Text, dateTimePicker1.Value, dateTimePicker1.Value, txt_DI.Text, cbx_recibido.SelectedItem.ToString(), double.Parse(txt_Seg.Text),  float.Parse(dgvtargeta.Rows[1].Cells[0].Value.ToString()), float.Parse(dgvtargeta.Rows[1].Cells[1].Value.ToString()), int.Parse(dgvtargeta.Rows[1].Cells[2].Value.ToString()), float.Parse(dgvtargeta.Rows[1].Cells[3].Value.ToString()), float.Parse(dgvtargeta.Rows[0].Cells[0].Value.ToString()), float.Parse(dgvtargeta.Rows[0].Cells[1].Value.ToString()), int.Parse(dgvtargeta.Rows[0].Cells[2].Value.ToString()), float.Parse(dgvtargeta.Rows[0].Cells[3].Value.ToString()));

                    }

                   
                    MessageBox.Show("¡ Se han guardado los Datos ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    cargarGridgraduacionDatos();
                }
                else
                {
                    MessageBox.Show("¡ Debe rellenar todos los espacios ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                cargarGridgraduacionDatos();
                cargarCombos();
            }
            catch(Exception j) {
                Console.Write(j);
            }
        }

        private void label7_Click_1(object sender, EventArgs e)
        {

        }

        private void groupBox5_Enter(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

        }

        private void label19_Click(object sender, EventArgs e)
        {

        }

        private void frmTarjeta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void dgvtargeta_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            MessageBox.Show("¡ Error al ingresar dato, dato debe ser un numero entero ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);


            if (e.Context == DataGridViewDataErrorContexts.Commit)
            {
                MessageBox.Show("¡ Error al ingresar dato, dato debe ser un numero entero ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Context == DataGridViewDataErrorContexts.CurrentCellChange)
            {
                MessageBox.Show("¡ Error al ingresar dato, dato debe ser un numero entero! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Context == DataGridViewDataErrorContexts.Parsing)
            {
                MessageBox.Show("¡ Error al ingresar dato, dato debe ser un numero entero ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            if (e.Context == DataGridViewDataErrorContexts.LeaveControl)
            {
                MessageBox.Show("¡ Error al ingresar dato, dato debe ser un numero entero ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            if ((e.Exception) is ConstraintException)
            {
                DataGridView view = (DataGridView)sender;
                view.Rows[e.RowIndex].ErrorText = "an error";
                view.Rows[e.RowIndex].Cells[e.ColumnIndex].ErrorText = "an error";

                e.ThrowException = false;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Imprimir();
        }

        private void Imprimir()
        {
            //if (textBox1.Text != "")
            //{
            dgvtemp.Rows[0].Cells[0].Value = dgvtargeta.Rows[1].Cells[0].Value.ToString();
            dgvtemp.Rows[0].Cells[1].Value = dgvtargeta.Rows[1].Cells[1].Value.ToString();
            dgvtemp.Rows[0].Cells[2].Value = dgvtargeta.Rows[1].Cells[2].Value.ToString();
            dgvtemp.Rows[0].Cells[3].Value = dgvtargeta.Rows[1].Cells[3].Value.ToString();
            dgvtemp.Rows[0].Cells[4].Value = dgvtargeta.Rows[0].Cells[0].Value.ToString();
            dgvtemp.Rows[0].Cells[5].Value = dgvtargeta.Rows[0].Cells[1].Value.ToString();
            dgvtemp.Rows[0].Cells[6].Value = dgvtargeta.Rows[0].Cells[2].Value.ToString();
            dgvtemp.Rows[0].Cells[7].Value = dgvtargeta.Rows[0].Cells[3].Value.ToString();
            dgvtemp.Rows[0].Cells[8].Value = lblUNombre.Text;
            dgvtemp.Rows[0].Cells[9].Value = cbx_Prod_Armazon.Text;
            dgvtemp.Rows[0].Cells[10].Value = txt_armason.Text;
            dgvtemp.Rows[0].Cells[11].Value = cbx_Prod_Lentes.Text;
            dgvtemp.Rows[0].Cells[12].Value = txt_lente.Text;
            dgvtemp.Rows[0].Cells[13].Value = dateTimePicker1.Value.ToString();
            dgvtemp.Rows[0].Cells[14].Value = txt_fecha.Text; 
            dgvtemp.Rows[0].Cells[15].Value = txt_DI.Text;
            dgvtemp.Rows[0].Cells[16].Value = cbx_recibido.Text;
            dgvtemp.Rows[0].Cells[17].Value = txt_Seg.Text;
            frmImpresionTarjeta reporte = new frmImpresionTarjeta(dgvtemp,id_usuario,usuario,cargo);
            reporte.Show();
            this.SetVisibleCore(false);
       }

        private void dgvtemp_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
