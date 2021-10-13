using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Permisos
{
    public partial class Permisos_New : System.Web.UI.Page
    {
        NegocioPermiso negocioPermiso = new NegocioPermiso();

        protected void Page_Load(object sender, EventArgs e)
        {
            ///permisos
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Permiso permiso = new Permiso()
            {
                Descripcion = TextDescripcion.Text,
            };

            negocioPermiso.agregar(permiso);

            Response.Redirect("Permisos.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Permisos.aspx");
        }
    }
}