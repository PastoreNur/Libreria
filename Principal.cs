﻿using System;
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
            this.DoubleBuffered = true;
            this.MouseWheel += new MouseEventHandler(panelFondo_Wheel);
        }

        



        void panelFondo_Wheel(object sender, MouseEventArgs e)
        {

            if (e.Delta > 0)
            {
                //Scroll arriba

                //Animacion desaparecer
                while (animacionscroll >= -640)
                {
                   animacionscroll -= 4;
                    panelGaleria.Location = new Point(26, animacionscroll); 
                }


                //Cambio de informacion de la galeria


                //Animacion aparecer
                animacionscroll = 640;
                panelGaleria.Location = new Point(26, animacionscroll);

                while (animacionscroll >= 5)
                {
                    animacionscroll -= 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }
            }
            else
            {
                //Scroll Abajo

                //Animacion desaparecer
                while (animacionscroll <= 606)
                {
                    animacionscroll += 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }


                //Cambio de informacion de la galeria


                //Animacion aparecer
                animacionscroll = -640;
                panelGaleria.Location = new Point(26, animacionscroll);

                while (animacionscroll <= 6)
                {
                    animacionscroll += 4;
                    panelGaleria.Location = new Point(26, animacionscroll);
                }
            }
                

           
        }




        //Método para iniciar sesión
        public void IniciarSesion()
        {
            if (txtUsuarioBar.Text == Usuario)
            {
                if (txtPAsswordBar.Text == contraseña)
                {
                    LblUsuario.Text = Nombre + "!";
                    lblSaludo.Text = "¡Hola";
                    loginBar.Size = new Size(width: 280, height: 0);
                    loginBar.Enabled = false;
                    txtPAsswordBar.Clear();
                    txtUsuarioBar.Clear();
                    login = true;

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

        public void ExtenderLoginBar()
        {
            if (loginBar.Enabled == false)
            {
                loginBar.Size = new Size(width: 280, height: 200);
                loginBar.Enabled = true;
                PopUpCarrito.Size = new Size(width: 0, height: 0);
                PopUpCarrito.Enabled = false;
                PopUpCarrito.Visible = false;
            }
            else if (loginBar.Enabled == true)
            {
                loginBar.Enabled = false;
                loginBar.Size = new Size(width: 280, height: 0);

            }
            
        }

        //Variables para inicio de sesion
        public string Usuario = "Invitado";
        public string Nombre = "Invitado";
        public string contraseña = "1234";
        //Variable para desactivar el loginbar
        public bool login = false;
        //Variables animacion panel categorias
        public int anchopanel = 60;
        //Variables animacion panel galeria
        int animacionscroll = 6;

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

        

        private void Principal_Load(object sender, EventArgs e)
        {
            PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            loginBar.BringToFront();
            //PanelGaleria.Size = new Size(width: 0, height: 0);
            //PanelGaleria.Visible = false;
            PopUpCarrito.BringToFront();
            /*lblNombreCategoriaBar.Text = "";
            lblSaludo.Text = "¡Aún no haz";
            LblUsuario.Text = "Iniciado Sesión!";*/
            

            
        }

        private void BtnIngresarBar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void BtnCerrarGaleria_Click(object sender, EventArgs e)
        {
            //PanelGaleria.Size = new Size(width:0,height:0);
            //PanelGaleria.Visible = false;
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

           // PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat1.Text;

        }

        private void BtnCat2_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            //PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat2.Text;
        }

        private void BtnCat3_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            //PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat3.Text;
        }

        private void BtnCat4_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            //PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat4.Text;
        }

        private void BtnCat5_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            //PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat5.Text;
        }

        private void BtnCat6_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            //PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat6.Text;
        }

        private void BtnCat7_Click(object sender, EventArgs e)
        {
            ocultarLoginBar();
            //PanelGaleria.Visible = true;
            //PanelGaleria.Size = new Size(width: 825, height: 595);
            lblNombreCategoriaBar.Text = BtnCat7.Text;
        }

        private void BtnCat7_MouseHover(object sender, EventArgs e)
        {
            while (anchopanel <= 178)
            {
                anchopanel = anchopanel + 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel,630); 
            }
      
        }

        private void BtnCat7_MouseLeave(object sender, EventArgs e)
        {

        }

        private void BtnCat7_MouseLeave_1(object sender, EventArgs e)
        {
            while (anchopanel >= 60)
            {
                anchopanel = anchopanel - 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            }
        }

        private void PanelCategorias_MouseHover(object sender, EventArgs e)
        {
            while (anchopanel <= 178)
            {
                anchopanel = anchopanel + 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            }
        }

        private void PanelCategorias_MouseLeave(object sender, EventArgs e)
        {
            while (anchopanel >= 60)
            {
                anchopanel = anchopanel - 3;
                PanelCategorias.Size = new System.Drawing.Size(anchopanel, 630);
            }
        }

       

        private void BtnUserBar_Click(object sender, EventArgs e)
        {
            if (login)
            {

            }
            else
            {
                ExtenderLoginBar();
            }
        }

        //Botton Carrito

        private void button1_Click(object sender, EventArgs e)
        {
            if (PopUpCarrito.Enabled == false)
            {
                PopUpCarrito.Location = new Point(535,2);
             
                
                PopUpCarrito.Size = new Size(width: 400, height: 340);
                PopUpCarrito.Enabled = true;
                PopUpCarrito.Visible = true;
                loginBar.Enabled = false;
                loginBar.Size = new Size(width: 280, height: 0);
            }
            else if (PopUpCarrito.Enabled == true)
            {
                PopUpCarrito.Size = new Size(width: 0, height: 0);
                PopUpCarrito.Enabled = false;
                PopUpCarrito.Visible = false;
            }
        }

        private void BtnPagar_Click(object sender, EventArgs e)
        {
            if (login == false)
            {
               DialogResult Mensaje = MessageBox.Show("¡Necesitas Iniciar Sesión!", "AVISO", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

               if (Mensaje == DialogResult.OK)
               {
                   Login loginVentana = new Login();
                   loginVentana.MdiParent = this;
                   PopUpCarrito.Size = new Size(width: 0, height: 0);
                   PopUpCarrito.Enabled = false;
                   PopUpCarrito.Visible = false;
                   loginVentana.Show();
                   loginVentana.BringToFront();
                   

               }
           

            }
            else
            {
                Facturacion factura = new Facturacion();
                factura.MdiParent = this;
                PopUpCarrito.Size = new Size(width: 0, height: 0);
                PopUpCarrito.Enabled = false;
                PopUpCarrito.Visible = false;
                factura.Show();
                factura.BringToFront();
                
            }
        }
  
        private void panel9_Scroll(object sender, ScrollEventArgs e)
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
