using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzeriaDll.DAO;

namespace Pizzeria.GUI
{
    public partial class PizzaIngrediente : System.Web.UI.Page
    {
        PizzaIngredienteDAO oPizzaIngrDAO;
        protected void Page_Load(object sender, EventArgs e)
        {
            oPizzaIngrDAO = new PizzaIngredienteDAO();
            FacadeMth("Listar");
        }

        public void Listar()
        {
            gvPizzas.DataSource = oPizzaIngrDAO.DevuelveProductos();
            gvPizzas.DataBind();
        }

        public void FacadeMth(string Acty)
        {
            switch (Acty)
            {
                case "Listar":
                    Listar();
                    break;
            }
        }

        protected void btnAgregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("RegPI.aspx");
        }
    }
}