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
    public partial class RegIngrediente : System.Web.UI.Page
    {
        IngredienteBO oIngreBO;
        IngredienteDAO oIngreDAO;

        protected void Page_Load(object sender, EventArgs e)
        {
            oIngreBO = new IngredienteBO();
            oIngreDAO = new IngredienteDAO();
        }

        public void limpiar()
        {
            txtNombre.Text = "";
            txtDescripcion.Value = "";
        }

        public IngredienteBO DtaCollection()
        {
            oIngreBO.Nombre = txtNombre.Text;
            oIngreBO.Descripcion = txtDescripcion.Value;

            return oIngreBO;
        }

        private void FacadeMth(string Acty)
        {
            switch (Acty)
            {
                case "Guardar":
                    Agregar();
                    break;
            }
        }

        public void Agregar()
        {
            IngredienteBO oIngredBO = DtaCollection();
            if (txtNombre.Text.Length != 0 || txtDescripcion.Value.Length != 0)
            {
                oIngreDAO.CrearIngrediente(oIngredBO);
            }
            limpiar();
            Response.Redirect("Ingrediente.aspx");
        }

        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            FacadeMth("Guardar");
        }

        protected void btnCancelar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Ingrediente.aspx");
        }
    }
}