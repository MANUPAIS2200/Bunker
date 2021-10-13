using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Provincias
{
    public partial class Provincias : System.Web.UI.Page
    {
        NegocioProvincia negocioProvincia = new NegocioProvincia();
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Ver permisos.
            CargarProvincias();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Provincias_New.aspx");
        }

        protected void CargarProvincias()
        {
            grid_Provincia.DataSource = DataSetProvincias();
            grid_Provincia.DataBind();

        }

        protected List<Provincia> DataSetProvincias()
        {
            return negocioProvincia.listar();
        }

       

        protected void grid_Provincia_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Provincia.DataSource = DataSetProvincias();
            this.grid_Provincia.PageIndex = e.NewPageIndex;
            this.grid_Provincia.DataBind();
        }

        protected void grid_Provincia_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            NegocioPais negocioPais = new NegocioPais();

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[1].Text = negocioPais.descripcionxid(int.Parse(e.Row.Cells[1].Text));
                
            }
        }
    }
}