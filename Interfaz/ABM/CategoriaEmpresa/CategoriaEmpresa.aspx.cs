using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace Interfaz.ABM.CategoriaEmpresa
{
    public partial class CategoriaEmpresa : System.Web.UI.Page
    {
        NegocioCategoriaEmpresa negocioCategoriaEmpresa = new NegocioCategoriaEmpresa();
        protected void Page_Load(object sender, EventArgs e)
        {/// ver permisos
            CargarCategoriaEmpresa();

        }
        protected void CargarCategoriaEmpresa()
        {
            grid_CategoriaEmpresa.DataSource = DataSetCategoriaEmpresa();
            grid_CategoriaEmpresa.DataBind();

        }
        protected List<Dominio.CategoriaEmpresa> DataSetCategoriaEmpresa()
        {
            return negocioCategoriaEmpresa.listar();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoriaEmpresa_New.aspx");
        }

        protected void grid_CategoriaEmpresa_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_CategoriaEmpresa.DataSource = DataSetCategoriaEmpresa();
            this.grid_CategoriaEmpresa.PageIndex = e.NewPageIndex;
            this.grid_CategoriaEmpresa.DataBind();
        }
    }
}