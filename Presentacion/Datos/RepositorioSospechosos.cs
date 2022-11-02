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
    public class RepositorioSospechosos
    {
        SqlConnection cm = new SqlConnection(ConfigurationManager.ConnectionStrings["sql"].ConnectionString);


        public DataTable ListarSospechosos()
        {
            SqlCommand cmd = new SqlCommand("listarsospechosos", cm);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;


        }


        public DataTable BuscarSospechoso(Sospechoso obj)
        {
            SqlCommand cmd = new SqlCommand("buscarsospechoso", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@nombres", obj.Nombres);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;

        }



        public string Mantenimientodesospechoso(Sospechoso obj)
        {
            string accion = " ";
            SqlCommand cmd = new SqlCommand("mantenimientosospechosos", cm);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@identificacion", obj.Identificacion);
            cmd.Parameters.AddWithValue("@nombres", obj.Nombres);
            cmd.Parameters.AddWithValue("@apellidos", obj.Apellidos);
            cmd.Parameters.AddWithValue("@alias", obj.Alias);
            cmd.Parameters.AddWithValue("@edad", obj.Edad);
            
            cmd.Parameters.AddWithValue("@noVIvienda", obj.NoVivienda);
            cmd.Parameters.AddWithValue("@localidad", obj.Localidad);
            cmd.Parameters.AddWithValue("@ciudad", obj.Ciudad);
            cmd.Parameters.AddWithValue("@departamento", obj.Departamento);
            cmd.Parameters.AddWithValue("@pais", obj.Pais);

            cmd.Parameters.AddWithValue("@descripcion", obj.Descripcion);
            

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
