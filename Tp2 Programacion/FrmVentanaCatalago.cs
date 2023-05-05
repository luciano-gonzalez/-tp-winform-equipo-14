using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tp2_Programacion
{
    public partial class FrmVentanaCatalago : Form
    {
        public FrmVentanaCatalago()
        {
            InitializeComponent();
        }

        private void FrmVentanaCatalago_Load(object sender, EventArgs e)
        {
            ArticulosNegocio datos = new ArticulosNegocio();
            DgbArticulos.DataSource = datos.listar();
            Text = "Modificar Articulo";
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo ventana = new FrmAgregarArticulo();
            ventana.ShowDialog();
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

      

        private void TsmModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgbArticulos.CurrentRow.DataBoundItem;
            FrmAgregarArticulo modificar = new FrmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
        }

        private void TsmEliminar_Click(object sender, EventArgs e)
        {
            ArticulosNegocio negocio = new ArticulosNegocio();
            Articulo seleccionado;
            try
            {
                DialogResult respuesta = MessageBox.Show("Desea eliminar el articulo definitivamente?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning );
                if (respuesta == DialogResult.Yes)
                {
                    seleccionado = (Articulo)DgbArticulos.CurrentRow.DataBoundItem;
                    negocio.Eliminar(seleccionado.ID);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
