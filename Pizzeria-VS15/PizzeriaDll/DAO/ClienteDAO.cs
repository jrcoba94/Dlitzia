using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using PizzeriaDll.BO;
using System.Data.SqlClient;
using System.Data;

namespace PizzeriaDll.DAO
{
    public class ClienteDAO
    {
        protected SqlConnection conn;
        ConecctionDAO  conexion = new ConecctionDAO();
        public ClienteDAO()
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
        public int Save(ClienteBO obj)
        {
            string insert = "INSERT INTO Cliente(Nombre,Telefono,Direccion) " +
                "VALUES(@Nombre,@Telefono,@Direccion)";
            SqlCommand cmd = new SqlCommand(insert, conn);
            cmd.Parameters.Add(new SqlParameter("@Nombre", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Telefono", SqlDbType.VarChar));
            cmd.Parameters.Add(new SqlParameter("@Direccion", SqlDbType.VarChar));

            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@Telefono"].Value = obj.Telefono;
            cmd.Parameters["@Direccion"].Value = obj.Direccion;
            return EjecutarSQL(cmd);
        }
        public int Delete(ClienteBO obj)
        {
            string delete = "DELETE FROM Cliente WHERE IDCLIENTE = @IdCliente";
            SqlCommand cmd = new SqlCommand(delete, conn);
            cmd.Parameters.Add(new SqlParameter("@IdCliente", SqlDbType.Int));
            cmd.Parameters["@IdCliente"].Value = obj.IdCliente;
            return EjecutarSQL(cmd);
        }
        public DataTable Select()
        {
            try
            {
                string qlistado = "SELECT * FROM Cliente";
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