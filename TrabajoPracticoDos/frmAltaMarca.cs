using Dominio;
using Negocio;
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
    public partial class frmAltaMarca : Form
    {
        public Marca marca { get; }

        public frmAltaMarca()
        {
            InitializeComponent();
        }

        public frmAltaMarca(Marca marca)
        {
            InitializeComponent();
            this.marca = marca;
            Text = "Modificar Marca";
            txtMarca.Text = marca.Descripcion;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtMarca.Text))
            {
                MessageBox.Show("El campo Marca es obligatorio para una marca.", "Campo obligatorio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtMarca.Focus();
                return;
            }

            Marca nueva = new Marca();
            MarcaNegocio negocio = new MarcaNegocio();

            try

            {
                if (marca!=null&& marca.Id != 0)
                {
                    marca.Descripcion = txtMarca.Text;
                    negocio.modificar(marca);
                    MessageBox.Show("Modificado exitosamente");
                    Close();
                    return;
                }
                else
                {
                Marca marca = new Marca();
                nueva.Descripcion = txtMarca.Text;
                negocio.agregar(nueva);
                MessageBox.Show("Agregado exitosamente");
                Close();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAltaMarca_Load(object sender, EventArgs e)
        {

        }
    }
    
}
