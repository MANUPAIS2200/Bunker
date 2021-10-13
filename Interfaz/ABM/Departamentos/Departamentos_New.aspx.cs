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
    public partial class Departamentos_New : System.Web.UI.Page
    {
        NegocioDepartamento negocioDepartamento = new NegocioDepartamento();

        protected void Page_Load(object sender, EventArgs e)
        {
            /// ver permisos
        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {
            Departamento departamento = new Departamento()
            {
                Descripcion = txt_Descripcion.Text
            };

            negocioDepartamento.agregar(departamento);

            Response.Redirect("Departamentos.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Departamentos.aspx");
        }
    }
}