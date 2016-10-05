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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimizar_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnUser_Click(object sender, EventArgs e)
        {
            if(loginBar.Enabled == true)
            {
                loginBar.Size = new Size(width: 280, height: 1);
                loginBar.Enabled = false;
            }
            else if(loginBar.Enabled == false)
            {
                loginBar.Enabled = true;
                loginBar.Size = new Size(width: 280, height: 200);
                
            }
        }

        private void Principal_Load(object sender, EventArgs e)
        {

        }


        /*
         * try
            {
                System.Diagnostics.Process.Start("http://www.microsoft.com");
            }
            catch { }
         */
    }
}
