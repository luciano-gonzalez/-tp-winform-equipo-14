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

        private List<Articulo> listaArticulos;
        private void FrmVentanaCatalago_Load(object sender, EventArgs e)
        {
            cargar();

        }

        private void cargar()
        {
            ArticulosNegocio datos = new ArticulosNegocio();

            listaArticulos = datos.listar(); ;
            DgbArticulos.DataSource = listaArticulos ;
            DgbArticulos.Columns["_codArticulo"].Visible = false;
            DgbArticulos.Columns["_descripcion"].Visible = false;
            DgbArticulos.Columns["_categoria"].Visible = false;
            DgbArticulos.Columns["_marca"].Visible = false;
            DgbArticulos.Columns["_precio"].Visible = false;
            Text = "Modificar Articulo";


        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAgregarArticulo ventana = new FrmAgregarArticulo();
            ventana.ShowDialog();
            cargar();
        }

        private void TsmModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)DgbArticulos.CurrentRow.DataBoundItem;
            FrmAgregarArticulo modificar = new FrmAgregarArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();

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
            cargar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            
        }

        private void txtfiltro_KeyPress(object sender, KeyPressEventArgs e) 
        {
            List<Articulo> listafiltrada;
            string filtro = txtfiltro.Text;
            if (filtro != " ")
            {
                //listafiltrada = listaArticulos.FindAll(x => x._nombre.ToUpper().Contains(txtfiltro.Text.ToUpper()));
                //listafiltrada = listaArticulos.FindAll(x => x._categoria._descripcion.ToUpper().Contains(txtfiltro.Text.ToUpper()));
                //listafiltrada = listaArticulos.FindAll(x => x._descripcion.ToUpper().Contains(txtfiltro.Text.ToUpper()));
                listafiltrada = listaArticulos.FindAll(x => x._marca._nombre.ToUpper().Contains(txtfiltro.Text.ToUpper()));

            }
            else
            {
                listafiltrada = listaArticulos;
            }


            DgbArticulos.DataSource = null;
            DgbArticulos.DataSource = listafiltrada;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void btnDetalles_Click(object sender, EventArgs e)
        {
            FrmVerDetalles ventanaDetalles = new FrmVerDetalles();
            ventanaDetalles.ShowDialog();
        }
    }
}
