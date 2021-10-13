using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Paises
{
    public partial class Paises_New : System.Web.UI.Page
    {
        NegocioPais negocioPais = new NegocioPais();

        protected void Page_Load(object sender, EventArgs e)
        {
            //ver permisos
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {

            Pais pais = new Pais()
            {
                Descripcion = txt_Descripcion.Text
            };

            negocioPais.agregar(pais);

            Response.Redirect("Paises.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Paises.aspx");
        }
    }
}