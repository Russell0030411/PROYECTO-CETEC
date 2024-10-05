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
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            Timer tiempo = new Timer();
            tiempo.Interval = 3000;
            tiempo.Tick += new EventHandler(TiempoAgotado);
            tiempo.Start();
            for(int i=0; i < 100; i++)
            {
                progressBar1.Value = i;
                lbl_cargar.Text = progressBar1.Value.ToString() + "%";
            }
        }
        private void TiempoAgotado(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Cronometro_Tick(object sender, EventArgs e)
        {
            
        }
    }
}
