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
    public partial class Login : System.Windows.Forms.Form
    {
        public Login()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            LoginController loginController = null;
            string usuario = null;
            string contrasena = null;

            loginController = new LoginController();
            usuario = txbUsuarioByLogin.Text;
            contrasena = txbContrasenaByLogin.Text;

            bool consultaExitosa = loginController.GetLogin(usuario,contrasena);
            if (consultaExitosa)
            {
                this.Hide();
                HomeView homeView = new HomeView();
                homeView.Show();
                
            }
            else
            {
                lblError.Text = loginController.Error;
                txbUsuarioByLogin.Text = "";
                txbContrasenaByLogin.Text = "";
            }

        }
    
    }
}
