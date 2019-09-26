using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace PizzeriaDll.DAO
{
    public class ConecctionDAO
    {
        public SqlConnection EstablecerConexion()
        {
            return new SqlConnection("Data Source = .; Initial Catalog = Pizzeria; Integrated Security = True");
        }
    }
}
