namespace mascotas
{
    partial class Form5
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
            components = new System.ComponentModel.Container();
            label1 = new Label();
            txtnombredueño = new TextBox();
            txtrazadueño = new TextBox();
            txtespecie = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            txtdirecion = new TextBox();
            txttelefono = new TextBox();
            dateTimePicker2 = new DateTimePicker();
            button1 = new Button();
            imageList1 = new ImageList(components);
            pictureBox1 = new PictureBox();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 43);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 22;
            label1.Text = "Nombre del dueño:";
            // 
            // txtnombredueño
            // 
            txtnombredueño.Location = new Point(178, 40);
            txtnombredueño.Name = "txtnombredueño";
            txtnombredueño.Size = new Size(444, 27);
            txtnombredueño.TabIndex = 23;
            // 
            // txtrazadueño
            // 
            txtrazadueño.Location = new Point(140, 92);
            txtrazadueño.Name = "txtrazadueño";
            txtrazadueño.Size = new Size(158, 27);
            txtrazadueño.TabIndex = 25;
            // 
            // txtespecie
            // 
            txtespecie.Location = new Point(105, 160);
            txtespecie.Name = "txtespecie";
            txtespecie.Size = new Size(133, 27);
            txtespecie.TabIndex = 26;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Enabled = false;
            label2.Location = new Point(76, 95);
            label2.Name = "label2";
            label2.Size = new Size(44, 20);
            label2.TabIndex = 28;
            label2.Text = "Raza:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Enabled = false;
            label4.Location = new Point(22, 163);
            label4.Name = "label4";
            label4.Size = new Size(62, 20);
            label4.TabIndex = 30;
            label4.Text = "Especie:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Enabled = false;
            label5.Location = new Point(340, 142);
            label5.Name = "label5";
            label5.Size = new Size(149, 20);
            label5.TabIndex = 31;
            label5.Text = "Fecha de nacimiento:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Enabled = false;
            label6.Location = new Point(66, 234);
            label6.Name = "label6";
            label6.Size = new Size(68, 20);
            label6.TabIndex = 32;
            label6.Text = "Direcion:";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Enabled = false;
            label7.Location = new Point(419, 205);
            label7.Name = "label7";
            label7.Size = new Size(70, 20);
            label7.TabIndex = 33;
            label7.Text = "Telefono:";
            // 
            // txtdirecion
            // 
            txtdirecion.Location = new Point(140, 234);
            txtdirecion.Name = "txtdirecion";
            txtdirecion.Size = new Size(224, 27);
            txtdirecion.TabIndex = 34;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(507, 202);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(172, 27);
            txttelefono.TabIndex = 35;
            txttelefono.TextChanged += textBox7_TextChanged;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(507, 142);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(250, 27);
            dateTimePicker2.TabIndex = 36;
            // 
            // button1
            // 
            button1.Location = new Point(594, 333);
            button1.Name = "button1";
            button1.Size = new Size(133, 65);
            button1.TabIndex = 37;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // imageList1
            // 
            imageList1.ColorDepth = ColorDepth.Depth8Bit;
            imageList1.ImageSize = new Size(16, 16);
            imageList1.TransparentColor = Color.Transparent;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descargar;
            pictureBox1.Location = new Point(178, 305);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(198, 118);
            pictureBox1.TabIndex = 38;
            pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(label5);
            panel1.Controls.Add(dateTimePicker2);
            panel1.Controls.Add(txttelefono);
            panel1.Controls.Add(label7);
            panel1.Location = new Point(1, 2);
            panel1.Name = "panel1";
            panel1.Size = new Size(799, 451);
            panel1.TabIndex = 39;
            panel1.Paint += panel1_Paint;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pictureBox1);
            Controls.Add(button1);
            Controls.Add(txtdirecion);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label2);
            Controls.Add(txtespecie);
            Controls.Add(txtrazadueño);
            Controls.Add(txtnombredueño);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "Form5";
            Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txtnombredueño;
        private TextBox txtrazadueño;
        private TextBox txtespecie;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private TextBox txtdirecion;
        private TextBox txttelefono;
        private DateTimePicker dateTimePicker2;
        private Button button1;
        private ImageList imageList1;
        private PictureBox pictureBox1;
        private Panel panel1;
    }
}