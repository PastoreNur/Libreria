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
    public class ClsInformacion
    {
        
        
        public int Categoria = 0;
        public int Scroll = 0;


        public void Infomacion_Categoria(int Infcategoria, int scroll) 
        {
            Scroll = scroll;
             Categoria = Infcategoria;

            switch (Categoria)
            {
                case 1:

                    switch (Scroll)
	                        {
                            case 1:
                            //Contenido Scroll 1 categoria 1
                                   // MessageBox.Show("Clase funcionando scroll 1");
                            break;

                            case 2:
                            //Contenido Scroll 2 categoria 1
                            //MessageBox.Show("scroll 2");
                            break;
	                        }

                    break;
                case 2:
                    switch (Scroll)
	                        {
                            case 1:
                            //Contenido Scroll 1 categoria 2
                                    MessageBox.Show("Cat2 scr1");
                            break;

                            case 2:
                            //Contenido Scroll 2 categoria 2
                            MessageBox.Show("Cat2 scr2");
                            break;
	                        }
                    break;
                case 3:
                    switch (Scroll)
	                        {
                            case 1:
                            //contenido Scroll 1 Categoria 3
                            break;

                            case 2:
                            //Contenido Scroll 2 Categoria 3
                            break;
                            }
                    break;
                        case 4:
                            switch (Scroll)
	                        {
                            case 1:
                            //Contenido Scroll 1 Categoria 4
                            break;
                                
                            case 2:
                            //Contenido Scroll 2 Categoria 4
                            break;
	                        }
                            break;
                case 5:
                    switch (Scroll)
	                        {
                            case 1:
                            //Contenido Scroll 1 Categoria 5
                            break;

                            case 2:
                            //Contenido Scroll 2 Categoria 5
                            break;
	                        }
                            break;
                case 6:
                    switch (Scroll)
	                        {
                            case 1:
                            //Contenido Scroll 1 Categoria 6
                            break;
                        case 2:
                            //Contenido Scroll 2 Categoria 6
                            break;
	                        }
                            break;
                case 7:
                    switch (Scroll)
	                        {
                            case 1:
                            //Contenido Scroll 1 Categoria 7
                            break;

                        case 2:
                            //Contemido Scroll 2 Categoria 7
                            break;
	                        }
                            break;
            }
        }
    }
}
