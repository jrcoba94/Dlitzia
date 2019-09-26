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
    public partial class Clientes : System.Web.UI.Page
    {
        ClienteBO oobj;
        ClienteDAO objdao;
        protected void Page_Load(object sender, EventArgs e)
        {
            oobj = new ClienteBO();
            objdao = new ClienteDAO();
            if (!IsPostBack)
            {
                Facade("Select");
            }
        }
        private void Facade(string accion)
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
        private void Select()
        {
            gvProductos.DataSource = objdao.Select();
            gvProductos.DataBind();
        }
        private void Guardar()
        {
            ClienteBO cli = InterfaceToData();
            objdao.Save(cli);
            Facade("Select");
            Facade("Limpiar");
        }
        private void Limpiar()
        {
            txtNombre.Text = "";
            txtDireccion.Text = "";
            txtTelefono.Text = "";
        }
        private ClienteBO InterfaceToData()
        {
            oobj.Nombre = txtNombre.Text;
            oobj.Direccion = txtDireccion.Text;
            oobj.Telefono = txtTelefono.Text;
            return oobj;
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
            if (txtDireccion.Text == "")
                msg += "Favor de llenar el campo Dirección\n";
            if (txtTelefono.Text == "")
                msg += "Favor de llenar el campo Telefono\n";
            return msg;
        }
        private void Eliminar()
        {
            ClienteBO prod = new ClienteBO();
            prod.IdCliente = Convert.ToInt32(HiddenId.Value);
            if (prod.IdCliente > 0)
            {
                objdao.Delete(prod);
                Select();
                Limpiar();
            }
        }
        protected void btnEliminar_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            GridViewRow gvrow = (GridViewRow)btn.NamingContainer;
            int index = gvrow.RowIndex;

            HiddenId.Value = gvProductos.DataKeys[index]["IdCliente"].ToString();
            Facade("Eliminar");
        }
    }
}