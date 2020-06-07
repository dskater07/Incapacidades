using System;
using System.Collections.Generic;
using System.Data;
using System.Web;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using libConexionBd;
using System.Web.UI.WebControls;
using libLlenarGrids;

namespace libIncapacidadesRN
{
   public class clsVehiculosRN
    {
        #region "Atributos"
        private string strPlaca;
        private int intNumeroInterno;
        private int intIdTipoVehiculo;
        private string strMotor;
        private string strModelo;
        private int intIdPropietario;
        private string strError;
        private int intRespuesta;
        private SqlParameter[] objDatosMatricula;
        private clsConexionBd objConex;
        private clsLlenarGrids objLlenaGrids;
        private DataSet dsDatos;
        GridView gvVehiculo;


        #endregion

        #region "Constructor"
        public clsVehiculosRN() {
            strPlaca = string.Empty;
            intNumeroInterno = -1;
            intIdTipoVehiculo = -1;
            strMotor = string.Empty;
            strModelo = string.Empty;
            intIdPropietario = -1;        
            strError = string.Empty;
            intRespuesta = -1; }
        #endregion

        #region "Propiedades"
        public string Placa { get => strPlaca; set => strPlaca = value; }
        public int NumeroInterno { get => intNumeroInterno; set => intNumeroInterno = value; }
        public int IdTipoVehiculo { get => intIdTipoVehiculo; set => intIdTipoVehiculo = value; }
        public string Motor { get => strMotor; set => strMotor = value; }
        public string Modelo { get => strModelo; set => strModelo = value; }
        public int IdPropietario { get => intIdPropietario; set => intIdPropietario = value; }
        public string Error { get => strError; set => strError = value; }
        public int Respuesta { get => intRespuesta; set => intRespuesta = value; }
        #endregion

        #region "Métodos Privados"

        #endregion

        #region "Métodos Públicos"

        #endregion
    }
}
