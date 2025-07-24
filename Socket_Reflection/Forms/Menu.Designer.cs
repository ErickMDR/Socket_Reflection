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
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle6 = new DataGridViewCellStyle();
            CargarLibreria = new Button();
            Title = new Label();
            PanelCliente = new Panel();
            CrearSocketCli = new Button();
            AccionesCliente = new Panel();
            label9 = new Label();
            cmbTabla = new ComboBox();
            Eliminar = new Button();
            Buscar = new Button();
            Ingresar = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dataGridViewTabla = new DataGridView();
            panel2 = new Panel();
            label8 = new Label();
            TxtTipos = new TextBox();
            label7 = new Label();
            TxtParams = new TextBox();
            label6 = new Label();
            TextMetodo = new TextBox();
            label5 = new Label();
            label3 = new Label();
            ApagarServer = new Button();
            TxtClase = new TextBox();
            panel4 = new Panel();
            label = new Label();
            TxtEstadoServidor = new TextBox();
            label4 = new Label();
            IniciarServer = new Button();
            panel3 = new Panel();
            label10 = new Label();
            TxtEstadoCliente = new TextBox();
            PanelCliente.SuspendLayout();
            AccionesCliente.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).BeginInit();
            panel2.SuspendLayout();
            panel4.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // CargarLibreria
            // 
            CargarLibreria.BackColor = Color.FromArgb(13, 13, 13);
            CargarLibreria.Cursor = Cursors.Hand;
            CargarLibreria.FlatAppearance.BorderColor = Color.White;
            CargarLibreria.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            CargarLibreria.FlatStyle = FlatStyle.Flat;
            CargarLibreria.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            CargarLibreria.Location = new Point(20, 86);
            CargarLibreria.Name = "CargarLibreria";
            CargarLibreria.Size = new Size(197, 51);
            CargarLibreria.TabIndex = 0;
            CargarLibreria.Text = "Cargar Librería";
            CargarLibreria.UseVisualStyleBackColor = false;
            CargarLibreria.Click += CargarLibreria_Click;
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(338, 20);
            Title.Name = "Title";
            Title.Size = new Size(333, 45);
            Title.TabIndex = 1;
            Title.Text = "Socket con Reflexión";
            // 
            // PanelCliente
            // 
            PanelCliente.BorderStyle = BorderStyle.FixedSingle;
            PanelCliente.Controls.Add(panel3);
            PanelCliente.Controls.Add(CrearSocketCli);
            PanelCliente.Controls.Add(AccionesCliente);
            PanelCliente.Controls.Add(label1);
            PanelCliente.Controls.Add(CargarLibreria);
            PanelCliente.Location = new Point(17, 85);
            PanelCliente.Name = "PanelCliente";
            PanelCliente.Size = new Size(460, 650);
            PanelCliente.TabIndex = 3;
            // 
            // CrearSocketCli
            // 
            CrearSocketCli.BackColor = Color.FromArgb(13, 13, 13);
            CrearSocketCli.Cursor = Cursors.Hand;
            CrearSocketCli.FlatAppearance.BorderColor = Color.White;
            CrearSocketCli.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            CrearSocketCli.FlatStyle = FlatStyle.Flat;
            CrearSocketCli.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            CrearSocketCli.Location = new Point(236, 86);
            CrearSocketCli.Name = "CrearSocketCli";
            CrearSocketCli.Size = new Size(197, 51);
            CrearSocketCli.TabIndex = 5;
            CrearSocketCli.Text = "Crear Socket Cli";
            CrearSocketCli.UseVisualStyleBackColor = false;
            // 
            // AccionesCliente
            // 
            AccionesCliente.BorderStyle = BorderStyle.FixedSingle;
            AccionesCliente.Controls.Add(label9);
            AccionesCliente.Controls.Add(cmbTabla);
            AccionesCliente.Controls.Add(Eliminar);
            AccionesCliente.Controls.Add(Buscar);
            AccionesCliente.Controls.Add(Ingresar);
            AccionesCliente.Location = new Point(20, 267);
            AccionesCliente.Name = "AccionesCliente";
            AccionesCliente.Size = new Size(413, 170);
            AccionesCliente.TabIndex = 4;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label9.ForeColor = Color.White;
            label9.Location = new Point(63, 32);
            label9.Name = "label9";
            label9.Size = new Size(68, 30);
            label9.TabIndex = 20;
            label9.Text = "Tabla:";
            // 
            // cmbTabla
            // 
            cmbTabla.BackColor = Color.FromArgb(13, 13, 13);
            cmbTabla.Cursor = Cursors.Hand;
            cmbTabla.FlatStyle = FlatStyle.Popup;
            cmbTabla.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cmbTabla.ForeColor = Color.White;
            cmbTabla.FormattingEnabled = true;
            cmbTabla.Location = new Point(143, 27);
            cmbTabla.Name = "cmbTabla";
            cmbTabla.Size = new Size(197, 38);
            cmbTabla.TabIndex = 6;
            // 
            // Eliminar
            // 
            Eliminar.BackColor = Color.FromArgb(13, 13, 13);
            Eliminar.Cursor = Cursors.Hand;
            Eliminar.FlatAppearance.BorderColor = Color.White;
            Eliminar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Eliminar.FlatStyle = FlatStyle.Flat;
            Eliminar.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            Eliminar.Location = new Point(283, 101);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(110, 50);
            Eliminar.TabIndex = 7;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            // 
            // Buscar
            // 
            Buscar.BackColor = Color.FromArgb(13, 13, 13);
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderColor = Color.White;
            Buscar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            Buscar.Location = new Point(21, 101);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(110, 50);
            Buscar.TabIndex = 6;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            // 
            // Ingresar
            // 
            Ingresar.BackColor = Color.FromArgb(13, 13, 13);
            Ingresar.Cursor = Cursors.Hand;
            Ingresar.FlatAppearance.BorderColor = Color.White;
            Ingresar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Ingresar.FlatStyle = FlatStyle.Flat;
            Ingresar.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            Ingresar.Location = new Point(153, 101);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(110, 50);
            Ingresar.TabIndex = 5;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(172, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridViewTabla);
            panel1.Location = new Point(21, 537);
            panel1.Name = "panel1";
            panel1.Size = new Size(452, 194);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(179, 6);
            label2.Name = "label2";
            label2.Size = new Size(95, 36);
            label2.TabIndex = 4;
            label2.Text = "TABLA";
            // 
            // dataGridViewTabla
            // 
            dataGridViewTabla.AllowUserToAddRows = false;
            dataGridViewTabla.AllowUserToDeleteRows = false;
            dataGridViewTabla.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewTabla.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewTabla.BackgroundColor = Color.FromArgb(13, 13, 13);
            dataGridViewTabla.BorderStyle = BorderStyle.None;
            dataGridViewTabla.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 16F, FontStyle.Bold);
            dataGridViewCellStyle4.ForeColor = Color.White;
            dataGridViewCellStyle4.Padding = new Padding(30, 5, 5, 5);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewTabla.ColumnHeadersHeight = 50;
            dataGridViewCellStyle5.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle5.Font = new Font("Segoe UI", 14F);
            dataGridViewCellStyle5.ForeColor = Color.White;
            dataGridViewCellStyle5.Padding = new Padding(5);
            dataGridViewCellStyle5.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle5.SelectionForeColor = Color.White;
            dataGridViewCellStyle5.WrapMode = DataGridViewTriState.False;
            dataGridViewTabla.DefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewTabla.EnableHeadersVisualStyles = false;
            dataGridViewTabla.GridColor = Color.LightGray;
            dataGridViewTabla.Location = new Point(0, 50);
            dataGridViewTabla.Margin = new Padding(0);
            dataGridViewTabla.Name = "dataGridViewTabla";
            dataGridViewTabla.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle6.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle6.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle6.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            dataGridViewTabla.RowHeadersWidth = 49;
            dataGridViewTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTabla.Size = new Size(452, 147);
            dataGridViewTabla.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label8);
            panel2.Controls.Add(TxtTipos);
            panel2.Controls.Add(label7);
            panel2.Controls.Add(TxtParams);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(TextMetodo);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label3);
            panel2.Controls.Add(ApagarServer);
            panel2.Controls.Add(TxtClase);
            panel2.Controls.Add(panel4);
            panel2.Controls.Add(label4);
            panel2.Controls.Add(IniciarServer);
            panel2.Location = new Point(503, 85);
            panel2.Name = "panel2";
            panel2.Size = new Size(460, 650);
            panel2.TabIndex = 5;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(39, 561);
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
            TxtTipos.Location = new Point(137, 558);
            TxtTipos.MaxLength = 40;
            TxtTipos.Name = "TxtTipos";
            TxtTipos.ReadOnly = true;
            TxtTipos.Size = new Size(261, 37);
            TxtTipos.TabIndex = 18;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.ForeColor = Color.White;
            label7.Location = new Point(39, 498);
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
            TxtParams.Location = new Point(137, 495);
            TxtParams.MaxLength = 40;
            TxtParams.Name = "TxtParams";
            TxtParams.ReadOnly = true;
            TxtParams.Size = new Size(261, 37);
            TxtParams.TabIndex = 16;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.White;
            label6.Location = new Point(39, 429);
            label6.Name = "label6";
            label6.Size = new Size(96, 30);
            label6.TabIndex = 15;
            label6.Text = "Método:";
            // 
            // TextMetodo
            // 
            TextMetodo.BackColor = Color.FromArgb(13, 13, 13);
            TextMetodo.Enabled = false;
            TextMetodo.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TextMetodo.ForeColor = Color.White;
            TextMetodo.Location = new Point(137, 426);
            TextMetodo.MaxLength = 40;
            TextMetodo.Name = "TextMetodo";
            TextMetodo.ReadOnly = true;
            TextMetodo.Size = new Size(261, 37);
            TextMetodo.TabIndex = 14;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(92, 286);
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
            label3.Location = new Point(39, 364);
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
            ApagarServer.Location = new Point(243, 86);
            ApagarServer.Name = "ApagarServer";
            ApagarServer.Size = new Size(197, 51);
            ApagarServer.TabIndex = 5;
            ApagarServer.Text = "Apagar Servidor";
            ApagarServer.UseVisualStyleBackColor = false;
            // 
            // TxtClase
            // 
            TxtClase.BackColor = Color.FromArgb(13, 13, 13);
            TxtClase.Enabled = false;
            TxtClase.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtClase.ForeColor = Color.White;
            TxtClase.Location = new Point(137, 361);
            TxtClase.MaxLength = 40;
            TxtClase.Name = "TxtClase";
            TxtClase.ReadOnly = true;
            TxtClase.Size = new Size(261, 37);
            TxtClase.TabIndex = 11;
            // 
            // panel4
            // 
            panel4.BorderStyle = BorderStyle.FixedSingle;
            panel4.Controls.Add(label);
            panel4.Controls.Add(TxtEstadoServidor);
            panel4.Location = new Point(-1, 156);
            panel4.Name = "panel4";
            panel4.Size = new Size(460, 97);
            panel4.TabIndex = 4;
            // 
            // label
            // 
            label.AutoSize = true;
            label.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label.ForeColor = Color.White;
            label.Location = new Point(36, 35);
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
            TxtEstadoServidor.Location = new Point(134, 32);
            TxtEstadoServidor.MaxLength = 40;
            TxtEstadoServidor.Name = "TxtEstadoServidor";
            TxtEstadoServidor.ReadOnly = true;
            TxtEstadoServidor.Size = new Size(264, 37);
            TxtEstadoServidor.TabIndex = 9;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(163, 22);
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
            IniciarServer.Location = new Point(20, 86);
            IniciarServer.Name = "IniciarServer";
            IniciarServer.Size = new Size(197, 51);
            IniciarServer.TabIndex = 0;
            IniciarServer.Text = "Iniciar Servidor";
            IniciarServer.UseVisualStyleBackColor = false;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(TxtEstadoCliente);
            panel3.Location = new Point(-1, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(460, 97);
            panel3.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(36, 35);
            label10.Name = "label10";
            label10.Size = new Size(82, 30);
            label10.TabIndex = 10;
            label10.Text = "Estado:";
            // 
            // TxtEstadoCliente
            // 
            TxtEstadoCliente.BackColor = Color.FromArgb(13, 13, 13);
            TxtEstadoCliente.Enabled = false;
            TxtEstadoCliente.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            TxtEstadoCliente.ForeColor = Color.White;
            TxtEstadoCliente.Location = new Point(134, 32);
            TxtEstadoCliente.MaxLength = 40;
            TxtEstadoCliente.Name = "TxtEstadoCliente";
            TxtEstadoCliente.ReadOnly = true;
            TxtEstadoCliente.Size = new Size(264, 37);
            TxtEstadoCliente.TabIndex = 9;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(982, 755);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(PanelCliente);
            Controls.Add(Title);
            ForeColor = Color.White;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socket";
            PanelCliente.ResumeLayout(false);
            PanelCliente.PerformLayout();
            AccionesCliente.ResumeLayout(false);
            AccionesCliente.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button CargarLibreria;
        private Label Title;
        private Panel PanelCliente;
        private Label label1;
        private Panel AccionesCliente;
        private Button Eliminar;
        private Button Buscar;
        private Button Ingresar;
        public DataGridView dataGridViewTabla;
        private Label label2;
        private Button CrearSocketCli;
        private Panel panel1;
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
        private TextBox TextMetodo;
        private Label label8;
        private TextBox TxtTipos;
        private ComboBox cmbTabla;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private TextBox TxtEstadoCliente;
    }
}
