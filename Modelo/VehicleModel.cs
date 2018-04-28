using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace Model
{
    public class VehicleModel
    {
        #region attributes
        public string Vehiculo { get; set; }
        public string Marca { get; set; }
        public string Linea { get; set; }
        public string Modelo { get; set; }
        public string Placa { get; set; }
        public string Kilometraje { get; set; }
        public string Motor { get; set; }
        public string Ciudad { get; set; }
        public string Precio { get; set; }
        public string Url { get; set; }
        public string Mensaje { get; set; }
        public int Id_Usuario { get; set; }

        ConexionSQL conexionSQL = null;
        private SqlCommand sqlCommand;
        #endregion
        #region Constructor
        public VehicleModel()
        {
            conexionSQL = new ConexionSQL();
            this.sqlCommand = new SqlCommand();
        }
        #endregion
        #region  Create Vehicle
        public bool CreateVehicle(string vehiculo, string marca, string linea, string modelo, string placa,
            string kilometraje, string motor, string ciudad, string precio, string url, string descripcion, int id_usuario)
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
            sqlCommand.Parameters.AddWithValue("@Id_Usuario", id_usuario);

            bool registroExitoso = conexionSQL.ExecuteStoreProcedure(sqlCommand);

            if (registroExitoso)
            {
                Mensaje = "Registro Exitoso";
                return true;
            }
            else
            {
                Mensaje = conexionSQL.ErrorMessage;
                return false;
            }
        }
        #endregion
    }

}
