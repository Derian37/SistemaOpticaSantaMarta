using CapaPresentacion.ReporteTarjeta;
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
    public partial class frmImpresionTarjeta : Form
    {
        int id_usuario;
        string usuario;
        string cargo;
        DsTarjeta tempreporte = new DsTarjeta();
        DataGridView temporal = new DataGridView();

        public frmImpresionTarjeta(DataGridView NuevoData, int id_usuario,string usuario,string cargo)
        {
            this.temporal = NuevoData;
            InitializeComponent();
        }

        private void crv_Tarjeta_Load(object sender, EventArgs e)
        {
            Reportes();
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, usuario, cargo);
            principal.Show();
            this.SetVisibleCore(false);
        }
        private void Reportes()
        {
           
                tempreporte.Tables[0].Rows.Add(new object[] { temporal[0,0].Value.ToString(),
                                                              temporal[1,0].Value.ToString(),
                                                              temporal[2,0].Value.ToString(),
                                                              temporal[3,0].Value.ToString(),
                                                              temporal[4,0].Value.ToString(),
                                                              temporal[5,0].Value.ToString(),
                                                              temporal[6,0].Value.ToString(),
                                                              temporal[7,0].Value.ToString(),
                                                              temporal[8,0].Value.ToString(),
                                                              temporal[9,0].Value.ToString(),
                                                              temporal[10,0].Value.ToString(),
                                                              temporal[11,0].Value.ToString(),
                                                              temporal[12,0].Value.ToString(),
                                                              temporal[13,0].Value.ToString(),
                                                              temporal[14,0].Value.ToString(),
                                                              temporal[15,0].Value.ToString(),
                                                              temporal[16,0].Value.ToString(),
                                                              temporal[17,0].Value.ToString()});
          
            Tarjeta reporte = new Tarjeta();
            reporte.Load("../../Reporte.rpt");
            reporte.SetDataSource(tempreporte);

            crv_Tarjeta.ReportSource = reporte;
        }

        private void frmImpresionTarjeta_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
