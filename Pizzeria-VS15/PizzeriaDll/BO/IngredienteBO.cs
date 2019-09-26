using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PizzeriaDll.BO
{
    public class IngredienteBO
    {
        public int IdIngrediente { get; set; }
        public string Nombre { get; set; }
        public string Cantidad { get; set; }
        public string Descripcion { get; set; }
        public string Fecha { get; set; }
        public byte[] Imagen { get; set; }
    }
}
