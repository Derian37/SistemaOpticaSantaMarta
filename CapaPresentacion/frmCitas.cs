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
        DataTable dtCitas = new DataTable();
        DataSet dsCitas = new DataSet();
        /// <summary>
        /// Metodo que inicializa el form con el nombre del que inicia sesion y ademas con su cargo respectivo
        /// </summary>
        /// <param name="id_usuario"></param>
        /// <param name="nombre"></param>
        /// <param name="cargo"></param>
        public frmCitas(int id_usuario, string nombre, string cargo)
        {
            this.id_usuario = id_usuario;
            usuario = nombre;
            this.cargo = cargo;
            InitializeComponent();
        }
        /// <summary>
        /// Metodo que carga el form y utiliza los metodos cargargridcitas y cargargridcitas recientes desde que se accede a el
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCitas_Load(object sender, EventArgs e)
        {
            cargarGridCitas();
            cargarGridCitasRecientes();
        }
        /// <summary>
        /// Metodo que vuelve al form principal
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmPrincipal frm_Principal = new frmPrincipal(id_usuario, usuario, cargo);
            frm_Principal.Show();
            this.SetVisibleCore(false);
        }
        /// <summary>
        /// Metodo que busca una cita independientemente de la opcion de busqueda de acuerdo a los radiobutton
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_buscarCita_Click(object sender, EventArgs e)
        {
            buscar = txt_valor_Cita.Text;
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
                        DataColumn[] columns = dtCitas.Columns.Cast<DataColumn>().ToArray();
                        bool existe = dtCitas.AsEnumerable().Any(row => columns.Any(col => row["cedula"].ToString() == txt_valor_Cita.Text.Trim()));
                        if (existe)
                        {
                            if (!Regex.IsMatch(buscar, @"^[\p{L}]+$"))
                            {
                                this.dsCitas = Cita.ConsultarCitaCedula(buscar);
                                this.dtCitas = this.dsCitas.Tables[0];
                                CargarDatosCita();
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
                            MessageBox.Show("El valor de busqueda no existe!", "Error de busqueda!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_valor_Cita.Text = "";
                        }
                    }
                    else
                    {
                       DataColumn[] columns = dtCitas.Columns.Cast<DataColumn>().ToArray();
                       bool existe1 = dtCitas.AsEnumerable().Any(row => columns.Any(col => row["nombre"].ToString() == txt_valor_Cita.Text.Trim()));
                        if (existe1)
                        {
                            if (Regex.IsMatch(buscar, @"[A-Z][a-zA-Z\s\'-]*"))
                            {
                                this.dsCitas = Cita.ConsultarCitaNombre(buscar);
                                this.dtCitas = this.dsCitas.Tables[0];
                                gbx_datosCita.Visible = true;
                                btn_EliminarCita.Visible = true;
                                btn_EditarCita.Visible = true;
                                lbl_editarCita.Visible = true;
                                lbl_eliminarCita.Visible = true;
                                gbx_datosCita.Enabled = true;
                            }
                            else
                            {
                                //buscar.SetError(buscar, "Only use alphabates");
                                MessageBox.Show("Solo puede se permiten letras(Nombre), cambie la seleccion de busqueda!", "Error de busqueda!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            }
                        }
                        else
                        {
                            MessageBox.Show("El valor de busqueda no existe!", "Error de busqueda!!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            txt_valor_Cita.Text = "";
                        }
                       

                    }
                       
                }

            }
            
        }
        /// <summary>
        /// Metodo que carga un grid con citas con sus campos respectivos
        /// </summary>
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

        /// <summary>
        /// Metodo que inserta una cita y ademas inactiva algunos campos para evitar mayor uso de codigo en excepciones
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
        /// <summary>
        /// Metodo que modifica una cita ya registrada
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                cargarGridCitasRecientes();
                grb_menuCita.Visible = true;

            }
        }
        /// <summary>
        /// Metodo que inactiva una cita a elección del usuario logeado
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                        cargarGridCitasRecientes();
                        grb_menuCita.Visible = true;
                    }
                }
            }
                
        }
        /// <summary>
        /// Metodo que carga un datagridview con citas con un periodo de registro de hace un año o mayor
        /// </summary>
        private void cargarGridCitas()
        {
            using (GestorCita cita = new GestorCita())
            {
                dgvCitas.DataSource = cita.ListarCitasAnio();
                dgvCitas.Columns["cedula"].HeaderText = "CEDULA";
                dgvCitas.Columns["nombre_paciente"].HeaderText = "NOMBRE";
                dgvCitas.Columns["telefono"].HeaderText = "TELEFONO";
                dgvCitas.Columns["fecha"].HeaderText = "FECHA";
            }
        }
        /// <summary>
        /// Metodo que carga un datagridview con citas con un periodo de registro no mayor a 11 meses
        /// </summary>
        private void cargarGridCitasRecientes()
        {
            using (GestorCita cita = new GestorCita())
            {
                dgvCitasRecientes.DataSource = cita.ListarCitas();

                dgvCitasRecientes.Columns["cedula"].HeaderText = "CEDULA";
                dgvCitasRecientes.Columns["nombre_paciente"].HeaderText = "NOMBRE";
                dgvCitasRecientes.Columns["telefono"].HeaderText = "TELEFONO";
                dgvCitasRecientes.Columns["fecha"].HeaderText = "FECHA";
            }
        }
        /// <summary>
        /// Metodo que guarda una cita
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
                            cargarGridCitasRecientes();
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
        /// <summary>
        /// Metodo que bloquea algunos elementos del form dependiendo de los privilegios del usuario
        /// </summary>
        private void bloquearCamposCita()
        {
            txt_CedulaUsuario.Enabled = false;
            txt_nombreUsuario.Enabled = false;
            txt_telefonoUsuario.Enabled = false;
            txt_detalleCita.Enabled = false;
            dtpFechaCita.Enabled = false;
        }
        /// <summary>
        /// Metodo que limpia campos en base a la accion realizada(modificar,borrar,guardar)
        /// </summary>
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
        /// <summary>
        /// Metodo de validacion que permite solo numeros o letras y espacios en blanco dependiendo de la opcion de busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void txt_valor_Cita_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbtn_CedulaCita.Checked == true)
            {   
                if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                {
                    e.Handled = true;
                }
            }
            else
            {
                if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                    e.Handled = true;

            }
        }
        /// <summary>
        /// Metodo que solo permite numeros en caso de ser cedula el valor de busqueda
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_CedulaUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Metodo que solo permite numeros en el campo telefono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_telefonoUsuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        /// <summary>
        /// Metodo que no permite caracteres especiales, solo caracteres alfanumericos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_detalleCita_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = e.KeyChar != (char)Keys.Back && !char.IsSeparator(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsDigit(e.KeyChar);
        }
        /// <summary>
        /// Metodo que defina que pasa cuando se cierra el form de citas
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void frmCitas_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
