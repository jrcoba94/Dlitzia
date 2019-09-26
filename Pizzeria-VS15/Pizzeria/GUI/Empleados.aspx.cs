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
    public partial class Empleados : System.Web.UI.Page
    {
        EmpleadoBO obj;
        EmpleadoDAO objdao;
        protected void Page_Load(object sender, EventArgs e)
        {
            obj = new EmpleadoBO();
            objdao = new EmpleadoDAO();
            if (!IsPostBack)
            {
                Facade("Select");
            }

        }
        public void CargarPizzerias()
        {
            PizzeriaDAO objdaopizzerias = new PizzeriaDAO();
            ddlPizzerias.DataSource = objdaopizzerias.Select();
            ddlPizzerias.DataTextField = "Nombre";
            ddlPizzerias.DataValueField = "IdPizzeria";
            ddlPizzerias.DataBind();

        }
        public void Facade(string accion)
        {
            switch (accion)
            {
                case "Select":
                    Select();
                    break;
                case "Guardar":
                    Guardar();
                    break;
                case "Limpiar":
                    Limpiar();
                    break;
                case "Eliminar":
                    Eliminar();
                    break;
            }
        }
        public EmpleadoBO InterfaceToData()
        {
            obj.Nombre = txtNombre.Text;
            obj.Usuario = txtUsuario.Text;
            obj.Contrasenia = txtContrasenia.Text;
            obj.Direccion = txtDireccion.Text;
            obj.IdPizzeria = Convert.ToInt32(ddlPizzerias.SelectedValue);
            return obj;
        }
        public void Guardar()
        {
            EmpleadoBO emp = InterfaceToData();
            objdao.Save(emp);
            Facade("Select");
            Facade("Limpiar");
        }
        private void Select()
        {
            gvProductos.DataSource = objdao.Select();
            gvProductos.DataBind();
            CargarPizzerias();
        }
        public void Limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtUsuario.Text = "";
            txtContrasenia.Text = "";
            ddlPizzerias.SelectedIndex = 0;
        }
        private void Eliminar()
        {
            EmpleadoBO prod = new EmpleadoBO();
            prod.IdEmpleado = Convert.ToInt32(HiddenId.Value);
            if (prod.IdEmpleado > 0)
            {
                objdao.Delete(prod);
                Select();
                Limpiar();
            }
        }
        protected void btnGuardar_Click(object sender, EventArgs e)
        {
            string validado = validar();
            if (validado == "")
                Facade("Guardar");
            else
              ScriptManager.RegisterClientScriptBlock(this, this.GetType(), "alertMessage", "alert('Favor de llenar los campos')", true);
        }
        public string validar()
        {
            string msg = "";
            if (txtNombre.Text == "")
                msg += "Favor de llenar el campo Nombre\n";
            if (txtUsuario.Text == "")
                msg += "Favor de llenar el campo Usuario\n";
            if (txtContrasenia.Text == "")
                msg += "Favor de llenar el campo Contraseña\n";
            if (txtConfirmar.Text == "")
                msg += "Favor de llenar el campo Confirmar Contraseña\n";
            if (txtDireccion.Text == "")
                msg += "Favor de llenar el campo Dirección\n";
            return msg;
        }

        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gvrow = (GridViewRow)btn.NamingContainer;
            int index = gvrow.RowIndex;

            HiddenId.Value = gvProductos.DataKeys[index]["IdEmpleado"].ToString();
            Facade("Eliminar");
        }
    }
}