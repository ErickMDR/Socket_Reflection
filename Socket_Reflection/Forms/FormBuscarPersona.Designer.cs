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
            Txtcedula = new TextBox();
            Buscar = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(171, 37);
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
            label1.Location = new Point(81, 113);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 17;
            label1.Text = "Cédula:";
            // 
            // Txtcedula
            // 
            Txtcedula.BackColor = Color.FromArgb(13, 13, 13);
            Txtcedula.Cursor = Cursors.IBeam;
            Txtcedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Txtcedula.ForeColor = Color.FromArgb(70, 70, 70);
            Txtcedula.Location = new Point(72, 146);
            Txtcedula.Name = "Txtcedula";
            Txtcedula.Size = new Size(318, 37);
            Txtcedula.TabIndex = 16;
            Txtcedula.Text = "Ingrese cédula";
            // 
            // Buscar
            // 
            Buscar.BackColor = Color.FromArgb(13, 13, 13);
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderColor = Color.White;
            Buscar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Buscar.ForeColor = Color.White;
            Buscar.Location = new Point(152, 245);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(167, 51);
            Buscar.TabIndex = 15;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            // 
            // FormBuscarPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 355);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Txtcedula);
            Controls.Add(Buscar);
            Name = "FormBuscarPersona";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar por Persona";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Label label1;
        private TextBox Txtcedula;
        private Button Buscar;
    }
}