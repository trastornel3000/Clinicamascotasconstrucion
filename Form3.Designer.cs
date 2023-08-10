namespace mascotas
{
    partial class Form3
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
            panel1 = new Panel();
            telefonodoctor = new TextBox();
            label5 = new Label();
            btnguardardoctor = new Button();
            pictureBox1 = new PictureBox();
            doctorcedula = new TextBox();
            doctortarejta = new TextBox();
            doctornombre = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            label2 = new Label();
            doctornacimiento = new DateTimePicker();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(doctornacimiento);
            panel1.Controls.Add(telefonodoctor);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(btnguardardoctor);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(doctorcedula);
            panel1.Controls.Add(doctortarejta);
            panel1.Controls.Add(doctornombre);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(label2);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(905, 505);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // telefonodoctor
            // 
            telefonodoctor.Location = new Point(181, 266);
            telefonodoctor.Name = "telefonodoctor";
            telefonodoctor.Size = new Size(371, 27);
            telefonodoctor.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(86, 273);
            label5.Name = "label5";
            label5.Size = new Size(70, 20);
            label5.TabIndex = 10;
            label5.Text = "Telefono:";
            // 
            // btnguardardoctor
            // 
            btnguardardoctor.Location = new Point(650, 345);
            btnguardardoctor.Name = "btnguardardoctor";
            btnguardardoctor.Size = new Size(174, 94);
            btnguardardoctor.TabIndex = 9;
            btnguardardoctor.Text = "Guardar";
            btnguardardoctor.UseVisualStyleBackColor = true;
            btnguardardoctor.Click += btnguardardoctor_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descargar;
            pictureBox1.Location = new Point(613, 25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(246, 236);
            pictureBox1.TabIndex = 8;
            pictureBox1.TabStop = false;
            // 
            // doctorcedula
            // 
            doctorcedula.Location = new Point(193, 148);
            doctorcedula.Name = "doctorcedula";
            doctorcedula.Size = new Size(263, 27);
            doctorcedula.TabIndex = 7;
            // 
            // doctortarejta
            // 
            doctortarejta.Location = new Point(202, 212);
            doctortarejta.Name = "doctortarejta";
            doctortarejta.Size = new Size(360, 27);
            doctortarejta.TabIndex = 6;
            // 
            // doctornombre
            // 
            doctornombre.Location = new Point(181, 69);
            doctornombre.Name = "doctornombre";
            doctornombre.Size = new Size(371, 27);
            doctornombre.TabIndex = 4;
            doctornombre.TextChanged += doctornombre_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(4, 212);
            label4.Name = "label4";
            label4.Size = new Size(192, 20);
            label4.TabIndex = 3;
            label4.Text = "Numero tarjeta profesional:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(15, 345);
            label3.Name = "label3";
            label3.Size = new Size(149, 20);
            label3.TabIndex = 2;
            label3.Text = "Fecha de nacimiento:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(47, 76);
            label1.Name = "label1";
            label1.Size = new Size(117, 20);
            label1.TabIndex = 1;
            label1.Text = "Nombre Doctor:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(106, 148);
            label2.Name = "label2";
            label2.Size = new Size(58, 20);
            label2.TabIndex = 0;
            label2.Text = "Cedula:";
            // 
            // doctornacimiento
            // 
            doctornacimiento.Location = new Point(193, 345);
            doctornacimiento.Name = "doctornacimiento";
            doctornacimiento.Size = new Size(250, 27);
            doctornacimiento.TabIndex = 12;
            doctornacimiento.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(905, 505);
            Controls.Add(panel1);
            Name = "Form3";
            Text = "Form3";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label3;
        private TextBox doctorcedula;
        private TextBox doctortarejta;
        private TextBox doctornombre;
        private Button btnguardardoctor;
        private PictureBox pictureBox1;
        private TextBox telefonodoctor;
        private Label label5;
        private DateTimePicker doctornacimiento;
    }
}