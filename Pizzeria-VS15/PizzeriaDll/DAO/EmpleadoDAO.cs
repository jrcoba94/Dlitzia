using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzeriaDll.BO;
using System.Data.SqlClient;
using System.Data;

namespace PizzeriaDll.DAO
{
    public class EmpleadoDAO
    {
        protected SqlConnection conn;
        ConecctionDAO conexion = new ConecctionDAO();
        public EmpleadoDAO()
        {
            conn = conexion.EstablecerConexion();
        }
        public int EjecutarSQL(SqlCommand cmd)
        {
            int resultado = 0;
            try
            {
                cmd.Connection.Open();
                resultado = cmd.ExecuteNonQuery();
                cmd.Connection.Close();
                return resultado;
            }
            catch
            {
                cmd.Connection.Close();
                return resultado;
            }
        }
        public int Save(EmpleadoBO obj)
        {
            string insert = "INSERT INTO Empleado(Usuario,Contrasenia,Nombre,Direccion,IdPizzeria) " +
                "VALUES(@Usuario,@Contrasenia,@Nombre,@Direccion,@IdPizzeria)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@IdPizzeria", SqlDbType.Int));

            cmd.Parameters["@Usuario"].Value = obj.Usuario;
            cmd.Parameters["@Contrasenia"].Value = obj.Contrasenia;
            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@Direccion"].Value = obj.Direccion;
            cmd.Parameters["@IdPizzeria"].Value = obj.IdPizzeria;
            return EjecutarSQL(cmd);
        }
        public DataTable Select()
        {
            try
            {
                string qlistado = "SELECT * FROM Empleado";
                SqlDataAdapter dalistado = new SqlDataAdapter(qlistado, conn);
                DataTable dtlistado = new DataTable();
                dalistado.Fill(dtlistado);
                return dtlistado;
            }
            catch
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
        public int Delete(EmpleadoBO obj)
        {
            string delete = "DELETE FROM Empleado WHERE IDEmpleado = @IdEmpleado";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@IdEmpleado", SqlDbType.Int));
            cmd.Parameters["@IdEmpleado"].Value = obj.IdEmpleado;
            return EjecutarSQL(cmd);
        }
        public bool Ingresar(EmpleadoBO obj)
        {
            try
            {
                string qlistado = "SELECT * FROM Empleado WHERE Usuario=@Usuario AND Contrasenia = @Contrasenia";
                SqlCommand cmd = new SqlCommand(qlistado,conn);
                cmd.Parameters.Add(new SqlParameter("@Usuario", SqlDbType.VarChar));
                cmd.Parameters.Add(new SqlParameter("@Contrasenia", SqlDbType.VarChar));

                cmd.Parameters["@Usuario"].Value = obj.Usuario;
                cmd.Parameters["@Contrasenia"].Value = obj.Contrasenia;
                conn.Open();
                SqlDataAdapter dalistado = new SqlDataAdapter(cmd);
                DataTable dtlistado = new DataTable();
                dalistado.Fill(dtlistado);
                conn.Close();
                return dtlistado.Rows.Count >0;
            }
            catch
            {
                conn.Close();
                return false;
            }
        }

    }
}