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
            labelTitulo = new Label();
            listRequisitos = new ListBox();
            labelTitulo2 = new Label();
            labelContra1 = new Label();
            labelContra2 = new Label();
            textBoxContra1 = new TextBox();
            textBoxContra2 = new TextBox();
            butRestablecer = new Button();
            labelCorreo = new Label();
            textBoxCorreo = new TextBox();
            butInicio = new Button();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(22, 35);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(144, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "OLVIDO SU CONTRASEÑA";
            // 
            // listRequisitos
            // 
            listRequisitos.BackColor = SystemColors.Window;
            listRequisitos.BorderStyle = BorderStyle.None;
            listRequisitos.FormattingEnabled = true;
            listRequisitos.ItemHeight = 15;
            listRequisitos.Items.AddRange(new object[] { "- Contener minimo 8 ", "   caracteres", "- Contener una letra ", "   mayuscula y una minuscula", "- Contener un caracter espcial", "- No debe contener ", "   numero de documento", "- No debe contener ", "   fecha de cumpleaños" });
            listRequisitos.Location = new Point(22, 101);
            listRequisitos.Name = "listRequisitos";
            listRequisitos.Size = new Size(173, 150);
            listRequisitos.TabIndex = 1;
            // 
            // labelTitulo2
            // 
            labelTitulo2.AutoSize = true;
            labelTitulo2.Location = new Point(2, 68);
            labelTitulo2.Name = "labelTitulo2";
            labelTitulo2.Size = new Size(240, 15);
            labelTitulo2.TabIndex = 2;
            labelTitulo2.Text = "PARA RESTABLECER SU CONTRASEÑA DEBE:";
            // 
            // labelContra1
            // 
            labelContra1.AutoSize = true;
            labelContra1.Location = new Point(22, 276);
            labelContra1.Name = "labelContra1";
            labelContra1.Size = new Size(123, 15);
            labelContra1.TabIndex = 3;
            labelContra1.Text = "NUEVA CONTRASEÑA";
            // 
            // labelContra2
            // 
            labelContra2.AutoSize = true;
            labelContra2.Location = new Point(22, 331);
            labelContra2.Name = "labelContra2";
            labelContra2.Size = new Size(162, 15);
            labelContra2.TabIndex = 4;
            labelContra2.Text = "CONFIRME LA CONTRASEÑA";
            // 
            // textBoxContra1
            // 
            textBoxContra1.Location = new Point(22, 294);
            textBoxContra1.Name = "textBoxContra1";
            textBoxContra1.Size = new Size(123, 23);
            textBoxContra1.TabIndex = 5;
            // 
            // textBoxContra2
            // 
            textBoxContra2.Location = new Point(22, 349);
            textBoxContra2.Name = "textBoxContra2";
            textBoxContra2.Size = new Size(123, 23);
            textBoxContra2.TabIndex = 6;
            // 
            // butRestablecer
            // 
            butRestablecer.BackColor = SystemColors.InactiveCaption;
            butRestablecer.Location = new Point(32, 467);
            butRestablecer.Name = "butRestablecer";
            butRestablecer.Size = new Size(102, 23);
            butRestablecer.TabIndex = 7;
            butRestablecer.Text = "RESTABLECER";
            butRestablecer.UseVisualStyleBackColor = false;
            // 
            // labelCorreo
            // 
            labelCorreo.AutoSize = true;
            labelCorreo.Location = new Point(22, 399);
            labelCorreo.Name = "labelCorreo";
            labelCorreo.Size = new Size(212, 15);
            labelCorreo.TabIndex = 8;
            labelCorreo.Text = "CONFIRME SU CORREO ELECTRONICO";
            // 
            // textBoxCorreo
            // 
            textBoxCorreo.Location = new Point(22, 417);
            textBoxCorreo.Name = "textBoxCorreo";
            textBoxCorreo.Size = new Size(123, 23);
            textBoxCorreo.TabIndex = 9;
            // 
            // butInicio
            // 
            butInicio.BackColor = SystemColors.InactiveCaption;
            butInicio.Location = new Point(750, 30);
            butInicio.Name = "butInicio";
            butInicio.Size = new Size(75, 23);
            butInicio.TabIndex = 10;
            butInicio.Text = "INICIO";
            butInicio.UseVisualStyleBackColor = false;
            butInicio.Click += button2_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Window;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(880, 526);
            Controls.Add(butInicio);
            Controls.Add(textBoxCorreo);
            Controls.Add(labelCorreo);
            Controls.Add(butRestablecer);
            Controls.Add(textBoxContra2);
            Controls.Add(textBoxContra1);
            Controls.Add(labelContra2);
            Controls.Add(labelContra1);
            Controls.Add(labelTitulo2);
            Controls.Add(listRequisitos);
            Controls.Add(labelTitulo);
            DoubleBuffered = true;
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private ListBox listRequisitos;
        private Label labelTitulo2;
        private Label labelContra1;
        private Label labelContra2;
        private TextBox textBoxContra1;
        private TextBox textBoxContra2;
        private Button butRestablecer;
        private Label labelCorreo;
        private TextBox textBoxCorreo;
        private Button butInicio;
    }
}