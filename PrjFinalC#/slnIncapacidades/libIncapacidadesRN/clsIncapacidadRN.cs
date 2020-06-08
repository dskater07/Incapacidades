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
    public class clsIncapacidadRN
    {
        #region "Atributos"
        private string strNum_incap;
        private int intIdEmpleado;
        private int intIdVehiculo;
        private int intIdIncapInicial;
        private int intIdTipoIncapciad;
        private DateTime? dtFechaInicial;
        private DateTime? dtFechaFinal;
        private double dblIBC;
        private string strObservaciones;                                          
        private DateTime? dtFechaUpdate;
        private int intDiaCobrar;
        private int intDiasProrroga;
        private string strError;
        private int intRpta;
        private string strNombreApp;
        private SqlParameter[] objDatosIncapacidad;
        private clsConexionBd objConex;
        private clsLlenarGrids objLlenaGrids;
        private DataSet dsDatos;
        GridView gvVehiculo;


        #endregion

        #region "Constructor"
        public clsIncapacidadRN() { 

            strNum_incap = string.Empty;
            intIdEmpleado = -1;
            intIdVehiculo = -1;
            intIdIncapInicial = -1;
            intIdTipoIncapciad = -1;
            dtFechaInicial = null;
            dtFechaFinal =null;            
            dblIBC = -1;
            strObservaciones = string.Empty;
            dtFechaUpdate = null;
            intDiaCobrar = -1;
            intDiasProrroga = -1;
            strError = string.Empty;

            strNombreApp = string.Empty;



        }
        #endregion

        #region "Propiedades"
        public string Num_incap {set => strNum_incap = value; }
        public int IdEmpleado {set => intIdEmpleado = value; }
        public int IdVehiculo {set => intIdVehiculo = value; }
        public int IdIncapInicial {set => intIdIncapInicial = value; }
        public int IdTipoIncapciad {set => intIdTipoIncapciad = value; }
        public DateTime? FechaInicial {set => dtFechaInicial = value; }
        public DateTime? FechaFinal {set => dtFechaFinal = value; }
        public double IBC {set => dblIBC = value; }
        public string Observaciones {set => strObservaciones = value; }
        public DateTime? FechaUpdate {set => dtFechaUpdate = value; }
        public int DiaCobrar {set => intDiaCobrar = value; }
        public int DiasProrroga {set => intDiasProrroga = value; }
        public string Error { get => strError;}
        public int Rpta { get => intRpta; }

        #endregion


        #region "Métodos Privados"
        private bool validar()
        {





            return true;
        }

        #endregion
        #region "Métodos Públicos"

        public bool crearIncapacidad()
        {
            try
            {
                if (!validar())
                {
                    return false;
                }
                objConex = new clsConexionBd(strNombreApp);







                return true;
                
            }
            catch (Exception ex)
            {

                throw ex;
            }

        }



        #endregion
    }
}
