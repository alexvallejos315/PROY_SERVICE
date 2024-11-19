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
    /// Descripción breve de Eventos
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Eventos : System.Web.Services.WebService
    {


        [WebMethod]
        public DataSet GETALL_EVENTOS()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("GETALL_EVENTOS", cn);
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
        public DataSet EVENTOS_UP(int Id,string tipoDato,string tipoPago, string NroParticipantes,
            string FechaDeEvento,string TipoDeVestimenta,string Departamento,
            string Distrito,string ServiciosAdicionales, string DuracionPromedioDeEvento)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("UP_EVENTOS", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@Id", Id);
            cmd.Parameters.AddWithValue("@TipoDeEvento", tipoDato);
            cmd.Parameters.AddWithValue("@TipoDeEvento", tipoDato);
            cmd.Parameters.AddWithValue("@TipoDePago", tipoPago);
            cmd.Parameters.AddWithValue("@NroParticipantes", NroParticipantes);
            cmd.Parameters.AddWithValue("@FechaDeEvento", FechaDeEvento);
            cmd.Parameters.AddWithValue("@TipoDeVestimenta", TipoDeVestimenta);
            cmd.Parameters.AddWithValue("@Departamento", Departamento);
            cmd.Parameters.AddWithValue("@Distrito", Distrito);
            cmd.Parameters.AddWithValue("@ServiciosAdicionales", ServiciosAdicionales);
            cmd.Parameters.AddWithValue("@DuracionPromedioDeEvento", DuracionPromedioDeEvento);



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
        public DataSet EVENTOS_DEL()
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("EVENTOS_DEL", cn);
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
        public DataSet EVENTOS_IN(string tipoDato, string tipoPago, string NroParticipantes,
            string FechaDeEvento, string TipoDeVestimenta, string Departamento,
            string Distrito, string ServiciosAdicionales, string DuracionPromedioDeEvento)
        {

            SqlConnection cn = new SqlConnection();
            cn.ConnectionString = "Data Source=DVALLEJOS\\MSSQLSERVER01;Initial Catalog=DB_ACCESS;Persist Security Info=true;Integrated Security=SSPI";

            SqlCommand cmd = new SqlCommand("EVENTOS_IN", cn);

            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TipoDeEvento", tipoDato);
            cmd.Parameters.AddWithValue("@TipoDePago", tipoPago);
            cmd.Parameters.AddWithValue("@NroParticipantes", NroParticipantes);
            cmd.Parameters.AddWithValue("@FechaDeEvento", FechaDeEvento);
            cmd.Parameters.AddWithValue("@TipoDeVestimenta", TipoDeVestimenta);
            cmd.Parameters.AddWithValue("@Departamento", Departamento);
            cmd.Parameters.AddWithValue("@Distrito", Distrito);
            cmd.Parameters.AddWithValue("@ServiciosAdicionales", ServiciosAdicionales);
            cmd.Parameters.AddWithValue("@DuracionPromedioDeEvento", DuracionPromedioDeEvento);
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
