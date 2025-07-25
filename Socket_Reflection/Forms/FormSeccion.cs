using System;
using System.Windows.Forms;

namespace Socket_Reflection
{
    public partial class FormSeccion : Form
    {
        public string DescripcionSeccion { get; private set; }
        public string DescripcionBusqueda { get; private set; }
        private readonly ModoFormulario _modo;

        public FormSeccion(ModoFormulario modo)
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
            if (string.IsNullOrWhiteSpace(TxtSeccion.Text))
            {
                MessageBox.Show("Ingrese una descripción válida", "Error", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (_modo == ModoFormulario.Insertar)
            {
                DescripcionSeccion = TxtSeccion.Text;
            }
            else
            {
                DescripcionBusqueda = TxtSeccion.Text;
            }

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
