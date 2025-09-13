using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
using Dominio;

namespace TrabajoPracticoDos
{
    public partial class frmTipoAlta : Form
    {
        public frmTipoAlta()
        {
            InitializeComponent();
        }

        private void btnAltaArticulo_Click(object sender, EventArgs e)
        {
            frmAltaArticulo nuevoArticulo = new frmAltaArticulo();
            nuevoArticulo.ShowDialog();
        }

        private void btnAltaMarca_Click(object sender, EventArgs e)
        {
            frmMarca nuevaMarca = new frmMarca();
            nuevaMarca.ShowDialog();
        }

        private void btnAltaCategoria_Click(object sender, EventArgs e)
        {
            frmCategoria nuevaCategoria = new frmCategoria();
            nuevaCategoria.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
