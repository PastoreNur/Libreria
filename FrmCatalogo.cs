using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Libreria
{
    public partial class FrmCatalogo : Form
    {

        int panelmenuancho = 150;


        public FrmCatalogo()
        {
            InitializeComponent();
        }

        private void panelmenu_MouseHover(object sender, EventArgs e)
        {
            do
            {
                panelmenuancho = panelmenuancho + 2;
                panelmenu.Size = new Size(panelmenuancho, 547);
            } while (panelmenuancho <= 150);
            
                
            
        }

        private void FrmCatalogo_Load(object sender, EventArgs e)
        {
            do
            {
                panelmenuancho = panelmenuancho - 2;
                panelmenu.Size = new Size(panelmenuancho, 547);
            } while (panelmenuancho >= 50);
        }

        private void panelmenu_MouseLeave(object sender, EventArgs e)
        {

            do
            {
                panelmenuancho = panelmenuancho - 2;
                panelmenu.Size = new Size(panelmenuancho, 547);
            } while (panelmenuancho >= 50);

        }

        private void FrmCatalogo_MouseLeave(object sender, EventArgs e)
        {
            panelmenu.Size = new Size(150, 547);
     
            
                if (panelmenuancho < 50)
                {
                    panelmenuancho = 150;
                }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Galeria gale = new Galeria();
            gale.MdiParent = this;
            gale.Show();
        }
    }
}
