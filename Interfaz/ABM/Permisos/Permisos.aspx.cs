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
    public partial class Permisos : System.Web.UI.Page
    {
        NegocioPermiso negocioPermiso = new NegocioPermiso();

        protected void Page_Load(object sender, EventArgs e)
        {
            /// Ver permisos.
            CargarPermisos();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Permisos_New.aspx");
        }
        protected void CargarPermisos()
        {
            grid_Permisos.DataSource = DataSetPermisos();
            grid_Permisos.DataBind();

        }
        protected List<Permiso> DataSetPermisos()
        {
            return negocioPermiso.listar();
        }
        protected void grid_Permisos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Permisos.DataSource = DataSetPermisos();
            this.grid_Permisos.PageIndex = e.NewPageIndex;
            this.grid_Permisos.DataBind();
        }

        protected void grid_Permisos_RowDataBound(object sender, GridViewRowEventArgs e)
        {

        }
    }
}