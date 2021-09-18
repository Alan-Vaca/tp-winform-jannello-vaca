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
            dgvTabla.DataSource = negocio.listar(" order by C.Id asc");

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
                    dgvTabla.DataSource = negocio.listar(" order by C.Id asc");
                    break;
                case "Codigo de articulo":
                    dgvTabla.DataSource = negocio.listar(" order by A.Id asc");
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
                    dgvTabla.DataSource = negocio.listar(" order by M.Id asc");
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
            Articulo art;
            art = (Articulo)dgvTabla.CurrentRow.DataBoundItem;
            detalles detalles = new detalles(art);
            detalles.ShowDialog();
            reLoadTable();
        }
    }
}
