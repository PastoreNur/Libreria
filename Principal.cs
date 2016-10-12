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
            this.DoubleBuffered = true;
            this.MouseWheel += new MouseEventHandler(panelFondo_Wheel);
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
        int timermousewheelint = 0;
        //Variables Importantes
        //En serio muy importantes
        //Variables de cambio de informacion
        int scroll = 0;
        int categoria = 0;
        //Clase cambio de informacion
        ClsInformacion Cambio = new ClsInformacion();

        int animacioncategoria = 23;
        public void Animacion_Categoria(int categoria, int scroll) 
        {
            //desaparecer
            while (animacioncategoria <= 950)
            {
                animacioncategoria += 4;
                panelGaleria.Location = new Point(animacioncategoria, animacionscroll);
            }
            //Cambio de informacion


            //Metodo de cambio de informacion con switch
            Cambio.Infomacion_Categoria(categoria, scroll);
            
            
            //Reaparecer
            animacioncategoria = -950;
            while (animacioncategoria <= 23)
            {
                animacioncategoria += 4;
                panelGaleria.Location = new Point(animacioncategoria, animacionscroll);
            }
        }


        void panelFondo_Wheel(object sender, MouseEventArgs e)
        {
            do
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

                    if (scroll == 1)
                    {
                        scroll = 2;
                        Cambio.Infomacion_Categoria(categoria, scroll);
                    }
                    else if(scroll == 2)
                    {
                        scroll = 1;
                        Cambio.Infomacion_Categoria(categoria, scroll);
                    }
                    else
                    {
                        MessageBox.Show("Error fatal scroll fuera de rango");
                    }

                    

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

                    if (scroll == 1)
                    {
                        scroll = 2;
                    }
                    else if (scroll == 2)
                    {
                        scroll = 1;
                    }
                    else
                    {
                        MessageBox.Show("Error fatal scroll fuera de rango");
                    }

                    Cambio.Infomacion_Categoria(categoria,scroll);

                    //Animacion aparecer
                    animacionscroll = -640;
                    panelGaleria.Location = new Point(26, animacionscroll);

                    while (animacionscroll <= 6)
                    {
                        animacionscroll += 4;
                        panelGaleria.Location = new Point(26, animacionscroll);
                    }
                }
                TimerMouseWheelRest.Start();
            } while (timermousewheelint != 0);
            
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
           
            PopUpCarrito.BringToFront();
      
            

            
        }

        private void BtnIngresarBar_Click(object sender, EventArgs e)
        {
            IniciarSesion();
        }

        private void BtnCerrarGaleria_Click(object sender, EventArgs e)
        {

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
            //Variable categoria para el paramentro de la clase informacion
            categoria = 1;
            //Arriba
            scroll = 1;
            ocultarLoginBar();
            Animacion_Categoria(categoria,scroll);
            lblNombreCategoriaBar.Text = BtnCat1.Text;

        }

        private void BtnCat2_Click(object sender, EventArgs e)
        {
            //Variable categoria para el paramentro de la clase informacion
            categoria = 2;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat2.Text;
        }

        private void BtnCat3_Click(object sender, EventArgs e)
        {
            //Variable categoria para el paramentro de la clase informacion
            categoria = 3;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat3.Text;
        }

        private void BtnCat4_Click(object sender, EventArgs e)
        {
            //Variable categoria para el paramentro de la clase informacion
            categoria = 4;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat4.Text;
        }

        private void BtnCat5_Click(object sender, EventArgs e)
        {
            //Variable categoria para el paramentro de la clase informacion
            categoria = 5;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat5.Text;
        }

        private void BtnCat6_Click(object sender, EventArgs e)
        {
            //Variable categoria para el paramentro de la clase informacion
            categoria = 6;
            //Arriba
            scroll = 1;
            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
            lblNombreCategoriaBar.Text = BtnCat6.Text;
        }

        private void BtnCat7_Click(object sender, EventArgs e)
        {
            //Variable categoria para el paramentro de la clase informacion
            categoria = 7;
            //Arriba
            scroll = 1;

            Animacion_Categoria(categoria,scroll);
            ocultarLoginBar();
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


        private void TimerMouseWheelRest_Tick(object sender, EventArgs e)
        {
            timermousewheelint = 0;
            TimerMouseWheelRest.Stop();
        }


        /*
          try
            {
                System.Diagnostics.Process.Start("http://www.microsoft.com");
            }
            catch { }
         */
    }
}
