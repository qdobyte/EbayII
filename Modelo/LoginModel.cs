using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;


namespace Model
{
    public class LoginModel
    {
        #region attributes
        public string Nombre { get; set; }
        public string Correo { get; set; }
        public string Telefono { get; set; }
        public string Usuario { get; set; }
        public string Contrasena { get; set; }
        public string Error { get; set; }

        ConexionSQL ConexionSQL = null;
        #endregion
        public LoginModel()
        {
            ConexionSQL = new ConexionSQL();
        }
        public bool GetLogin(string usuario, string contrasena)
        {
            bool consultaExitosa = ConexionSQL.GetLogin(usuario, contrasena);
            if (consultaExitosa)
            {
                if (ConexionSQL.data.Rows.Count > 0)
                {
                    foreach (DataRow row in ConexionSQL.data.Rows)
                    {
                        this.Nombre = row["nombre"].ToString();
                    }
                    return true;
                }
                else
                {
                    this.Error = "Usuario o Contraseña incorrecta";
                    return false;
                }
            }
            else
            {
                this.Error = ConexionSQL.ErrorMessage;
                return false;
            }
        }
    }

}
