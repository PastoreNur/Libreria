using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//Comentario de prueba
namespace Libreria
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        public void ExtenderLoginBar()
        {
            if (loginBar.Enabled == true)
            {
                loginBar.Size = new Size(width: 280, height: 0);
                loginBar.Enabled = false;
            }
            else if (loginBar.Enabled == false)
            {
                loginBar.Enabled = true;
                loginBar.Size = new Size(width: 280, height: 200);

            }
        }

        //Variables para inicio de sesion
        public string Usuario = "Invitado";
        public string Nombre = "Invitado";
        public string contraseña = "1234";

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
            ExtenderLoginBar();
        }

        private void Principal_Load(object sender, EventArgs e)
        {
            PanelGaleria.Size = new Size(width: 0, height: 0);
            PanelGaleria.Visible = false;
            lblNombreCategoriaBar.Text = "";
        }

        private void BtnIngresarBar_Click(object sender, EventArgs e)
        {
            if (txtUsuarioBar.Text == Usuario)
            {
                if (txtPAsswordBar.Text == contraseña)
                {
                    LblUsuario.Text = Nombre + "!";
                    lblSaludo.Text = "¡Hola";
                    loginBar.Size = new Size(width: 280, height: 1);
                    loginBar.Enabled = false;
                    txtPAsswordBar.Clear();
                    txtUsuarioBar.Clear();

                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtPAsswordBar.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtUsuarioBar.Clear();
            }
        }

        private void BtnCerrarGaleria_Click(object sender, EventArgs e)
        {
            PanelGaleria.Size = new Size(width:0,height:0);
            PanelGaleria.Visible = false;
            lblNombreCategoriaBar.Text = "";
            
        }

        private void ocultarLoginBar()
        {
            if (loginBar.Enabled == true)
            {
                loginBar.Size = new Size(width: 280, height: 0);
                loginBar.Enabled = false;
            }
        }

        private void BtnCat1_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();

            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat1.Text;

        }

        private void BtnCat2_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat2.Text;
        }

        private void BtnCat3_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat3.Text;
        }

        private void BtnCat4_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat4.Text;
        }

        private void BtnCat5_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat5.Text;
        }

        private void BtnCat6_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat6.Text;
        }

        private void BtnCat7_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            PanelGaleria.Visible = true;
            PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat7.Text;
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
