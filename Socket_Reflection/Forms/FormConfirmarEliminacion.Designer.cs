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
            label2 = new Label();
            Si = new Button();
            No = new Button();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(85, 59);
            label2.Name = "label2";
            label2.Size = new Size(316, 40);
            label2.TabIndex = 12;
            label2.Text = "Confirmar operación?";
            // 
            // Si
            // 
            Si.BackColor = Color.FromArgb(13, 13, 13);
            Si.FlatAppearance.BorderColor = Color.White;
            Si.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Si.FlatStyle = FlatStyle.Flat;
            Si.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold);
            Si.ForeColor = Color.White;
            Si.Location = new Point(85, 161);
            Si.Name = "Si";
            Si.Size = new Size(122, 71);
            Si.TabIndex = 11;
            Si.Text = "Si";
            Si.UseVisualStyleBackColor = false;
            // 
            // No
            // 
            No.BackColor = Color.FromArgb(13, 13, 13);
            No.FlatAppearance.BorderColor = Color.White;
            No.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            No.FlatStyle = FlatStyle.Flat;
            No.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold);
            No.ForeColor = Color.White;
            No.Location = new Point(265, 161);
            No.Name = "No";
            No.Size = new Size(122, 71);
            No.TabIndex = 13;
            No.Text = "No";
            No.UseVisualStyleBackColor = false;
            // 
            // FormConfirmarEliminacion
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(482, 305);
            Controls.Add(No);
            Controls.Add(label2);
            Controls.Add(Si);
            Name = "FormConfirmarEliminacion";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Confirmar Eliminación";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private Button Si;
        private Button No;
    }
}