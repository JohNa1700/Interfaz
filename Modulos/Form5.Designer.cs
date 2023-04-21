namespace Modulos
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
            dateCita = new DateTimePicker();
            labelFecha = new Label();
            comboProfesional = new ComboBox();
            labelProfesional = new Label();
            labelSede = new Label();
            comboSede = new ComboBox();
            labelCiudad = new Label();
            comboCiudad = new ComboBox();
            butInicio = new Button();
            butAtras = new Button();
            SuspendLayout();
            // 
            // dateCita
            // 
            dateCita.Location = new Point(37, 95);
            dateCita.Name = "dateCita";
            dateCita.Size = new Size(200, 23);
            dateCita.TabIndex = 6;
            // 
            // labelFecha
            // 
            labelFecha.AutoSize = true;
            labelFecha.Location = new Point(37, 77);
            labelFecha.Name = "labelFecha";
            labelFecha.Size = new Size(97, 15);
            labelFecha.TabIndex = 7;
            labelFecha.Text = "FECHA DESEADA";
            // 
            // comboProfesional
            // 
            comboProfesional.FormattingEnabled = true;
            comboProfesional.Items.AddRange(new object[] { "Profesional 1", "Profesional 2", "Profesional 3", "Profesional 4", "Profesional 5", "\t" });
            comboProfesional.Location = new Point(38, 180);
            comboProfesional.Name = "comboProfesional";
            comboProfesional.Size = new Size(121, 23);
            comboProfesional.TabIndex = 8;
            comboProfesional.Text = "SELECCIONAR";
            // 
            // labelProfesional
            // 
            labelProfesional.AutoSize = true;
            labelProfesional.Location = new Point(38, 162);
            labelProfesional.Name = "labelProfesional";
            labelProfesional.Size = new Size(83, 15);
            labelProfesional.TabIndex = 9;
            labelProfesional.Text = "PROFESIONAL";
            // 
            // labelSede
            // 
            labelSede.AutoSize = true;
            labelSede.Location = new Point(38, 244);
            labelSede.Name = "labelSede";
            labelSede.Size = new Size(33, 15);
            labelSede.TabIndex = 10;
            labelSede.Text = "SEDE";
            // 
            // comboSede
            // 
            comboSede.FormattingEnabled = true;
            comboSede.Items.AddRange(new object[] { "Sede 1", "Sede 2", "Sede 3", "Sede 4", "Sede 5" });
            comboSede.Location = new Point(38, 262);
            comboSede.Name = "comboSede";
            comboSede.Size = new Size(121, 23);
            comboSede.TabIndex = 11;
            comboSede.Text = "SELECCIONAR";
            // 
            // labelCiudad
            // 
            labelCiudad.AutoSize = true;
            labelCiudad.Location = new Point(38, 335);
            labelCiudad.Name = "labelCiudad";
            labelCiudad.Size = new Size(50, 15);
            labelCiudad.TabIndex = 12;
            labelCiudad.Text = "CIUDAD";
            // 
            // comboCiudad
            // 
            comboCiudad.FormattingEnabled = true;
            comboCiudad.Items.AddRange(new object[] { "Ciudad 1", "Ciudad 2", "Ciudad 3", "Ciudad 4", "Ciudad 5" });
            comboCiudad.Location = new Point(38, 353);
            comboCiudad.Name = "comboCiudad";
            comboCiudad.Size = new Size(121, 23);
            comboCiudad.TabIndex = 13;
            comboCiudad.Text = "SELECCIONAR";
            // 
            // butInicio
            // 
            butInicio.BackColor = SystemColors.ActiveCaption;
            butInicio.Location = new Point(720, 55);
            butInicio.Name = "butInicio";
            butInicio.Size = new Size(75, 23);
            butInicio.TabIndex = 14;
            butInicio.Text = "INICIO";
            butInicio.UseVisualStyleBackColor = false;
            butInicio.Click += button1_Click;
            // 
            // butAtras
            // 
            butAtras.BackColor = SystemColors.ActiveCaption;
            butAtras.BackgroundImage = Properties.Resources.Back;
            butAtras.Location = new Point(720, 92);
            butAtras.Name = "butAtras";
            butAtras.Size = new Size(70, 23);
            butAtras.TabIndex = 15;
            butAtras.Text = "ATRAS";
            butAtras.UseVisualStyleBackColor = false;
            butAtras.Click += button2_Click;
            // 
            // Form5
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Back1;
            BackgroundImageLayout = ImageLayout.Zoom;
            ClientSize = new Size(864, 525);
            Controls.Add(butAtras);
            Controls.Add(butInicio);
            Controls.Add(comboCiudad);
            Controls.Add(labelCiudad);
            Controls.Add(comboSede);
            Controls.Add(labelSede);
            Controls.Add(labelProfesional);
            Controls.Add(comboProfesional);
            Controls.Add(labelFecha);
            Controls.Add(dateCita);
            DoubleBuffered = true;
            Name = "Form5";
            Text = "ASIGNAR CITA";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateCita;
        private Label labelFecha;
        private ComboBox comboProfesional;
        private Label labelProfesional;
        private Label labelSede;
        private ComboBox comboSede;
        private Label labelCiudad;
        private ComboBox comboCiudad;
        private Button butInicio;
        private Button butAtras;
    }
}