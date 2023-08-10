namespace mascotas
{
    partial class Form6
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
            txtprecioventa = new TextBox();
            label3 = new Label();
            pictureBox2 = new PictureBox();
            button1 = new Button();
            txtstock = new TextBox();
            txtdescripcion = new TextBox();
            txtpreciocosto = new TextBox();
            txtnombreproducto = new TextBox();
            label5 = new Label();
            label4 = new Label();
            label2 = new Label();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ButtonHighlight;
            panel1.Controls.Add(txtprecioventa);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(pictureBox2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(txtstock);
            panel1.Controls.Add(txtdescripcion);
            panel1.Controls.Add(txtpreciocosto);
            panel1.Controls.Add(txtnombreproducto);
            panel1.Controls.Add(label5);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Dock = DockStyle.Fill;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(800, 450);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // txtprecioventa
            // 
            txtprecioventa.Location = new Point(144, 217);
            txtprecioventa.Name = "txtprecioventa";
            txtprecioventa.Size = new Size(262, 27);
            txtprecioventa.TabIndex = 13;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Cursor = Cursors.IBeam;
            label3.Location = new Point(24, 217);
            label3.Name = "label3";
            label3.Size = new Size(114, 20);
            label3.TabIndex = 12;
            label3.Text = "Precio de costo:";
            // 
            // pictureBox2
            // 
            pictureBox2.Image = Properties.Resources.descargar;
            pictureBox2.Location = new Point(373, 217);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(196, 221);
            pictureBox2.TabIndex = 11;
            pictureBox2.TabStop = false;
            // 
            // button1
            // 
            button1.Location = new Point(575, 351);
            button1.Name = "button1";
            button1.Size = new Size(164, 87);
            button1.TabIndex = 10;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // txtstock
            // 
            txtstock.Location = new Point(107, 252);
            txtstock.Name = "txtstock";
            txtstock.Size = new Size(74, 27);
            txtstock.TabIndex = 8;
            // 
            // txtdescripcion
            // 
            txtdescripcion.Location = new Point(133, 96);
            txtdescripcion.Name = "txtdescripcion";
            txtdescripcion.Size = new Size(328, 27);
            txtdescripcion.TabIndex = 7;
            // 
            // txtpreciocosto
            // 
            txtpreciocosto.Location = new Point(166, 156);
            txtpreciocosto.Name = "txtpreciocosto";
            txtpreciocosto.Size = new Size(328, 27);
            txtpreciocosto.TabIndex = 6;
            // 
            // txtnombreproducto
            // 
            txtnombreproducto.Location = new Point(187, 38);
            txtnombreproducto.Name = "txtnombreproducto";
            txtnombreproducto.Size = new Size(328, 27);
            txtnombreproducto.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(37, 96);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 4;
            label5.Text = "Descripcion:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(37, 163);
            label4.Name = "label4";
            label4.Size = new Size(114, 20);
            label4.TabIndex = 3;
            label4.Text = "Precio de costo:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(53, 255);
            label2.Name = "label2";
            label2.Size = new Size(48, 20);
            label2.TabIndex = 1;
            label2.Text = "Stock:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 41);
            label1.Name = "label1";
            label1.Size = new Size(157, 20);
            label1.TabIndex = 0;
            label1.Text = "Nombre del producto:";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.Boutique_pets_logo_dogs_pet_shop;
            pictureBox1.Location = new Point(432, 30);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(356, 153);
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Form6
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panel1);
            Name = "Form6";
            Text = "Form6";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label5;
        private Label label4;
        private Label label2;
        private Label label1;
        private PictureBox pictureBox1;
        private TextBox txtstock;
        private TextBox txtdescripcion;
        private TextBox txtpreciocosto;
        private TextBox txtnombreproducto;
        private Button button1;
        private PictureBox pictureBox2;
        private TextBox txtprecioventa;
        private Label label3;
    }
}