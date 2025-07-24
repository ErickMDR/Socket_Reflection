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
            label = new Label();
            labeltitulo = new Label();
            button1 = new Button();
            textBox1 = new TextBox();
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
            Aceptar.FlatAppearance.BorderColor = Color.White;
            Aceptar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Aceptar.FlatStyle = FlatStyle.Flat;
            Aceptar.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Aceptar.ForeColor = Color.White;
            Aceptar.Location = new Point(145, 251);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(167, 51);
            Aceptar.TabIndex = 5;
            Aceptar.UseVisualStyleBackColor = false;
            // 
            // TxtMateria
            // 
            TxtMateria.BackColor = Color.FromArgb(13, 13, 13);
            TxtMateria.Cursor = Cursors.IBeam;
            TxtMateria.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMateria.ForeColor = Color.FromArgb(70, 70, 70);
            TxtMateria.Location = new Point(73, 169);
            TxtMateria.Name = "TxtMateria";
            TxtMateria.Size = new Size(318, 37);
            TxtMateria.TabIndex = 7;
            TxtMateria.Text = "Ingrese materia";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(82, 136);
            label.Name = "label";
            label.Size = new Size(92, 30);
            label.TabIndex = 8;
            label.Text = "Materia:";
            // 
            // labeltitulo
            // 
            labeltitulo.AutoSize = true;
            labeltitulo.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labeltitulo.ForeColor = Color.White;
            labeltitulo.Location = new Point(172, 57);
            labeltitulo.Name = "labeltitulo";
            labeltitulo.Size = new Size(124, 40);
            labeltitulo.TabIndex = 10;
            labeltitulo.Text = "Materia";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(13, 13, 13);
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 11.8956518F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.ForeColor = Color.White;
            button1.Location = new Point(145, 251);
            button1.Name = "button1";
            button1.Size = new Size(167, 51);
            button1.TabIndex = 5;
            button1.UseVisualStyleBackColor = false;
            // 
            // textBox1
            // 
            textBox1.BackColor = Color.FromArgb(13, 13, 13);
            textBox1.Cursor = Cursors.IBeam;
            textBox1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBox1.ForeColor = Color.FromArgb(70, 70, 70);
            textBox1.Location = new Point(73, 169);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(318, 37);
            textBox1.TabIndex = 7;
            textBox1.Text = "Ingrese materia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(82, 136);
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
            label2.Location = new Point(172, 57);
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
            ClientSize = new Size(482, 355);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(labeltitulo);
            Controls.Add(textBox1);
            Controls.Add(label);
            Controls.Add(TxtMateria);
            Controls.Add(button1);
            Controls.Add(Titulo);
            Controls.Add(Aceptar);
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
        private Label label;
        private Label labeltitulo;
        private Button button1;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
    }
}