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
        }
    }
}
