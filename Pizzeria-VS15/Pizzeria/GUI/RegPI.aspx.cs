using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using PizzeriaDll.BO;
using PizzeriaDll.DAO;

namespace Pizzeria.GUI
{
    public partial class RegPI : System.Web.UI.Page
    {
        PizzaIngredienteBO oPizzaIngreBO;
        PizzaIngredienteDAO oPizzaIngreDAO;
        IngredienteDAO oIngrDAO;

        protected void Page_Load(object sender, EventArgs e)
        {
            oPizzaIngreBO = new PizzaIngredienteBO();
            oPizzaIngreDAO = new PizzaIngredienteDAO();
            oIngrDAO = new IngredienteDAO();
        }

        public void Limpiar()
        {
            txtCantidad.Text = "";
            txtMedida.Text = "";
        }

        PizzaIngredienteBO DtaCollection()
        {
            string id = "";
            oPizzaIngreBO.Cantidad = txtCantidad.Text;
            oPizzaIngreBO.Medida = txtMedida.Text;
            oPizzaIngreBO.IdPizza = Convert.ToInt32(ddlPizzas.DataValueField);
            if (cblIngredientes.SelectedIndex == 0)
            {
                oPizzaIngreBO.IdIngrediente = Convert.ToInt32(cblIngredientes.DataValueField);
                for (int i = 0; i < oIngrDAO.DevuelveProductos().Columns.Count; i++)
                {
                    id += oIngrDAO.DevuelveProductos().Rows[i]["IdPizzaIngrediente"].ToString() + ",";
                    oPizzaIngreBO.IdIngrediente = Convert.ToInt32(oIngrDAO.DevuelveProductos().Rows[i]["IdPizzaIngrediente"].ToString());
                }
            }

            return DtaCollection();
        }

        public void Agregar()
        {
            PizzaIngredienteBO oPizzaIngr = DtaCollection();
            if (txtCantidad.Text.Length != 0)
            {
                oPizzaIngreDAO.CrearPizzaIngrediente(oPizzaIngr);
            }

            Limpiar();
            Response.Redirect("PizzaIngrediente.aspx");
        }

        private void MtdFacade(string Acty)
        {
            switch (Acty)
            {
                case "Guardar":
                    Agregar();
                    break;
            }
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            MtdFacade("Guardar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("PizzaIngrediente.aspx");
        }
    }
}