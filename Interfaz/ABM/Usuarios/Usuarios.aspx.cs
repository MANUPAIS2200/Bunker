using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Usuarios
{
    public partial class Usuarios : System.Web.UI.Page
    {
        NegocioUsuario negocioUsuario = new NegocioUsuario();

        protected void Page_Load(object sender, EventArgs e)
        {
            /// Ver permisos.
            CargarUsuarios();
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios_New.aspx");
        }
        protected void CargarUsuarios()
        {
            grid_Usuarios.DataSource = DataSetUsuarios();
            grid_Usuarios.DataBind();
        
        }

        protected List<Usuario> DataSetUsuarios()
        {
            return negocioUsuario.listarAltas();
        }

        protected void grid_Usuarios_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            this.grid_Usuarios.DataSource = DataSetUsuarios();
            this.grid_Usuarios.PageIndex = e.NewPageIndex;
            this.grid_Usuarios.DataBind();
        }

        protected void grid_Usuarios_RowDataBound(object sender, GridViewRowEventArgs e)
        {

            NegocioContacto negocioContacto = new NegocioContacto();
            NegocioDepartamento negocioDepartamento = new NegocioDepartamento();
            NegocioPermiso negocioPermiso = new NegocioPermiso();

            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                e.Row.Cells[3].Text = negocioContacto.descripcionxid(int.Parse(e.Row.Cells[5].Text));
                e.Row.Cells[6].Text = negocioDepartamento.descripcionxid(int.Parse(e.Row.Cells[6].Text));
                e.Row.Cells[7].Text = negocioPermiso.descripcionxid(int.Parse(e.Row.Cells[7].Text));
               

            }
        }
    }

      
   
}