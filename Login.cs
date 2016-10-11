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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        

        private void BtnMostrarContraseña_Click(object sender, EventArgs e)
        {
            if (txtContraseña.UseSystemPasswordChar == true)
            {
                BtnMostrarContraseña.BackgroundImage = Image.FromFile("Invisible-48.png");
                txtContraseña.UseSystemPasswordChar = false;
            }
            else if(txtContraseña.UseSystemPasswordChar == false)
            {
                BtnMostrarContraseña.BackgroundImage = Image.FromFile("Visible-48.png");
                txtContraseña.UseSystemPasswordChar = true;
            }
        }

         Principal principal = new Principal();

        private void BtnIniciarSesion_Click(object sender, EventArgs e)
        {
            string nombre = principal.Nombre;
            string usuario = principal.Usuario;
            string contraseña = principal.contraseña;
            Facturacion facturacion = new Facturacion();

            if (txtUsuario.Text == usuario)
            {
                
                if (txtContraseña.Text == contraseña)
                {
                    
                    principal.LblUsuario.Text = nombre + "!";
                    
                    principal.lblSaludo.Text = "¡Hola";
                    principal.loginBar.Size = new Size(width: 280, height: 0);
                    principal.loginBar.Enabled = false;
                    txtUsuario.Clear();
                    txtContraseña.Clear();
                    principal.login = true;
                    facturacion.Show();
                    this.Close();
                    principal.BringToFront();

                }
                else
                {
                    MessageBox.Show("Contraseña Incorrecta", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                    txtContraseña.Clear();
                }
            }
            else
            {
                MessageBox.Show("Usuario Incorrecto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
               
                txtUsuario.Clear();
            }
        }
    }
}
