using CineTEC.Vistas;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CineTEC
{
    internal class FlujoSistema : ApplicationContext
    {
        public FlujoSistema() {
            
            try
            {
                Splash splash = new Splash();
                splash.ShowDialog();
                try
                {
                    Dashboard dashboard = new Dashboard();
                    dashboard.ShowDialog();
                }
                catch (Exception)
                {
                    throw;
                }
            }
            catch (Exception)
            {
                Console.Write("Error al cargar el Splash");
            }

        }
        /*public FlujoPrograma()
        {
            try
            {
                Splash splashito = new Splash();
                splashito.ShowDialog();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            Dashboard frm = new Dashboard();
            frm.ShowDialog();


        }*/
    }
}
