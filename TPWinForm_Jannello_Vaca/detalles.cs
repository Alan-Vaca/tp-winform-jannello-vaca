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
    public partial class detalles : Form
    {
        public detalles()
        {
            InitializeComponent();
        }

        //Se cargan los datos solicitados al formulario de previsualizacion
        public void id(string id) { textBoxIdDetalles.Text = id; }
        public void cod(string cod) { textBoxCodDetalles.Text = cod; }
        public void nombre(string nombre) { textBoxNombreDetalles.Text = nombre; }
        public void descrip(string descrip) { textBoxDescripcionDetalles.Text = descrip; }
        public void marca(string marca) { textBoxMarcaDetalles.Text = marca; }
        public void categ(string categ) { textBoxCategoriaDetalles.Text = categ; }
        public void imagen(string img)
        {
            try
            {
                pictureBoxImg.Load(img);
            }
            catch
            {
                pictureBoxImg.Load("https://png.pngtree.com/png-vector/20190927/ourlarge/pngtree-red-cross-with-the-outline-coming-out-png-image_1761934.jpg");
            }
        }
        public void precio(string precio) { textBoxPrecioDetalles.Text = precio; }

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            int codigo = int.Parse(textBoxIdDetalles.Text);
            artNegocio.eliminar(codigo);
            MessageBox.Show("¡Eliminado con éxito!");
            Close();
        }

        private void textBoxIdDetalles_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
