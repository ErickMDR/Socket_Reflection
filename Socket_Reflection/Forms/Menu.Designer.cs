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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            Title = new Label();
            PanelCliente = new Panel();
            panel3 = new Panel();
            label10 = new Label();
            TxtEstadoCliente = new TextBox();
            CrearSocketCli = new Button();
            AccionesCliente = new Panel();
            label9 = new Label();
            cmbTabla = new ComboBox();
            Eliminar = new Button();
            Buscar = new Button();
            Ingresar = new Button();
            label11 = new Label();
            button1 = new Button();
            label1 = new Label();
            panel1 = new Panel();
            label2 = new Label();
            dataGridViewTabla = new DataGridView();
            PanelCliente.SuspendLayout();
            panel3.SuspendLayout();
            AccionesCliente.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).BeginInit();
            SuspendLayout();
            // 
            // Title
            // 
            Title.AutoSize = true;
            Title.Font = new Font("Segoe UI", 20.0347824F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Title.Location = new Point(100, 25);
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
            PanelCliente.Controls.Add(label11);
            PanelCliente.Controls.Add(button1);
            PanelCliente.Controls.Add(label1);
            PanelCliente.Location = new Point(17, 85);
            PanelCliente.Name = "PanelCliente";
            PanelCliente.Size = new Size(500, 650);
            PanelCliente.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(label10);
            panel3.Controls.Add(TxtEstadoCliente);
            panel3.Location = new Point(-1, 156);
            panel3.Name = "panel3";
            panel3.Size = new Size(500, 97);
            panel3.TabIndex = 11;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.White;
            label10.Location = new Point(25, 35);
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
            TxtEstadoCliente.Location = new Point(123, 32);
            TxtEstadoCliente.MaxLength = 40;
            TxtEstadoCliente.Name = "TxtEstadoCliente";
            TxtEstadoCliente.ReadOnly = true;
            TxtEstadoCliente.Size = new Size(347, 37);
            TxtEstadoCliente.TabIndex = 9;
            // 
            // CrearSocketCli
            // 
            CrearSocketCli.BackColor = Color.FromArgb(13, 13, 13);
            CrearSocketCli.Cursor = Cursors.Hand;
            CrearSocketCli.FlatAppearance.BorderColor = Color.White;
            CrearSocketCli.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            CrearSocketCli.FlatStyle = FlatStyle.Flat;
            CrearSocketCli.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            CrearSocketCli.Location = new Point(286, 86);
            CrearSocketCli.Name = "CrearSocketCli";
            CrearSocketCli.Size = new Size(153, 51);
            CrearSocketCli.TabIndex = 5;
            CrearSocketCli.Text = "Conectar";
            CrearSocketCli.UseVisualStyleBackColor = false;
            CrearSocketCli.Click += CrearSocketCli_Click;
            // 
            // AccionesCliente
            // 
            AccionesCliente.BorderStyle = BorderStyle.FixedSingle;
            AccionesCliente.Controls.Add(label9);
            AccionesCliente.Controls.Add(cmbTabla);
            AccionesCliente.Controls.Add(Eliminar);
            AccionesCliente.Controls.Add(Buscar);
            AccionesCliente.Controls.Add(Ingresar);
            AccionesCliente.Location = new Point(18, 267);
            AccionesCliente.Name = "AccionesCliente";
            AccionesCliente.Size = new Size(462, 170);
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
            cmbTabla.Size = new Size(231, 38);
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
            Eliminar.Location = new Point(321, 101);
            Eliminar.Name = "Eliminar";
            Eliminar.Size = new Size(110, 50);
            Eliminar.TabIndex = 7;
            Eliminar.Text = "Eliminar";
            Eliminar.UseVisualStyleBackColor = false;
            Eliminar.Click += Eliminar_Click;
            // 
            // Buscar
            // 
            Buscar.BackColor = Color.FromArgb(13, 13, 13);
            Buscar.Cursor = Cursors.Hand;
            Buscar.FlatAppearance.BorderColor = Color.White;
            Buscar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Buscar.FlatStyle = FlatStyle.Flat;
            Buscar.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            Buscar.Location = new Point(31, 101);
            Buscar.Name = "Buscar";
            Buscar.Size = new Size(110, 50);
            Buscar.TabIndex = 6;
            Buscar.Text = "Buscar";
            Buscar.UseVisualStyleBackColor = false;
            Buscar.Click += Buscar_Click;
            // 
            // Ingresar
            // 
            Ingresar.BackColor = Color.FromArgb(13, 13, 13);
            Ingresar.Cursor = Cursors.Hand;
            Ingresar.FlatAppearance.BorderColor = Color.White;
            Ingresar.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            Ingresar.FlatStyle = FlatStyle.Flat;
            Ingresar.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            Ingresar.Location = new Point(175, 101);
            Ingresar.Name = "Ingresar";
            Ingresar.Size = new Size(110, 50);
            Ingresar.TabIndex = 5;
            Ingresar.Text = "Ingresar";
            Ingresar.UseVisualStyleBackColor = false;
            Ingresar.Click += Ingresar_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label11.Location = new Point(194, 22);
            label11.Name = "label11";
            label11.Size = new Size(112, 40);
            label11.TabIndex = 4;
            label11.Text = "Cliente";
            // 
            // button1
            // 
            button1.BackColor = Color.FromArgb(13, 13, 13);
            button1.Cursor = Cursors.Hand;
            button1.FlatAppearance.BorderColor = Color.White;
            button1.FlatAppearance.MouseOverBackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Microsoft Sans Serif", 13.1478262F);
            button1.Location = new Point(52, 86);
            button1.Name = "button1";
            button1.Size = new Size(170, 51);
            button1.TabIndex = 0;
            button1.Text = "Cargar Librería";
            button1.UseVisualStyleBackColor = false;
            button1.Click += CargarLibreria_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 18.1565228F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(194, 22);
            label1.Name = "label1";
            label1.Size = new Size(112, 40);
            label1.TabIndex = 4;
            label1.Text = "Cliente";
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label2);
            panel1.Controls.Add(dataGridViewTabla);
            panel1.Location = new Point(17, 537);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 198);
            panel1.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 16.2782612F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.Control;
            label2.Location = new Point(199, 5);
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
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Bold, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(30, 5, 5, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewTabla.ColumnHeadersHeight = 50;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 13.7739134F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.White;
            dataGridViewCellStyle2.Padding = new Padding(5);
            dataGridViewCellStyle2.SelectionBackColor = Color.MediumPurple;
            dataGridViewCellStyle2.SelectionForeColor = Color.White;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewTabla.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewTabla.EnableHeadersVisualStyles = false;
            dataGridViewTabla.GridColor = Color.LightGray;
            dataGridViewTabla.Location = new Point(0, 50);
            dataGridViewTabla.Margin = new Padding(0);
            dataGridViewTabla.Name = "dataGridViewTabla";
            dataGridViewTabla.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 8.765218F);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(22, 18, 30);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridViewTabla.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewTabla.RowHeadersWidth = 49;
            dataGridViewTabla.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewTabla.Size = new Size(498, 146);
            dataGridViewTabla.TabIndex = 4;
            // 
            // Menu
            // 
            AutoScaleDimensions = new SizeF(8F, 19F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(13, 13, 13);
            ClientSize = new Size(532, 755);
            Controls.Add(panel1);
            Controls.Add(PanelCliente);
            Controls.Add(Title);
            ForeColor = Color.White;
            Name = "Menu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Socket con Reflexión";
            PanelCliente.ResumeLayout(false);
            PanelCliente.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            AccionesCliente.ResumeLayout(false);
            AccionesCliente.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTabla).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
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
        private Button button6;
        private ComboBox cmbTabla;
        private Label label9;
        private Panel panel3;
        private Label label10;
        private TextBox TxtEstadoCliente;
        private Label label11;
        private Button button1;
    }
}
