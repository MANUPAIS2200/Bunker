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
    public partial class Provincias_New : System.Web.UI.Page
    {
        NegocioProvincia negocioProvincia = new NegocioProvincia();
        NegocioPais negocioPais = new NegocioPais();

        List<Pais> listaPais = new List<Pais>();


        protected void Page_Load(object sender, EventArgs e)
        {
            listaPais = negocioPais.listar();

            ListItem a;
            foreach (Pais item in listaPais)
            {
                a = new ListItem(item.Descripcion, item.ID.ToString());
                DropDownListPais.Items.Add(a);
            }

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
           Provincia provincia = new Provincia()
            {
                IDPais = DropDownListPais.SelectedIndex + 1,
                Descripcion = Text_Descripcion.Text,
              
            };

            negocioProvincia.agregar(provincia);

            Response.Redirect("Provincias.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Provincias.aspx");
        }
    }
}