using libConexionBd;
using libLlenarGrids;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;

namespace libIncapacidadesRN
{
    public class clsEmpleadoRN
    {
        #region "Atributos"
        string strNum_incap;
        int intIdEmpleado;
        int intIdVehiculo;
        int idIncapInicial;
        int idTipoIncapciad;
        DateTime dtFechaInicial;
        DateTime dtFechaFinal;
        double dblIBC;
        string strObservaciones;
        DateTime dtFechaUpdate;
        int intDiaCobrar;
        int intDiasProrroga;
        private SqlParameter[] objDatosMatricula;
        private clsConexionBd objConex;
        private clsLlenarGrids objLlenaGrids;
        private DataSet dsDatos;
        GridView gvVehiculo;

        #endregion

        #region "Constructor"
        public clsEmpleadoRN() { 
        strNum_incap = string.Empty;
        }
        #endregion

        #region Parámetros
        public string StrNum_incap { get => strNum_incap; set => strNum_incap = value; }
        public int IntIdEmpleado { get => intIdEmpleado; set => intIdEmpleado = value; }
        public int IntIdVehiculo { get => intIdVehiculo; set => intIdVehiculo = value; }
        public int IdIncapInicial { get => idIncapInicial; set => idIncapInicial = value; }
        public int IdTipoIncapciad { get => idTipoIncapciad; set => idTipoIncapciad = value; }
        public DateTime DtFechaInicial { get => dtFechaInicial; set => dtFechaInicial = value; }
        public DateTime DtFechaFinal { get => dtFechaFinal; set => dtFechaFinal = value; }
        public double DblIBC { get => dblIBC; set => dblIBC = value; }
        public string StrObservaciones { get => strObservaciones; set => strObservaciones = value; }
        public DateTime DtFechaUpdate { get => dtFechaUpdate; set => dtFechaUpdate = value; }
        public int IntDiaCobrar { get => intDiaCobrar; set => intDiaCobrar = value; }
        public int IntDiasProrroga { get => intDiasProrroga; set => intDiasProrroga = value; }


        #endregion


        #region "Métodos Privados"


        #endregion
        #region "Métodos Públicos"





        #endregion
    }
}
