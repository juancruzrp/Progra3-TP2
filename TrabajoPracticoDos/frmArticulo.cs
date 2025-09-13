using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Negocio;


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
            cargar();
            
        }

        private void dgvArticulo_SelectionChanged(object sender, EventArgs e)
        {
            Articulo seleccionado = (Articulo)dgvArticulo.CurrentRow.DataBoundItem;
            cargarImagen(seleccionado.ImagenUrl);
        }

        private void cargar()
        {
            ArticuloNegocio artNegocio = new ArticuloNegocio();
            try
            {
                listaArticulo = artNegocio.listar();
                dgvArticulo.DataSource = listaArticulo;
                dgvArticulo.Columns["ImagenUrl"].Visible = false;
                dgvArticulo.Columns["Id"].Visible = false;
                cargarImagen(listaArticulo[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cargarImagen(string imagen)
        {

            try
            {
                pbxArticulo.Load(imagen);

            }
            catch (Exception)
            {

                pbxArticulo.Load("https://png.pngtree.com/png-vector/20221125/ourmid/pngtree-illustration-of-a-flat-vector-icon-set-featuring-a-camera-symbol-and-a-placeholder-image-icon-vector-png-image_40968740.jpg");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmTipoAlta alta = new frmTipoAlta();
            alta.ShowDialog();
            cargar();
        }
    }
}
