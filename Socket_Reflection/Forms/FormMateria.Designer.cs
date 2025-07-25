namespace Socket_Reflection
{
    partial class FormMateria
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
            Titulo = new Label();
            Aceptar = new Button();
            TxtMateria = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // Titulo
            // 
            Titulo.AutoSize = true;
            Titulo.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Titulo.ForeColor = Color.White;
            Titulo.Location = new Point(189, 43);
            Titulo.Name = "Titulo";
            Titulo.Size = new Size(0, 40);
            Titulo.TabIndex = 6;
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
            Aceptar.Location = new Point(135, 216);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(167, 51);
            Aceptar.TabIndex = 5;
            Aceptar.UseVisualStyleBackColor = false;
            Aceptar.Click += Aceptar_Click;
            // 
            // TxtMateria
            // 
            TxtMateria.BackColor = Color.FromArgb(13, 13, 13);
            TxtMateria.Cursor = Cursors.IBeam;
            TxtMateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMateria.ForeColor = Color.White;
            TxtMateria.Location = new Point(54, 135);
            TxtMateria.Name = "TxtMateria";
            TxtMateria.PlaceholderText = "Ingrese materia";
            TxtMateria.Size = new Size(318, 37);
            TxtMateria.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(64, 102);
            label1.Name = "label1";
            label1.Size = new Size(92, 30);
            label1.TabIndex = 8;
            label1.Text = "Materia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(154, 38);
            label2.Name = "label2";
            label2.Size = new Size(124, 40);
            label2.TabIndex = 10;
            label2.Text = "Materia";
            // 
            // FormMateria
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(432, 305);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtMateria);
            Controls.Add(Aceptar);
            Controls.Add(Titulo);
            Name = "FormMateria";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Materia";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button Aceptar;
        private TextBox TxtMateria;
        private Label label1;
        private Label label2;
    }
}