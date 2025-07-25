using Socket_Reflection.Entidades;
using Socket_Reflection.Forms;
using Socket_Reflection.WebSocket;
using System;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Socket_Reflection
{
    public partial class Menu : Form
    {
        private readonly Client _cliente;
        private readonly Server _servidor;
        private bool _servidorIniciado = false;
        private string _tablaSeleccionada;

        public Menu()
        {
            InitializeComponent();
            _cliente = new Client();
            _servidor = new Server();

            _servidor.EstadoServidorCambiado += Servidor_EstadoCambiado;

            cmbTabla.Items.AddRange(new[] { "Persona", "Materia", "Seccion" });
            cmbTabla.SelectedIndex = 0;
            _tablaSeleccionada = cmbTabla.SelectedItem.ToString();
        }

        #region Métodos auxiliares
        private void Servidor_EstadoCambiado(bool servidorActivo)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<bool>(Servidor_EstadoCambiado), servidorActivo);
                return;
            }

            if (!servidorActivo)
            {
                ActualizarEstadoCliente("Servidor desconectado");
            }
        }

        private void ActualizarEstadoCliente(string mensaje)
        {
            TxtEstadoCliente.Text = mensaje;
            TxtEstadoCliente.Refresh();
        }

        private void ActualizarEstadoServidor(string mensaje)
        {
            TxtEstadoServidor.Text = mensaje;
            TxtEstadoServidor.Refresh();
        }

        private void MostrarDetallesEjecucion(DetalleEjecucion detalle)
        {
            TxtClase.Text = detalle?.Clase ?? "N/A";
            TxtMetodo.Text = detalle?.Metodo ?? "N/A";
            TxtParams.Text = detalle != null ? string.Join(", ", detalle.ParametrosJson) : "N/A";
            TxtTipos.Text = detalle != null ? string.Join(", ", detalle.TiposParametros) : "N/A";
        }
        #endregion

        #region Eventos del formulario
        private void CargarLibreria_Click(object sender, EventArgs e)
        {
            try
            {
                var rutaLib = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "libCli.json");

                _cliente.ConfigurarDesdeJson(rutaLib);
                ActualizarEstadoCliente($"Librería cargada");

                var config = JsonConvert.DeserializeObject<dynamic>(File.ReadAllText(rutaLib));
            }
            catch (Exception ex)
            {
                ActualizarEstadoCliente("Error al cargar librería");
                MessageBox.Show($"Error al cargar librería: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CrearSocketCli_Click(object sender, EventArgs e)
        {
            try
            {
                if (!_cliente.Configurado)
                {
                    MessageBox.Show("Primero cargue la librería de configuración", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!_servidorIniciado)
                {
                    MessageBox.Show("El servidor no está iniciado", "Advertencia",
                        MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                var resultado = _cliente.EnviarSolicitud("Materia", "Listado");

                if (resultado.Exitoso)
                {
                    ActualizarEstadoCliente($"Conectado a {_cliente.Host}:{_cliente.Port}");
                }
                else
                {
                    throw new Exception(resultado.Mensaje);
                }
            }
            catch (Exception ex)
            {
                ActualizarEstadoCliente("Error de conexión");
                MessageBox.Show($"Error al conectar con el servidor: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Buscar_Click(object sender, EventArgs e)
        {
            _tablaSeleccionada = cmbTabla.SelectedItem.ToString();
            switch (_tablaSeleccionada)
            {
                case "Persona":
                    using (var form = new FormBuscarPersona())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var cedula = form.CedulaBusqueda;
                            var resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "BuscarPorCedula", cedula);
                            ProcesarResultadoBusqueda(resultado);
                        }
                    }
                    break;

                case "Materia":
                    using (var form = new FormMateria(modo: ModoFormulario.Buscar))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var nombre = form.NombreBusqueda;
                            var resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "BuscarPorNombre", nombre);
                            ProcesarResultadoBusqueda(resultado);
                        }
                    }
                    break;

                case "Seccion":
                    using (var form = new FormSeccion(modo: ModoFormulario.Buscar))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var descripcion = form.DescripcionBusqueda;
                            var resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "BuscarPorDescripcion", descripcion);
                            ProcesarResultadoBusqueda(resultado);
                        }
                    }
                    break;
            }
        }

        private void Ingresar_Click(object sender, EventArgs e)
        {
            _tablaSeleccionada = cmbTabla.SelectedItem.ToString();
            switch (_tablaSeleccionada)
            {
                case "Persona":
                    using (var form = new FormPersona())
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var persona = new Persona
                            {
                                Nombre = form.Nombre,
                                Apellido = form.Apellido,
                                Cedula = form.Cedula,
                                TipoPersona = form.TipoPersona
                            };
                            var resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "Insertar", persona);
                            ProcesarResultado(resultado);
                        }
                    }
                    break;

                case "Materia":
                    using (var form = new FormMateria(modo: ModoFormulario.Insertar))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var materia = new Materia { Nombre = form.NombreMateria };
                            var resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "Insertar", materia);
                            ProcesarResultado(resultado);
                        }
                    }
                    break;

                case "Seccion":
                    using (var form = new FormSeccion(modo: ModoFormulario.Insertar))
                    {
                        if (form.ShowDialog() == DialogResult.OK)
                        {
                            var seccion = new Seccion { Descripcion = form.DescripcionSeccion };
                            var resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "Insertar", seccion);
                            ProcesarResultado(resultado);
                        }
                    }
                    break;
            }
        }

        private void Eliminar_Click(object sender, EventArgs e)
        {
            _tablaSeleccionada = cmbTabla.SelectedItem?.ToString();

            if (dataGridViewTabla.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un registro para eliminar", "Advertencia",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var selectedRow = dataGridViewTabla.SelectedRows[0];

            using (var form = new FormConfirmarEliminacion())
            {
                if (form.ShowDialog() == DialogResult.OK && form.Confirmado)
                {
                    try
                    {
                        Resultado resultado = null;

                        switch (_tablaSeleccionada)
                        {
                            case "Persona":
                                var id = Convert.ToInt32(selectedRow.Cells["Cédula"].Value);
                                var nombre = selectedRow.Cells["Nombre"].Value.ToString();
                                resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "Eliminar", id);
                                break;
                            case "Materia":
                                var idMateria = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                                var nombreMateria = selectedRow.Cells["Nombre"].Value.ToString();
                                resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "Eliminar", idMateria);
                                break;
                            case "Seccion":
                                var idSeccion = Convert.ToInt32(selectedRow.Cells["Id"].Value);
                                var nombreSeccion = selectedRow.Cells["Descripcion"].Value.ToString();
                                resultado = _cliente.EnviarSolicitud(_tablaSeleccionada, "Eliminar", idSeccion);
                                break;
                        }

                        if (resultado != null)
                        {
                            ProcesarResultado(resultado);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show($"Error al eliminar: {ex.Message}", "Error",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void IniciarServer_Click(object sender, EventArgs e)
        {
            try
            {
            _servidor.Iniciar();
            _servidorIniciado = true;
            ActualizarEstadoServidor("Servidor iniciado");
            ApagarServer.Enabled = true;
            IniciarServer.Enabled = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al iniciar servidor: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ApagarServer_Click(object sender, EventArgs e)
        {
            try
            {
                _servidor.Detener();
                _servidorIniciado = false;
                ActualizarEstadoServidor("Servidor detenido");
                ApagarServer.Enabled = false;
                IniciarServer.Enabled = true;

                ActualizarEstadoCliente("Servidor desconectado");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al detener servidor: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        #endregion

        #region Métodos auxiliares
        private void ProcesarResultadoBusqueda(Resultado resultado)
        {
            if (!resultado.Exitoso)
            {
                MessageBox.Show($"Error: {resultado.Mensaje}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                if (_tablaSeleccionada == "Persona")
                {
                    var personas = JsonConvert.DeserializeObject<List<Persona>>(resultado.DatosJson);

                    DataTable dt = new DataTable();
                    dt.Columns.Add("Cédula", typeof(int));
                    dt.Columns.Add("Nombre", typeof(string));

                    foreach (var persona in personas)
                    {
                        dt.Rows.Add(persona.Cedula, persona.Nombre);
                    }

                    dataGridViewTabla.DataSource = dt;
                }
                else
                {
                    Type tipoLista = _tablaSeleccionada switch
                    {
                        "Materia" => typeof(List<Materia>),
                        "Seccion" => typeof(List<Seccion>),
                        _ => throw new Exception("Tabla no reconocida")
                    };

                    var lista = JsonConvert.DeserializeObject(resultado.DatosJson, tipoLista);
                    DataTable dataTable = ConvertirListaADataTable(lista);
                    dataGridViewTabla.DataSource = dataTable;
                }

                MostrarDetallesEjecucion(resultado.DetalleEjecucion);
                ActualizarEstadoCliente($"Búsqueda en {_tablaSeleccionada} completada");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar resultados: {ex.Message}", "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private DataTable ConvertirListaADataTable(object lista)
        {
            DataTable dataTable = new DataTable();

            Type tipoElemento = lista.GetType().GetGenericArguments()[0];

            foreach (var prop in tipoElemento.GetProperties())
            {
                dataTable.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            }

            foreach (var item in (System.Collections.IEnumerable)lista)
            {
                DataRow row = dataTable.NewRow();
                foreach (var prop in tipoElemento.GetProperties())
                {
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                }
                dataTable.Rows.Add(row);
            }

            return dataTable;
        }

        private void ProcesarResultado(Resultado resultado)
        {
            if (resultado.Exitoso)
            {
                ActualizarEstadoCliente("Operación exitosa: " + resultado.Mensaje);
                MostrarDetallesEjecucion(resultado.DetalleEjecucion);
            }
            else
            {
                ActualizarEstadoCliente("Operación fallida");
                MessageBox.Show("Error: " + resultado.Mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
            dataGridViewTabla.DataSource = null;
            TxtClase.Text = "";
            TxtMetodo.Text = "";
            TxtParams.Text = "";
            TxtTipos.Text = "";
        }

        private void Menu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (_servidorIniciado)
            {
                _servidor.Detener();
            }
        }
    }
        #endregion

    public enum ModoFormulario
    {
        Insertar,
        Buscar
    }
}
