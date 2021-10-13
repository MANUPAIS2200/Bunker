using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Etapas
{
    public partial class Etapas_New : System.Web.UI.Page
    {
        NegocioEtapa negocioEtapa = new NegocioEtapa();

        protected void Page_Load(object sender, EventArgs e)
        {
            //ver permisos
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Etapa etapa = new Etapa()
            {
                Descripcion = txt_Descripcion.Text
            };

            negocioEtapa.agregar(etapa);

            Response.Redirect("Etapas.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Etapas.aspx");
        }
    }
}