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
        public FrmReporte(int id_usuario, string nombre, string cargo)
        {
            InitializeComponent();
            this.id_usuario = id_usuario;
            this.nombre = nombre;
            this.cargo = cargo;
        }

        private void FrmReporte_Load(object sender, EventArgs e)
        {
            //CargarReporte();
        }

        private void CargarReporte()
        {
            // Creamos el documento con el tamaño de página tradicional
            Document doc = new Document(PageSize.LETTER,10f,10f,10f,10f);

            SaveFileDialog guardar = new SaveFileDialog();
            guardar.InitialDirectory = @"D: ..\..\UNA\ProyectoOptica\Reportes";
            guardar.Title = "Guardar Reporte";
            guardar.DefaultExt = "pdf";
            guardar.Filter = "pdf Files(*.pdf)|*.pdf| All Files(*.*)|*.*";
            guardar.FilterIndex = 2;
            guardar.RestoreDirectory = true;
            string nombreArchivo = "";
            string fechacreacion = DateTime.Now.ToLongDateString();
            if (guardar.ShowDialog() == DialogResult.OK)
            {
                guardar.FileName = fechacreacion;
                nombreArchivo = guardar.FileName;
            }
            if (nombreArchivo.Trim() != "")
            {
                // Indicamos donde vamos a guardar el documento
                PdfWriter writer = PdfWriter.GetInstance(doc, new FileStream(@"D: \UNA\ProyectoOptica\Reportes\reporte " + fechacreacion + ".pdf", FileMode.Create));
                // Le colocamos el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle(title: $"Reporte ventas {fechacreacion}");
                doc.AddCreator(creator: "Doney");

                // Abrimos el archivo
                doc.Open();

                // Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Escribimos el encabezamiento en el documento
                Paragraph title = new Paragraph(str: " OPTICA SANTA MARTA");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                Paragraph subtitle = new Paragraph(str: $"Reporte ventas {fechacreacion}");
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);
                doc.Add(element: Chunk.NEWLINE);
                doc.Add(element: Chunk.NEWLINE);

                //img.ScaleToFit(fitWidth: 125f, fitHeight: 60f);
                //img.SetAbsolutePosition(absoluteX: 530, absoluteY: 730);
                //doc.Add(element: img);


                // Creamos una tabla que contendrá el nombre, apellido y país
                // de nuestros visitante.
                PdfPTable tblPrueba = new PdfPTable(3)
                {
                    WidthPercentage = 100
                };

                // Configuramos el título de las columnas de la tabla
                PdfPCell clNombre = new PdfPCell(new Phrase("Nombre", _standardFont))
                {
                    BorderWidth = 0,
                    BorderWidthBottom = 0.75f
                };

                PdfPCell clApellido = new PdfPCell(new Phrase("Apellido", _standardFont))
                {
                    BorderWidth = 0,
                    BorderWidthBottom = 0.75f
                };

                PdfPCell clPais = new PdfPCell(new Phrase("País", _standardFont))
                {
                    BorderWidth = 0,
                    BorderWidthBottom = 0.75f
                };

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clApellido);
                tblPrueba.AddCell(clPais);

                // Llenamos la tabla con información
                clNombre = new PdfPCell(new Phrase("Roberto", _standardFont))
                {
                    BorderWidth = 0
                };

                clApellido = new PdfPCell(new Phrase("Torres", _standardFont))
                {
                    BorderWidth = 0
                };

                clPais = new PdfPCell(new Phrase("Puerto Rico", _standardFont))
                {
                    BorderWidth = 0
                };

                // Añadimos las celdas a la tabla
                tblPrueba.AddCell(clNombre);
                tblPrueba.AddCell(clApellido);
                tblPrueba.AddCell(clPais);

                // Finalmente, añadimos la tabla al documento PDF y cerramos el documento
                doc.Add(element: tblPrueba);

                doc.Close();
                writer.Close();
                // Process.Start(fileName: @"D: \UNA\ProyectoOptica\Reportes\reporte " + fechacreacion + ".pdf");
            }

        }

        public PdfWriter Writer { get => Writer; set => Writer = value; }
        public PdfWriter Writer1 { get => Writer1; set => Writer1 = value; }

        private void btn_volver_Click(object sender, EventArgs e)
        {
            //frmPrincipal principal = new frmPrincipal(id_usuario, nombre, cargo);
            //principal.Show();
            this.Close();
        }

        
        private void btn_generar_reporte_Click(object sender, EventArgs e)
        {
            string fecha = DateTime.Now.ToShortDateString();
            
            try
            {
                using(GestorReportes reporte = new GestorReportes())
                {
                    this.dsReporte = reporte.ReporteDia(fecha);
                    this.dtReporte = this.dsReporte.Tables[0];

                    Dgv_reporte_ventas.DataSource = this.dtReporte;

                    Dgv_reporte_ventas.Columns["Cod_Prod"].HeaderText = "CODIGO";
                    Dgv_reporte_ventas.Columns["Modo_Pago"].HeaderText = "MODO PAGO";
                    Dgv_reporte_ventas.Columns["Nombre"].HeaderText = "NOMBRE PRODUCTO";
                    Dgv_reporte_ventas.Columns["Cantidad"].HeaderText = "VENTAS";
                    Dgv_reporte_ventas.Columns["Total"].HeaderText = "TOTAL";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error de SQL: " + ex.Message);
            }
            btn_guardar.Visible = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
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

                // Le colocamos el título y el autor
                // **Nota: Esto no será visible en el documento
                doc.AddTitle(title: $"Reporte ventas {fechacreacion}");

                // Abrimos el archivo
                doc.Open();

                // Creamos el tipo de Font que vamos utilizar
                iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

                // Escribimos el encabezamiento en el documento
                Paragraph title = new Paragraph(str: " OPTICA SANTA MARTA");
                title.Alignment = Element.ALIGN_CENTER;
                doc.Add(title);
                Paragraph subtitle = new Paragraph(str: $"Reporte ventas {fechacreacion}");
                subtitle.Alignment = Element.ALIGN_CENTER;
                doc.Add(subtitle);
                doc.Add(element: Chunk.NEWLINE);
                doc.Add(element: Chunk.NEWLINE);

                img.ScaleToFit(fitWidth: 125f, fitHeight: 60f);
                img.SetAbsolutePosition(absoluteX: 530, absoluteY: 730);
                doc.Add(element: img);

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
        private void tbReporte_dia_Click(object sender, EventArgs e)
        {

        }

        private void Dgv_reporte_ventas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }       
}

