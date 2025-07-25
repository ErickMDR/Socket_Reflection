using Socket_Reflection.Entidades;
using Socket_Reflection.WebSocket;
using System;
using System.Data;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace Socket_Reflection
{
    public partial class Menu : Form
    {
        private readonly Server _servidor;
        private bool _servidorIniciado = false;
        private string _tablaSeleccionada;

        public Menu()
        {
            InitializeComponent();
            _servidor = new Server();

            _servidor.ResultadoRecibido += Servidor_ResultadoRecibido;
        }

        #region Métodos auxiliares

        private void Servidor_ResultadoRecibido(Resultado resultado)
        {
            if (InvokeRequired)
            {
                Invoke(new Action<Resultado>(Servidor_ResultadoRecibido), resultado);
                return;
            }

            ProcesarResultado(resultado); 
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
                }

                MostrarDetallesEjecucion(resultado.DetalleEjecucion);
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
                MostrarDetallesEjecucion(resultado.DetalleEjecucion);
            }
            else
            {
                MessageBox.Show("Error: " + resultado.Mensaje, "Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimpiarCampos()
        {
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
}
