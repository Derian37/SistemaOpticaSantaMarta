using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using itextsharp;
using itextsharp.pdfa;
using iTextSharp.text;
using iTextSharp;
using iTextSharp.text.pdf;
using iTextSharp.text.pdf.parser;
using System.IO;
using System.Diagnostics;
using ProyectoOptica.CapaIntegracion;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReporte : Form
    {
        int id_usuario;
        string nombre;
        string cargo;
        private DataTable dtReporte = new DataTable();
        private DataSet dsReporte = new DataSet();
        iTextSharp.text.Image img = iTextSharp.text.Image.GetInstance("../../Resources/LogoOptica.png");

        public PdfWriter Writer { get => Writer; set => Writer = value; }
        public PdfWriter Writer1 { get => Writer1; set => Writer1 = value; }

        public FrmReporte(int id_usuario, string nombre, string cargo)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            GenerarReporteDiario(fecha);
        }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(id_usuario, nombre, cargo);
            principal.Show();
            this.Close();
        }
        private void GenerarReporteDiario(string fecha)
        {
            double totalVenta = 0;
            try
            {
                using (GestorReportes reporte = new GestorReportes())
                {
                    this.dsReporte = reporte.ReporteDia(fecha);
                    this.dtReporte = this.dsReporte.Tables[0];

                    Dgv_reporte_ventas.DataSource = this.dtReporte;

                    Dgv_reporte_ventas.Columns["Fecha"].HeaderText = "FECHA";
                    Dgv_reporte_ventas.Columns["N_Recibo"].HeaderText = "NUM_RECIBO";
                    Dgv_reporte_ventas.Columns["Cod_Prod"].HeaderText = "CODIGO";
                    Dgv_reporte_ventas.Columns["Modo_Pago"].HeaderText = "MODO PAGO";
                    Dgv_reporte_ventas.Columns["Nombre"].HeaderText = "NOMBRE PRODUCTO";
                    Dgv_reporte_ventas.Columns["Total"].HeaderText = "TOTAL";
                }
                

                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            foreach (DataGridViewRow fila in Dgv_reporte_ventas.Rows)
            {
                //agregamos la cantidad, el precio y subtotal
                totalVenta += Convert.ToDouble(fila.Cells[5].Value);
            }
            lbl_totalVenta.Text = totalVenta.ToString();
            Lbl_subtituloDia.Text = "Reporte de " + fecha;
            Btn_guardarReporteDia.Visible = true;
        }


        private void GenerarReporteMensual(int numMes)
        {
            int year = int.Parse(DateTime.Now.Year.ToString().Substring(1));
            string mes = GeneraMes(numMes);
            string inicio = ("01-" + mes + "-" + year);
            int ultimo = DateTime.DaysInMonth(year, numMes);
            string fin = (ultimo + "-" + mes + "-" + year);
            
            double totalVenta = 0;
            try
            {
                using (GestorReportes reporte = new GestorReportes())
                {
                    this.dsReporte = reporte.ReporteMensual(inicio,fin);
                    this.dtReporte = this.dsReporte.Tables[0];

                    Dgv_ReporteMensual.DataSource = this.dtReporte;

                    Dgv_reporte_ventas.Columns["Fecha"].HeaderText = "FECHA";
                    Dgv_reporte_ventas.Columns["N_Recibo"].HeaderText = "NUM_RECIBO";
                    Dgv_reporte_ventas.Columns["Cod_Prod"].HeaderText = "CODIGO";
                    Dgv_reporte_ventas.Columns["Modo_Pago"].HeaderText = "MODO PAGO";
                    Dgv_reporte_ventas.Columns["Nombre"].HeaderText = "NOMBRE PRODUCTO";
                    Dgv_reporte_ventas.Columns["Total"].HeaderText = "TOTAL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            foreach (DataGridViewRow fila in Dgv_ReporteMensual.Rows)
            {
                //agregamos la cantidad, el precio y subtotal
                totalVenta += Convert.ToDouble(fila.Cells[5].Value);
            }
            Lbl_totalMensual.Text = totalVenta.ToString();
            Lbl_SubtituloMes.Text = "Reporte del mes de " + Cbx_Mes.SelectedItem.ToString().Substring(3);
            Btn_GuardarReporteMensual.Visible = true;
        }

        private string GeneraMes(int num)
        {
            string mes = "";
            switch (num)
            {
                case 1:
                    mes = "ene";
                    break;
                case 2:
                    mes = "feb";
                    break;
                case 3:
                    mes = "mar";
                    break;
                case 4:
                    mes = "abr";
                    break;
                case 5:
                    mes = "may";
                    break;
                case 6:
                    mes = "jun";
                    break;
                case 7:
                    mes = "jul";
                    break;
                case 8:
                    mes = "ago";
                    break;
                case 9:
                    mes = "set";
                    break;
                case 10:
                    mes = "oct";
                    break;
                case 11:
                    mes = "nov";
                    break;
                case 12:
                    mes = "dic";
                    break;
            }

            return mes;
        }

        private void Btn_ReporteDia_Click(object sender, EventArgs e)
        {
            string fecha = Dtp_Dia.Value.ToShortDateString();
            GenerarReporteDiario(fecha);
        }

        private void Btn_ReporteSemanal_Click(object sender, EventArgs e)
        {
            string fecha1 = dtp_fecha1.Value.ToShortDateString();
            string fecha2 = dtp_fecha2.Value.ToShortDateString();
            int cant = 0;
            double totalVenta = 0;
            try
            {
                using (GestorReportes reporte = new GestorReportes())
                {
                    this.dsReporte = reporte.ReporteSemanal(fecha1, fecha2);
                    this.dtReporte = this.dsReporte.Tables[0];

                    Dgv_reporteSemanal.DataSource = this.dtReporte;

                    Dgv_reporte_ventas.Columns["Fecha"].HeaderText = "FECHA";
                    Dgv_reporte_ventas.Columns["N_Recibo"].HeaderText = "NUM_RECIBO";
                    Dgv_reporte_ventas.Columns["Cod_Prod"].HeaderText = "CODIGO";
                    Dgv_reporte_ventas.Columns["Modo_Pago"].HeaderText = "MODO PAGO";
                    Dgv_reporte_ventas.Columns["Nombre"].HeaderText = "NOMBRE PRODUCTO";
                    Dgv_reporte_ventas.Columns["Total"].HeaderText = "TOTAL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            foreach (DataGridViewRow fila in Dgv_reporteSemanal.Rows)
            {
                //agregamos la cantidad, el precio y subtotal
                totalVenta += Convert.ToDouble(fila.Cells[5].Value);
            }
            Lbl_totalSemanal.Text = totalVenta.ToString();
            Lbl_SubtituloSemana.Text = "Reporte de " + fecha1 + " a " + fecha2;
            Btn_guardarReporteSemanal.Visible = true;
        }

        private void Btn_ReporteMensual_Click(object sender, EventArgs e)
        {
            int mes = int.Parse(Cbx_Mes.SelectedItem.ToString().Remove(2));
            GenerarReporteMensual(mes);
        }

        private void Btn_guardarReporteDia_Click(object sender, EventArgs e)
        {
            GuardarReporte(1);  //tipo 1 es igual a reporte diario
        }

        private void Btn_guardarReporteSemanal_Click(object sender, EventArgs e)
        {
            GuardarReporte(2);  //tipo 2 es semanal
        }

        private void Btn_GuardarReporteMensual_Click(object sender, EventArgs e)
        {
            GuardarReporte(3);  //tipo 3 es mensual
        }
        
        private void GuardarReporte(int tipo)
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER, 10f, 10f, 10f, 10f);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = @"C:";
            guardar.Title = "Guardar Reporte";
            guardar.DefaultExt = "pdf";
            guardar.Filter = "pdf Files(*.pdf)|*.pdf| All Files(*.*)|*.*";
            guardar.FilterIndex = 2;
            guardar.RestoreDirectory = true;
            string nombreArchivo = "";
            string fechacreacion = DateTime.Now.ToString();
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                //guardar.FileName = fechacreacion;
                nombreArchivo = guardar.FileName;
            }
            if (nombreArchivo.Trim() != "")
            {
                // Indicamos donde vamos a guardar el documento
                FileStream archivo = new FileStream(nombreArchivo, FileMode.OpenOrCreate, FileAccess.ReadWrite, FileShare.ReadWrite);
                PdfWriter.GetInstance(doc, archivo);

                // Le colocamos el título 
                // **Nota: Esto no será visible en el documento
                doc.AddTitle(title: $"Reporte ventas. {fechacreacion}");

                // Abrimos el archivo
                doc.Open();

                // Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Escribimos el encabezamiento en el documento
                Paragraph title = new Paragraph(str: " OPTICA SANTA MARTA");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                
                doc.Add(element: Chunk.NEWLINE);

                img.ScaleToFit(fitWidth: 125f, fitHeight: 60f);
                img.SetAbsolutePosition(absoluteX: 530, absoluteY: 730);
                doc.Add(element: img);

                if (tipo == 1)
                {
                    Paragraph subtitle = new Paragraph("Reporte ventas día "+ Dtp_Dia.Value.ToShortDateString());
                    subtitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitle);
                    Paragraph subtitulo = new Paragraph("Consultado el día: " + fechacreacion);
                    subtitulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitulo);
                    doc.Add(element: Chunk.NEWLINE);

                    int i, j;

                    PdfPTable datatable = new PdfPTable(Dgv_reporte_ventas.ColumnCount);
                    datatable.DefaultCell.Padding = 3;
                    float[] headerwidths = GetTamañoColumnas(Dgv_reporte_ventas);
                    datatable.SetWidths(headerwidths);
                    datatable.WidthPercentage = 100;
                    datatable.DefaultCell.BorderWidth = 2;
                    datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    for (i = 0; i < Dgv_reporte_ventas.ColumnCount; i++)
                    {
                        datatable.AddCell(Dgv_reporte_ventas.Columns[i].HeaderText);
                    }
                    datatable.HeaderRows = 1;
                    datatable.DefaultCell.BorderWidth = 1;
                    for (i = 0; i < Dgv_reporte_ventas.Rows.Count; i++)
                    {
                        for (j = 0; j < Dgv_reporte_ventas.Columns.Count; j++)
                        {
                            if (Dgv_reporte_ventas[j, i].Value != null)
                            {
                                datatable.AddCell(new Phrase(Dgv_reporte_ventas[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                            }
                        }
                        datatable.CompleteRow();
                    }

                    doc.Add(datatable);
                    doc.Add(element: Chunk.NEWLINE);
                    Paragraph total = new Paragraph("Total: "+lbl_totalVenta.Text);
                    total.Alignment = Element.ALIGN_RIGHT;

                    doc.Add(total);

                }
                else if (tipo == 2)
                {
                    Paragraph subtitle = new Paragraph("Reporte ventas semanal");
                    subtitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitle);
                    Paragraph subtitulo = new Paragraph("de " + dtp_fecha1.Value.ToShortDateString() + " a " + dtp_fecha2.Value.ToShortDateString());
                    subtitulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitulo);
                    doc.Add(element: Chunk.NEWLINE);

                    int i, j;

                    PdfPTable datatable = new PdfPTable(Dgv_reporteSemanal.ColumnCount);
                    datatable.DefaultCell.Padding = 3;
                    float[] headerwidths = GetTamañoColumnas(Dgv_reporteSemanal);
                    datatable.SetWidths(headerwidths);
                    datatable.WidthPercentage = 100;
                    datatable.DefaultCell.BorderWidth = 2;
                    datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    for (i = 0; i < Dgv_reporteSemanal.ColumnCount; i++)
                    {
                        datatable.AddCell(Dgv_reporteSemanal.Columns[i].HeaderText);
                    }
                    datatable.HeaderRows = 1;
                    datatable.DefaultCell.BorderWidth = 1;
                    for (i = 0; i < Dgv_reporteSemanal.Rows.Count; i++)
                    {
                        for (j = 0; j < Dgv_reporteSemanal.Columns.Count; j++)
                        {
                            if (Dgv_reporteSemanal[j, i].Value != null)
                            {
                                datatable.AddCell(new Phrase(Dgv_reporteSemanal[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                            }
                        }
                        datatable.CompleteRow();
                    }

                    doc.Add(datatable);
                    doc.Add(element: Chunk.NEWLINE);
                    Paragraph total = new Paragraph("Total: " + Lbl_totalSemanal.Text);
                    total.Alignment = Element.ALIGN_RIGHT;

                    doc.Add(total);
                }
                else if (tipo == 3)
                {
                    Paragraph subtitle = new Paragraph("Reporte ventas mensual");
                    subtitle.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitle);
                    Paragraph subtitulo = new Paragraph("Para el mes de "+ Cbx_Mes.SelectedItem.ToString().Substring(3));
                    subtitulo.Alignment = Element.ALIGN_CENTER;
                    doc.Add(subtitulo);
                    doc.Add(element: Chunk.NEWLINE);

                    int i, j;

                    PdfPTable datatable = new PdfPTable(Dgv_reporteSemanal.ColumnCount);
                    datatable.DefaultCell.Padding = 3;
                    float[] headerwidths = GetTamañoColumnas(Dgv_reporteSemanal);
                    datatable.SetWidths(headerwidths);
                    datatable.WidthPercentage = 100;
                    datatable.DefaultCell.BorderWidth = 2;
                    datatable.DefaultCell.HorizontalAlignment = Element.ALIGN_CENTER;
                    for (i = 0; i < Dgv_reporteSemanal.ColumnCount; i++)
                    {
                        datatable.AddCell(Dgv_reporteSemanal.Columns[i].HeaderText);
                    }
                    datatable.HeaderRows = 1;
                    datatable.DefaultCell.BorderWidth = 1;
                    for (i = 0; i < Dgv_reporteSemanal.Rows.Count; i++)
                    {
                        for (j = 0; j < Dgv_reporteSemanal.Columns.Count; j++)
                        {
                            if (Dgv_reporteSemanal[j, i].Value != null)
                            {
                                datatable.AddCell(new Phrase(Dgv_reporteSemanal[j, i].Value.ToString()));//En esta parte, se esta agregando un renglon por cada registro en el datagrid
                            }
                        }
                        datatable.CompleteRow();
                    }

                    doc.Add(datatable);
                    doc.Add(element: Chunk.NEWLINE);
                    Paragraph total = new Paragraph("Total: " + Lbl_totalMensual.Text);
                    total.Alignment = Element.ALIGN_RIGHT;

                    doc.Add(total);
                }

                doc.Close();
                Process.Start(nombreArchivo);
            }
        }
        public float[] GetTamañoColumnas(DataGridView dg)
        {
            float[] values = new float[dg.ColumnCount];

            for (int i = 0; i < dg.ColumnCount; i++)
            {
                values[i] = (float)dg.Columns[i].Width;
            }
            return values;
        }
    }
}

