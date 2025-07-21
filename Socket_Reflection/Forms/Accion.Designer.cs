namespace Socket_Reflection
{
    partial class Accion
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
            label.Size = new Size(169, 30);
            label.TabIndex = 8;
            label.Text = "Ingrese materia:";
            // 
            // Accion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 355);
            Controls.Add(label);
            Controls.Add(TxtMateria);
            Controls.Add(Titulo);
            Controls.Add(Aceptar);
            Name = "Accion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Accion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button Aceptar;
        private TextBox TxtMateria;
        private Label label;
    }
}