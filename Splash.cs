﻿using System;
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


        //Abre El formulario principal (Catalogo)
        private void AbrirVentana()
        {
           Application.Run(new Principal());
        }

       Thread CerraVentana;
    
        //La función del timer que hace que la progressbar se llene
        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Minimum = 0;
            progressBar1.Maximum = 100;

            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 5;
            }
            else
            {
                //Ésto es lo que cierra el splash y llama el metodo de AbrirVentana
                timer1.Enabled = false;

                CerraVentana = new Thread(AbrirVentana);
                CerraVentana.SetApartmentState(ApartmentState.STA);
                CerraVentana.Start();
                this.Close();

            }
        }

        //Con ésto se inicia el timer al momento de carga del splash
        private void Splash_Load(object sender, EventArgs e)
        {
            this.timer1.Start();
        }

        
    }
}
