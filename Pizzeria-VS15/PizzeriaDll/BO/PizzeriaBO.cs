using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzeriaDll.BO
{
    public class PizzeriaBO
    {
        public int IdPizzeria { get; set; }
        public String Nombre { get; set; }
        public String RFC { get; set; }
        public String Direccion { get; set; }
        public String Telefono { get; set; }
    }
}