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
    public partial class CategoriaEmpresa_Det : System.Web.UI.Page
    {
        NegocioCategoriaEmpresa negocioCategoriaEmpresa = new NegocioCategoriaEmpresa();
        List<Dominio.CategoriaEmpresa> listaCategoriaEmpresa = new List<Dominio.CategoriaEmpresa>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaCategoriaEmpresa = negocioCategoriaEmpresa.listar();
                Dominio.CategoriaEmpresa seleccionado = listaCategoriaEmpresa.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

                txt_Descripcion.Text = seleccionado.Descripcion;
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idCategoria = int.Parse(Request.QueryString["id"]);

            Dominio.CategoriaEmpresa categoriaEmpresa = new Dominio.CategoriaEmpresa()
            {
                ID = idCategoria,
                Descripcion = txt_Descripcion.Text
            };
            negocioCategoriaEmpresa.modificar(categoriaEmpresa);

            Response.Redirect("CategoriaEmpresa.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("CategoriaEmpresa.aspx");
        }
    }
}