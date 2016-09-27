namespace Libreria
{
    partial class Splash
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Splash));
            this.splashimg = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.splashimg)).BeginInit();
            this.SuspendLayout();
            // 
            // splashimg
            // 
            this.splashimg.BackColor = System.Drawing.Color.Transparent;
            this.splashimg.Image = ((System.Drawing.Image)(resources.GetObject("splashimg.Image")));
            this.splashimg.Location = new System.Drawing.Point(0, 0);
            this.splashimg.Name = "splashimg";
            this.splashimg.Size = new System.Drawing.Size(500, 300);
            this.splashimg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.splashimg.TabIndex = 1;
            this.splashimg.TabStop = false;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(464, 265);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(24, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "->";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Splash
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.splashimg);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Splash";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Splash";
            this.TransparencyKey = System.Drawing.Color.Red;
            this.Load += new System.EventHandler(this.Splash_Load);
            ((System.ComponentModel.ISupportInitialize)(this.splashimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox splashimg;
        private System.Windows.Forms.Button button1;

    }
}