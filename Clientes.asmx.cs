using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace ServiciosSOAP
{
    /// <summary>
    /// Descripción breve de Clientes
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Clientes : System.Web.Services.WebService
    {

        [WebMethod]
        public DataSet ObtenerDatosUsuarios()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("LISTA_USUARIOS", cn);
            cmd.CommandType = CommandType.StoredProcedure;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                cn.Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de usuarios: " + ex.Message);
            }
            finally
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


            return ds;
        }


        [WebMethod]

        public DataSet ObtenerUsuarioPorID(string id)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("USUARIO_ID", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", id);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                cn.Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de usuarios: " + ex.Message);
            }
            finally
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


            return ds;
        }
        

        [WebMethod]

        public DataSet ActualizarUsuarioPorID(string id,string apellidoPaterno,string apellidoMaterno,string nombres,string correo )
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("ACTUALIZAR_USUARIOS", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@ID", id);
            cmd.Parameters.AddWithValue("@ApellidoPaterno", apellidoPaterno);
            cmd.Parameters.AddWithValue("@ApellidoMaterno", apellidoMaterno);
            cmd.Parameters.AddWithValue("@Nombres", nombres);
            cmd.Parameters.AddWithValue("@Correo", correo);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                cn.Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de usuarios: " + ex.Message);
            }
            finally
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


            return ds;
        }



        [WebMethod]

        public DataSet EliminarUsuarioPorID(string id, string apellidoPaterno, string apellidoMaterno, string nombres, string correo)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("DEL_USUARIO", cn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.AddWithValue("@Id", id);
          
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();

            try
            {
                cn.Open();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                throw new Exception("Error al obtener datos de usuarios: " + ex.Message);
            }
            finally
            {

                if (cn.State == ConnectionState.Open)
                {
                    cn.Close();
                }
            }


            return ds;
        }






    }
}
