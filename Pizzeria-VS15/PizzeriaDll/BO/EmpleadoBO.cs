using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PizzeriaDll.BO
{
    public class EmpleadoBO
    {
        public int IdEmpleado { get; set; }
        public String Usuario { get; set; }
        public String Contrasenia { get; set; }
        public String Nombre { get; set; }
        public String Direccion { get; set; }
        public int IdPizzeria { get; set; }

    }
}