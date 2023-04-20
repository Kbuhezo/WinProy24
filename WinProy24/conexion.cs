using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinProy24
{
    public class conexion
    {
        private string cadena = "Data Source=LAPTOP-5DG5SOH2\\MSSQLSERVER01;Initial Catalog=BDFundamentos;Integrated Security=True";

        public List<Sedes> SedesLista()
        {
            List<Sedes> listasedes = new List<Sedes>();

            SqlConnection conn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand("dbo.sp_Lista_Sede", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);//, conn);
            da.Fill(tabla);

            foreach (DataRow row in tabla.Rows)
            {
                Sedes objsedes = new Sedes();
                objsedes.idsede = (int)row["idsede"];
                objsedes.nombresede = (string)row["nombresede"];
                listasedes.Add(objsedes);
            }
            return listasedes;
        }

        public List<curso> CursoListar()
        {
            List<curso> listacursos = new List<curso>();


            SqlConnection conn = new SqlConnection(cadena);
            SqlCommand cmd = new SqlCommand("dbo.sp_Lista_Cliente", conn);
            cmd.CommandType = CommandType.StoredProcedure;
            DataTable tabla = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);//, conn);
            da.Fill(tabla);

            //da.SelectCommand.CommandType = CommandType.Text;
            //DataSet ds = new DataSet();
            //da.Fill(ds, "cursos");

            foreach (DataRow row in tabla.Rows)
            {
                curso objcurso = new curso();
                objcurso.idcurso = (int)row["Idcurso"];
                objcurso.Nombre = (string)row["Nombre"];
                objcurso.Duracion = (int)row["Duracion"];
                objcurso.Descripcion = (string)row["Descripcion"];
                objcurso.idsede = (int)row["idsede"];
                listacursos.Add(objcurso);
            }

            //for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            //{
            //    curso objcurso = new curso();
            //    objcurso.Nombre = ds.Tables[0].Rows[i]["Nombre"].ToString();
            //    objcurso.Duracion = Convert.ToInt32(ds.Tables[0].Rows[i]["Duracion"].ToString());
            //    objcurso.Descripcion = ds.Tables[0].Rows[i]["Descripcion"].ToString();

            //    listacursos.Add(objcurso);
            //}
            //ds.Dispose();
            //ds.Dispose();

            return listacursos;
        }
        public int CursoInsertar(curso objcurso)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Insert into cursos(Nombre, Duracion, Descripcion) values (@Nombre, @Duracion, @Descripcion)", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Nombre", objcurso.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", objcurso.Duracion);
                cmd.Parameters.AddWithValue("Descripcion", objcurso.Descripcion);
                cmd.Parameters.AddWithValue("@Idsede", objcurso.Duracion);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch(Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public int CursoEditar(curso objcurso)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Update cursos set Nombre=@Nombre, Duracion=@Duracion, Descripcion=@Descripcion where Idcurso=@Idcurso", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@Idcurso", objcurso.idcurso);
                cmd.Parameters.AddWithValue("@Nombre", objcurso.Nombre);
                cmd.Parameters.AddWithValue("@Duracion", objcurso.Duracion);
                cmd.Parameters.AddWithValue("@Descripcion", objcurso.Descripcion);
                cmd.Parameters.AddWithValue("@Idsede", objcurso.Descripcion);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
        public int CursoEliminar(int idcurso)
        {
            try
            {
                SqlConnection conn = new SqlConnection(cadena);
                conn.Open();
                SqlCommand cmd = new SqlCommand("Delete from cursos where idcurso=@idcurso", conn);
                cmd.CommandType = CommandType.Text;
                cmd.Parameters.AddWithValue("@idcurso", idcurso);
                cmd.ExecuteNonQuery();
                conn.Close();
            }
            catch (Exception ex)
            {
                return 0;
            }
            return 1;
        }
    }
}
