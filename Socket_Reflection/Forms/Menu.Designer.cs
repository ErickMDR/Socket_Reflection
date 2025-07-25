using System.Windows.Forms;

namespace Socket_Reflection
{
    partial class Menu
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Title = new Label();
            panel2 = new Panel();
            label8 = new Label();
            TxtTipos = new TextBox();
            label7 = new Label();
            TxtParams = new TextBox();
            label6 = new Label();
            TxtMetodo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            ApagarServer = new Button();
            TxtClase = new TextBox();
            panel4 = new Panel();
            label = new Label();
            TxtEstadoServidor = new TextBox();
            label4 = new Label();
            IniciarServer = new Button();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(100, 23);
            Title.Name = "Title";
            Title.Size = new Size(333, 45);
            Title.TabIndex = 1;
            Title.Text = "Socket con Reflexión";
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(TxtTipos);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TxtParams);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TxtMetodo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ApagarServer);
            panel2.Controls.Add(TxtClase);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(IniciarServer);
            panel2.Location = new Point(15, 93);
            panel2.Name = "panel2";
            panel2.Size = new Size(500, 650);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(27, 561);
            label8.Name = "label8";
            label8.Size = new Size(70, 30);
            label8.TabIndex = 19;
            label8.Text = "Tipos:";
            // 
            // TxtTipos
            // 
            TxtTipos.BackColor = Color.FromArgb(13, 13, 13);
            TxtTipos.Enabled = false;
            TxtTipos.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtTipos.ForeColor = Color.White;
            TxtTipos.Location = new Point(125, 558);
            TxtTipos.MaxLength = 40;
            TxtTipos.Name = "TxtTipos";
            TxtTipos.ReadOnly = true;
            TxtTipos.Size = new Size(345, 37);
            TxtTipos.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(27, 498);
            label7.Name = "label7";
            label7.Size = new Size(87, 30);
            label7.TabIndex = 17;
            label7.Text = "Params:";
            // 
            // TxtParams
            // 
            TxtParams.BackColor = Color.FromArgb(13, 13, 13);
            TxtParams.Enabled = false;
            TxtParams.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtParams.ForeColor = Color.White;
            TxtParams.Location = new Point(125, 495);
            TxtParams.MaxLength = 40;
            TxtParams.Name = "TxtParams";
            TxtParams.ReadOnly = true;
            TxtParams.Size = new Size(345, 37);
            TxtParams.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(27, 429);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 15;
            label6.Text = "Método:";
            // 
            // TxtMetodo
            // 
            TxtMetodo.BackColor = Color.FromArgb(13, 13, 13);
            TxtMetodo.Enabled = false;
            TxtMetodo.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtMetodo.ForeColor = Color.White;
            TxtMetodo.Location = new Point(125, 426);
            TxtMetodo.MaxLength = 40;
            TxtMetodo.Name = "TxtMetodo";
            TxtMetodo.ReadOnly = true;
            TxtMetodo.Size = new Size(345, 37);
            TxtMetodo.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(136, 280);
            label5.Name = "label5";
            label5.Size = new Size(250, 40);
            label5.TabIndex = 13;
            label5.Text = "Acción ejecutada";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(27, 364);
            label3.Name = "label3";
            label3.Size = new Size(69, 30);
            label3.TabIndex = 12;
            label3.Text = "Clase:";
            // 
            // ApagarServer
            // 
            ApagarServer.BackColor = Color.FromArgb(13, 13, 13);
            ApagarServer.Cursor = Cursors.Hand;
            ApagarServer.FlatAppearance.BorderColor = Color.White;
            ApagarServer.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            ApagarServer.FlatStyle = FlatStyle.Flat;
            ApagarServer.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            ApagarServer.Location = new Point(285, 86);
            ApagarServer.Name = "ApagarServer";
            ApagarServer.Size = new Size(153, 51);
            ApagarServer.TabIndex = 5;
            ApagarServer.Text = "Apagar";
            ApagarServer.UseVisualStyleBackColor = false;
            ApagarServer.Click += ApagarServer_Click;
            // 
            // TxtClase
            // 
            TxtClase.BackColor = Color.FromArgb(13, 13, 13);
            TxtClase.Enabled = false;
            TxtClase.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtClase.ForeColor = Color.White;
            TxtClase.Location = new Point(125, 361);
            TxtClase.MaxLength = 40;
            TxtClase.Name = "TxtClase";
            TxtClase.ReadOnly = true;
            TxtClase.Size = new Size(345, 37);
            TxtClase.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label);
            panel4.Controls.Add(TxtEstadoServidor);
            panel4.Location = new Point(-1, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(500, 97);
            panel4.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(29, 35);
            label.Name = "label";
            label.Size = new Size(82, 30);
            label.TabIndex = 10;
            label.Text = "Estado:";
            // 
            // TxtEstadoServidor
            // 
            TxtEstadoServidor.BackColor = Color.FromArgb(13, 13, 13);
            TxtEstadoServidor.Enabled = false;
            TxtEstadoServidor.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEstadoServidor.ForeColor = Color.White;
            TxtEstadoServidor.Location = new Point(127, 32);
            TxtEstadoServidor.MaxLength = 40;
            TxtEstadoServidor.Name = "TxtEstadoServidor";
            TxtEstadoServidor.ReadOnly = true;
            TxtEstadoServidor.Size = new Size(343, 37);
            TxtEstadoServidor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(181, 22);
            label4.Name = "label4";
            label4.Size = new Size(134, 40);
            label4.TabIndex = 4;
            label4.Text = "Servidor";
            // 
            // IniciarServer
            // 
            IniciarServer.BackColor = Color.FromArgb(13, 13, 13);
            IniciarServer.Cursor = Cursors.Hand;
            IniciarServer.FlatAppearance.BorderColor = Color.White;
            IniciarServer.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            IniciarServer.FlatStyle = FlatStyle.Flat;
            IniciarServer.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            IniciarServer.Location = new Point(63, 86);
            IniciarServer.Name = "IniciarServer";
            IniciarServer.Size = new Size(153, 51);
            IniciarServer.TabIndex = 0;
            IniciarServer.Text = "Iniciar";
            IniciarServer.UseVisualStyleBackColor = false;
            IniciarServer.Click += IniciarServer_Click;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(532, 755);
            Controls.Add(panel2);
            Controls.Add(Title);
            ForeColor = Color.White;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socket con Reflexión";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label Title;
        private Panel panel2;
        private Panel panel4;
        private Label label4;
        private Button button6;
        private Button IniciarServer;
        private Label label;
        private TextBox TxtEstadoServidor;
        private Button ApagarServer;
        private Label label5;
        private Label label3;
        private TextBox TxtClase;
        private Label label7;
        private TextBox TxtParams;
        private Label label6;
        private TextBox TxtMetodo;
        private Label label8;
        private TextBox TxtTipos;
    }
}
