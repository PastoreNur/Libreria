namespace Libreria
{
    partial class FrmCatalogo
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelencabezado = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
<<<<<<< HEAD
            this.panelmenu = new System.Windows.Forms.Panel();
=======
            this.button2 = new System.Windows.Forms.Button();
>>>>>>> origin/master
            this.panelencabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelencabezado
            // 
            this.panelencabezado.Controls.Add(this.button2);
            this.panelencabezado.Controls.Add(this.button1);
            this.panelencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelencabezado.Location = new System.Drawing.Point(0, 0);
            this.panelencabezado.Name = "panelencabezado";
            this.panelencabezado.Size = new System.Drawing.Size(894, 42);
            this.panelencabezado.TabIndex = 2;
            // 
            // button1
            // 
<<<<<<< HEAD
            this.button1.Location = new System.Drawing.Point(446, 12);
=======
            this.button1.Location = new System.Drawing.Point(73, 13);
>>>>>>> origin/master
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clic";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // vScrollBar1
            // 
            this.vScrollBar1.Dock = System.Windows.Forms.DockStyle.Right;
            this.vScrollBar1.LargeChange = 101;
            this.vScrollBar1.Location = new System.Drawing.Point(877, 42);
            this.vScrollBar1.Name = "vScrollBar1";
            this.vScrollBar1.Size = new System.Drawing.Size(17, 505);
            this.vScrollBar1.TabIndex = 3;
            // 
<<<<<<< HEAD
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 42);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(134, 505);
            this.panelmenu.TabIndex = 5;
            this.panelmenu.MouseLeave += new System.EventHandler(this.panelmenu_MouseLeave);
            this.panelmenu.MouseHover += new System.EventHandler(this.panelmenu_MouseHover);
=======
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir Temporal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
>>>>>>> origin/master
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 547);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panelencabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatalogo";
            this.panelencabezado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelencabezado;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
<<<<<<< HEAD
        private System.Windows.Forms.Panel panelmenu;
=======
        private System.Windows.Forms.Button button2;
>>>>>>> origin/master
    }
}