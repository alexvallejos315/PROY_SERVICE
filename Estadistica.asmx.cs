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
    /// Descripción breve de Estadistica
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Estadistica : System.Web.Services.WebService
    {

        // Cuál es el cantidad de mayor tipo de pago?

        [WebMethod]
        public DataSet ESTADISTICA_1()
        {
            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("ESTADISTICA_1", cn);
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


        // Mostrar los distritos y fecha de evento que hayan realizado pago solo con efectivo

        [WebMethod]
        public DataSet ESTADISTICA_2()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("ESTADISTICA_2", cn);
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


        // LISTARME LOS TIPO DE EVENTOS y distrito DONDE HAYAN HABIDO MÁS DE 100 PARTICIPANTES

        [WebMethod]
        public DataSet ESTADISTICA_3()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("ESTADISTICA_3", cn);
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


        // ESTADISTICA_4

        [WebMethod]
        public DataSet ESTADISTICA_4()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("ESTADISTICA_4", cn);
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






    }
}
