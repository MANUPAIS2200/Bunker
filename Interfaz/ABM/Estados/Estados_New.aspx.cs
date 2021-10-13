using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;


namespace Interfaz.ABM.Estados
{
    public partial class Estados_New : System.Web.UI.Page
    {
        NegocioEstado negocioEstado = new NegocioEstado();

        protected void Page_Load(object sender, EventArgs e)
        {
            //ver permisos
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Estado estado = new Estado()
            {
                Descripcion = txt_Descripcion.Text
            };

            negocioEstado.agregar(estado);

            Response.Redirect("Estados.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estados.aspx");

        }
    }
}