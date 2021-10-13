using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Empresas
{
    public partial class Empresas : System.Web.UI.Page
    {
        NegocioEmpresa negocioEmpresa = new NegocioEmpresa();
       
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Ver permisos.
            CargarEmpresas();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Empresas_New.aspx");
        }

        protected void CargarEmpresas()
        {
            grid_Empresas.DataSource = DataSetEmpresas();
            grid_Empresas.DataBind();

        }

        protected List<Empresa> DataSetEmpresas()
        {
            return negocioEmpresa.listar();
        }

        protected void grid_Empresas_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Empresas.DataSource = DataSetEmpresas();
            this.grid_Empresas.PageIndex = e.NewPageIndex;
            this.grid_Empresas.DataBind();
        }

        protected void grid_Empresas_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            NegocioCategoriaEmpresa negocioCategoriaEmpresa = new NegocioCategoriaEmpresa();
            

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[2].Text = negocioCategoriaEmpresa.descripcionxid(int.Parse(e.Row.Cells[2].Text));
               
            }
        }
    }
}