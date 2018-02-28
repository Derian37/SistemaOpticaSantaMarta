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
    public partial class frmNuevaTarjeta : Form
    {
        bool bandera = true;
        private int graduacion;
        int id_usuario;
        string id_cliente;
        string usuario;
        string cargo;

        public int Graduacion { get => graduacion; set => graduacion = value; }

        public frmNuevaTarjeta(int id_usuario, string id_cliente,  string usuario, string cargo)
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
            dgvtargeta.Rows.Add("", "", "", "");
            dgvtargeta.Rows.Add("", "", "", "");
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
            label20.Text = bandera.ToString();
           
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
            guardar();
        }

        private void guardar()
        {

            int Id_cliente = int.Parse(id_cliente);
            try
                {
                if (txt_armason.Text !="" && txt_DI.Text!=""&& txt_lente.Text !="" && txt_Seg.Text!="") {
                    using (GestorTarjeta elTarjeta = new GestorTarjeta())
                    {
                        elTarjeta.InsertarTarjeta(Id_cliente, int.Parse(cbx_Prod_Lentes.SelectedValue.ToString()), txt_armason.Text, int.Parse(cbx_Prod_Armazon.SelectedValue.ToString()), txt_lente.Text, dateTimePicker1.Value, dateTimePicker1.Value, txt_DI.Text, cbx_recibido.SelectedItem.ToString(), double.Parse(txt_Seg.Text)
                            , float.Parse(dgvtargeta.Rows[1].Cells[0].Value.ToString()), float.Parse(dgvtargeta.Rows[1].Cells[1].Value.ToString()), int.Parse(dgvtargeta.Rows[1].Cells[2].Value.ToString()), float.Parse(dgvtargeta.Rows[1].Cells[3].Value.ToString()), float.Parse(dgvtargeta.Rows[0].Cells[0].Value.ToString()), float.Parse(dgvtargeta.Rows[0].Cells[1].Value.ToString()), int.Parse(dgvtargeta.Rows[0].Cells[2].Value.ToString()), float.Parse(dgvtargeta.Rows[0].Cells[3].Value.ToString()));
                    }
                    MessageBox.Show("¡ Se han guardado los Datos ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    frmExpediente volver = new frmExpediente(id_usuario, usuario, cargo);
                    volver.Show();
                    this.SetVisibleCore(false);
                }
                else
                {
                    MessageBox.Show("¡ Faltan datos que llenar ! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
                catch (Exception h)
                {
                  MessageBox.Show(h.ToString(), "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                    cargarCombos();
        }

        private void CrearGraduacion()
        {
           
            if (dgvtargeta.Rows[0].Cells[0].Value.ToString() != "" || dgvtargeta.Rows[0].Cells[1].Value.ToString() != "" || dgvtargeta.Rows[0].Cells[2].Value.ToString() != "" || dgvtargeta.Rows[0].Cells[3].Value.ToString() != "" || dgvtargeta.Rows[1].Cells[0].Value.ToString() != "" || dgvtargeta.Rows[1].Cells[1].Value.ToString() != "" || dgvtargeta.Rows[1].Cells[2].Value.ToString() != "" || dgvtargeta.Rows[1].Cells[3].Value.ToString() != "")
            {
                try
                {

                    using (GestorGraduacion elGraduacion = new GestorGraduacion())
                    {
                        
                    }
                    using (GestorGraduacion elGraduacion = new GestorGraduacion())
                    {
                        Graduacion = int.Parse(elGraduacion.UltimaGraduacion().Tables[0].Rows[0][0].ToString());
                    }
                    bandera = false;
                    label20.Text = bandera.ToString();
                   
                }
                catch (Exception y)
                {
                    MessageBox.Show("¡ Error al ingresar dato, dato debe ser un numero entero, en los ejes! ", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Console.Write(y);
                }
            }
        
        }

        private void frmNuevaTargea_FormClosing(object sender, FormClosingEventArgs e)
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

        private void frmNuevaTarjeta_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dgvtargeta.Rows[0].Cells[0].Value.ToString() != "" && dgvtargeta.Rows[0].Cells[1].Value.ToString() != "" && 
                dgvtargeta.Rows[0].Cells[2].Value.ToString() != "" && dgvtargeta.Rows[0].Cells[3].Value.ToString() != "" && 
                dgvtargeta.Rows[1].Cells[0].Value.ToString() != "" && dgvtargeta.Rows[1].Cells[1].Value.ToString() != "" && 
                dgvtargeta.Rows[1].Cells[2].Value.ToString() != "" && dgvtargeta.Rows[1].Cells[3].Value.ToString() != "" &&
                txt_DI.Text !="" && txt_Seg.Text !="" && cbx_Prod_Lentes.SelectedValue.ToString()!="" && 
                cbx_Prod_Armazon.SelectedValue.ToString() !="" && cbx_recibido.Text.ToString() !="" && dateTimePicker1.Value != null)
            {
                btn_Crear.Enabled = true;
                btn_Crear.BackColor = Color.Gold;
            }
            else
            {
                MessageBox.Show("¡ Debe llenar todos los datos necesarios! ", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btn_Crear.Enabled = false;
            }
        }
    }
}
