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
    public partial class Form : System.Windows.Forms.Form
    {
        public Form()
        {
            InitializeComponent();
            this.cbxTipoVehiculo.Items.AddRange(new object[] 
            {"Automovil","Motocicleta"});
            //if (cbxTipoVehiculo.Text = "Automovil")
            //{

            //}
            this.cbxLinea.Items.AddRange(new object[] { "Particular", "Comercial" });
            this.cbxCiudad.Items.AddRange(new object[] { "Medellín", "Bogotá", "Cali", "Pereira" });
        }

        private void Formulario_Load(object sender, EventArgs e)
        {
            //string ruta = Application.StartupPath + "\\recursos\\SanderoRS.jpg";
            //pictureBox1.ImageLocation = ruta;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void lblEncabezado_Click(object sender, EventArgs e)
        {

        }

        private void btbSubirImagen_Click(object sender, EventArgs e)
        {
            try
            {

                string url;
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    url = openFileDialog1.FileName;
                    pictureBox1.Image = Image.FromFile(url);
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

        private void cbxTipoVehiculo_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void btnPublicar_Click(object sender, EventArgs e)
        {
            
        }

        private void txbDescripcion_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbPrecio_TextChanged(object sender, EventArgs e)
        {

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

        private void txbModelo_TextChanged(object sender, EventArgs e)
        {

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

        private void txbPlaca_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
    }
}
