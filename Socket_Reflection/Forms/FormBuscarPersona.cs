using System;
using System.Windows.Forms;

namespace Socket_Reflection.Forms
{
    public partial class FormBuscarPersona : Form
    {
        public int CedulaBusqueda { get; private set; }

        public FormBuscarPersona()
        {
            InitializeComponent();
        }
        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (int.TryParse(TxtCedula.Text, out int cedula))
            {
                CedulaBusqueda = cedula;
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Ingrese una cédula válida", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}