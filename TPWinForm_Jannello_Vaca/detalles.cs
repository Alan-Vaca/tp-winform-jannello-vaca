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
using dominio;

namespace TPWinForm_Jannello_Vaca
{
    public partial class detalles : Form
    {
        public bool Modificando { get; set; }
        public int StartItemMarca;
        public int StartItemCategoria;
        public detalles(Articulo art)
        {
            InitializeComponent();
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar("");
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listar("");
            comboBoxCategoria.DataSource = categorias;
            comboBoxCategoria.ValueMember = "Id";
            comboBoxCategoria.DisplayMember = "Descripcion";
            comboBoxMarca.DataSource = marcas;
            comboBoxMarca.ValueMember = "Id";
            comboBoxMarca.DisplayMember = "Descripcion";
            Modificando = false;
            textBoxIdDetalles.Text = art.Id.ToString();
            textBoxCodDetalles.Text = art.CodigoArticulo;
            textBoxDescripcionDetalles.Text = art.Descripcion;
            textBoxNombreDetalles.Text = art.Nombre;
            textBoxPrecioDetalles.Text = art.Precio.ToString();
            textBoxURLImagen.Text = art.URLimagen;
            imagen(art.URLimagen);
            comboBoxMarca.SelectedValue = art.Marca.Id;
            StartItemMarca = art.Marca.Id; // esto lo guardo para usarlo en el Cancelar
            comboBoxCategoria.SelectedValue = art.Categoria.Id;
            StartItemCategoria = art.Categoria.Id; // acá también
        }
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

        private void buttonEliminar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            int codigo = int.Parse(textBoxIdDetalles.Text);
            artNegocio.eliminar(codigo);
            MessageBox.Show("¡Eliminado con éxito!");
            Close();
        }

        private void buttonModificar_Click(object sender, EventArgs e)
        {
            if (!Modificando)
            {
                buttonModificar.Text = "Guardar";
                buttonCancelar.Visible = true;
                comboBoxCategoria.Enabled = true;
                textBoxCodDetalles.Enabled = true;
                textBoxDescripcionDetalles.Enabled = true;
                comboBoxMarca.Enabled = true;
                textBoxNombreDetalles.Enabled = true;
                textBoxPrecioDetalles.Enabled = true;
                textBoxURLImagen.Enabled = true;
            }
            else
            {
                ArticuloNegocio negocioArt = new ArticuloNegocio();
                Articulo art = new Articulo();
                buttonModificar.Text = "Modificar";
                buttonCancelar.Visible = false;
                buttonCancelar.Visible = false;
                comboBoxMarca.Enabled = false;
                textBoxCodDetalles.Enabled = false;
                textBoxDescripcionDetalles.Enabled = false;
                comboBoxCategoria.Enabled = false;
                textBoxNombreDetalles.Enabled = false;
                textBoxPrecioDetalles.Enabled = false;
                textBoxURLImagen.Enabled = false;
                StartItemMarca = (int)comboBoxMarca.SelectedValue;
                StartItemCategoria = (int)comboBoxCategoria.SelectedValue;
                art.Nombre = textBoxNombreDetalles.Text;
                art.CodigoArticulo = textBoxCodDetalles.Text;
                art.Descripcion = textBoxDescripcionDetalles.Text;
                art.URLimagen = textBoxURLImagen.Text;
                art.Marca = (Marca)comboBoxMarca.SelectedItem;
                art.Categoria = (Categoria)comboBoxCategoria.SelectedItem;
                art.Precio = decimal.Parse(textBoxPrecioDetalles.Text);
                art.Id = int.Parse(textBoxIdDetalles.Text);
                negocioArt.modificar(art);
                imagen(art.URLimagen);
            }
            Modificando = !Modificando;
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            buttonModificar.Text = "Modificar";
            buttonCancelar.Visible = false;
            comboBoxCategoria.Enabled = false;
            textBoxCodDetalles.Enabled = false;
            textBoxDescripcionDetalles.Enabled = false;
            comboBoxMarca.Enabled = false;
            textBoxNombreDetalles.Enabled = false;
            textBoxPrecioDetalles.Enabled = false;
            textBoxURLImagen.Enabled = false;
            textBoxCodDetalles.Undo();
            textBoxCodDetalles.ClearUndo();
            textBoxDescripcionDetalles.Undo();
            textBoxDescripcionDetalles.ClearUndo();
            textBoxNombreDetalles.Undo();
            textBoxNombreDetalles.ClearUndo();
            textBoxPrecioDetalles.Undo();
            textBoxPrecioDetalles.ClearUndo();
            textBoxURLImagen.Undo();
            textBoxURLImagen.ClearUndo();
            comboBoxCategoria.SelectedValue = StartItemCategoria;
            comboBoxMarca.SelectedValue = StartItemMarca;
        }

        private void buttonCerrar_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
