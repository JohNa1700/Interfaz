namespace Modulos
{
    partial class Form4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form4));
            textBoxTitulo = new TextBox();
            openFileDialog1 = new OpenFileDialog();
            buttonInicio = new Button();
            butMedicinaG = new Button();
            butOdonto = new Button();
            butLaboratorio = new Button();
            butOptom = new Button();
            SuspendLayout();
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.BackColor = SystemColors.InactiveCaption;
            textBoxTitulo.Location = new Point(407, 40);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(91, 23);
            textBoxTitulo.TabIndex = 0;
            textBoxTitulo.Text = "CITAS MEDICAS";
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonInicio
            // 
            buttonInicio.BackColor = SystemColors.ActiveCaption;
            buttonInicio.Location = new Point(770, 40);
            buttonInicio.Name = "buttonInicio";
            buttonInicio.Size = new Size(75, 23);
            buttonInicio.TabIndex = 5;
            buttonInicio.Text = "INICIO";
            buttonInicio.UseVisualStyleBackColor = false;
            buttonInicio.Click += button1_Click;
            // 
            // butMedicinaG
            // 
            butMedicinaG.BackColor = SystemColors.ActiveCaption;
            butMedicinaG.Location = new Point(35, 104);
            butMedicinaG.Name = "butMedicinaG";
            butMedicinaG.Size = new Size(132, 23);
            butMedicinaG.TabIndex = 6;
            butMedicinaG.Text = "MEDICINA GENERAL";
            butMedicinaG.UseVisualStyleBackColor = false;
            butMedicinaG.Click += button2_Click;
            // 
            // butOdonto
            // 
            butOdonto.BackColor = SystemColors.ActiveCaption;
            butOdonto.Location = new Point(35, 175);
            butOdonto.Name = "butOdonto";
            butOdonto.Size = new Size(119, 23);
            butOdonto.TabIndex = 7;
            butOdonto.Text = "ODONTOLOGIA";
            butOdonto.UseVisualStyleBackColor = false;
            butOdonto.Click += button3_Click;
            // 
            // butLaboratorio
            // 
            butLaboratorio.BackColor = SystemColors.ActiveCaption;
            butLaboratorio.Location = new Point(35, 240);
            butLaboratorio.Name = "butLaboratorio";
            butLaboratorio.Size = new Size(75, 23);
            butLaboratorio.TabIndex = 8;
            butLaboratorio.Text = "LABORATORIO";
            butLaboratorio.UseVisualStyleBackColor = false;
            butLaboratorio.Click += button4_Click;
            // 
            // butOptom
            // 
            butOptom.BackColor = SystemColors.ActiveCaption;
            butOptom.Location = new Point(35, 317);
            butOptom.Name = "butOptom";
            butOptom.Size = new Size(93, 23);
            butOptom.TabIndex = 9;
            butOptom.Text = "OPTOMETRIA";
            butOptom.UseVisualStyleBackColor = false;
            butOptom.Click += button5_Click;
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(891, 528);
            Controls.Add(butOptom);
            Controls.Add(butLaboratorio);
            Controls.Add(butOdonto);
            Controls.Add(butMedicinaG);
            Controls.Add(buttonInicio);
            Controls.Add(textBoxTitulo);
            DoubleBuffered = true;
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxTitulo;
        private OpenFileDialog openFileDialog1;
        private Button buttonInicio;
        private Button butMedicinaG;
        private Button butOdonto;
        private Button butLaboratorio;
        private Button butOptom;
    }
}