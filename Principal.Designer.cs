namespace Libreria
{
    partial class Principal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Principal));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnMinimizar = new System.Windows.Forms.PictureBox();
            this.BtnCerrar = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.LblUsuario = new System.Windows.Forms.Label();
            this.BtnUser = new System.Windows.Forms.PictureBox();
            this.BtnCarrito = new System.Windows.Forms.PictureBox();
            this.loginBar = new System.Windows.Forms.Panel();
            this.BtnIngresarBar = new System.Windows.Forms.Button();
            this.txtPAsswordBar = new System.Windows.Forms.TextBox();
            this.txtUsuarioBar = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUser)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCarrito)).BeginInit();
            this.loginBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.BtnMinimizar);
            this.panel1.Controls.Add(this.BtnCerrar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1000, 30);
            this.panel1.TabIndex = 1;
            // 
            // BtnMinimizar
            // 
            this.BtnMinimizar.Image = ((System.Drawing.Image)(resources.GetObject("BtnMinimizar.Image")));
            this.BtnMinimizar.Location = new System.Drawing.Point(939, 2);
            this.BtnMinimizar.Name = "BtnMinimizar";
            this.BtnMinimizar.Size = new System.Drawing.Size(25, 25);
            this.BtnMinimizar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnMinimizar.TabIndex = 3;
            this.BtnMinimizar.TabStop = false;
            this.BtnMinimizar.Click += new System.EventHandler(this.BtnMinimizar_Click);
            // 
            // BtnCerrar
            // 
            this.BtnCerrar.Image = ((System.Drawing.Image)(resources.GetObject("BtnCerrar.Image")));
            this.BtnCerrar.Location = new System.Drawing.Point(969, 2);
            this.BtnCerrar.Name = "BtnCerrar";
            this.BtnCerrar.Size = new System.Drawing.Size(25, 25);
            this.BtnCerrar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCerrar.TabIndex = 2;
            this.BtnCerrar.TabStop = false;
            this.BtnCerrar.Click += new System.EventHandler(this.BtnCerrar_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.LblUsuario);
            this.panel2.Controls.Add(this.BtnUser);
            this.panel2.Controls.Add(this.BtnCarrito);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 30);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1000, 40);
            this.panel2.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(401, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Nombre de Categoría";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(871, 3);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Entrar";
            // 
            // LblUsuario
            // 
            this.LblUsuario.AutoSize = true;
            this.LblUsuario.Location = new System.Drawing.Point(871, 22);
            this.LblUsuario.Name = "LblUsuario";
            this.LblUsuario.Size = new System.Drawing.Size(83, 13);
            this.LblUsuario.TabIndex = 2;
            this.LblUsuario.Text = "Nombre Usuario";
            // 
            // BtnUser
            // 
            this.BtnUser.Image = ((System.Drawing.Image)(resources.GetObject("BtnUser.Image")));
            this.BtnUser.Location = new System.Drawing.Point(838, 5);
            this.BtnUser.Name = "BtnUser";
            this.BtnUser.Size = new System.Drawing.Size(30, 30);
            this.BtnUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnUser.TabIndex = 1;
            this.BtnUser.TabStop = false;
            this.BtnUser.Click += new System.EventHandler(this.BtnUser_Click);
            // 
            // BtnCarrito
            // 
            this.BtnCarrito.Image = ((System.Drawing.Image)(resources.GetObject("BtnCarrito.Image")));
            this.BtnCarrito.Location = new System.Drawing.Point(960, 5);
            this.BtnCarrito.Name = "BtnCarrito";
            this.BtnCarrito.Size = new System.Drawing.Size(30, 30);
            this.BtnCarrito.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.BtnCarrito.TabIndex = 0;
            this.BtnCarrito.TabStop = false;
            // 
            // loginBar
            // 
            this.loginBar.BackColor = System.Drawing.Color.Transparent;
            this.loginBar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("loginBar.BackgroundImage")));
            this.loginBar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.loginBar.Controls.Add(this.BtnIngresarBar);
            this.loginBar.Controls.Add(this.txtPAsswordBar);
            this.loginBar.Controls.Add(this.txtUsuarioBar);
            this.loginBar.Enabled = false;
            this.loginBar.Location = new System.Drawing.Point(715, 72);
            this.loginBar.Name = "loginBar";
            this.loginBar.Size = new System.Drawing.Size(280, 1);
            this.loginBar.TabIndex = 3;
            // 
            // BtnIngresarBar
            // 
            this.BtnIngresarBar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.BtnIngresarBar.Location = new System.Drawing.Point(174, 160);
            this.BtnIngresarBar.Name = "BtnIngresarBar";
            this.BtnIngresarBar.Size = new System.Drawing.Size(75, 23);
            this.BtnIngresarBar.TabIndex = 2;
            this.BtnIngresarBar.Text = "Ingresar";
            this.BtnIngresarBar.UseVisualStyleBackColor = true;
            // 
            // txtPAsswordBar
            // 
            this.txtPAsswordBar.BackColor = System.Drawing.SystemColors.MenuBar;
            this.txtPAsswordBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPAsswordBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPAsswordBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtPAsswordBar.Location = new System.Drawing.Point(36, 117);
            this.txtPAsswordBar.Name = "txtPAsswordBar";
            this.txtPAsswordBar.Size = new System.Drawing.Size(169, 19);
            this.txtPAsswordBar.TabIndex = 1;
            this.txtPAsswordBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtPAsswordBar.UseSystemPasswordChar = true;
            // 
            // txtUsuarioBar
            // 
            this.txtUsuarioBar.BackColor = System.Drawing.SystemColors.Menu;
            this.txtUsuarioBar.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUsuarioBar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsuarioBar.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.txtUsuarioBar.Location = new System.Drawing.Point(36, 67);
            this.txtUsuarioBar.Name = "txtUsuarioBar";
            this.txtUsuarioBar.Size = new System.Drawing.Size(169, 19);
            this.txtUsuarioBar.TabIndex = 0;
            this.txtUsuarioBar.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 700);
            this.Controls.Add(this.loginBar);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Principal_FormClosing);
            this.Load += new System.EventHandler(this.Principal_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BtnMinimizar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCerrar)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BtnUser)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BtnCarrito)).EndInit();
            this.loginBar.ResumeLayout(false);
            this.loginBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox BtnMinimizar;
        private System.Windows.Forms.PictureBox BtnCerrar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label LblUsuario;
        private System.Windows.Forms.PictureBox BtnUser;
        private System.Windows.Forms.PictureBox BtnCarrito;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel loginBar;
        private System.Windows.Forms.TextBox txtPAsswordBar;
        private System.Windows.Forms.TextBox txtUsuarioBar;
        private System.Windows.Forms.Button BtnIngresarBar;

    }
}