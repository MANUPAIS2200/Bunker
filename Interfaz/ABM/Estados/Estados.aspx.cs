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
    public partial class Estados : System.Web.UI.Page
    {
        NegocioEstado negocioEstado = new NegocioEstado();

        protected void Page_Load(object sender, EventArgs e)
        {
            /// ver permisos
            CargarEstados();
        }

        protected void CargarEstados()
        {
            grid_Estados.DataSource = DataSetEstados();
            grid_Estados.DataBind();

        }
        protected List<Estado> DataSetEstados()
        {
            return negocioEstado.listar();
        }


        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estados_New.aspx");
        }

        protected void grid_Estados_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Estados.DataSource = DataSetEstados();
            this.grid_Estados.PageIndex = e.NewPageIndex;
            this.grid_Estados.DataBind();
        }
    }
}