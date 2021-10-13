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
    public partial class Etapas : System.Web.UI.Page
    {
        NegocioEtapa negocioEtapa = new NegocioEtapa();
 
        protected void Page_Load(object sender, EventArgs e)
        {
            // ver permisos
            CargarEtapas();
        }

        protected void CargarEtapas()
        {
            grid_Etapas.DataSource = DataSetEtapas();
            grid_Etapas.DataBind();

        }
        protected List<Etapa> DataSetEtapas()
        {
            return negocioEtapa.listar();
        }


        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Etapas_New.aspx");
        }

        protected void grid_Etapas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Etapas.DataSource = DataSetEtapas();
            this.grid_Etapas.PageIndex = e.NewPageIndex;
            this.grid_Etapas.DataBind();
        }
    }
}