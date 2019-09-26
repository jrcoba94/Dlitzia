using PizzeriaDll.BO;
using PizzeriaDll.DAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Pizzeria.GUI
{
    public partial class Pizzeria : System.Web.UI.Page
    {
        PizzeriaBO obj;
        PizzeriaDAO objdao;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new PizzeriaBO();
            objdao = new PizzeriaDAO();
            if (!IsPostBack)
            {
                Facade("Select");
            }
        }
        private void Facade(string accion)
        {
            switch (accion)
            {
                case "Guardar":
                    Guardar();
                    break;
                case "Limpiar":
                    Limpiar();
                    break;
                case "Select":
                    Select();
                    break;
                case "Eliminar":
                    Eliminar();
                    break;
            }
        }
        private void Select()
        {
            gvProductos.DataSource = objdao.Select();
            gvProductos.DataBind();
        }
        private PizzeriaBO InterfaceToData()
        {
            obj.Nombre = txtNombre.Text;
            obj.RFC = txtRFC.Text;
            obj.Telefono = txtTelefono.Text;
            obj.Direccion = txtDireccion.Text;
            return obj;
        }
        private void Limpiar()
        {
            txtTelefono.Text = "";
            txtRFC.Text = "";
            txtDireccion.Text = "";
            txtNombre.Text = "";
        }
        private void Guardar()
        {
            string validado = validar();
            if (validado == "")
            {
                PizzeriaBO pizz = InterfaceToData();
                objdao.Save(pizz);
                Facade("Select");
                Facade("Limpiar");
            }
            else
                ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Favor de llenar los campos')", true);
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            Facade("Guardar");
        }
        private void Eliminar()
        {
            PizzeriaBO prod = new PizzeriaBO();
            prod.IdPizzeria = Convert.ToInt32(HiddenId.Value);
            if (prod.IdPizzeria > 0)
            {
                objdao.Delete(prod);
                Select();
                Limpiar();
            }
        }
        public string validar()
        {
            string msg = "";
            if (txtNombre.Text == "")
                msg += "Favor de llenar el campo Nombre\n";
            if (txtRFC.Text == "")
                msg += "Favor de llenar el campo RFC\n";
            if (txtDireccion.Text == "")
                msg += "Favor de llenar el campo Dirección\n";
            if (txtTelefono.Text == "")
                msg += "Favor de llenar el campo Telefono\n";
            return msg;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gvrow = (GridViewRow)btn.NamingContainer;
            int index = gvrow.RowIndex;

            HiddenId.Value = gvProductos.DataKeys[index]["IdPizzeria"].ToString();
            Facade("Eliminar");
        }
    }
}