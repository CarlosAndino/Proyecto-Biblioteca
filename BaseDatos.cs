using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Biblioteca
{
    public class BaseDatos
    {

       readonly string cadena = @"Data Source=DESKTOP-6CORFUF\SQLEXPRESS; Initial Catalog=Proyecto_Biblioteca; Integrated Security=true";

        public bool ValidarUsuario(string codigo, string clave)
        {
            bool EsUsuarioValido = false;

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT 1 FROM USUARIOS ");
                consultaSQL.Append(" WHERE CODIGO = @codigo AND CLAVE = @Clave ");

                using(SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using(SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Clave", SqlDbType.NVarChar, 30).Value = clave;

                        EsUsuarioValido = Convert.ToBoolean(comando.ExecuteScalar());

                    }
                }

            }
            catch (Exception)
            {

               
            }

            return EsUsuarioValido;


        }

        public DataTable CargarCategorias()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT * FROM CATEGORIAS ");
                
                using(SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return tabla;
        }

        public DataTable CargarEstado()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT * FROM ESTADO ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {

                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {

                
            }
            return tabla;
        }

        public bool InsertarLibro(string codigo, string descripcion, int idCategoria, int idEstado,string nombre, int existencia)
        {

            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" INSERT INTO LIBROS ");
                consultaSQL.Append(" VALUES (@Codigo, @Descripcion, @IdCategoria, @IdEstado, @Nombre, @Existencia ); ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {

                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = descripcion;
                        comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;
                        comando.Parameters.Add("@IdEstado", SqlDbType.Int).Value = idEstado;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = nombre;
                        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

       public DataTable ListarLibros()
        {
            DataTable tabla = new DataTable();
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" SELECT L.CODIGO, L.DESCRIPCION, C.DESCRIPCION CATEGORIA, E.DESCRIPCION ESTADO, L.NOMBRE, L.EXISTENCIAS FROM LIBROS L  ");
                consultaSQL.Append(" INNER JOIN CATEGORIAS C ON C.ID = L.IDCATEGORIA ");
                consultaSQL.Append(" INNER JOIN ESTADO E ON E.ID = L.IDESTADO ");
                using (SqlConnection _conexion = new SqlConnection(cadena))
                {
                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        SqlDataReader dr = comando.ExecuteReader();
                        tabla.Load(dr);
                    }
                }
            }
            catch (Exception)
            {


            }
            return tabla;



        }

        public bool EditarLibros(string codigo, string descripcion, int idCategoria, int idEstado, string nombre, int existencia)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" UPDATE LIBROS ");
                consultaSQL.Append(" SET DESCRIPCION = @Descripcion, IDCATEGORIA = @IdCategoria, IDESTADO = @IdEstado, NOMBRE = @Nombre, EXISTENCIAS =  @Existencia");
                consultaSQL.Append("  WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {

                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.Parameters.Add("@Descripcion", SqlDbType.NVarChar, 80).Value = descripcion;
                        comando.Parameters.Add("@IdCategoria", SqlDbType.Int).Value = idCategoria;
                        comando.Parameters.Add("@IdEstado", SqlDbType.Int).Value = idEstado;
                        comando.Parameters.Add("@Nombre", SqlDbType.NVarChar, 80).Value = nombre;
                        comando.Parameters.Add("@Existencia", SqlDbType.Int).Value = existencia;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

        public bool EliminarRegistroL(string codigo)
        {
            try
            {
                StringBuilder consultaSQL = new StringBuilder();
                consultaSQL.Append(" DELETE FROM LIBROS ");
                consultaSQL.Append("  WHERE CODIGO = @Codigo; ");

                using (SqlConnection _conexion = new SqlConnection(cadena))
                {

                    _conexion.Open();
                    using (SqlCommand comando = new SqlCommand(consultaSQL.ToString(), _conexion))
                    {
                        comando.CommandType = CommandType.Text;
                        comando.Parameters.Add("@Codigo", SqlDbType.NVarChar, 30).Value = codigo;
                        comando.ExecuteNonQuery();
                        return true;
                    }
                }
            }
            catch (Exception)
            {

                return false;
            }
        }

       


    }
}
