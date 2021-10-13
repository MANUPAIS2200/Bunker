using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;

namespace Interfaz.ABM.Provincias
{
    public partial class Provincias_Det : System.Web.UI.Page
    {
        NegocioProvincia negocioProvincia = new NegocioProvincia();
        NegocioPais negocioPais = new NegocioPais();

        List<Pais> listaPais = new List<Pais>();
        List<Provincia> listaProvincia = new List<Provincia>();
        protected void Page_Load(object sender, EventArgs e)
        {
            if(!IsPostBack)
            {

                listaPais = negocioPais.listar();
                ListItem a;
                foreach (Pais item in listaPais)
                {
                    a = new ListItem(item.Descripcion, item.ID.ToString());
                    DropDownListPais.Items.Add(a);
                }

                listaProvincia = negocioProvincia.listar();
                var seleccionado = listaProvincia.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

                TextDescripcion.Text = seleccionado.Descripcion;

                DropDownListPais.SelectedValue = seleccionado.IDPais.ToString();
            }


        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {

            int idProvincia = int.Parse(Request.QueryString["id"]);
            Provincia provincia = new Provincia()
            {
                ID = idProvincia,
                Descripcion = TextDescripcion.Text,
                IDPais = int.Parse(DropDownListPais.SelectedValue),
            };

            negocioProvincia.modificar(provincia);

            Response.Redirect("Provincias.aspx");


        }



        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Provincias.aspx");
        }
    }
}