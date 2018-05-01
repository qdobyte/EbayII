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
        public string UserName { get; set; }
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
            VehicleView vehicleView = new VehicleView(this, this.UserName);
            vehicleView.Show();
            vehicleView = null;
            this.Hide();
        }

        public void Reload() {
            this.Show();
            //Recargue en la base de datos
        }
    }
}
