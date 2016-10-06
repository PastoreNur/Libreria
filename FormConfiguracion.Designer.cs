namespace Libreria
{
    partial class FormConfiguracion
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
            this.panelprincipal = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTipoUser = new System.Windows.Forms.Label();
            this.groupBoxAparienciaInvitado = new System.Windows.Forms.GroupBox();
            this.groupBoxTipodetema = new System.Windows.Forms.GroupBox();
            this.radioButtonTemaStock = new System.Windows.Forms.RadioButton();
            this.radioButtonTemaPersonal = new System.Windows.Forms.RadioButton();
            this.groupBoxTemasStock = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBoxTemaPersonal = new System.Windows.Forms.GroupBox();
            this.panelprincipal.SuspendLayout();
            this.groupBoxAparienciaInvitado.SuspendLayout();
            this.groupBoxTipodetema.SuspendLayout();
            this.groupBoxTemasStock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelprincipal
            // 
            this.panelprincipal.Controls.Add(this.groupBoxAparienciaInvitado);
            this.panelprincipal.Controls.Add(this.labelTipoUser);
            this.panelprincipal.Controls.Add(this.label1);
            this.panelprincipal.Location = new System.Drawing.Point(1, 0);
            this.panelprincipal.Name = "panelprincipal";
            this.panelprincipal.Size = new System.Drawing.Size(813, 397);
            this.panelprincipal.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(11, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tipo de Usuario:";
            // 
            // labelTipoUser
            // 
            this.labelTipoUser.AutoSize = true;
            this.labelTipoUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTipoUser.Location = new System.Drawing.Point(166, 23);
            this.labelTipoUser.Name = "labelTipoUser";
            this.labelTipoUser.Size = new System.Drawing.Size(0, 20);
            this.labelTipoUser.TabIndex = 1;
            // 
            // groupBoxAparienciaInvitado
            // 
            this.groupBoxAparienciaInvitado.Controls.Add(this.groupBoxTemaPersonal);
            this.groupBoxAparienciaInvitado.Controls.Add(this.groupBoxTemasStock);
            this.groupBoxAparienciaInvitado.Controls.Add(this.groupBoxTipodetema);
            this.groupBoxAparienciaInvitado.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxAparienciaInvitado.Location = new System.Drawing.Point(15, 58);
            this.groupBoxAparienciaInvitado.Name = "groupBoxAparienciaInvitado";
            this.groupBoxAparienciaInvitado.Size = new System.Drawing.Size(769, 314);
            this.groupBoxAparienciaInvitado.TabIndex = 2;
            this.groupBoxAparienciaInvitado.TabStop = false;
            this.groupBoxAparienciaInvitado.Text = "Apariencia";
            // 
            // groupBoxTipodetema
            // 
            this.groupBoxTipodetema.Controls.Add(this.radioButtonTemaPersonal);
            this.groupBoxTipodetema.Controls.Add(this.radioButtonTemaStock);
            this.groupBoxTipodetema.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTipodetema.Location = new System.Drawing.Point(47, 34);
            this.groupBoxTipodetema.Name = "groupBoxTipodetema";
            this.groupBoxTipodetema.Size = new System.Drawing.Size(226, 115);
            this.groupBoxTipodetema.TabIndex = 0;
            this.groupBoxTipodetema.TabStop = false;
            this.groupBoxTipodetema.Text = "Tipo de tema";
            // 
            // radioButtonTemaStock
            // 
            this.radioButtonTemaStock.AutoSize = true;
            this.radioButtonTemaStock.Location = new System.Drawing.Point(6, 38);
            this.radioButtonTemaStock.Name = "radioButtonTemaStock";
            this.radioButtonTemaStock.Size = new System.Drawing.Size(196, 28);
            this.radioButtonTemaStock.TabIndex = 0;
            this.radioButtonTemaStock.TabStop = true;
            this.radioButtonTemaStock.Text = "Temas Predefinidos";
            this.radioButtonTemaStock.UseVisualStyleBackColor = true;
            // 
            // radioButtonTemaPersonal
            // 
            this.radioButtonTemaPersonal.AutoSize = true;
            this.radioButtonTemaPersonal.Location = new System.Drawing.Point(6, 81);
            this.radioButtonTemaPersonal.Name = "radioButtonTemaPersonal";
            this.radioButtonTemaPersonal.Size = new System.Drawing.Size(201, 28);
            this.radioButtonTemaPersonal.TabIndex = 1;
            this.radioButtonTemaPersonal.TabStop = true;
            this.radioButtonTemaPersonal.Text = "Tema Personalizado";
            this.radioButtonTemaPersonal.UseVisualStyleBackColor = true;
            // 
            // groupBoxTemasStock
            // 
            this.groupBoxTemasStock.Controls.Add(this.label2);
            this.groupBoxTemasStock.Controls.Add(this.comboBox1);
            this.groupBoxTemasStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTemasStock.Location = new System.Drawing.Point(450, 43);
            this.groupBoxTemasStock.Name = "groupBoxTemasStock";
            this.groupBoxTemasStock.Size = new System.Drawing.Size(265, 106);
            this.groupBoxTemasStock.TabIndex = 1;
            this.groupBoxTemasStock.TabStop = false;
            this.groupBoxTemasStock.Text = "Temas Predefinidos";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(22, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(221, 32);
            this.comboBox1.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Seleccione una opción:";
            // 
            // groupBoxTemaPersonal
            // 
            this.groupBoxTemaPersonal.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBoxTemaPersonal.Location = new System.Drawing.Point(21, 188);
            this.groupBoxTemaPersonal.Name = "groupBoxTemaPersonal";
            this.groupBoxTemaPersonal.Size = new System.Drawing.Size(694, 100);
            this.groupBoxTemaPersonal.TabIndex = 2;
            this.groupBoxTemaPersonal.TabStop = false;
            this.groupBoxTemaPersonal.Text = "Tema Personalizado";
            // 
            // FormConfiguracion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 397);
            this.Controls.Add(this.panelprincipal);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.IsMdiContainer = true;
            this.Name = "FormConfiguracion";
            this.Text = "FormConfiguracion";
            this.panelprincipal.ResumeLayout(false);
            this.panelprincipal.PerformLayout();
            this.groupBoxAparienciaInvitado.ResumeLayout(false);
            this.groupBoxTipodetema.ResumeLayout(false);
            this.groupBoxTipodetema.PerformLayout();
            this.groupBoxTemasStock.ResumeLayout(false);
            this.groupBoxTemasStock.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelprincipal;
        private System.Windows.Forms.GroupBox groupBoxAparienciaInvitado;
        private System.Windows.Forms.GroupBox groupBoxTemaPersonal;
        private System.Windows.Forms.GroupBox groupBoxTemasStock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.GroupBox groupBoxTipodetema;
        private System.Windows.Forms.RadioButton radioButtonTemaPersonal;
        private System.Windows.Forms.RadioButton radioButtonTemaStock;
        private System.Windows.Forms.Label labelTipoUser;
        private System.Windows.Forms.Label label1;
    }
}