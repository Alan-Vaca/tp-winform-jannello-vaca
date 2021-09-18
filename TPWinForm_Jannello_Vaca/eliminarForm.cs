using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;

namespace TPWinForm_Jannello_Vaca
{
    public partial class eliminarForm : Form
    {
        public eliminarForm()
        {
            InitializeComponent();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            int codigo = int.Parse(textBoxID.Text);
            if (artNegocio.existeEnLaDb(codigo))
            {
                artNegocio.eliminar(codigo);
                MessageBox.Show("¡Eliminado con éxito!");
                Close();
            }
            else
            {
                MessageBox.Show("Ese producto no existe en la DB");
            }

        }

    }
}
