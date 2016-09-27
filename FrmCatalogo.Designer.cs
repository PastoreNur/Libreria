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
            this.panelmenu = new System.Windows.Forms.Panel();
            this.panelencabezado = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.vScrollBar1 = new System.Windows.Forms.VScrollBar();
            this.button2 = new System.Windows.Forms.Button();
            this.panelencabezado.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 0);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(150, 547);
            this.panelmenu.TabIndex = 1;
            this.panelmenu.MouseLeave += new System.EventHandler(this.panelmenu_MouseLeave);
            this.panelmenu.MouseHover += new System.EventHandler(this.panelmenu_MouseHover);
            // 
            // panelencabezado
            // 
            this.panelencabezado.Controls.Add(this.button2);
            this.panelencabezado.Controls.Add(this.button1);
            this.panelencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelencabezado.Location = new System.Drawing.Point(150, 0);
            this.panelencabezado.Name = "panelencabezado";
            this.panelencabezado.Size = new System.Drawing.Size(744, 42);
            this.panelencabezado.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(73, 13);
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
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(584, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(127, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "Salir Temporal";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(894, 547);
            this.Controls.Add(this.vScrollBar1);
            this.Controls.Add(this.panelencabezado);
            this.Controls.Add(this.panelmenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmCatalogo";
            this.Text = "FrmCatalogo";
            this.Load += new System.EventHandler(this.FrmCatalogo_Load);
            this.MouseLeave += new System.EventHandler(this.FrmCatalogo_MouseLeave);
            this.panelencabezado.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.Panel panelencabezado;
        private System.Windows.Forms.VScrollBar vScrollBar1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}