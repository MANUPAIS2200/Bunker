using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Paises
{
    public partial class Paises_Det : System.Web.UI.Page
    {
        NegocioPais negocioPais = new NegocioPais();
        List<Pais> listaContactos = new List<Pais>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaContactos = negocioPais.listar();
                Pais seleccionado = listaContactos.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

                txt_Descripcion.Text = seleccionado.Descripcion;
            }

        }     

        

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Paises.aspx");
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idpais = int.Parse(Request.QueryString["id"]);
            string aux = txt_Descripcion.Text;
            Pais pais = new Pais()
            {
                ID = idpais,
                Descripcion = txt_Descripcion.Text
            };
            negocioPais.modificar(pais);

            Response.Redirect("Paises.aspx");

        }
    }
}