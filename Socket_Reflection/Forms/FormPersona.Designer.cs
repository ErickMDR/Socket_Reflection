namespace Socket_Reflection.Forms
{
    partial class FormPersona
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
            label3 = new Label();
            TxtNombre = new TextBox();
            label4 = new Label();
            TxtApellido = new TextBox();
            label5 = new Label();
            ComboBox = new ComboBox();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 32);
            label2.Name = "label2";
            label2.Size = new Size(127, 40);
            label2.TabIndex = 14;
            label2.Text = "Persona";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(62, 85);
            label1.Name = "label1";
            label1.Size = new Size(85, 30);
            label1.TabIndex = 13;
            label1.Text = "Cédula:";
            // 
            // TxtCedula
            // 
            TxtCedula.BackColor = Color.FromArgb(13, 13, 13);
            TxtCedula.Cursor = Cursors.IBeam;
            TxtCedula.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtCedula.ForeColor = Color.White;
            TxtCedula.Location = new Point(53, 118);
            TxtCedula.Name = "TxtCedula";
            TxtCedula.PlaceholderText = "Ingrese cédula";
            TxtCedula.Size = new Size(318, 37);
            TxtCedula.TabIndex = 12;
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
            Aceptar.Location = new Point(125, 467);
            Aceptar.Name = "Aceptar";
            Aceptar.Size = new Size(167, 51);
            Aceptar.TabIndex = 11;
            Aceptar.Text = "Aceptar";
            Aceptar.UseVisualStyleBackColor = false;
            Aceptar.Click += Aceptar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(62, 174);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 16;
            label3.Text = "Nombre:";
            // 
            // TxtNombre
            // 
            TxtNombre.BackColor = Color.FromArgb(13, 13, 13);
            TxtNombre.Cursor = Cursors.IBeam;
            TxtNombre.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtNombre.ForeColor = Color.White;
            TxtNombre.Location = new Point(53, 207);
            TxtNombre.Name = "TxtNombre";
            TxtNombre.PlaceholderText = "Ingrese nombre";
            TxtNombre.Size = new Size(318, 37);
            TxtNombre.TabIndex = 15;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.White;
            label4.Location = new Point(62, 264);
            label4.Name = "label4";
            label4.Size = new Size(98, 30);
            label4.TabIndex = 18;
            label4.Text = "Apellido:";
            // 
            // TxtApellido
            // 
            TxtApellido.BackColor = Color.FromArgb(13, 13, 13);
            TxtApellido.Cursor = Cursors.IBeam;
            TxtApellido.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtApellido.ForeColor = Color.White;
            TxtApellido.Location = new Point(53, 297);
            TxtApellido.Name = "TxtApellido";
            TxtApellido.PlaceholderText = "Ingrese apellido";
            TxtApellido.Size = new Size(318, 37);
            TxtApellido.TabIndex = 17;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.White;
            label5.Location = new Point(62, 353);
            label5.Name = "label5";
            label5.Size = new Size(174, 30);
            label5.TabIndex = 20;
            label5.Text = "Tipo de Persona:";
            // 
            // ComboBox
            // 
            ComboBox.BackColor = Color.FromArgb(13, 13, 13);
            ComboBox.Cursor = Cursors.Hand;
            ComboBox.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ComboBox.ForeColor = SystemColors.Menu;
            ComboBox.FormattingEnabled = true;
            ComboBox.Location = new Point(53, 386);
            ComboBox.Name = "ComboBox";
            ComboBox.Size = new Size(318, 38);
            ComboBox.TabIndex = 21;
            // 
            // FormPersona
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(432, 555);
            Controls.Add(ComboBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(TxtApellido);
            Controls.Add(label3);
            Controls.Add(TxtNombre);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(TxtCedula);
            Controls.Add(Aceptar);
            Name = "FormPersona";
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
        private Label label3;
        private TextBox TxtNombre;
        private Label label4;
        private TextBox TxtApellido;
        private Label label5;
        private ComboBox ComboBox;
    }
}