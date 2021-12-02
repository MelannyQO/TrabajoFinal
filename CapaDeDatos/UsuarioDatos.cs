using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using CapaDeEntidades;

namespace CapaDeDatos
{
    public class UsuarioDatos
    {
        public string nombre { get; set; }
        public string apellido { get; set; }
        public string tipoDocumento { get; set; }
        public string nDocumento { get; set; }
        public string fechaNacimiento { get; set; }
        public string genero { get; set; }
        public string correo { get; set; }
        public string contrasenia { get; set; }

        #region ADO .NET
        public DataBase cBD = new DataBase();
        public DataTable ListarUsuarios()
        {
            return cBD.EjecutarStoredProcedureDeListado("SP_ListarUsuarios", new SqlParameter[0]);
        }

        public string InsertarUsuario(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            var parametos = new[]
            {
                new SqlParameter("@NOMBRE",nombre),
                new SqlParameter("@APELLIDO",apellido),
                new SqlParameter("@TIPO_DOC",tipoDocumento),
                new SqlParameter("@NUM_DOCUMENTO",nDocumento),
                new SqlParameter("@FECHA_NACIMIENTO",fechaNacimiento),
                new SqlParameter("@GENERO",genero),
                new SqlParameter("@EMAIL",correo)
            };
            return cBD.EjecutarStoredProcedure("SP_InsertarUsuario", parametos);
        }

        public string ActualizarUsuario(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            var parametos = new[]
            {
                new SqlParameter("@NOMBRE",nombre),
                new SqlParameter("@APELLIDO",apellido),
                new SqlParameter("@TIPO_DOC",tipoDocumento),
                new SqlParameter("@NUM_DOCUMENTO",nDocumento),
                new SqlParameter("@FECHA_NACIMIENTO",fechaNacimiento),
                new SqlParameter("@GENERO",genero),
                new SqlParameter("@EMAIL",correo)
            };
            return cBD.EjecutarStoredProcedure("SP_ActualizarUsuario", parametos);
        }

        public string EliminarUsuario(string nDocumento)
        {
            var parametros = new[]
            {
                new SqlParameter("@NUM_DOCUMENTO", nDocumento)
            };

            return cBD.EjecutarStoredProcedure("SP_EliminarUsuario", parametros);
        }
      
        #endregion

        #region Entity Framework
        public USUARIO UsuarioDeEntidad = new USUARIO();
        
        public bool InsertarUsuarioEF(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            return  UsuarioDeEntidad.InsertarUsuarioEF(nombre,apellido,tipoDocumento,nDocumento,fechaNacimiento,genero,correo);
        }
        
        public bool ActualizarUsuarioEF(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            return  UsuarioDeEntidad.ActualizarUsuarioEF(nombre,apellido,tipoDocumento,nDocumento,fechaNacimiento,genero,correo);
        }

        public bool EliminarUsuarioEF(string nDocumento)
        {
            return UsuarioDeEntidad.EliminarUsuarioEF(nDocumento);
        }

        public List<USUARIO> ListarUsuariosEF()
        {
            return UsuarioDeEntidad.ListarUsuariosEF();
        }

        #endregion
    }

}



