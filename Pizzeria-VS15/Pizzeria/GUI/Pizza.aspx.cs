using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzeriaDll.DAO;

namespace Pizzeria.GUI
{
    public partial class Pizza : System.Web.UI.Page
    {
        PizzaDAO oPizzaDAO;

        protected void Page_Load(object sender, EventArgs e)
        {
            oPizzaDAO = new PizzaDAO();

            FacadeMth("Listar");
        }

        public void Listar()
        {
            gvPizzas.DataSource = oPizzaDAO.DevuelveProductos();
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
            Response.Redirect("RegPizza.aspx");
        }
    }
}