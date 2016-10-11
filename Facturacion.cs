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

        Document factura = new Document();

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            PdfWriter.GetInstance(factura, new FileStream("Factura.pdf", FileMode.OpenOrCreate));
            factura.Open();

            factura.Add(new Paragraph("Factura :v"));
            factura.Close();
        }
    }
}
