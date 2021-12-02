using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Configuration;
using System.Data.SqlClient;
namespace CapaDeDatos
{
    public class DataBase
    {
        private static SqlConnection conexion;
        public DataBase()
        {

            SqlConnection conexion = new SqlConnection(ConfigurationManager.ConnectionStrings["cadenaDeConexion"].ConnectionString);
        }

        public void AbrirConexion()
        {
            if (conexion.State == ConnectionState.Closed) conexion.Open();
        }

        public void CerrarConexion()
        {
            if (conexion.State == ConnectionState.Open) conexion.Close();
        }

        public DataTable EjecutarStoredProcedureDeListado(string nombreDeSP, SqlParameter[] parametrosDeSP)
        {
            DataTable resultado = new DataTable();
            var command = new SqlCommand(nombreDeSP, conexion)
            {
                CommandType = CommandType.StoredProcedure
            };
            command.Parameters.AddRange(parametrosDeSP);
            var dataAdapter = new SqlDataAdapter(command);
            dataAdapter.Fill(resultado);
            return resultado;
        }

        public string EjecutarStoredProcedure(string nombreDeSP, SqlParameter[] parametrosDeSP)
        {
            var resultado = string.Empty;
            var command = new SqlCommand(nombreDeSP, conexion);
            command.CommandType = CommandType.StoredProcedure;
            command.Parameters.AddRange(parametrosDeSP);

            AbrirConexion();
            var a = command.ExecuteReader();
            while (a.Read())
            {
                resultado = a[0].ToString();
            }
            CerrarConexion();
            return resultado;
        }


    }
}

