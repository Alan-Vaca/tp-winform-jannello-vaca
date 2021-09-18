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
    public partial class AppForm : Form
    {
        ArticuloNegocio negocio = new ArticuloNegocio();
        List<Articulo> fetchedArticulos = new List<Articulo>();


        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            reLoadTable();
            cbOrdernarPor.Items.Clear();
            cbOrdernarPor.Items.Add("Categoria");
            cbOrdernarPor.Items.Add("Codigo de articulo");
            cbOrdernarPor.Items.Add("Descripcion");
            cbOrdernarPor.Items.Add("Mas antiguo");
            cbOrdernarPor.Items.Add("Mas reciente");
            cbOrdernarPor.Items.Add("Marca");
            cbOrdernarPor.Items.Add("Nombre");
            cbOrdernarPor.Items.Add("Precio ascendente");
            cbOrdernarPor.Items.Add("Precio descendente");
            MarcaNegocio marcaNegocio = new MarcaNegocio();
            List<Marca> marcas = marcaNegocio.listar("");
            CategoriaNegocio categoriaNegocio = new CategoriaNegocio();
            List<Categoria> categorias = categoriaNegocio.listar("");
            Categoria auxC = new Categoria(-1, "Sin Categoria");
            categorias.Add(auxC);
            Marca auxM = new Marca(-1, "Sin Marca");
            marcas.Add(auxM);
            listaCategoria.DataSource = categorias;
            listaMarca.DataSource = marcas;

        }

        private void buttonAgregar_Click(object sender, EventArgs e)
        {
            formAgregar form = new formAgregar();
            form.ShowDialog();
            reLoadTable();
        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            eliminarForm form = new eliminarForm();
            form.ShowDialog();
            reLoadTable();
        }

        private void reLoadTable()
        {
            cbOrdernarPor.Text = "Categoria";
            fetchedArticulos = negocio.listar(" order by C.Descripcion asc");
            dgvTabla.DataSource = fetchedArticulos;

        }

        private void BtnSesion_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cbOrdernarPor_SelectionChangeCommitted(object sender, EventArgs e)
        {
            string opAux = cbOrdernarPor.Text;
            switch (opAux)
            {
                case "Categoria":
                    dgvTabla.DataSource = negocio.listar(" order by C.Descripcion asc");
                    break;
                case "Codigo de articulo":
                    dgvTabla.DataSource = negocio.listar(" order by A.Codigo asc");
                    break;
                case "Descripcion":
                    dgvTabla.DataSource = negocio.listar(" order by A.Descripcion asc");
                    break;
                case "Mas antiguo":
                    dgvTabla.DataSource = negocio.listar(" order by A.Id asc");
                    break;
                case "Mas reciente":
                    dgvTabla.DataSource = negocio.listar(" order by A.Id desc");
                    break;
                case "Marca":
                    dgvTabla.DataSource = negocio.listar(" order by M.Descripcion asc");
                    break;
                case "Nombre":
                    dgvTabla.DataSource = negocio.listar(" order by A.Nombre asc");
                    break;
                case "Precio ascendente":
                    dgvTabla.DataSource = negocio.listar(" order by A.Precio asc");
                    break;
                case "Precio descendente":
                    dgvTabla.DataSource = negocio.listar(" order by A.Precio desc");
                    break;
            }
        }

        private void BtnVerDetalle_Click(object sender, EventArgs e)
        {
            mostrarDetalle();
        }

        private void dgvTabla_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            mostrarDetalle();
        }
        public void mostrarDetalle()
        {
            Articulo art;
            art = (Articulo)dgvTabla.CurrentRow.DataBoundItem;
            detalles detalles = new detalles(art);
            detalles.ShowDialog();
            reLoadTable();
        }

        public void filtrarPorPrecio()
        {
            if (nudMin.Value == 0 && nudMax.Value == 0) {
                dgvTabla.DataSource = fetchedArticulos;
                return; // Si estan los dos vacíos no va a hacer nada
            }
            decimal max = nudMax.Value;
            decimal min = nudMin.Value;
            List<Articulo> articulos = fetchedArticulos;
            List<Articulo> filtrado = new List<Articulo>();
            foreach (Articulo articulo in articulos)
            {
                bool estaEnIntervalo = checkSiEstaEnIntervalo(max, min, articulo.Precio);
                if (estaEnIntervalo)
                    filtrado.Add(articulo);
            }
            dgvTabla.DataSource = filtrado;
        }
        public bool checkSiEstaEnIntervalo(decimal max, decimal min, decimal precio)
        {
            if (max != 0 && min != 0)
            {
                if (precio >= min && precio <= max)
                    return true;
                else return false;
            } else if (max != 0)
            {
                if (precio <= max)
                    return true;
                else return false;
            } else
            {
                if (precio >= min)
                    return true;
                else return false;
            }
        }

        private void nudMin_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorPrecio();
        }

        private void nudMax_ValueChanged(object sender, EventArgs e)
        {
            filtrarPorPrecio();
        }

        private void resetFiltroPrecio()
        {
            nudMax.Value = 0;
            nudMax.Value = 0;
        }

        private void buttonBuscar_Click(object sender, EventArgs e)
        {
            string valorABuscar = textBoxBuscador.Text;
            if (valorABuscar == null || valorABuscar == "")
                return;
            List<Articulo> artEncontrado = new List<Articulo>();
            foreach (Articulo articulo in fetchedArticulos)
            {
                if (articulo.CodigoArticulo.Contains(valorABuscar) || articulo.Nombre.Contains(valorABuscar) || articulo.Descripcion.Contains(valorABuscar))
                {
                    artEncontrado.Add(articulo);
                }
            }
            resetFiltroPrecio();
            dgvTabla.DataSource = artEncontrado;
            buttonCancelBusqueda.Visible = true;
        }

        private void buttonCancelBusqueda_Click(object sender, EventArgs e)
        {
            dgvTabla.DataSource = fetchedArticulos;
            buttonCancelBusqueda.Visible = false;
            textBoxBuscador.Text = null;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
