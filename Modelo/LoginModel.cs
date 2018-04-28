using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

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
        SqlCommand sqlCommand = null;
        #endregion

        ConexionSQL conexionSQL = null;
        public LoginModel()
        {
            conexionSQL = new ConexionSQL();
            this.sqlCommand = new SqlCommand();
        }
        public bool Login(string usuario, string contrasena)
        {
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "validarUsuario";
            sqlCommand.Parameters.AddWithValue("@usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@contrasena", contrasena);

            bool consultaExitosa = conexionSQL.ExecuteStoreProcedure(sqlCommand);
            sqlCommand = null;
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
