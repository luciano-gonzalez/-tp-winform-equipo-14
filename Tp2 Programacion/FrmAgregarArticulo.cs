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
    public partial class FrmAgregarArticulo : Form
    {
        public FrmAgregarArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Articulo articulo = new Articulo(); 
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();
            try
            {
                articulo._codArticulo = txtCodigo.Text;
                articulo._nombre = txtNombre.Text;
                articulo._descripcion = txtDescripcion.Text;
                articulo._precio = float.Parse(txtPrecio.Text);
                articulo._marca = (Marca)cboMarca.SelectedItem;
                articulo._categoria = (Categoria)cboCategoria.SelectedItem;

                articulosNegocio.Agregar(articulo);
                MessageBox.Show("Agregado exitosamente");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }

        private void FrmAgregarArticulo_Load(object sender, EventArgs e)
        {
            ArticulosNegocio articulosNegocio = new ArticulosNegocio();

            try
            {
                cboMarca.DataSource = articulosNegocio.listarMarcas();
                cboCategoria.DataSource = articulosNegocio.listarCategorias();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }
        }
    }
}
