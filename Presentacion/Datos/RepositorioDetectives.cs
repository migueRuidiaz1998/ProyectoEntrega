using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace Datos
{
    public class RepositorioDetectives
    {
        SqlConnection cm = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        public DataTable ListarDetectives()
        {
            SqlCommand cmd = new SqlCommand("listardetectives", cm);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }
        

        public DataTable BuscarDetective(Detective obj)
        {
            SqlCommand cmd = new SqlCommand("buscardetective", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombres", obj.Nombres);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }


        public string Mantenimientodedetective(Detective obj)
        {
            string accion = " ";
            SqlCommand cmd = new SqlCommand("mantenimientodetectives", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@identificacion", obj.Identificacion);
            cmd.Parameters.AddWithValue("@nombres", obj.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", obj.Apellidos);
            cmd.Parameters.AddWithValue("@experiencia", obj.AñosDeExperiencia);
            cmd.Parameters.AddWithValue("@tipocaso", obj.TipoCaso);

            cmd.Parameters.Add("@accion", SqlDbType.VarChar, 50).Value = obj.accion;
            cmd.Parameters["@accion"].Direction = ParameterDirection.InputOutput;
            if (cm.State == ConnectionState.Open) cm.Close();
            cm.Open();
            cmd.ExecuteNonQuery();
            accion = cmd.Parameters["@accion"].Value.ToString();
            cm.Close();
            return accion;



        }






    }
}
