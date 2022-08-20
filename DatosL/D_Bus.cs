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
    public class D_Bus
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

        public List<E_Bus> ListarBus(string buscar)
        {
            SqlDataReader leerR;
            SqlCommand cmd = new SqlCommand("readBus", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerR = cmd.ExecuteReader();

            List<E_Bus> list = new List<E_Bus>();
            while (leerR.Read())
            {
                list.Add(new E_Bus
                {
                    PLACA = leerR.GetString(0),
                    MARCA = leerR.GetString(1),
                    MODELO = leerR.GetString(2),
                    COLOR = leerR.GetString(3),
                    YIAR  = leerR.GetString(4),


                });
            }
            conectar.Close();
            leerR.Close();
            return list;
        }

        public void insertB(E_Bus e_Bus)
        {
            SqlCommand cmd = new SqlCommand("regBus", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@PLACA", e_Bus.PLACA);
            cmd.Parameters.AddWithValue("@MARCA", e_Bus.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", e_Bus.MODELO);
            cmd.Parameters.AddWithValue("@COLOR", e_Bus.COLOR);
            cmd.Parameters.AddWithValue("@YIAR", e_Bus.YIAR);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void updateB(E_Bus e_Bus)
        {
            SqlCommand cmd = new SqlCommand("updateBus", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@PLACA", e_Bus.PLACA);
            cmd.Parameters.AddWithValue("@MARCA", e_Bus.MARCA);
            cmd.Parameters.AddWithValue("@MODELO", e_Bus.MODELO);
            cmd.Parameters.AddWithValue("@COLOR", e_Bus.COLOR);
            cmd.Parameters.AddWithValue("@YIAR", e_Bus.YIAR);


            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public void deleteB(E_Bus e_Bus)
        {
            SqlCommand cmd = new SqlCommand("deletBus", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@PLACA", e_Bus.PLACA);

            cmd.ExecuteNonQuery();
            conectar.Close();
        }

        public DataTable Showlist()
        {
            SqlDataReader leer;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "Select * From vwDatosBus";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            dataTable.Load(leer);
            conectar.Close();
            return dataTable;
        }
    }
}
