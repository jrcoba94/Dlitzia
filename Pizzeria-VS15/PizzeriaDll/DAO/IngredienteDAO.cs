using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PizzeriaDll.BO;
using PizzeriaDll.DAO;

namespace PizzeriaDll.DAO
{
    public class IngredienteDAO
    {
        SqlConnection conn;
        ConecctionDAO conexion = new ConecctionDAO();

        public IngredienteDAO()
        {
            conn = conexion.EstablecerConexion();
        }

        public int Ejecutarsql(SqlCommand cmd)
        {
            int resultado = 0;

            try
            {
                cmd.Connection.Open();
                resultado = cmd.ExecuteNonQuery();
                cmd.Connection.Close();

                return resultado;
            }
            catch (Exception)
            {
                cmd.Connection.Close();
                return resultado;
            }
        }

        public DataSet devuelveIngrediente(IngredienteBO obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            SqlCommand cmd = new SqlCommand();
            DataSet dsIngrediente = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            if (obj.IdIngrediente > 0)
            {
                cadenaWhere = cadenaWhere + " IdIngrediente=@IdIngrediente and";
                cmd.Parameters.Add("@IdIngrediente", SqlDbType.Int);
                cmd.Parameters["@IdIngrediente"].Value = obj.IdIngrediente;
                edo = true;
            }
            if (obj.Nombre != null)
            {
                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = obj.Nombre;
                edo = true;
            }
            if (obj.Descripcion != null)
            {

                cadenaWhere = cadenaWhere + " Descripcion=@Descripcion and";
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters["@Descripcion"].Value = obj.Descripcion;
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            string sql = " SELECT * FROM Ingrediente " + cadenaWhere;
            cmd = new SqlCommand(sql, conn);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsIngrediente);
            return dsIngrediente;
        }

        public int CrearIngrediente(IngredienteBO obj)
        {
            string sql = "INSERT INTO Ingrediente(Nombre,Descripcion)" +
            "VALUES(@Nombre,@Descripcion)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);

            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@Descripcion"].Value = obj.Descripcion;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminaIngrediente(IngredienteBO obj)
        {
            string sql = "DELETE FROM Ingrediente WHERE IdIngrediente = @IdIngrediente";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@IdIngrediente", SqlDbType.Int);
            cmd.Parameters["@IdIngrediente"].Value = obj.IdIngrediente;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaIngrediente(IngredienteBO obj)
        {
            string sql = "UPDATE Ingrediente " +
                  "SET Nombre = @Nombre," +
                  "Descripcion = @Descripcion," +
                  " WHERE IdIngrediente = @IdIngrediente";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@IdIngrediente", SqlDbType.Int);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);

            cmd.Parameters["@IdIngrediente"].Value = obj.IdIngrediente;
            cmd.Parameters["@Medida"].Value = obj.Nombre;
            cmd.Parameters["@IdPizza"].Value = obj.Descripcion;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public DataTable DevuelveProductos()
        {
            try
            {
                string sql = "SELECT * FROM Ingrediente";
                SqlDataAdapter da = new SqlDataAdapter(sql, conn);
                DataTable dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch
            {
                DataTable dt = new DataTable();
                return dt;
            }
        }
    }
}
