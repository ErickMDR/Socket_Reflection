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

        private void AgregarHeaders()
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
        private void CargarLibreria_Click(object sender, EventArgs e)
        {
            using var form = new FormMateria();
            //if (form.ShowDialog() == DialogResult.OK && form.MateriaAgregada)
                //CargarDatosMaterias();
        }
        private void Enviar_Click(object sender, EventArgs e)
        {
            using var form = new FormMateria();
            //if (form.ShowDialog() == DialogResult.OK && form.MateriaAgregada)
                //CargarDatosMaterias();
        }
    }
}
