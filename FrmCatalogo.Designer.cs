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


        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCatalogo));
            this.panelencabezado = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panelmenu = new System.Windows.Forms.Panel();
            this.PanelCat1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelencabezado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panelmenu.SuspendLayout();
            this.PanelCat1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelencabezado
            // 
            this.panelencabezado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(42)))), ((int)(((byte)(62)))), ((int)(((byte)(80)))));
            this.panelencabezado.Controls.Add(this.BtnCerrar);
            this.panelencabezado.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelencabezado.Location = new System.Drawing.Point(0, 0);
            this.panelencabezado.Name = "panelencabezado";
            this.panelencabezado.Size = new System.Drawing.Size(900, 45);
            this.panelencabezado.TabIndex = 2;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(867, 6);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panelmenu
            // 
            this.panelmenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(126)))), ((int)(((byte)(34)))));
            this.panelmenu.Controls.Add(this.PanelCat1);
            this.panelmenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelmenu.Location = new System.Drawing.Point(0, 45);
            this.panelmenu.Name = "panelmenu";
            this.panelmenu.Size = new System.Drawing.Size(60, 555);
            this.panelmenu.TabIndex = 5;
            this.panelmenu.MouseLeave += new System.EventHandler(this.panelmenu_MouseLeave);
            this.panelmenu.MouseHover += new System.EventHandler(this.panelmenu_MouseHover);
            // 
            // PanelCat1
            // 
            this.PanelCat1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(71)))), ((int)(((byte)(71)))));
            this.PanelCat1.Controls.Add(this.label1);
            this.PanelCat1.Location = new System.Drawing.Point(0, 0);
            this.PanelCat1.Name = "PanelCat1";
            this.PanelCat1.Size = new System.Drawing.Size(162, 57);
            this.PanelCat1.TabIndex = 0;
            this.PanelCat1.MouseHover += new System.EventHandler(this.panel1_MouseHover);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(61, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Categoria1";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            this.label1.MouseLeave += new System.EventHandler(this.label1_MouseLeave);
            // 
            // FrmCatalogo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(195)))), ((int)(((byte)(199)))));
            this.ClientSize = new System.Drawing.Size(900, 600);
            this.Controls.Add(this.panelmenu);
            this.Controls.Add(this.panelencabezado);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FrmCatalogo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCatalogo";
            this.panelencabezado.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panelmenu.ResumeLayout(false);
            this.PanelCat1.ResumeLayout(false);
            this.PanelCat1.PerformLayout();
            this.ResumeLayout(false);

        }
        private System.Windows.Forms.Panel panelencabezado;
        private System.Windows.Forms.Panel panelmenu;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Panel PanelCat1;
        private System.Windows.Forms.Label label1;


    }
}