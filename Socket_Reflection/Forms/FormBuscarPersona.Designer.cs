namespace Socket_Reflection.Forms
{
    partial class FormBuscarPersona
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
            label2 = new Label();
            label1 = new Label();
            TxtCedula = new TextBox();
            Aceptar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 38);
            label2.Name = "label2";
            label2.Size = new Size(127, 40);
            label2.TabIndex = 18;
            label2.Text = "Persona";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 102);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 17;
            label1.Text = "Cédula:";
            // 
            // TxtCedula
            // 
            TxtCedula.BackColor = Color.FromArgb(13, 13, 13);
            TxtCedula.Cursor = Cursors.IBeam;
            TxtCedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCedula.ForeColor = Color.White;
            TxtCedula.ImeMode = ImeMode.NoControl;
            TxtCedula.Location = new Point(55, 135);
            TxtCedula.MaxLength = 20;
            TxtCedula.Name = "TxtCedula";
            TxtCedula.PlaceholderText = "Ingrese cédula";
            TxtCedula.Size = new Size(318, 37);
            TxtCedula.TabIndex = 16;
            // 
            // Aceptar
            // 
            Aceptar.BackColor = Color.FromArgb(13, 13, 13);
            Aceptar.Cursor = Cursors.Hand;
            Aceptar.FlatAppearance.BorderColor = Color.White;
            Aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Aceptar.FlatStyle = FlatStyle.Flat;
            Aceptar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aceptar.ForeColor = Color.White;
            Aceptar.Location = new Point(135, 212);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(167, 51);
            Aceptar.TabIndex = 15;
            Aceptar.Text = "Buscar";
            Aceptar.UseVisualStyleBackColor = false;
            Aceptar.Click += Aceptar_Click;
            // 
            // FormBuscarPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(432, 305);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtCedula);
            Controls.Add(Aceptar);
            Name = "FormBuscarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox TxtCedula;
        private Button Aceptar;
    }
}