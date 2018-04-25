using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class LoginController
    {
        #region attributes
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Error { get; set; }

        #endregion

        LoginModel loginModel = null;
        public LoginController()
        {
            loginModel = new LoginModel();
        }
        public bool GetLogin(string usuario, string contrasena)
        {
            bool consultaExitosa = loginModel.GetLogin(usuario, contrasena);
            if (consultaExitosa)
            {
                this.Nombre = loginModel.Nombre;
                return true;
            }
            else
            {
               this.Error = loginModel.Error;
                return false;
            }

        }

    }
}
