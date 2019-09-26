using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using PizzeriaDll.BO;

namespace PizzeriaDll.DAO
{
    public class PizzaIngredienteDAO
    {
        SqlConnection conn;
        ConecctionDAO conexion = new ConecctionDAO();

        public PizzaIngredienteDAO()
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

        public DataSet devuelvePizzaIngrediente(PizzaIngredienteBO obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            SqlCommand cmd = new SqlCommand();
            DataSet dsPizzaIngrediente = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            if (obj.IdPizzaIngrediente > 0)
            {
                cadenaWhere = cadenaWhere + " IdPizzaIngrediente=@IdPizzaIngrediente and";
                cmd.Parameters.Add("@IdPizzaIngrediente", SqlDbType.Int);
                cmd.Parameters["@IdPizzaIngrediente"].Value = obj.IdPizzaIngrediente;
                edo = true;
            }
            if (obj.Cantidad != null)
            {
                cadenaWhere = cadenaWhere + " Cantidad=@Cantidad and";
                cmd.Parameters.Add("@Cantidad", SqlDbType.Int);
                cmd.Parameters["@Cantidad"].Value = obj.Cantidad;
                edo = true;
            }
            if (obj.Medida != null)
            {

                cadenaWhere = cadenaWhere + " Medida=@Medida and";
                cmd.Parameters.Add("@Medida", SqlDbType.VarChar);
                cmd.Parameters["@Medida"].Value = obj.Medida;
                edo = true;
            }
            if (obj.IdPizza != null)
            {

                cadenaWhere = cadenaWhere + " IdPizza=@IdPizza and";
                cmd.Parameters.Add("@IdPizza", SqlDbType.Int);
                cmd.Parameters["@IdPizza"].Value = obj.IdPizza;
                edo = true;
            }
            if (obj.IdIngrediente != null)
            {

                cadenaWhere = " IdIngrediente=@IdIngrediente and";
                cmd.Parameters.Add("@Ingrediente", SqlDbType.Int);
                cmd.Parameters["@Ingrediente"].Value = obj.IdIngrediente;
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            string sql = " SELECT * FROM PizzaIngrediente " + cadenaWhere;
            cmd = new SqlCommand(sql, conn);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsPizzaIngrediente);
            return dsPizzaIngrediente;
        }

        public int CrearPizzaIngrediente(PizzaIngredienteBO obj)
        {
            
            string sql = "INSERT INTO PizzaIngrediente(Cantidad,Medida,IdPizza,IdIngrediente)" +
            "VALUES(@Cantidad,@Medida,@IdPizza,@IdIngrediente)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Cantidad", SqlDbType.Int);
            cmd.Parameters.Add("@Medida", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdPizza", SqlDbType.Int);
            cmd.Parameters.Add("@IdIngrediente", SqlDbType.Int);

            cmd.Parameters["@Cantidad"].Value = obj.Cantidad;
            cmd.Parameters["@Medida"].Value = obj.Medida;
            cmd.Parameters["@IdPizza"].Value = obj.IdPizza;
            cmd.Parameters["@IdIngrediente"].Value = obj.IdIngrediente;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminaPizzaIngrediente(PizzaIngredienteBO obj)
        {
            string sql = "DELETE FROM PizzaIngrediente WHERE IdPizzaIngrediente = @IdPizzaIngrediente";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@PizzaIngrediente", SqlDbType.Int);
            cmd.Parameters["@PizzaIngrediente"].Value = obj.IdPizzaIngrediente;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaPizzaIngrediente(PizzaIngredienteBO obj)
        {
            string sql = "UPDATE PizzaIngrediente " +
                  "SET Cantidad = @Cantidad," +
                  "Medida = @Medida," +
                  "IdPizza = @IdPizza," +
                  "IdIngrediente = @IdIngrediente" +
                  " WHERE IdPizzaIngrediente = @IdPizzaIngrediente";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@IdPizzaIngrediente", SqlDbType.Int);
            cmd.Parameters.Add("@Cantidad", SqlDbType.Int);
            cmd.Parameters.Add("@Medida", SqlDbType.VarChar);
            cmd.Parameters.Add("@IdPizza", SqlDbType.Int);
            cmd.Parameters.Add("@IdIngrediente", SqlDbType.Int);

            cmd.Parameters["@IdPizzaIngrediente"].Value = obj.Cantidad;
            cmd.Parameters["@Cantidad"].Value = obj.Cantidad;
            cmd.Parameters["@Medida"].Value = obj.Medida;
            cmd.Parameters["@IdPizza"].Value = obj.IdPizza;
            cmd.Parameters["@IdIngrediente"].Value = obj.IdIngrediente;

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
                string sql = "SELECT * FROM V_PizzaIngrediente";
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
