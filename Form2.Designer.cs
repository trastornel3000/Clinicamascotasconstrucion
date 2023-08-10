namespace mascotas
{
    partial class Form2
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
            helpProvider1 = new HelpProvider();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label6 = new Label();
            timexx = new DateTimePicker();
            txtlista = new ListBox();
            txtconsultorios = new ComboBox();
            txtdoctor = new ComboBox();
            btnver = new Button();
            panel2 = new Panel();
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            mostrarnombreconsultorio = new Label();
            mostrarnombredueño = new Label();
            txtraza = new TextBox();
            labelnombre = new Label();
            label5 = new Label();
            txtnombre = new ComboBox();
            btnconfirmar = new Button();
            txthorario = new ComboBox();
            btnreservar = new Button();
            printDialog1 = new PrintDialog();
            printDialog2 = new PrintDialog();
            fontDialog1 = new FontDialog();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(37, 43);
            label1.Name = "label1";
            label1.Size = new Size(138, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del dueño:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(359, 222);
            label2.Name = "label2";
            label2.Size = new Size(69, 20);
            label2.TabIndex = 1;
            label2.Text = "Horarios:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(392, 115);
            label3.Name = "label3";
            label3.Size = new Size(94, 20);
            label3.TabIndex = 2;
            label3.Text = "Consultorios:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 189);
            label4.Name = "label4";
            label4.Size = new Size(58, 20);
            label4.TabIndex = 3;
            label4.Text = "Doctor:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(59, 115);
            label6.Name = "label6";
            label6.Size = new Size(44, 20);
            label6.TabIndex = 5;
            label6.Text = "Raza:";
            // 
            // timexx
            // 
            timexx.Location = new Point(134, 278);
            timexx.Margin = new Padding(3, 4, 3, 4);
            timexx.Name = "timexx";
            timexx.Size = new Size(228, 27);
            timexx.TabIndex = 9;
            timexx.ValueChanged += timexx_ValueChanged;
            // 
            // txtlista
            // 
            txtlista.FormattingEnabled = true;
            txtlista.ItemHeight = 20;
            txtlista.Location = new Point(59, 377);
            txtlista.Margin = new Padding(3, 4, 3, 4);
            txtlista.Name = "txtlista";
            txtlista.Size = new Size(427, 144);
            txtlista.TabIndex = 12;
            // 
            // txtconsultorios
            // 
            txtconsultorios.FormattingEnabled = true;
            txtconsultorios.Location = new Point(506, 112);
            txtconsultorios.Margin = new Padding(3, 4, 3, 4);
            txtconsultorios.Name = "txtconsultorios";
            txtconsultorios.Size = new Size(197, 28);
            txtconsultorios.TabIndex = 13;
            txtconsultorios.SelectedIndexChanged += txtconsultorios_SelectedIndexChanged;
            // 
            // txtdoctor
            // 
            txtdoctor.FormattingEnabled = true;
            txtdoctor.Location = new Point(76, 189);
            txtdoctor.Margin = new Padding(3, 4, 3, 4);
            txtdoctor.Name = "txtdoctor";
            txtdoctor.Size = new Size(197, 28);
            txtdoctor.TabIndex = 15;
            txtdoctor.SelectedIndexChanged += txtdoctor_SelectedIndexChanged;
            // 
            // btnver
            // 
            btnver.Location = new Point(866, 278);
            btnver.Margin = new Padding(3, 4, 3, 4);
            btnver.Name = "btnver";
            btnver.Size = new Size(201, 103);
            btnver.TabIndex = 17;
            btnver.Text = "Ver todas las citas Disponibles.";
            btnver.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            panel2.BackColor = SystemColors.ButtonHighlight;
            panel2.Controls.Add(pictureBox2);
            panel2.Controls.Add(pictureBox1);
            panel2.Controls.Add(mostrarnombreconsultorio);
            panel2.Controls.Add(mostrarnombredueño);
            panel2.Controls.Add(txtraza);
            panel2.Controls.Add(labelnombre);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(txtconsultorios);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(txtnombre);
            panel2.Controls.Add(label2);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(btnconfirmar);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txthorario);
            panel2.Controls.Add(txtdoctor);
            panel2.Controls.Add(btnreservar);
            panel2.Controls.Add(btnver);
            panel2.Controls.Add(timexx);
            panel2.Controls.Add(txtlista);
            panel2.Controls.Add(label1);
            panel2.Location = new Point(0, 1);
            panel2.Margin = new Padding(3, 4, 3, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1130, 673);
            panel2.TabIndex = 18;
            panel2.Paint += panel2_Paint;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.Boutique_pets_logo_dogs_pet_shop;
            pictureBox2.Location = new Point(734, 79);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(384, 163);
            pictureBox2.TabIndex = 28;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.descargar;
            pictureBox1.Location = new Point(583, 422);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(218, 228);
            pictureBox1.TabIndex = 27;
            pictureBox1.TabStop = false;
            // 
            // mostrarnombreconsultorio
            // 
            mostrarnombreconsultorio.AutoSize = true;
            mostrarnombreconsultorio.Location = new Point(583, 161);
            mostrarnombreconsultorio.Name = "mostrarnombreconsultorio";
            mostrarnombreconsultorio.Size = new Size(50, 20);
            mostrarnombreconsultorio.TabIndex = 26;
            mostrarnombreconsultorio.Text = "label8";
            // 
            // mostrarnombredueño
            // 
            mostrarnombredueño.AutoSize = true;
            mostrarnombredueño.Location = new Point(436, 46);
            mostrarnombredueño.Name = "mostrarnombredueño";
            mostrarnombredueño.Size = new Size(50, 20);
            mostrarnombredueño.TabIndex = 25;
            mostrarnombredueño.Text = "label7";
            mostrarnombredueño.Click += mostrarnombredueño_Click;
            // 
            // txtraza
            // 
            txtraza.Location = new Point(124, 108);
            txtraza.Name = "txtraza";
            txtraza.Size = new Size(238, 27);
            txtraza.TabIndex = 24;
            // 
            // labelnombre
            // 
            labelnombre.AutoSize = true;
            labelnombre.Location = new Point(304, 189);
            labelnombre.Name = "labelnombre";
            labelnombre.Size = new Size(0, 20);
            labelnombre.TabIndex = 23;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(45, 283);
            label5.Name = "label5";
            label5.Size = new Size(50, 20);
            label5.TabIndex = 22;
            label5.Text = "Fecha:";
            // 
            // txtnombre
            // 
            txtnombre.FormattingEnabled = true;
            txtnombre.Location = new Point(181, 43);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(194, 28);
            txtnombre.TabIndex = 21;
            txtnombre.SelectedIndexChanged += txtnombre_SelectedIndexChanged;
            // 
            // btnconfirmar
            // 
            btnconfirmar.Location = new Point(885, 479);
            btnconfirmar.Margin = new Padding(3, 4, 3, 4);
            btnconfirmar.Name = "btnconfirmar";
            btnconfirmar.Size = new Size(171, 103);
            btnconfirmar.TabIndex = 20;
            btnconfirmar.Text = "Confirmar";
            btnconfirmar.UseVisualStyleBackColor = true;
            btnconfirmar.Click += btnconfirmar_Click;
            // 
            // txthorario
            // 
            txthorario.FormattingEnabled = true;
            txthorario.Location = new Point(489, 223);
            txthorario.Margin = new Padding(3, 4, 3, 4);
            txthorario.Name = "txthorario";
            txthorario.Size = new Size(197, 28);
            txthorario.TabIndex = 19;
            txthorario.SelectedIndexChanged += txthorario_SelectedIndexChanged;
            // 
            // btnreservar
            // 
            btnreservar.Location = new Point(599, 278);
            btnreservar.Margin = new Padding(3, 4, 3, 4);
            btnreservar.Name = "btnreservar";
            btnreservar.Size = new Size(171, 103);
            btnreservar.TabIndex = 18;
            btnreservar.Text = "Reservar.";
            btnreservar.UseVisualStyleBackColor = true;
            btnreservar.Click += btnreservar_Click;
            // 
            // printDialog1
            // 
            printDialog1.UseEXDialog = true;
            // 
            // printDialog2
            // 
            printDialog2.UseEXDialog = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1130, 675);
            Controls.Add(panel2);
            Name = "Form2";
            Text = " ";
            Load += Form2_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private HelpProvider helpProvider1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label6;
        private TextBox txtmostrar;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private ListBox txtlista;
        private ComboBox txtconsultorios;
        private TextBox textBox2;
        private ComboBox txtdoctor;
        private Button button2;
        private Button btnver;
        private Panel panel2;
        private Button btnreservar;
        private ComboBox txthorario;
        private Button btnconfirmar;
        private DateTimePicker time;
        private DateTimePicker timexx;
        private ComboBox txtnombre;
        private Label label5;
        private PrintDialog printDialog1;
        private PrintDialog printDialog2;
        private FontDialog fontDialog1;
        private Label labelnombre;
        private TextBox textBox1;
        private TextBox txtraza;
        private Label label8;
        private Label label7;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private Label mostrarnombreconsultorio;
        private Label mostrarnombredueño;
    }
}