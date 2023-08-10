namespace mascotas
{
    partial class Form4
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
            btnguardardoctor = new Button();
            pictureBox1 = new PictureBox();
            direcionsede = new TextBox();
            telefonosede = new TextBox();
            nombresede = new TextBox();
            label4 = new Label();
            label1 = new Label();
            label2 = new Label();
            correosede = new TextBox();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnguardardoctor
            // 
            btnguardardoctor.Location = new Point(667, 324);
            btnguardardoctor.Name = "btnguardardoctor";
            btnguardardoctor.Size = new Size(174, 94);
            btnguardardoctor.TabIndex = 21;
            btnguardardoctor.Text = "Guardar";
            btnguardardoctor.UseVisualStyleBackColor = true;
            btnguardardoctor.Click += btnguardardoctor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descargar;
            pictureBox1.Location = new Point(648, 33);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(219, 236);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // direcionsede
            // 
            direcionsede.Location = new Point(215, 223);
            direcionsede.Name = "direcionsede";
            direcionsede.Size = new Size(263, 27);
            direcionsede.TabIndex = 19;
            // 
            // telefonosede
            // 
            telefonosede.Location = new Point(210, 148);
            telefonosede.Name = "telefonosede";
            telefonosede.Size = new Size(360, 27);
            telefonosede.TabIndex = 18;
            // 
            // nombresede
            // 
            nombresede.Location = new Point(199, 83);
            nombresede.Name = "nombresede";
            nombresede.Size = new Size(371, 27);
            nombresede.TabIndex = 17;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(110, 155);
            label4.Name = "label4";
            label4.Size = new Size(83, 20);
            label4.TabIndex = 16;
            label4.Text = "TELEFONO:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(91, 90);
            label1.Name = "label1";
            label1.Size = new Size(102, 20);
            label1.TabIndex = 14;
            label1.Text = "Nombre sede:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(91, 230);
            label2.Name = "label2";
            label2.Size = new Size(118, 20);
            label2.TabIndex = 13;
            label2.Text = "DIRECION SEDE:";
            // 
            // correosede
            // 
            correosede.Location = new Point(215, 280);
            correosede.Name = "correosede";
            correosede.Size = new Size(336, 27);
            correosede.TabIndex = 22;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(126, 283);
            label3.Name = "label3";
            label3.Size = new Size(55, 20);
            label3.TabIndex = 23;
            label3.Text = "correo:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(898, 443);
            Controls.Add(label3);
            Controls.Add(correosede);
            Controls.Add(btnguardardoctor);
            Controls.Add(pictureBox1);
            Controls.Add(direcionsede);
            Controls.Add(telefonosede);
            Controls.Add(nombresede);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(label2);
            Name = "Form4";
            Text = "Form4";
            Load += Form4_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnguardardoctor;
        private PictureBox pictureBox1;
        private TextBox direcionsede;
        private TextBox telefonosede;
        private TextBox nombresede;
        private Label label4;
        private Label label1;
        private Label label2;
        private TextBox correosede;
        protected Label label3;
    }
}