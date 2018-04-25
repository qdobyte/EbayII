using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Controller
{
    public class VehicleController
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
        public string Descripcion { get; set; }
        public string Url { get; set; }
        public string Mensaje { get; set; }
        public string NombreVendedor { get; set; }
        #endregion
        VehicleModel VehicleModel = null;
        public VehicleController()
        {
            VehicleModel = new VehicleModel();
            this.NombreVendedor = this.GetNombreVendedor();
        }
        public bool SetForm(string vehiculo, string marca, string linea, string modelo, string placa,
            string kilometraje, string motor, string ciudad, string precio,string url, string descripcion)
        {
            bool registroExitoso = VehicleModel.SetForm(vehiculo, marca, linea, modelo, placa, kilometraje, motor, ciudad, precio, url, descripcion);
            if (registroExitoso)
            {
                Mensaje = "Registro Exitoso";
                return true;
            }
            else
            {
                this.Mensaje = VehicleModel.Mensaje;
                return false;
            }
            
        }
        private string GetNombreVendedor()
        {
            LoginModel loginModel = new LoginModel();
            return loginModel.Nombre;
        }
    }
}
