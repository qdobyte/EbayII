using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vista
{
    public partial class HomeView : System.Windows.Forms.Form
    {
        public HomeView()
        {
            InitializeComponent();
        }

        private void HomeView_Load(object sender, EventArgs e)
        {
            //string ruta = Application.StartupPath + "\\recursos\\SanderoRS.jpeg";
            //pictureBox1.ImageLocation = ruta;
        }

        private void btnVender_Click(object sender, EventArgs e)
        {
            VehicleView formulario = new VehicleView();
            formulario.Show();
        }
      
    }
}
