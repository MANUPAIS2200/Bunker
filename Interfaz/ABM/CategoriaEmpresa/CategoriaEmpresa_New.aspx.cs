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
    public partial class CategoriaEmpresa_New : System.Web.UI.Page
    {
        NegocioCategoriaEmpresa negocioCategoriaEmpresa = new NegocioCategoriaEmpresa();

        protected void Page_Load(object sender, EventArgs e)
        {
            /// ver permisos
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Dominio.CategoriaEmpresa categoriaEmpresa = new Dominio.CategoriaEmpresa()
            {
                Descripcion = txt_Descripcion.Text
            };

            negocioCategoriaEmpresa.agregar(categoriaEmpresa);

            Response.Redirect("CategoriaEmpresa.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoriaEmpresa.aspx");
        }
    }
}