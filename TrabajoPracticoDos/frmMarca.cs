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
    public partial class frmMarca : Form
    {
        private List<Marca> listaMarcas;
        private DataGridView dgvMarcas;

        public frmMarca()
        {
            InitializeComponent();
        }

        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void cargar() {

            MarcaNegocio negocio = new MarcaNegocio();

            try
            {

                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
          
                dgvMarcas.Columns["Id"].Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }   

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Marca seleccionado = (Marca)dgvMarcas.CurrentRow.DataBoundItem;
            MarcaNegocio negocio = new MarcaNegocio();
            try
            {
            DialogResult respuesta = MessageBox.Show("¿Seguro que desea eliminar la marca " + seleccionado.Descripcion + "?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (respuesta==DialogResult.Yes)
                {
                    negocio.eliminarLogico(seleccionado.Id);
                    cargar();
                }
               
              }

            catch (Exception ex)
            {
            MessageBox.Show(ex.ToString());

            }
        }
    }
}