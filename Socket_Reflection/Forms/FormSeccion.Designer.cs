namespace Socket_Reflection
{
    partial class FormSeccion
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
            TxtSeccion = new TextBox();
            label = new Label();
            Sección = new Label();
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
            Aceptar.Location = new Point(127, 218);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(167, 51);
            Aceptar.TabIndex = 5;
            Aceptar.UseVisualStyleBackColor = false;
            Aceptar.Click += Aceptar_Click;
            // 
            // TxtSeccion
            // 
            TxtSeccion.BackColor = Color.FromArgb(13, 13, 13);
            TxtSeccion.CharacterCasing = CharacterCasing.Upper;
            TxtSeccion.Cursor = Cursors.IBeam;
            TxtSeccion.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtSeccion.ForeColor = Color.White;
            TxtSeccion.Location = new Point(55, 142);
            TxtSeccion.MaxLength = 2;
            TxtSeccion.Name = "TxtSeccion";
            TxtSeccion.PlaceholderText = "Ingrese sección";
            TxtSeccion.Size = new Size(318, 37);
            TxtSeccion.TabIndex = 7;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(64, 109);
            label.Name = "label";
            label.Size = new Size(92, 30);
            label.TabIndex = 8;
            label.Text = "Sección:";
            // 
            // Sección
            // 
            Sección.AutoSize = true;
            Sección.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Sección.ForeColor = Color.White;
            Sección.Location = new Point(150, 43);
            Sección.Name = "Sección";
            Sección.Size = new Size(121, 40);
            Sección.TabIndex = 9;
            Sección.Text = "Sección";
            // 
            // FormSeccion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(432, 305);
            Controls.Add(Sección);
            Controls.Add(label);
            Controls.Add(TxtSeccion);
            Controls.Add(Titulo);
            Controls.Add(Aceptar);
            Name = "FormSeccion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Sección";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Titulo;
        private Button Aceptar;
        private TextBox TxtSeccion;
        private Label label;
        private Label Sección;
    }
}