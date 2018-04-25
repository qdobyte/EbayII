using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class ConexionSQL
    {
        SqlConnection sqlConnection = null;
        SqlCommand sqlCommand = null;
        SqlDataReader sqlDataReader = null;
        string connectionString = null;
        public DataTable data = null;
        public string ErrorMessage = null;

        #region Constructor
        public ConexionSQL()
        {
            this.connectionString = "Data Source=QDOBYTE\\MYSQL; Initial Catalog=MyEbay; Integrated Security = true";
            this.sqlConnection = new SqlConnection(this.connectionString);
            this.sqlCommand = new SqlCommand(); //Insert into, Delete, Update, Select   

            data = new DataTable();
        }
        #endregion

        #region methods

        private void OpenConnection()
        {
            this.sqlConnection.Open();
        }

        private void CloseConnection()
        {
            this.sqlConnection.Close();
        }
        
        #region methods Validar Usuario
        public bool GetLogin(string usuario, string contrasena)
        {
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "validarUsuario";
            sqlCommand.Parameters.AddWithValue("@usuario", usuario);
            sqlCommand.Parameters.AddWithValue("@contrasena", contrasena);
            sqlCommand.Connection = sqlConnection;
            try
            {
                this.OpenConnection();
                sqlDataReader = sqlCommand.ExecuteReader();
                this.data.Load(sqlDataReader);
                this.CloseConnection();
            }
            catch (Exception Ex)
            {
                this.ErrorMessage = Ex.Message;
                return false;
            }

            return true;
        }
        #endregion

        #region methods Registrar Vehiculo
        public bool SetForm(string vehiculo, string marca, string linea, string modelo, string placa,
            string kilometraje, string motor, string ciudad, string precio, string url, string descripcion)
        {
            sqlCommand.CommandType = CommandType.StoredProcedure;
            sqlCommand.CommandText = "IngresarVehiculos";
            sqlCommand.Parameters.AddWithValue("@Vehiculo", vehiculo);
            sqlCommand.Parameters.AddWithValue("@Marca", marca);
            sqlCommand.Parameters.AddWithValue("@Linea", linea);
            sqlCommand.Parameters.AddWithValue("@Modelo", marca);
            sqlCommand.Parameters.AddWithValue("@Placa", placa);
            sqlCommand.Parameters.AddWithValue("@Kilometraje", kilometraje);
            sqlCommand.Parameters.AddWithValue("@Motor", motor);
            sqlCommand.Parameters.AddWithValue("@Ciudad", ciudad);
            sqlCommand.Parameters.AddWithValue("@Precio", precio);
            sqlCommand.Parameters.AddWithValue("@Url", url);
            sqlCommand.Parameters.AddWithValue("@Descripcion", descripcion);
            sqlCommand.Connection = sqlConnection;
            try
            {
                this.OpenConnection();
                sqlDataReader = sqlCommand.ExecuteReader();
                this.data.Load(sqlDataReader);
                this.CloseConnection();
            }
            catch (Exception Ex)
            {
                this.ErrorMessage = Ex.Message;
                return false;
            }

            return true;
        }
        #endregion

        #endregion
    }
}
