using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Socket_Reflection.Forms
{
    public partial class FormConfirmarEliminacion : Form
    {
        public bool Confirmado { get; private set; }

        public FormConfirmarEliminacion()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            Confirmado = true;
            DialogResult = DialogResult.OK;
            Close();
        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            Confirmado = false;
            DialogResult = DialogResult.Cancel;
            Close();

        }
    }
}
