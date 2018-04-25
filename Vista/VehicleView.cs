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
        public VehicleView()
        {
            InitializeComponent();
            VehicleController vehicleController = new VehicleController();
            this.txbVendedor.Text = vehicleController.NombreVendedor;
            this.cbxTipoVehiculo.Items.AddRange(new object[] 
            {"Automovil","Motocicleta"});
            this.cbxLinea.Items.AddRange(new object[] { "Particular", "Comercial" });
            this.cbxCiudad.Items.AddRange(new object[] { "Medellín", "Bogotá", "Cali", "Pereira" });
        }
        private void Formulario_Load(object sender, EventArgs e)
        {
            //string ruta = Application.StartupPath + "\\recursos\\SanderoRS.jpg";
            //pictureBox1.ImageLocation = ruta;
        }
        private void btbSubirImagen_Click(object sender, EventArgs e)
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
                MessageBox.Show("La imágen no es valida " + ex);
            }
        }
        private void txbVendedor_TextChanged(object sender, EventArgs e)
        {
            //txbVendedor.Text = ???? 
            
        }
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            VehicleController formController = new VehicleController();

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

            vehiculo = cbxTipoVehiculo.Text;
            marca = txbMarca.Text;
            linea = cbxLinea.Text;
            modelo = txbModelo.Text;
            placa = txbPlaca.Text;
            kilometraje = txbKilometraje.Text;
            motor = txbMotor.Text;
            ciudad = cbxCiudad.Text;
            precio = txbPrecio.Text;
            descripcion = txbDescripcion.Text;
            url = txbUrl.Text;

            bool registroExitoso = formController.SetForm(vehiculo, marca, linea, modelo, placa, 
                kilometraje, motor, ciudad, precio, url, descripcion);
            if (registroExitoso)
            {
                MessageBox.Show(formController.Mensaje);
                this.Close();
            }
            else
            {
                Error = formController.Mensaje;
                
            }
        }
        private void txbPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            {
                if (e.KeyChar >= 48 && e.KeyChar <= 57 || e.KeyChar == 8 || e.KeyChar == 13)
                {
                    e.Handled = false;
                    if (e.KeyChar == 13 && (txbPrecio.Text.Trim() != ""))
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
                    if (e.KeyChar == 13 && (txbPrecio.Text.Trim() != ""))
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
                    if (e.KeyChar == 13 && (txbPrecio.Text.Trim() != ""))
                    {

                    }
                }
                else
                {
                    e.Handled = true;
                }
            }
        }
    }
}
