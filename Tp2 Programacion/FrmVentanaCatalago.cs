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
            ConexionTabla datos = new ConexionTabla();
            DgbArticulos.DataSource = datos.listar();
        }

        private void agregarArticuloToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DgbArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

    }
}
