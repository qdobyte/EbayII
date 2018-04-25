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
        #endregion

        ConexionSQL conexionSQL = null;
        public LoginModel()
        {
            conexionSQL = new ConexionSQL();
        }
        public bool GetLogin(string usuario, string contrasena)
        {
            bool consultaExitosa = conexionSQL.GetLogin(usuario, contrasena);
            if (consultaExitosa)
            {
                if (conexionSQL.data.Rows.Count > 0)
                {
                    foreach (DataRow row in conexionSQL.data.Rows)
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
                this.Error = conexionSQL.ErrorMessage;
                return false;
            }
        }
    }

}
