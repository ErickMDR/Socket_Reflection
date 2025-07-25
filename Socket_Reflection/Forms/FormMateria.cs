using System;
using System.Windows.Forms;

namespace Socket_Reflection
{
    public partial class FormMateria : Form
    {
        public string NombreMateria { get; private set; }
        public string NombreBusqueda { get; private set; }
        private readonly ModoFormulario _modo;

        public FormMateria(ModoFormulario modo)
        {
            InitializeComponent();
            _modo = modo;
            ConfigurarFormSegunModo();
        }

        private void ConfigurarFormSegunModo()
        {
            switch (_modo)
            {
                case ModoFormulario.Insertar:
                    Aceptar.Text = "Insertar";
                    break;
                    
                case ModoFormulario.Buscar:
                    Aceptar.Text = "Buscar";
                    break;
            }
        }

        private void Aceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtMateria.Text))
            {
                MessageBox.Show("Ingrese un nombre válido", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_modo == ModoFormulario.Insertar)
            {
                NombreMateria = TxtMateria.Text;
            }
            else
            {
                NombreBusqueda = TxtMateria.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }

    }
}