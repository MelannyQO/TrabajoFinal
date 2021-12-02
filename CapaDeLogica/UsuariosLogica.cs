using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CapaDeEntidades;
using CapaDeDatos;

namespace CapaDeLogica
{
    public class UsuarioLogica
    {
        public UsuarioDatos Usuario = new UsuarioDatos();

        #region ADO .NET
        public DataTable ListarUsuarios()
        {
            return Usuario.ListarUsuarios();
        }

        public string InsertarUsuario(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            return Usuario.InsertarUsuario(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);
        }

        public string ActualizarUsuario(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            return Usuario.ActualizarUsuario(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);
        }

        public string EliminarUsuario(string nDocumento)
        {
            return Usuario.EliminarUsuario(nDocumento);
        }

        #endregion

        #region Entity Framework

        public bool InsertarUsuarioEF(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            return Usuario.InsertarUsuarioEF(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);
        }

        public bool ActualizarUsuarioEF(string nombre, string apellido, string tipoDocumento, string nDocumento, string fechaNacimiento, string genero, string correo)
        {
            return Usuario.ActualizarUsuarioEF(nombre, apellido, tipoDocumento, nDocumento, fechaNacimiento, genero, correo);
        }
        
        public bool EliminarUsuarioEf(string nDocumento)
        {
            return Usuario.EliminarUsuarioEF(nDocumento);
        }

        public List<USUARIO> ListarUsuariosEF()
        {
            return Usuario.ListarUsuariosEF();
        }

        #endregion



    }
}


