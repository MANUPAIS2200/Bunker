using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Departamentos
{
    public partial class Departamentos : System.Web.UI.Page
    {
        NegocioDepartamento negocioDepartamento = new NegocioDepartamento();
        protected void Page_Load(object sender, EventArgs e)
        {
            /// Ver permisos.
            CargarDepartamentos();
        }

        protected void CargarDepartamentos()
        {
            grid_Departamentos.DataSource = DataSetDepartamentos();
            grid_Departamentos.DataBind();

        }

        protected List<Departamento> DataSetDepartamentos()
        {
            return negocioDepartamento.listar();
        }

        protected void grid_Departamentos_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Departamentos.DataSource = DataSetDepartamentos();
            this.grid_Departamentos.PageIndex = e.NewPageIndex;
            this.grid_Departamentos.DataBind();

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos_New.aspx");
        }
    }
}