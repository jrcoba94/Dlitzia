using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data;
using System.Data.SqlClient;
using PizzeriaDll.BO;
using PizzeriaDll.DAO;

namespace PizzeriaDll.DAO
{
    public class PizzeriaDAO
    {
        protected SqlConnection conn;
        ConecctionDAO ConnectionDAO = new ConecctionDAO();
        public PizzeriaDAO()
        {
            conn = ConnectionDAO.EstablecerConexion();
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
        public int Save(PizzeriaBO obj)
        {
            string insert = "INSERT INTO Pizzeria(Nombre,RFC,Direccion,Telefono) " +
                "VALUES(@Nombre,@RFC,@Direccion,@Telefono)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@RFC", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));

            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@RFC"].Value = obj.RFC;
            cmd.Parameters["@Direccion"].Value = obj.Direccion;
            cmd.Parameters["@Telefono"].Value = obj.Telefono;
            return EjecutarSQL(cmd);
        }
        public int Delete(PizzeriaBO obj)
        {
            string delete = "DELETE FROM Pizzeria WHERE IDPizzeria = @IdPizzeria";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@IdPizzeria", SqlDbType.Int));
            cmd.Parameters["@IdPizzeria"].Value = obj.IdPizzeria;
            return EjecutarSQL(cmd);
        }
        public DataTable Select()
        {
            try
            {
                string qlistado = "SELECT * FROM Pizzeria";
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
    }
}