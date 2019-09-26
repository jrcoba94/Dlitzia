using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDll.BO
{
    public class PizzaIngredienteBO
    {
        public int IdPizzaIngrediente { get; set; }
        public string Cantidad { get; set; }
        public string Medida { get; set; }
        public int IdPizza { get; set; }
        public int IdIngrediente { get; set; }
    }
}
