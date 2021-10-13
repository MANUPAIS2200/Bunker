using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.NewFolder1
{
    public partial class Paises : System.Web.UI.Page
    {
        NegocioPais negocioPais = new NegocioPais();

        protected void Page_Load(object sender, EventArgs e)
        {/// ver permisos
            CargarPaises();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Paises_New.aspx");
        }

        protected void CargarPaises()
        {
            grid_Paises.DataSource = DataSetPaises();
            grid_Paises.DataBind();

        }
        protected List<Pais> DataSetPaises()
        {
            return negocioPais.listar();
        }

        protected void grid_Paises_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Paises.DataSource = DataSetPaises();
            this.grid_Paises.PageIndex = e.NewPageIndex;
            this.grid_Paises.DataBind();
        }

       
    }
}