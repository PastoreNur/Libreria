using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace Libreria
{
    public partial class Facturacion : Form
    {
        public Facturacion()
        {
            InitializeComponent();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void GenerarFactura(int NumFact)
        {
            Document factura = new Document(PageSize.A6);
            iTextSharp.text.Font _standardFont = new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 8, iTextSharp.text.Font.NORMAL, BaseColor.BLACK);

            PdfWriter writer = PdfWriter.GetInstance(factura, new FileStream("Factura" + NumFact.ToString() + ".pdf", FileMode.OpenOrCreate));


            factura.AddTitle("Factura Nº"+NumFact.ToString()+"");
            factura.AddCreator("AMAYA & PASTORE");

            factura.Open();

            factura.Add(new Paragraph("La Casa del Libro"));
            factura.Add(Chunk.NEWLINE);

            PdfPTable tablaPrueba = new PdfPTable(3);
            tablaPrueba.WidthPercentage = 100;

            PdfPCell clDescripcion = new PdfPCell(new Phrase("Descripción", _standardFont));
            clDescripcion.BorderWidth = 0;
            clDescripcion.BorderWidthBottom = 0.75f;

            PdfPCell clCantidad = new PdfPCell(new Phrase("Cantidad", _standardFont));
            clCantidad.BorderWidth = 0;
            clCantidad.BorderWidthBottom = 0.75f;

            PdfPCell clPrecio = new PdfPCell(new Phrase("Precio", _standardFont));
            clPrecio.BorderWidth = 0;
            clPrecio.BorderWidthBottom = 0.75f;

            tablaPrueba.AddCell(clDescripcion);
            tablaPrueba.AddCell(clCantidad);
            tablaPrueba.AddCell(clPrecio);

            // Llenamos la tabla con información

            string[] Descripcion = { };
            int[] Cantidad = new int[15];
            double[] precio = new double[15];

            Double Subtotal = 0.0;
            double IVA = 0.0;
            double Descuento = 0.0;
            double Total = 0.0;

            int x = 0;
            Double i = 0.0;
            while (i <= 10.0)
            {
                
                clDescripcion = new PdfPCell(new Phrase("libro"+i.ToString(), _standardFont));
                clDescripcion.BorderWidth = 0;
                

                clCantidad = new PdfPCell(new Phrase(i.ToString(), _standardFont));
                clCantidad.BorderWidth = 0;
                Cantidad[x] = Convert.ToInt16(i);


                clPrecio = new PdfPCell(new Phrase("$" + i.ToString(), _standardFont));
                clPrecio.BorderWidth = 0;
                precio[x] = i;

                
                IVA = IVA + ((Cantidad[x] * precio[x])*0.13);
                Subtotal = Subtotal + (Cantidad[x] * precio[x]);

                tablaPrueba.AddCell(clDescripcion);
                tablaPrueba.AddCell(clCantidad);
                tablaPrueba.AddCell(clPrecio);

                x++;
                i = i + 1.0;
            }
            


            iTextSharp.text.Image logo = iTextSharp.text.Image.GetInstance(@"C:\Users\Josuee\Desktop\logo3.png");

            logo.BorderWidth = 0;
            logo.Alignment = iTextSharp.text.Image.ALIGN_RIGHT;
            //float porcentaje = 0.0f;
            //porcentaje = 75 / logo.Width;
            logo.ScalePercent(24f);
            logo.SetAbsolutePosition(factura.PageSize.Width - 36f - 40f, factura.PageSize.Height - 36f - 10f);

            factura.Add(logo);

            factura.Add(tablaPrueba);

            IVA = Math.Round(IVA,2);
            Subtotal = Math.Round(Subtotal + IVA,2);

            factura.Add(Chunk.NEWLINE);
            factura.Add(new Paragraph("IVA: $" + IVA.ToString()));
           
            
            factura.Add(new Paragraph("SubTotal: $"+Subtotal.ToString()));
           

            if (Subtotal >= 100)
            {
                Descuento = Math.Round((Subtotal * 0.15),2);
                Total = Math.Round((Subtotal - Descuento),2);
                factura.Add(new Paragraph("Descuento: -$" + Descuento.ToString()));
                
            }
           
            factura.Add(new Paragraph("Total: $"+Total.ToString()));

            factura.Close();

            System.Diagnostics.Process.Start("Factura" + NumFact.ToString() + ".pdf");
        }

        int NumFact = 0;

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            

            if (System.IO.File.Exists("Factura" + NumFact.ToString() + ".pdf"))
            {
                while (NumFact <= 10000)
                {
                    NumFact++;
                    break;
                }
                   
                 GenerarFactura(NumFact);

            }
            else
            {
                GenerarFactura(NumFact);
                NumFact++;

            }


   

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {

        }
    }
}
