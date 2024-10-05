using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTEC.Vistas.Contenedores
{
    public partial class VistaCombos : Form
    {
        public VistaCombos()
        {
            InitializeComponent();
        }

        private void btnComprar_Click(object sender, EventArgs e)
        {
            DialogResult resultado = MessageBox.Show("¿Está seguro de que desea realizar la compra?", "Confirmar compra", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("Compra realizada con éxito.");
            }
            else
            {
                MessageBox.Show("Compra cancelada.");
            }
        }
    }
}
