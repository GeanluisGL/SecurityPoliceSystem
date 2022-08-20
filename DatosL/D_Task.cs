using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using EntityL;
using System.Data;


namespace DatosL
{
    public class D_Task
    {


        SqlConnection conectar = new SqlConnection(ConfigurationManager.ConnectionStrings["conn"].ConnectionString);

        public SqlConnection AbrirConexion()
        {
            if (conectar.State == ConnectionState.Closed)
                conectar.Open();
            return conectar;
        }
        public SqlConnection CerrarConexion()
        {
            if (conectar.State == ConnectionState.Open)
                conectar.Close();
            return conectar;
        }

        public List<E_Task> ListarViajes(string buscar)
        {
            SqlDataReader leerR;
            SqlCommand cmd = new SqlCommand("readVIAJES", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerR = cmd.ExecuteReader();

            List<E_Task> list = new List<E_Task>();
            while (leerR.Read())
            {
                list.Add(new E_Task
                {
                    ID = leerR.GetInt32(0),
                    ID_CHOFER = leerR.GetString(1),
                    ID_BUS = leerR.GetString(2),
                    ID_RUTA = leerR.GetString(3),

                });
            }
            conectar.Close();
            leerR.Close();
            return list;
        }

        public void insertT(E_Task e_Task)
        {
            SqlCommand cmd = new SqlCommand("regviaje", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@ID_CHOFER", e_Task.CHOFER);
            cmd.Parameters.AddWithValue("@ID_BUS", e_Task.ID_BUS);
            cmd.Parameters.AddWithValue("@ID_RUTA", e_Task.RUTA);

            cmd.ExecuteNonQuery();
            CerrarConexion();

        }

        public void updateT(E_Task e_Task)
        {

            SqlCommand cmd = new SqlCommand("updateVIAJE", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@ID", e_Task.ID);
            cmd.Parameters.AddWithValue("@ID_CHOFER", e_Task.ID_CHOFER);
            cmd.Parameters.AddWithValue("@ID_BUS", e_Task.ID_BUS);
            cmd.Parameters.AddWithValue("@ID_RUTA", e_Task.ID_RUTA);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }


        public void DeleteT(E_Task e_Task)
        {

            SqlCommand cmd = new SqlCommand("deletViaje", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@ID", e_Task.ID);

            cmd.ExecuteNonQuery();
            CerrarConexion();

        }

        public DataTable Showlist()
        {
            SqlDataReader leer;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "Select * From vwDatosViajes";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            dataTable.Load(leer);
            conectar.Close();
            return dataTable;
        }

        public DataTable ChoferCom() 
        {
            SqlDataAdapter da = new SqlDataAdapter("ShowChofer", conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable BusCom()
        {
            SqlDataAdapter da = new SqlDataAdapter("ShowBus", conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


        public DataTable RutaCom()
        {
            SqlDataAdapter da = new SqlDataAdapter("ShowRuta", conectar);
            da.SelectCommand.CommandType = CommandType.StoredProcedure;
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }


    }
}
