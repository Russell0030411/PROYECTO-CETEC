using CineTEC.Vistas.Contenedores;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTEC.Vistas
{
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
            VistaPeliculas f = new VistaPeliculas();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }

        private void Dashboard_FormClosed(object sender, FormClosedEventArgs e)
        {
            Environment.Exit(0);
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnCombos_Click(object sender, EventArgs e)
        {
            VistaCombos f = new VistaCombos();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnPeliculas_Click(object sender, EventArgs e)
        {
            VistaPeliculas f = new VistaPeliculas();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }

        private void btnSalas_Click(object sender, EventArgs e)
        {
            VistaSalas f = new VistaSalas();
            f.TopLevel = false;
            f.FormBorderStyle = FormBorderStyle.None;
            f.Dock = DockStyle.Fill;
            splitContainer1.Panel2.Controls.Clear();
            splitContainer1.Panel2.Controls.Add(f);
            f.Show();
        }
    }
}
