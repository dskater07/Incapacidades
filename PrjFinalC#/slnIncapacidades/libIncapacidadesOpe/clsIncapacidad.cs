using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libIncapacidadesOpe
{
    public class clsIncapacidad
    {
        #region "Atributos"
        private int id_Empleado;
        private int id_tipo_doc_Empleado;
        private int id_tipo_empleado;
        private int id_eps_Empleado;
        private int id_empresa;
        private string numero_documento;
        private string primer_nombre;
        private string segundo_nombre;
        private string primer_apellido;
        private string segundo_apellido;
        private byte es_usuario;
        private string direccion;
        private string telefono;
        private string correo_electronico;
        private DateTime fecha_creacion;
        private double salario;
        private string strError;
        private DataSet dsDatos;


    #endregion

    #region "Constructor"
    public clsIncapacidad(int id_Empleado, int id_tipo_doc_Empleado, int id_tipo_empleado, int id_eps_Empleado, int id_empresa, string numero_documento, string primer_nombre, string segundo_nombre, string primer_apellido, string segundo_apellido, byte es_usuario, string direccion, string telefono, string correo_electronico, DateTime fecha_creacion, double salario, string strError, DataSet dsDatos)
    {
        this.id_Empleado = -1;
        this.id_tipo_doc_Empleado = -1;
        this.id_tipo_empleado = -1;
        this.id_eps_Empleado = -1;
        this.id_empresa = id_empresa;
        this.numero_documento = numero_documento;
        this.primer_nombre = primer_nombre;
        this.segundo_nombre = segundo_nombre;
        this.primer_apellido = primer_apellido;
        this.segundo_apellido = segundo_apellido;
        this.es_usuario = es_usuario;
        this.direccion = direccion;
        this.telefono = telefono;
        this.correo_electronico = correo_electronico;
        this.fecha_creacion = fecha_creacion;
        this.salario = salario;
        this.strError = strError;
        this.dsDatos = dsDatos;
    }
        #endregion

        #region "Propiedades"
        #endregion

        #region "Métodos Privados"
        #endregion

        #region "Métodos Públicos"
        #endregion
    }
}
