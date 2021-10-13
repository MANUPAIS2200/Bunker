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
    public partial class Permisos_Det : System.Web.UI.Page
    {
        NegocioPermiso negocioPermiso = new NegocioPermiso();
        List<Permiso> listaPermiso = new List<Permiso>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            { 
            listaPermiso = negocioPermiso.listar();
            Permiso seleccionado = listaPermiso.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

            TextDescripcion.Text = seleccionado.Descripcion;
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idpermiso = int.Parse(Request.QueryString["id"]);
            string aux = TextDescripcion.Text;

            Permiso permiso = new Permiso()
            {
                ID = idpermiso,
                Descripcion = TextDescripcion.Text,
               
            };

            negocioPermiso.modificar(permiso);

            Response.Redirect("Permisos.aspx");

        }



        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Permisos.aspx");
        }

     
    }
}