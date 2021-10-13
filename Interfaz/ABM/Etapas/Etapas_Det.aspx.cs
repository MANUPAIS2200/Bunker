using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Etapas
{
    public partial class Etapas_Det : System.Web.UI.Page
    {
        NegocioEtapa negocioEtapa = new NegocioEtapa();
        List<Etapa> listaEstados = new List<Etapa>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaEstados = negocioEtapa.listar();
                Etapa seleccionado = listaEstados.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

                txt_Descripcion.Text = seleccionado.Descripcion;
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idestado = int.Parse(Request.QueryString["id"]);
            string aux = txt_Descripcion.Text;
            Etapa estado = new Etapa()
            {
                ID = idestado,
                Descripcion = txt_Descripcion.Text
            };
            negocioEtapa.modificar(estado);

            Response.Redirect("Etapas.aspx");
        }


        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Etapas.aspx");
        }
    }
}