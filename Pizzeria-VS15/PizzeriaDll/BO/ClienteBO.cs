using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzeriaDll.BO
{
    public class ClienteBO
    {
        public int IdCliente { get; set; }
        public String Nombre { get; set; }
        public String Telefono { get; set; }
        public String Direccion { get; set; }
    }
}