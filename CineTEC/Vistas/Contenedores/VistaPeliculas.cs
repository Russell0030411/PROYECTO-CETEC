using CineTEC.Vistas.Modales;
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
    public partial class VistaPeliculas : Form
    {
        public VistaPeliculas()
        {
            InitializeComponent();
        }

        private void btnConsultarAsientos1_Click(object sender, EventArgs e)
        {
            ReservarPeliculaUno f = new ReservarPeliculaUno();
            f.ShowDialog();
        }

        private void btnConsultarAsientos2_Click(object sender, EventArgs e)
        {
            ReservarPeliculaDos f = new ReservarPeliculaDos();
            f.ShowDialog();
        }

        private void btnConsultarAsientos3_Click(object sender, EventArgs e)
        {
            ReservarPeliculaTres f = new ReservarPeliculaTres();
            f.ShowDialog();
        }
    }
}
