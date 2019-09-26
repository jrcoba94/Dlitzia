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
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        public void Loguear()
        {
            EmpleadoBO obj = new EmpleadoBO();
            EmpleadoDAO objDao = new EmpleadoDAO();
            obj.Usuario = txtUsuario.Text;
            obj.Contrasenia = txtContrasena.Text;
            bool logueado = objDao.Ingresar(obj);
            if (logueado)
            {
                Session.Add("Logueado", true);
                Response.Redirect("Bienvenida.aspx");

            }
           
        }

        protected void btnAceptar_Click(object sender, EventArgs e)
        {
            Loguear();
        }
    }
}