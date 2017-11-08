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

namespace CapaPresentacion.Ventas
{
    public partial class FrmImpresoras : Form
    {
        int cantImpresoras;
        private string nombreImpresora;
        int id;
        private DataTable dtImpresora = new DataTable();
        private DataSet dsImpresora = new DataSet();
        private DataTable dtLista = new DataTable();
        private DataSet dsLista = new DataSet();

        public string NombreImpresora { get => nombreImpresora; set => nombreImpresora = value; }

        public FrmImpresoras()
        {
            InitializeComponent();
        }

        private void FrmImpresoras_Load(object sender, EventArgs e)
        {
            CargarImpresoras();
        }

        private void CargarImpresoras()
        {
            using (GestorImpresora impresora = new GestorImpresora())
            {
                dsImpresora = impresora.Consultar_cantidadImpresoras();
                dtImpresora = this.dsImpresora.Tables[0];

                cantImpresoras = int.Parse(this.dtImpresora.Rows[0]["cantidad"].ToString());

                dtImpresora = impresora.ListarImpresora();

                int i = 0;
                if (cantImpresoras <= 3)
                {
                    while (i < cantImpresoras)
                    {
                        if (i == 0)
                        {
                            rdb_impresora1.Text = dtImpresora.Rows[i]["nombre"].ToString();
                            pbx_impresora1.Visible = true;
                            rdb_impresora1.Visible = true;
                            if (dtImpresora.Rows[i]["tipo"].ToString() == "PREDETERMINADA")
                            {
                                rdb_impresora1.Checked = true;
                            }
                        }
                        else if (i == 1)
                        {
                            rdb_impresora2.Text = dtImpresora.Rows[i]["nombre"].ToString();
                            pbx_impresora2.Visible = true;
                            rdb_impresora2.Visible = true;

                            if (dtImpresora.Rows[i]["tipo"].ToString() == "PREDETERMINADA")
                            {
                                rdb_impresora2.Checked = true;
                            }
                        }
                        else if (i == 2)
                        {
                            rdb_impresora3.Text = dtImpresora.Rows[i]["nombre"].ToString();
                            pbx_impresora3.Visible = true;
                            rdb_impresora3.Visible = true;

                            if (dtImpresora.Rows[i]["tipo"].ToString() == "PREDETERMINADA")
                            {
                                rdb_impresora3.Checked = true;
                            }
                        }
                        i++;
                    }
                }

                
            }
        }

        private void btn_cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_seleccionar_Click(object sender, EventArgs e)
        {
            using (GestorImpresora impresora = new GestorImpresora())
            {
                if (rdb_impresora1.Checked)
                {
                    id = int.Parse(dtImpresora.Rows[0]["id_impresora"].ToString());
                    nombreImpresora = dtImpresora.Rows[0]["nombre"].ToString();
                    impresora.Quitar_impresorasPredeterminadas();
                    impresora.Establecer_impresoraPredeterminada(id);                                    
                }
                else if (rdb_impresora2.Checked)
                {
                    id = int.Parse(dtImpresora.Rows[1]["id_impresora"].ToString());
                    nombreImpresora = dtImpresora.Rows[1]["nombre"].ToString();
                    impresora.Quitar_impresorasPredeterminadas();
                    impresora.Establecer_impresoraPredeterminada(id);
                }
                else if (rdb_impresora3.Checked)
                {
                    id = int.Parse(dtImpresora.Rows[2]["id_impresora"].ToString());
                    nombreImpresora = dtImpresora.Rows[2]["nombre"].ToString();
                    impresora.Quitar_impresorasPredeterminadas();
                    impresora.Establecer_impresoraPredeterminada(id);
                }
            }
            this.Close();
            
        }
    }
}
