namespace Modulos
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
            label1 = new Label();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label3 = new Label();
            listBox1 = new ListBox();
            label4 = new Label();
            textBox3 = new TextBox();
            REGISTRARME = new Button();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 66);
            label1.Name = "label1";
            label1.Size = new Size(68, 15);
            label1.TabIndex = 0;
            label1.Text = "REGISTRESE";
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "C.C.", "T.I.", "R.C.", "C.E.", "PAS", "PEP" });
            comboBox1.Location = new Point(45, 114);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(146, 23);
            comboBox1.TabIndex = 1;
            comboBox1.Text = "TIPO DE DOCUMENTO";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(45, 156);
            label2.Name = "label2";
            label2.Size = new Size(150, 15);
            label2.TabIndex = 2;
            label2.Text = "NUMERO DE DOCUMENTO";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(45, 174);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(145, 23);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(44, 226);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(145, 23);
            textBox2.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(44, 208);
            label3.Name = "label3";
            label3.Size = new Size(122, 15);
            label3.TabIndex = 5;
            label3.Text = "CREAR CONTRASEÑA";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Control;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "- Minimo 8 caracteres", "- Mayusculas y minusculas", "- Caracter espcial" });
            listBox1.Location = new Point(44, 255);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(173, 60);
            listBox1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(368, 305);
            label4.Name = "label4";
            label4.Size = new Size(154, 15);
            label4.TabIndex = 7;
            label4.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(44, 342);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(149, 23);
            textBox3.TabIndex = 8;
            // 
            // REGISTRARME
            // 
            REGISTRARME.BackColor = SystemColors.ActiveCaption;
            REGISTRARME.Location = new Point(67, 397);
            REGISTRARME.Name = "REGISTRARME";
            REGISTRARME.Size = new Size(99, 23);
            REGISTRARME.TabIndex = 9;
            REGISTRARME.Text = "REGISTRARME";
            REGISTRARME.UseVisualStyleBackColor = false;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ActiveCaption;
            button1.Location = new Point(773, 39);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 10;
            button1.Text = "INICIO";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(894, 524);
            Controls.Add(button1);
            Controls.Add(REGISTRARME);
            Controls.Add(textBox3);
            Controls.Add(label4);
            Controls.Add(listBox1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textBox1;
        private TextBox textBox2;
        private Label label3;
        private ListBox listBox1;
        private Label label4;
        private TextBox textBox3;
        private Button REGISTRARME;
        private Button button1;
    }
}