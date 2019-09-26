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
    public class PizzaDAO
    {
        SqlConnection conn;
        ConecctionDAO conexion = new ConecctionDAO();

        public PizzaDAO()
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

        public DataSet devuelvePizza(PizzaBO obj)
        {
            string cadenaWhere = "";
            bool edo = false;
            SqlCommand cmd = new SqlCommand();
            DataSet dsPizza = new DataSet();
            SqlDataAdapter da = new SqlDataAdapter();

            if (obj.IdPizza > 0)
            {
                cadenaWhere = cadenaWhere + " IdPizza=@IdPizza and";
                cmd.Parameters.Add("@IdPizza", SqlDbType.Int);
                cmd.Parameters["@IdPizza"].Value = obj.IdPizza;
                edo = true;
            }
            if (obj.Nombre != null)
            {
                cadenaWhere = cadenaWhere + " Nombre=@Nombre and";
                cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
                cmd.Parameters["@Nombre"].Value = obj.Nombre;
                edo = true;
            }
            if (obj.Tamanio != null)
            {

                cadenaWhere = cadenaWhere + " Tamanio=@Tamaño and";
                cmd.Parameters.Add("@Tamaño", SqlDbType.VarChar);
                cmd.Parameters["@Tamaño"].Value = obj.Tamanio;
                edo = true;
            }
            if (obj.Descripcion != null)
            {

                cadenaWhere = cadenaWhere + " Descripcion=@Descripcion and";
                cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
                cmd.Parameters["@Descripcion"].Value = obj.Descripcion;
                edo = true;
            }
            if (obj.Precio != null)
            {

                cadenaWhere = " Precio=@Precio and";
                cmd.Parameters.Add("@Precio", SqlDbType.Real);
                cmd.Parameters["@Precio"].Value = obj.Precio;
                edo = true;
            }

            if (edo == true)
            {
                cadenaWhere = " WHERE " + cadenaWhere.Remove(cadenaWhere.Length - 3, 3);
            }
            string sql = " SELECT * FROM Pizza " + cadenaWhere;
            cmd = new SqlCommand(sql, conn);

            cmd.CommandText = sql;
            da.SelectCommand = cmd;
            da.Fill(dsPizza);
            return dsPizza;
        }

        public int CrearPizza(PizzaBO obj)
        {
            //string sql = "INSERT INTO Pizza(Nombre,Tamanio,Descripcion,Precio,Imagen)" +
            //"VALUES(@Nombre,@Tamanio,@Descripcion,@Precio,@Imagen)";

            string sql = "INSERT INTO Pizza(Nombre,Tamanio,Descripcion,Precio,null)" +
            "VALUES(@Nombre,@Tamanio,@Descripcion,@Precio,null)";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar);
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@Precio", SqlDbType.Decimal);
            //cmd.Parameters.Add("@Imagen", SqlDbType.Image);

            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@Tamanio"].Value = obj.Tamanio;
            cmd.Parameters["@Descripcion"].Value = obj.Descripcion;
            cmd.Parameters["@Precio"].Value = obj.Precio;
            //cmd.Parameters["@Imagen"].Value = obj.Imagen;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int EliminaPizza(PizzaBO obj)
        {
            string sql = "DELETE FROM Pizza WHERE IdPizza = @IdPizza";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@IdPizza", SqlDbType.Int);
            cmd.Parameters["@IdPizza"].Value = obj.IdPizza;

            int i = Ejecutarsql(cmd);
            if (i <= 0)
            {
                return 0;
            }
            return 1;
        }

        public int modificaPizza(PizzaBO obj)
        {
            string sql = "UPDATE PizzaIngrediente " +
                  "SET Nombre=@Nombre," +
                  "Tamanio=@Tamanio," +
                  "Descripcion=@Descripcion," +
                  "Precio=@Precio" +
                  " WHERE IdPizza = @IdPizza";
            SqlCommand cmd = new SqlCommand(sql, conn);

            cmd.Parameters.Add("@IdPizza", SqlDbType.Int);
            cmd.Parameters.Add("@Nombre", SqlDbType.VarChar);
            cmd.Parameters.Add("@Tamanio", SqlDbType.VarChar);
            cmd.Parameters.Add("@Descripcion", SqlDbType.VarChar);
            cmd.Parameters.Add("@Precio", SqlDbType.Real);

            cmd.Parameters["@IdPizza"].Value = obj.IdPizza;
            cmd.Parameters["@Nombre"].Value = obj.Nombre;
            cmd.Parameters["@Tamanio"].Value = obj.Tamanio;
            cmd.Parameters["@Descripcion"].Value = obj.Descripcion;
            cmd.Parameters["@Precio"].Value = obj.Precio;

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
                string sql = "SELECT * FROM Pizza";
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
