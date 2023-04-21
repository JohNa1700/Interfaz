﻿namespace Modulos
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
            labelTitulo = new Label();
            comboDocumento = new ComboBox();
            labelDocumento = new Label();
            textBoxDocumento = new TextBox();
            textBoxCrearContra = new TextBox();
            labelCrearContra = new Label();
            listRequisitos = new ListBox();
            label4 = new Label();
            textBoxConfirmarContra = new TextBox();
            ButRegistrarme = new Button();
            butInicio = new Button();
            labelConfirmarContra = new Label();
            SuspendLayout();
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Location = new Point(78, 66);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(68, 15);
            labelTitulo.TabIndex = 0;
            labelTitulo.Text = "REGISTRESE";
            // 
            // comboDocumento
            // 
            comboDocumento.FormattingEnabled = true;
            comboDocumento.Items.AddRange(new object[] { "C.C.", "T.I.", "R.C.", "C.E.", "PAS", "PEP" });
            comboDocumento.Location = new Point(45, 114);
            comboDocumento.Name = "comboDocumento";
            comboDocumento.Size = new Size(146, 23);
            comboDocumento.TabIndex = 1;
            comboDocumento.Text = "TIPO DE DOCUMENTO";
            // 
            // labelDocumento
            // 
            labelDocumento.AutoSize = true;
            labelDocumento.Location = new Point(45, 156);
            labelDocumento.Name = "labelDocumento";
            labelDocumento.Size = new Size(150, 15);
            labelDocumento.TabIndex = 2;
            labelDocumento.Text = "NUMERO DE DOCUMENTO";
            // 
            // textBoxDocumento
            // 
            textBoxDocumento.Location = new Point(45, 174);
            textBoxDocumento.Name = "textBoxDocumento";
            textBoxDocumento.Size = new Size(145, 23);
            textBoxDocumento.TabIndex = 3;
            // 
            // textBoxCrearContra
            // 
            textBoxCrearContra.Location = new Point(44, 226);
            textBoxCrearContra.Name = "textBoxCrearContra";
            textBoxCrearContra.Size = new Size(145, 23);
            textBoxCrearContra.TabIndex = 4;
            // 
            // labelCrearContra
            // 
            labelCrearContra.AutoSize = true;
            labelCrearContra.Location = new Point(44, 208);
            labelCrearContra.Name = "labelCrearContra";
            labelCrearContra.Size = new Size(122, 15);
            labelCrearContra.TabIndex = 5;
            labelCrearContra.Text = "CREAR CONTRASEÑA";
            // 
            // listRequisitos
            // 
            listRequisitos.BackColor = SystemColors.Control;
            listRequisitos.BorderStyle = BorderStyle.None;
            listRequisitos.FormattingEnabled = true;
            listRequisitos.ItemHeight = 15;
            listRequisitos.Items.AddRange(new object[] { "- Minimo 8 caracteres", "- Mayusculas y minusculas", "- Caracter espcial" });
            listRequisitos.Location = new Point(44, 255);
            listRequisitos.Name = "listRequisitos";
            listRequisitos.Size = new Size(173, 60);
            listRequisitos.TabIndex = 6;
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
            // textBoxConfirmarContra
            // 
            textBoxConfirmarContra.Location = new Point(44, 342);
            textBoxConfirmarContra.Name = "textBoxConfirmarContra";
            textBoxConfirmarContra.Size = new Size(149, 23);
            textBoxConfirmarContra.TabIndex = 8;
            // 
            // ButRegistrarme
            // 
            ButRegistrarme.BackColor = SystemColors.ActiveCaption;
            ButRegistrarme.Location = new Point(67, 397);
            ButRegistrarme.Name = "ButRegistrarme";
            ButRegistrarme.Size = new Size(99, 23);
            ButRegistrarme.TabIndex = 9;
            ButRegistrarme.Text = "REGISTRARME";
            ButRegistrarme.UseVisualStyleBackColor = false;
            // 
            // butInicio
            // 
            butInicio.BackColor = SystemColors.ActiveCaption;
            butInicio.Location = new Point(773, 39);
            butInicio.Name = "butInicio";
            butInicio.Size = new Size(75, 23);
            butInicio.TabIndex = 10;
            butInicio.Text = "INICIO";
            butInicio.UseVisualStyleBackColor = false;
            butInicio.Click += button1_Click;
            // 
            // labelConfirmarContra
            // 
            labelConfirmarContra.AutoSize = true;
            labelConfirmarContra.Location = new Point(45, 324);
            labelConfirmarContra.Name = "labelConfirmarContra";
            labelConfirmarContra.Size = new Size(154, 15);
            labelConfirmarContra.TabIndex = 11;
            labelConfirmarContra.Text = "CONFIRMAR CONTRASEÑA";
            // 
            // Form3
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(894, 524);
            Controls.Add(labelConfirmarContra);
            Controls.Add(butInicio);
            Controls.Add(ButRegistrarme);
            Controls.Add(textBoxConfirmarContra);
            Controls.Add(label4);
            Controls.Add(listRequisitos);
            Controls.Add(labelCrearContra);
            Controls.Add(textBoxCrearContra);
            Controls.Add(textBoxDocumento);
            Controls.Add(labelDocumento);
            Controls.Add(comboDocumento);
            Controls.Add(labelTitulo);
            DoubleBuffered = true;
            Name = "Form3";
            Text = "Form3";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelTitulo;
        private ComboBox comboDocumento;
        private Label labelDocumento;
        private TextBox textBoxDocumento;
        private TextBox textBoxCrearContra;
        private Label labelCrearContra;
        private ListBox listRequisitos;
        private Label label4;
        private TextBox textBoxConfirmarContra;
        private Button ButRegistrarme;
        private Button butInicio;
        private Label labelConfirmarContra;
    }
}