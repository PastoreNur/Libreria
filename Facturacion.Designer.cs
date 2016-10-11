namespace Libreria
{
    partial class Facturacion
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Facturacion));
            this.Bar = new System.Windows.Forms.Panel();
            this.BtnCerrar = new System.Windows.Forms.Button();
            this.ListProductos = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BtnPagar = new System.Windows.Forms.Button();
            this.Bar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Bar
            // 
            this.Bar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(58)))), ((int)(((byte)(69)))));
            this.Bar.Controls.Add(this.BtnCerrar);
            this.Bar.Dock = System.Windows.Forms.DockStyle.Top;
            this.Bar.Location = new System.Drawing.Point(0, 0);
            this.Bar.Name = "Bar";
            this.Bar.Size = new System.Drawing.Size(815, 30);
            this.Bar.TabIndex = 0;
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.BackColor = System.Drawing.Color.Transparent;
            this.BtnCerrar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.BackgroundImage")));
            this.BtnCerrar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnCerrar.FlatAppearance.BorderSize = 0;
            this.BtnCerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCerrar.Location = new System.Drawing.Point(785, 0);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(30, 30);
            this.BtnCerrar.TabIndex = 1;
            this.BtnCerrar.UseVisualStyleBackColor = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // ListProductos
            // 
            this.ListProductos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.ListProductos.CheckBoxes = true;
            this.ListProductos.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader3,
            this.columnHeader2});
            this.ListProductos.GridLines = true;
            this.ListProductos.Location = new System.Drawing.Point(40, 134);
            this.ListProductos.Name = "ListProductos";
            this.ListProductos.Size = new System.Drawing.Size(687, 259);
            this.ListProductos.TabIndex = 1;
            this.ListProductos.UseCompatibleStateImageBehavior = false;
            this.ListProductos.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "";
            this.columnHeader5.Width = 18;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Código";
            this.columnHeader4.Width = 82;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Descripción";
            this.columnHeader1.Width = 429;
            // 
            // columnHeader3
            // 
            this.columnHeader3.DisplayIndex = 4;
            this.columnHeader3.Text = "Precio";
            this.columnHeader3.Width = 79;
            // 
            // columnHeader2
            // 
            this.columnHeader2.DisplayIndex = 3;
            this.columnHeader2.Text = "Cantidad";
            this.columnHeader2.Width = 75;
            // 
            // BtnPagar
            // 
            this.BtnPagar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BtnPagar.BackgroundImage")));
            this.BtnPagar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.BtnPagar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnPagar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnPagar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnPagar.Location = new System.Drawing.Point(636, 399);
            this.BtnPagar.Name = "BtnPagar";
            this.BtnPagar.Size = new System.Drawing.Size(111, 49);
            this.BtnPagar.TabIndex = 2;
            this.BtnPagar.Text = "Pagar";
            this.BtnPagar.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BtnPagar.UseVisualStyleBackColor = true;
            // 
            // Facturacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(815, 470);
            this.Controls.Add(this.BtnPagar);
            this.Controls.Add(this.ListProductos);
            this.Controls.Add(this.Bar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Facturacion";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Facturacion";
            this.Bar.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Bar;
        private System.Windows.Forms.Button BtnCerrar;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button BtnPagar;
        public System.Windows.Forms.ListView ListProductos;
        public System.Windows.Forms.ColumnHeader columnHeader5;
        public System.Windows.Forms.ColumnHeader columnHeader2;
    }
}