using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzeriaDll.DAO;

namespace Pizzeria.GUI
{
    public partial class Ingrediente : System.Web.UI.Page
    {
        IngredienteDAO oIngreDAO;

        protected void Page_Load(object sender, EventArgs e)
        {
            oIngreDAO = new IngredienteDAO();
            FacadeMth("Listar");
        }

        public void Listar()
        {
            gvIngredientes.DataSource = oIngreDAO.DevuelveProductos();
            gvIngredientes.DataBind();
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
            Response.Redirect("RegIngrediente.aspx");
        }
    }
}