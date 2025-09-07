using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TrabajoPracticoDos
{
    public partial class frmArticulo : Form
    {
        private List<Articulo> listaArticulo;

        public frmArticulo()
        {
            
            InitializeComponent();
        }

        private void frmArticulo_Load(object sender, EventArgs e)
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            listaArticulo = artNegocio.listar();
            dgvArticulo.DataSource = listaArticulo;
            cargarImagen(listaArticulo[0].ImagenUrl);
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargarImagen(string imagen)
        {

            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception ex)
            {

                pbxArticulo.Load("https://png.pngtree.com/png-vector/20221125/ourmid/pngtree-illustration-of-a-flat-vector-icon-set-featuring-a-camera-symbol-and-a-placeholder-image-icon-vector-png-image_40968740.jpg");
            }
        }
    }
}
