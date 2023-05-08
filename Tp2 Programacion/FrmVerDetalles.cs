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

namespace Tp2_Programacion
{
    public partial class FrmVerDetalles : Form
    {
        public Articulo articulo { get; set; }
        public FrmVerDetalles()
        {
            InitializeComponent();
        }

        public FrmVerDetalles(Articulo arti)
        {
            articulo = arti;
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmVerDetalles_Load(object sender, EventArgs e)
        {
            txtId.Text = articulo.ID.ToString();
            txtCodigo.Text = articulo._codArticulo;
            txtDescripcion.Text = articulo._descripcion;
            txtnombre.Text = articulo._nombre;
            txtCategoria.Text = articulo._categoria.ToString();
            txtMarca.Text = articulo._marca.ToString();
            txtPrecio.Text = articulo._precio.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
