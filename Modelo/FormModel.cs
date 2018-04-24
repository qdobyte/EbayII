using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class FormModel
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
        public string Error { get; set; }

        ConexionSQL conexionSQL = null;
        #endregion
        public FormModel()
        {
            conexionSQL = new ConexionSQL();
        }
        public bool SetForm(string vehiculo, string marca, string linea, string modelo, string placa,
            string kilometraje, string motor, string ciudad, string precio)
        {
            bool registroExitoso = fgdfrtgrttgretet
        }
    }

}
