using System;
using System.Windows.Forms;

namespace Socket_Reflection.Forms
{
    public partial class FormPersona : Form
    {
        public string Nombre { get; private set; }
        public string Apellido { get; private set; }
        public int Cedula { get; private set; }
        public string TipoPersona { get; private set; }

        public FormPersona()
        {
            InitializeComponent();
            CargarTiposPersona();
        }

        private void CargarTiposPersona()
        {
            ComboBox.Items.AddRange(new[] { "Profesor", "Estudiante" });
            ComboBox.SelectedIndex = 0;
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtNombre.Text) || 
                string.IsNullOrWhiteSpace(TxtApellido.Text) ||
                !int.TryParse(TxtCedula.Text, out int cedula))
            {
                MessageBox.Show("Complete todos los campos correctamente", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Nombre = TxtNombre.Text;
            Apellido = TxtApellido.Text;
            Cedula = cedula;
            TipoPersona = ComboBox.SelectedItem.ToString();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}