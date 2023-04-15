namespace Modulos
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
            label1 = new Label();
            listBox1 = new ListBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            button1 = new Button();
            label5 = new Label();
            textBox3 = new TextBox();
            button2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 35);
            label1.Name = "label1";
            label1.Size = new Size(144, 15);
            label1.TabIndex = 0;
            label1.Text = "OLVIDO SU CONTRASEÑA";
            // 
            // listBox1
            // 
            listBox1.BackColor = SystemColors.Window;
            listBox1.BorderStyle = BorderStyle.None;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Items.AddRange(new object[] { "- Contener minimo 8 ", "   caracteres", "- Contener una letra ", "   mayuscula y una minuscula", "- Contener un caracter espcial", "- No debe contener ", "   numero de documento", "- No debe contener ", "   fecha de cumpleaños" });
            listBox1.Location = new Point(22, 101);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(173, 150);
            listBox1.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(2, 68);
            label2.Name = "label2";
            label2.Size = new Size(240, 15);
            label2.TabIndex = 2;
            label2.Text = "PARA RESTABLECER SU CONTRASEÑA DEBE:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 276);
            label3.Name = "label3";
            label3.Size = new Size(123, 15);
            label3.TabIndex = 3;
            label3.Text = "NUEVA CONTRASEÑA";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 331);
            label4.Name = "label4";
            label4.Size = new Size(162, 15);
            label4.TabIndex = 4;
            label4.Text = "CONFIRME LA CONTRASEÑA";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 294);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(123, 23);
            textBox1.TabIndex = 5;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 349);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(123, 23);
            textBox2.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.InactiveCaption;
            button1.Location = new Point(32, 467);
            button1.Name = "button1";
            button1.Size = new Size(102, 23);
            button1.TabIndex = 7;
            button1.Text = "RESTABLECER";
            button1.UseVisualStyleBackColor = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 399);
            label5.Name = "label5";
            label5.Size = new Size(212, 15);
            label5.TabIndex = 8;
            label5.Text = "CONFIRME SU CORREO ELECTRONICO";
            // 
            // textBox3
            // 
            textBox3.Location = new Point(22, 417);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(123, 23);
            textBox3.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = SystemColors.InactiveCaption;
            button2.Location = new Point(750, 30);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 10;
            button2.Text = "INICIO";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(880, 526);
            Controls.Add(button2);
            Controls.Add(textBox3);
            Controls.Add(label5);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(listBox1);
            Controls.Add(label1);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox listBox1;
        private Label label2;
        private Label label3;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private Button button1;
        private Label label5;
        private TextBox textBox3;
        private Button button2;
    }
}