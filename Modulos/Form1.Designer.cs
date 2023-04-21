namespace Modulos
{
    partial class Form1
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
            linkContraseña = new LinkLabel();
            linkRegistro = new LinkLabel();
            textBoxUsuario = new TextBox();
            textBoxContraseña = new TextBox();
            labelUsuario = new Label();
            labelContraseña = new Label();
            butInicio = new Button();
            SuspendLayout();
            // 
            // linkContraseña
            // 
            linkContraseña.AutoSize = true;
            linkContraseña.Location = new Point(27, 298);
            linkContraseña.Name = "linkContraseña";
            linkContraseña.Size = new Size(144, 15);
            linkContraseña.TabIndex = 0;
            linkContraseña.TabStop = true;
            linkContraseña.Text = "OLVIDO SU CONTRASEÑA";
            linkContraseña.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkRegistro
            // 
            linkRegistro.AutoSize = true;
            linkRegistro.Location = new Point(27, 326);
            linkRegistro.Name = "linkRegistro";
            linkRegistro.Size = new Size(68, 15);
            linkRegistro.TabIndex = 1;
            linkRegistro.TabStop = true;
            linkRegistro.Text = "REGISTRESE";
            linkRegistro.LinkClicked += linkLabel2_LinkClicked;
            // 
            // textBoxUsuario
            // 
            textBoxUsuario.Location = new Point(127, 135);
            textBoxUsuario.Name = "textBoxUsuario";
            textBoxUsuario.Size = new Size(100, 23);
            textBoxUsuario.TabIndex = 2;
            textBoxUsuario.TextChanged += textBox1_TextChanged;
            // 
            // textBoxContraseña
            // 
            textBoxContraseña.Location = new Point(127, 178);
            textBoxContraseña.Name = "textBoxContraseña";
            textBoxContraseña.Size = new Size(100, 23);
            textBoxContraseña.TabIndex = 3;
            textBoxContraseña.TextChanged += textBox2_TextChanged;
            // 
            // labelUsuario
            // 
            labelUsuario.AutoSize = true;
            labelUsuario.Location = new Point(27, 143);
            labelUsuario.Name = "labelUsuario";
            labelUsuario.Size = new Size(56, 15);
            labelUsuario.TabIndex = 4;
            labelUsuario.Text = "USUARIO";
            labelUsuario.Click += label1_Click;
            // 
            // labelContraseña
            // 
            labelContraseña.AutoSize = true;
            labelContraseña.Location = new Point(27, 187);
            labelContraseña.Name = "labelContraseña";
            labelContraseña.Size = new Size(83, 15);
            labelContraseña.TabIndex = 5;
            labelContraseña.Text = "CONTRASEÑA";
            labelContraseña.Click += label2_Click;
            // 
            // butInicio
            // 
            butInicio.BackColor = SystemColors.ActiveCaption;
            butInicio.Location = new Point(71, 245);
            butInicio.Name = "butInicio";
            butInicio.Size = new Size(75, 23);
            butInicio.TabIndex = 6;
            butInicio.Text = "LOGIN";
            butInicio.UseVisualStyleBackColor = false;
            butInicio.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(913, 520);
            Controls.Add(butInicio);
            Controls.Add(labelContraseña);
            Controls.Add(labelUsuario);
            Controls.Add(textBoxContraseña);
            Controls.Add(textBoxUsuario);
            Controls.Add(linkRegistro);
            Controls.Add(linkContraseña);
            DoubleBuffered = true;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel linkContraseña;
        private LinkLabel linkRegistro;
        private TextBox textBoxUsuario;
        private TextBox textBoxContraseña;
        private Label labelUsuario;
        private Label labelContraseña;
        private Button butInicio;
    }
}