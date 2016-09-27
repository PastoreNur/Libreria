using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Libreria
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void AbrirVentana()
        {
            Application.Run(new FrmCatalogo());
        }

        Thread CerraVentana;
        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            CerraVentana = new Thread(AbrirVentana);
            CerraVentana.SetApartmentState(ApartmentState.STA);
            CerraVentana.Start();
        }
    }
}
