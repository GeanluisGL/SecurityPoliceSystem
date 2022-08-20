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
    public class D_Chofer
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

        public List<E_Chofer> ListarChofer(string buscar)
        {
            SqlDataReader leerR;
            SqlCommand cmd = new SqlCommand("readChof", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@Buscar", buscar);
            leerR = cmd.ExecuteReader();

            List<E_Chofer> list = new List<E_Chofer>();
            while (leerR.Read())
            {
                list.Add(new E_Chofer
                {
                    ID = leerR.GetInt32(0),
                    Nombre = leerR.GetString(1),
                    Apellido = leerR.GetString(2),
                    BirthFecha = leerR.GetString(3),
                    Cedula = leerR.GetString(4),


                });
            }
            conectar.Close();
            leerR.Close();
            return list;
        }


        public void insertC(E_Chofer e_Chofer)
        {
            SqlCommand cmd = new SqlCommand("regChof", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            AbrirConexion();

            cmd.Parameters.AddWithValue("@Nombre", e_Chofer.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Chofer.Apellido);
            cmd.Parameters.AddWithValue("@BirthFecha", e_Chofer.BirthFecha);
            cmd.Parameters.AddWithValue("@Cedula", e_Chofer.Cedula);

            cmd.ExecuteNonQuery();
            CerrarConexion();
        }

        public void updateC(E_Chofer e_Chofer)
        {
            SqlCommand cmd = new SqlCommand("updateChof", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID", e_Chofer.ID);
            cmd.Parameters.AddWithValue("@Nombre", e_Chofer.Nombre);
            cmd.Parameters.AddWithValue("@APELLIDO", e_Chofer.Apellido);
            cmd.Parameters.AddWithValue("@BirthFecha", e_Chofer.BirthFecha);
            cmd.Parameters.AddWithValue("@Cedula", e_Chofer.Cedula);

            cmd.ExecuteNonQuery();
            conectar.Close();
        }


        public DataTable Showlist()
        {
            SqlDataReader leer;
            DataTable dataTable = new DataTable();
            SqlCommand cmd = new SqlCommand();

            cmd.Connection = AbrirConexion();
            cmd.CommandText = "Select * From CHOFER";
            cmd.CommandType = CommandType.Text;
            leer = cmd.ExecuteReader();
            dataTable.Load(leer);
            conectar.Close();
            return dataTable;
        }

        public void delete(E_Chofer e_Chofer)
        {
            SqlCommand cmd = new SqlCommand("deletChof", conectar);
            cmd.CommandType = CommandType.StoredProcedure;
            conectar.Open();

            cmd.Parameters.AddWithValue("@ID", e_Chofer.ID);

            cmd.ExecuteNonQuery();
            conectar.Close();
        }

    }
}
