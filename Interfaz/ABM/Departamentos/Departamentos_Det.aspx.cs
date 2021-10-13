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
    public partial class Departamentos_Det : System.Web.UI.Page
    {      
            NegocioDepartamento negocioDepartamento = new NegocioDepartamento();
            List<Departamento> listaDepartamentos = new List<Departamento>();
        protected void Page_Load(object sender, EventArgs e)
        {
               if (!IsPostBack)
                {
                listaDepartamentos = negocioDepartamento.listar();
                    Departamento seleccionado = listaDepartamentos.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));

                    txt_Descripcion.Text = seleccionado.Descripcion;
                }

       
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int iddepartamento = int.Parse(Request.QueryString["id"]);
           
            Departamento departamento = new Departamento()
            {
                ID = iddepartamento,
                Descripcion = txt_Descripcion.Text
            };
            negocioDepartamento.modificar(departamento);

            Response.Redirect("Departamentos.aspx");
        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos.aspx");
        }
    }
}