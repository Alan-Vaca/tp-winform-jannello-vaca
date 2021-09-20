using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace TPWinForm_Jannello_Vaca
{
    public partial class formAgregar : Form
    {
        public formAgregar()
        {
            InitializeComponent();
        }

        private void formAgregar_Load(object sender, EventArgs e)
        {
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar("");
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listar("");
            comboBoxCategorias.DataSource = categorias;
            comboBoxMarca.DataSource = marcas;
            agregarBtn.Enabled = false;
        }

        private void ValidarFormulario(object sender, EventArgs e)
        {
            if (textBoxNombre.Text != "" && textBoxDescripcion.Text != "" && textBoxCodigo.Text != "")
            {
                agregarBtn.Enabled = true;
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Articulo art = new Articulo();
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                art.Marca = (Marca)comboBoxMarca.SelectedItem;
                art.Nombre = textBoxNombre.Text;
                art.Precio = numericUpDownPrecio.Value;
                art.Categoria = (Categoria)comboBoxCategorias.SelectedItem;
                art.URLimagen = textBoxImagen.Text;
                art.Descripcion = textBoxDescripcion.Text;
                art.CodigoArticulo = textBoxCodigo.Text;
                if (!artNegocio.chequearCodArticuloEnDb(art.CodigoArticulo))
                {
                    artNegocio.agregar(art);
                    MessageBox.Show("¡Agregado con éxito!");
                }
                else
                {
                    MessageBox.Show("Error! Ya existe un artículo con ese código en la DB");
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("¡Error! " + ex.ToString());
            }
        }
    }
}
