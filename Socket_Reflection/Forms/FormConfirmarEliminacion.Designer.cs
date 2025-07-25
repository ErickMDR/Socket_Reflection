namespace Socket_Reflection.Forms
{
    partial class FormConfirmarEliminacion
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
            Cancelar = new Button();
            label11 = new Label();
            Confirmar = new Button();
            SuspendLayout();
            // 
            // Cancelar
            // 
            Cancelar.BackColor = Color.FromArgb(13, 13, 13);
            Cancelar.Cursor = Cursors.Hand;
            Cancelar.FlatAppearance.BorderColor = Color.White;
            Cancelar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Cancelar.FlatStyle = FlatStyle.Flat;
            Cancelar.Font = new Font("Microsoft Sans Serif", 16.2782612F, FontStyle.Bold);
            Cancelar.ForeColor = Color.White;
            Cancelar.Location = new Point(236, 133);
            Cancelar.Name = "Cancelar";
            Cancelar.Size = new Size(112, 60);
            Cancelar.TabIndex = 8;
            Cancelar.Text = "No";
            Cancelar.UseVisualStyleBackColor = false;
            Cancelar.Click += Cancelar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.ForeColor = Color.White;
            label11.Location = new Point(43, 53);
            label11.Name = "label11";
            label11.Size = new Size(349, 40);
            label11.TabIndex = 7;
            label11.Text = "¿Confirma la operación?";
            // 
            // Confirmar
            // 
            Confirmar.BackColor = Color.FromArgb(13, 13, 13);
            Confirmar.Cursor = Cursors.Hand;
            Confirmar.FlatAppearance.BorderColor = Color.White;
            Confirmar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Confirmar.FlatStyle = FlatStyle.Flat;
            Confirmar.Font = new Font("Microsoft Sans Serif", 16.2782612F, FontStyle.Bold);
            Confirmar.ForeColor = Color.White;
            Confirmar.Location = new Point(72, 133);
            Confirmar.Name = "Confirmar";
            Confirmar.Size = new Size(112, 60);
            Confirmar.TabIndex = 6;
            Confirmar.Text = "Si";
            Confirmar.UseVisualStyleBackColor = false;
            Confirmar.Click += Confirmar_Click;
            // 
            // FormConfirmarEliminacion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(432, 255);
            Controls.Add(Cancelar);
            Controls.Add(label11);
            Controls.Add(Confirmar);
            Name = "FormConfirmarEliminacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Eliminacion";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Cancelar;
        private Label label11;
        private Button Confirmar;
    }
}