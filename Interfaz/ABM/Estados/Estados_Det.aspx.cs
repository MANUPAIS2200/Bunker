using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Estados
{
    public partial class Estados_Det : System.Web.UI.Page
    {
        NegocioEstado negocioEstado = new NegocioEstado();
        List<Estado> listaEstados = new List<Estado>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                listaEstados = negocioEstado.listar();
                Estado seleccionado = listaEstados.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

                txt_Descripcion.Text = seleccionado.Descripcion;
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idestado = int.Parse(Request.QueryString["id"]);
            string aux = txt_Descripcion.Text;
            Estado estado = new Estado()
            {
                ID = idestado,
                Descripcion = txt_Descripcion.Text
            };
            negocioEstado.modificar(estado);

            Response.Redirect("Estados.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Estados.aspx");
        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            negocioEstado.eliminar(int.Parse(Request.QueryString["id"]));
            Response.Redirect("Estados.aspx");
        }
    }
}