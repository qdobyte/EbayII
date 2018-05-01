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
        public Login login { get; set; }
        public HomeView(Login login)
        {
            InitializeComponent();
            this.login = login;
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

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.login = null;
            Login login = new Login();
            login.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
