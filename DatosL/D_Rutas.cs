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
    public class D_Rutas
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

            public List<E_Route> ListarRutas(string buscar)
            {
                SqlDataReader leerR;
                SqlCommand cmd = new SqlCommand("readRuta", conectar);
                cmd.CommandType = CommandType.StoredProcedure;
                conectar.Open();

                cmd.Parameters.AddWithValue("@Buscar", buscar);
                leerR = cmd.ExecuteReader();

                List<E_Route> list = new List<E_Route>();
                while (leerR.Read())
                {
                    list.Add(new E_Route
                    {
                        ID_Ruta = leerR.GetInt32(0),
                        RUTA = leerR.GetString(1),
                        Distance = leerR.GetString(2),

                    });
                }
                conectar.Close();
                leerR.Close();
                return list;
            }

        public void insertR(E_Route e_Route)
        {
            SqlCommand cmd = new SqlCommand("regRuta", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@Ruta", e_Route.RUTA);
            cmd.Parameters.AddWithValue("@Distance", e_Route.Distance);

            cmd.ExecuteNonQuery();
            CerrarConexion();

        }

        public void update(E_Route e_Route)
        {

            SqlCommand cmd = new SqlCommand("updateRuta", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("ID", e_Route.ID_Ruta);
            cmd.Parameters.AddWithValue("@Ruta", e_Route.RUTA);
            cmd.Parameters.AddWithValue("@Distance", e_Route.Distance);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }


        public void DeleteRoute(E_Route e_Route)
        {

            SqlCommand cmd = new SqlCommand("deletRuta", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("ID", e_Route.ID_Ruta);

            cmd.ExecuteNonQuery();
            CerrarConexion();

        }

        public DataTable Showlist()
        {
            SqlDataReader leer;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "Select * From vwDatosRuta";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            dataTable.Load(leer);
            conectar.Close();
            return dataTable;
        }


    }
}
