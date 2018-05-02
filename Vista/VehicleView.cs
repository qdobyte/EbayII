using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controller;


namespace Vista
{
    public partial class VehicleView : System.Windows.Forms.Form
    {
        public string UserName { get; set; }
        public HomeView HomeView { get; set; }

        public VehicleView(HomeView HomeView, string userName)
        {
            InitializeComponent();
            VehicleController vehicleController = new VehicleController();
            this.HomeView = HomeView;
            this.UserName = userName;
            this.txtVendedor.Text = this.UserName;
        }
        private void btbSubirImagen_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    txbUrl.Text = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(openFileDialog1.FileName);
                }
            }
            catch (Exception ex)
            {
                MessageView messageView = new MessageView("La imágen no es valida " + ex);
                messageView.Show();
            }
        }
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            VehicleController vehicleController = new VehicleController();

            string vehiculo = null;
            string marca = null;
            string linea = null;
            string modelo = null;
            string placa = null;
            string kilometraje = null;
            string ciudad = null;
            string motor = null;
            string precio = null;
            string descripcion = null;
            string url = null;
            string Error = null;

            vehiculo = txtTipoVehiculo.Text;
            marca = txtMarca.Text;
            linea = txtLinea.Text;
            modelo = txtModelo.Text;
            placa = txtPlaca.Text;
            kilometraje = txtKilometraje.Text;
            motor = txtCilindraje.Text;
            ciudad = txtCiudad.Text;
            precio = txtPrecio.Text;
            descripcion = txtAccesorios.Text;
            url = txbUrl.Text;
            vehicleController.NombreVendedor = txtVendedor.Text;

            bool registroExitoso = vehicleController.SetForm(vehiculo, marca, linea, modelo, placa,
                kilometraje, motor, ciudad, precio, url, descripcion, 1);
            if (registroExitoso)
            {
                MessageView messageView = new MessageView(vehicleController.Mensaje);
                messageView.Show();
                this.CloseVehicleForm();
            }
            else
            {
                Error = vehicleController.Mensaje;
            }
        }
        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
                {
                    e.Handled = false;
                    if (e.KeyChar == 13 && (txtPrecio.Text.Trim() != ""))
                    {

                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void txbModelo_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
                {
                    e.Handled = false;
                    if (e.KeyChar == 13 && (txtPrecio.Text.Trim() != ""))
                    {

                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
        private void txbKilometraje_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
                {
                    e.Handled = false;
                    if (e.KeyChar == 13 && (txtPrecio.Text.Trim() != ""))
                    {

                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.CloseVehicleForm();
        }

        private void CloseVehicleForm () {
            this.Hide();
            this.HomeView.Reload();
        }
    }
}
