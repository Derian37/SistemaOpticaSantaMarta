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
using System.Text.RegularExpressions;

namespace CapaPresentacion
{
    public partial class frmCitas : Form
    {
        string usuario;
        string buscar;
        string cargo;
        int id_usuario;
        //DataTable dtCita = new DataTable();
        //DataSet dsCita = new DataSet();
        DataTable dtCitas = new DataTable();
        DataSet dsCitas = new DataSet();

        public frmCitas(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
            usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }

        private void frmCitas_Load(object sender, EventArgs e)
        {
            cargarGridCitas();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmPrincipal frm_Principal = new frmPrincipal(id_usuario, usuario, cargo);
            frm_Principal.Show();
            this.SetVisibleCore(false);
        }
        //BUSCA UNA CITA REGISTRADA
        private void btn_buscarCita_Click(object sender, EventArgs e)
        {
            this.buscar = txt_valor_Cita.Text;
            txt_CedulaUsuario.Enabled = false;
            btn_guardarCita.Visible = false;
            lbl_guardarCita.Visible = false;


            using (GestorCita Cita = new GestorCita())
            {
                

                if (string.IsNullOrWhiteSpace(txt_valor_Cita.Text))
                {
                    MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    if (rbtn_CedulaCita.Checked == true)
                    {
                        if (!Regex.IsMatch(buscar, @"^[\p{L}]+$"))
                        {

                            this.dsCitas = Cita.ConsultarCitaCedula(buscar);
                            this.dtCitas = this.dsCitas.Tables[0];
                            txt_CedulaUsuario.Enabled = false;
                            gbx_datosCita.Visible = true;
                            btn_EliminarCita.Visible = true;
                            lbl_editarCita.Visible = true;
                            lbl_eliminarCita.Visible = true;
                            btn_EditarCita.Visible = true;
                            gbx_datosCita.Enabled = true;
                        }
                        else
                        {
                            MessageBox.Show("Solo permiten numeros(Cedula), cambie la seleccion de busqueda!", "Error de busqueda!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_valor_Cita.Text = "";
                        }
                    }
                    else
                    {
                        //if (Regex.IsMatch(buscar, @"[A-Z][a-zA-Z\s\'-]*"))
                       // {
                            this.dsCitas = Cita.ConsultarCitaNombre(buscar);
                            this.dtCitas = this.dsCitas.Tables[0];
                            gbx_datosCita.Visible = true;
                            btn_EliminarCita.Visible = true;
                            btn_EditarCita.Visible = true;
                            lbl_editarCita.Visible = true;
                            lbl_eliminarCita.Visible = true;
                            gbx_datosCita.Enabled = true;    
                        //}
                       /* else
                        {
                            //buscar.SetError(buscar, "Only use alphabates");
                            MessageBox.Show("Solo puede se permiten letras(Nombre), cambie la seleccion de busqueda!", "Error de busqueda!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }*/

                    }
                CargarDatosCita();
                }

            }
            
        }

        private void CargarDatosCita()
        {
            txt_CedulaUsuario.Text = this.dtCitas.Rows[0]["cedula"].ToString();
            txt_nombreUsuario.Text = this.dtCitas.Rows[0]["nombre_paciente"].ToString();
            txt_telefonoUsuario.Text = this.dtCitas.Rows[0]["telefono"].ToString();
            txt_detalleCita.Text = this.dtCitas.Rows[0]["detalle"].ToString();
            String fecha1 = dtCitas.Rows[0]["fecha"].ToString();
            DateTime dt = Convert.ToDateTime(fecha1);
            dtpFechaCita.Value = dt;
            

        }
        //INSERTA UNA CITA
        private void btn_InsertarCita_Click(object sender, EventArgs e)
        {
            limpiarCamposCita();
            gbx_datosCita.Visible = true;
            gbx_datosCita.Enabled = true;
            grb_menuCita.Visible = false;
            btn_guardarCita.Visible = true;
            lbl_guardarCita.Visible = true;
            btn_EditarCita.Visible = false;
            lbl_editarCita.Visible = false;
            btn_EliminarCita.Visible = false;
            lbl_eliminarCita.Visible = false;
            

        }
        //EDITAR UNA CITA
        private void btn_EditarCita_Click(object sender, EventArgs e)
        {   
            //Ejecuta la accion mas no modifica
            //gbx_datosCita.Visible = true;
            //gbx_datosCita.Enabled = true;
            string ced = txt_CedulaUsuario.Text;



            if (string.IsNullOrWhiteSpace(txt_CedulaUsuario.Text) || string.IsNullOrWhiteSpace(txt_nombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txt_telefonoUsuario.Text) || string.IsNullOrWhiteSpace(txt_detalleCita.Text))
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                using (GestorCita Cita = new GestorCita())
                {
                    Cita.ModificarCita(ced, txt_CedulaUsuario.Text, txt_nombreUsuario.Text, txt_telefonoUsuario.Text, txt_detalleCita.Text, Convert.ToDateTime(dtpFechaCita.Value), "A");
                    
                }

                bloquearCamposCita();
                MessageBox.Show("Datos Modificados Satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                gbx_datosCita.Visible = false;
                limpiarCamposCita();
                cargarGridCitas();
                grb_menuCita.Visible = true;

            }
        }
        //ELIMINA UNA CITA
        private void btn_EliminarCita_Click(object sender, EventArgs e)
        {
            //Ejecuta la accion mas no inactiva el valor
            gbx_datosCita.Visible = true;
            gbx_datosCita.Enabled = true;
            if (string.IsNullOrWhiteSpace(txt_CedulaUsuario.Text))
            {
                MessageBox.Show("Campo Cedula vacio, llene el campo correspondiente!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                using (GestorCita elGestorCita = new GestorCita())
                {
                

                    DialogResult result = MessageBox.Show("¿Desea eliminar la cita?", "Confirmacion", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        elGestorCita.InactivarCita(txt_CedulaUsuario.Text.ToString());
                        bloquearCamposCita();
                        MessageBox.Show("Datos Registrados Eliminados satifactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        gbx_datosCita.Visible = false;
                        limpiarCamposCita();
                        cargarGridCitas();
                        grb_menuCita.Visible = true;
                    }
                    

                    

                    
                    
                }
            }
                
        }

        private void cargarGridCitas()
        {
            using (GestorCita cita = new GestorCita())
            {
                dgvCitas.DataSource = cita.ListarCitas();

                dgvCitas.Columns["id_consulta"].Visible = false;
                dgvCitas.Columns["cedula"].HeaderText = "CEDULA";
                dgvCitas.Columns["nombre_paciente"].HeaderText = "NOMBRE";
                dgvCitas.Columns["telefono"].HeaderText = "TELEFONO";
                dgvCitas.Columns["detalle"].HeaderText = "DETALLE";
                dgvCitas.Columns["fecha"].HeaderText = "FECHA";
                dgvCitas.Columns["estado"].Visible = false;
            }
        }
        //GUARDA UNA CITA 
        private void btn_guardarCita_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txt_CedulaUsuario.Text) || string.IsNullOrWhiteSpace(txt_nombreUsuario.Text) ||
                string.IsNullOrWhiteSpace(txt_telefonoUsuario.Text) || string.IsNullOrWhiteSpace(txt_detalleCita.Text))
                MessageBox.Show("Hay Uno o mas Campos Vacios!", "Campos Vacios!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            else
            {
                try {
                    using (GestorCita Cita = new GestorCita())
                    {
                        
                        string cedula = txt_CedulaUsuario.Text;
                        this.dsCitas = Cita.ConsultarCitaCedula(cedula);
                        this.dtCitas = this.dsCitas.Tables[0];
                        if (dtCitas.Rows.Count > 0)
                        {
                            MessageBox.Show("Ya existe un usuario con esa cedula, intente de nuevo", "Fallo", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            
                            Cita.InsertarCita(txt_CedulaUsuario.Text, txt_nombreUsuario.Text, txt_telefonoUsuario.Text, txt_detalleCita.Text, dtpFechaCita.Value, "A");

                            bloquearCamposCita();
                            MessageBox.Show("Datos Registrados satisfactoriamente", "EXITO", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            gbx_datosCita.Visible = false;
                            limpiarCamposCita();
                            cargarGridCitas();
                            grb_menuCita.Visible = true;
                        }

                    }

                }
                catch (Exception x)
                {
                    MessageBox.Show("Error de SQL: " + x.Message);
                }
               
                
            }
        }

        //Metodo que bloquea campos para usuarios no administradores
        private void bloquearCamposCita()
        {
            txt_CedulaUsuario.Enabled = false;
            txt_nombreUsuario.Enabled = false;
            txt_telefonoUsuario.Enabled = false;
            txt_detalleCita.Enabled = false;
            dtpFechaCita.Enabled = false;
        }
        private void limpiarCamposCita()
        {
            txt_CedulaUsuario.Enabled = true;
            txt_nombreUsuario.Enabled = true;
            txt_telefonoUsuario.Enabled = true;
            txt_detalleCita.Enabled = true;
            dtpFechaCita.Enabled = true;
            txt_valor_Cita.Text = "";
            txt_CedulaUsuario.Text = "";
            txt_nombreUsuario.Text = "";
            txt_telefonoUsuario.Text = "";
            txt_detalleCita.Text = "";
            dtpFechaCita.Value = DateTime.Today;
        }

        void txt_valor_Cita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtn_CedulaCita.Checked == true)
            {   
                //Solo permite numeros
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                //Solo permite letras y espacios en blanco
                
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;

            }
        }

        private void txt_CedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txt_telefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Solo permite numeros
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        //No permite caracteres especiales, solo caracteres alfanumericos
        private void txt_detalleCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
