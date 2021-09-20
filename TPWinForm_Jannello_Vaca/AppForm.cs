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

        public bool banderaFiltroC;
        public bool banderaFiltroM;
        ArticuloNegocio negocio = new ArticuloNegocio();
        List<Articulo> fetchedArticulos = new List<Articulo>();


        public AppForm()
        {
            InitializeComponent();
        }

        private void AppForm_Load(object sender, EventArgs e)
        {
            banderaFiltroC = false;
            banderaFiltroM = false;
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
            listaMarca.Text = "Sin Marca";
            listaCategoria.Text = "Sin Categoria";
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

        private void buttonCancelBusqueda_Click(object sender, EventArgs e)
        {
            buttonCancelBusqueda.Visible = false;
            textBoxBuscador.Text = null;
            ConsultaFiltroGeneral(sender, e);
        }

        public string FiltrarPorPrecio()
        {
            string filtrarPorPrecio = "";
            int minimo = int.Parse(nudMin.Value.ToString());
            int maximo = int.Parse(nudMax.Value.ToString());

            if(minimo != 0 && maximo != 0 || maximo > minimo)
            {
            filtrarPorPrecio = " PRECIO BETWEEN " + minimo.ToString() + " AND " + maximo.ToString();
            }
            else if(minimo != 0 && maximo == 0)
            {
                filtrarPorPrecio = " PRECIO >=" + minimo.ToString();
            }
            else
            {
                filtrarPorPrecio = " PRECIO >= 0";
            }
            return filtrarPorPrecio;
        }

        public string buttonBuscar_Click()
        {
            string resultadoBtnBuscar = "";
            string valorABuscar = textBoxBuscador.Text;
            if (valorABuscar != "")
            {
                resultadoBtnBuscar = " AND ( A.CODIGO LIKE '%" + valorABuscar + "%' OR A.NOMBRE LIKE '%" + valorABuscar + "%' OR A.DESCRIPCION LIKE '%" + valorABuscar + "%')";
                buttonCancelBusqueda.Visible = true;
            }
            return resultadoBtnBuscar;
        }

        public string filtrarPorMarcaYCategoria()
        {
            string marcaYCategoria = "";
                int selectMarca = listaMarca.SelectedIndex;
                int selectCategoria = listaCategoria.SelectedIndex;
                int cantMarca = listaMarca.Items.Count;
                int cantCat = listaCategoria.Items.Count;
                selectMarca++;
                selectCategoria++;
                 if (cantMarca != selectMarca && cantCat != selectCategoria)
                {
                marcaYCategoria = " AND M.Id=" + selectMarca + " and C.Id=" + selectCategoria;
                }
                else if(cantMarca != selectMarca && cantCat == selectCategoria)
                {
                marcaYCategoria = "AND M.Id=" + selectMarca;
                }
                else if(cantCat != selectCategoria && cantMarca == selectMarca)
                {
                marcaYCategoria = "AND C.Id=" + selectCategoria;
                }
            return marcaYCategoria;
        }

        public string cbOrdernarPor_SelectionChangeCommitted()
        {
            string opAux = cbOrdernarPor.Text;
            string opcion = "";
            switch (opAux)
            {
                case "Categoria":
                    opcion = " order by C.Descripcion asc";
                    break;
                case "Codigo de articulo":
                    opcion = " order by A.Codigo asc";
                    break;
                case "Descripcion":
                    opcion = " order by A.Descripcion asc";
                    break;
                case "Mas antiguo":
                    opcion = " order by A.Id asc";
                    break;
                case "Mas reciente":
                    opcion = " order by A.Id desc";
                    break;
                case "Marca":
                    opcion = " order by M.Descripcion asc";
                    break;
                case "Nombre":
                    opcion = " order by A.Nombre asc";
                    break;
                case "Precio ascendente":
                    opcion = " order by A.Precio asc";
                    break;
                case "Precio descendente":
                    opcion = " order by A.Precio desc";
                    break;
            }
            return opcion;
        }

        public void ConsultaFiltroGeneral(object sender, EventArgs e)
        {
            string condicionPrecio = FiltrarPorPrecio();
            string condicionBuscar = buttonBuscar_Click();
            string condicionMarcaYCategoria = filtrarPorMarcaYCategoria();
            string condicionOrdenar = cbOrdernarPor_SelectionChangeCommitted();

            dgvTabla.DataSource = negocio.listar(" WHERE" + condicionPrecio + condicionBuscar + condicionMarcaYCategoria + condicionOrdenar);
        }

    }
}
