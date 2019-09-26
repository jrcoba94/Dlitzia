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
    public partial class RegPizza : System.Web.UI.Page
    {
        PizzaBO oPizzaBO;
        PizzaDAO oPizzaDAO;

        protected void Page_Load(object sender, EventArgs e)
        {
            oPizzaBO = new PizzaBO();
            oPizzaDAO = new PizzaDAO();
        }

        public void Limpiar()
        {
            txtNombre.Text = "";
            txtTamaño.Text = "";
            txtDescripcion.Value = "";
            txtPrecio.Text = "";
        }

        PizzaBO DtaCollection()
        {
            oPizzaBO.Nombre = txtNombre.Text;
            oPizzaBO.Tamanio = txtTamaño.Text;
            oPizzaBO.Descripcion = txtDescripcion.Value;
            oPizzaBO.Precio = Convert.ToDecimal(txtPrecio.Text);
            
            return DtaCollection();
        }

        public void Agregar()
        {
            PizzaBO oPizza = DtaCollection();
            if (txtNombre.Text.Length != 0)
            {
                oPizzaDAO.CrearPizza(oPizza);
            }

            Limpiar();
            Response.Redirect("Pizza.aspx");
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
            Limpiar();
            Response.Redirect("Pizza.aspx");
        }
    }
}