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

        public frmMarca()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // frmMarca
            // 
            this.ClientSize = new System.Drawing.Size(330, 322);
            this.Name = "frmMarca";
            this.Load += new System.EventHandler(this.frmMarca_Load);
            this.ResumeLayout(false);

        }
        private void frmMarca_Load(object sender, EventArgs e)
        {
            cargarMarca();
        }

        private void cargarMarca()
        {
            MarcaNegocio negMarc = new MarcaNegocio(); // tu clase que contiene listar()
            try
            {
              MarcaNegocio negocio = new MarcaNegocio();
              //  dgvMarcas.datasource = negocio.listar();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
