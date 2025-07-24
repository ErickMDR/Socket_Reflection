namespace Socket_Reflection
{
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }
        /*private void CargarDatosMaterias()
        {
            try
            {
                using var tabla = new AccionesMateria();
                dataGridViewTabla.DataSource = tabla.Listado();
                AgregarHeaders();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al cargar datos: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }*/

        private void AgregarHeadersMateria()
        {
            try
            {
                dataGridViewTabla.Columns["materia_id"].HeaderText = "ID";
                dataGridViewTabla.Columns["materia_de"].HeaderText = "Nombre";
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    $"Error al configurar encabezados: {ex.Message}",
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }
        private void AgregarHeadersPersona()
        {
            try
            {
                dataGridViewTabla.Columns["persona_id"].Visible = false;
                dataGridViewTabla.Columns[1].HeaderText = "Cédula";
                dataGridViewTabla.Columns[2].HeaderText = "Nombre";
                dataGridViewTabla.Columns[3].HeaderText = "Apellido";
                dataGridViewTabla.Columns[4].HeaderText = "Tipo de Persona";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}", "Error",
                              MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void AgregarHeadersSeccion()
        {
            try
            {
                dataGridViewTabla.Columns["seccion_id"].HeaderText = "ID";
                dataGridViewTabla.Columns["seccion_de"].HeaderText = "Sección";
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar nombres de columna: {ex.Message}",
                              "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CargarLibreria_Click(object sender, EventArgs e)
        {
            
        }

        private void CrearSocketCli_Click(object sender, EventArgs e)
        {

        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            //using var form = new FormMateria();
            //if (form.ShowDialog() == DialogResult.OK && form.MateriaAgregada)
            //CargarDatosMaterias();
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

        }

        private void Eliminar_Click(object sender, EventArgs e)
        {

        }

        private void IniciarServer_Click(object sender, EventArgs e)
        {

        }

        private void ApagarServer_Click(object sender, EventArgs e)
        {

        }
    }
}
