using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace Interfaz
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Unnamed_Click(object sender, EventArgs e)
        {
            Usuario usuario = new Usuario();
            NegocioUsuario negocio = new NegocioUsuario();
            try
            {
                usuario = new Usuario();
                usuario.Nick = Request.Form.Get("usuario");
                usuario.Contraseña = Request.Form.Get("contraseña");
                if (negocio.loguear(usuario))
                {
                    ///Session.Add("usuario", usuario);
                    var page = HttpContext.Current.CurrentHandler as Page;
                    ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario logueado con Éxito!" + "');window.location ='" + "Default.aspx" + "';", true);
                   
                        Response.Redirect("Default.aspx");
                 

                }
                else
                {
                    Session.Add("error", "Usuario o Contraseña incorrecta");
                    var page = HttpContext.Current.CurrentHandler as Page;
                    ScriptManager.RegisterStartupScript(page, page.GetType(), "alert", "alert('" + "Usuario o Contraseña incorrecta" + "');window.location ='" + "Default.aspx" + "';", true);
                }


            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}