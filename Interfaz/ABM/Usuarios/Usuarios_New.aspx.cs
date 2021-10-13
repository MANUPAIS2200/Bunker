using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Dominio;
using Negocio;
namespace Interfaz.ABM.Usuarios
{ 
    public partial class Usuarios_New : System.Web.UI.Page
    {
        NegocioContacto negocioContacto = new NegocioContacto();
        NegocioDepartamento negocioDepartamento = new NegocioDepartamento();
        NegocioPermiso negocioPermiso = new NegocioPermiso();
        NegocioUsuario negocioUsuario = new NegocioUsuario();

        List<Contacto> listaContactos = new List<Contacto>();
        List<Departamento> listaDepartamentos = new List<Departamento>();
        List<Permiso> listaPermiso = new List<Permiso>();

        protected void Page_Load(object sender, EventArgs e)
        {
            listaContactos = negocioContacto.listarAltas();

            ListItem a;
            foreach (Contacto item in listaContactos)
            {
                a = new ListItem(item.Apellido, item.ID.ToString());
                DropDownListContactos.Items.Add(a);
            }

            listaDepartamentos = negocioDepartamento.listar();

            ListItem b;
            foreach (Departamento item in listaDepartamentos)
            {
                b = new ListItem(item.Descripcion, item.ID.ToString());
                DropDownListDepartamentos.Items.Add(b);
            }


            listaPermiso = negocioPermiso.listar();

            ListItem c;
            foreach (Permiso item in listaPermiso)
            {
                c = new ListItem(item.Descripcion, item.ID.ToString());
                DropDownListPermisos.Items.Add(c);
            }

        }

        protected void btn_Agregar_Click(object sender, EventArgs e)
        {

            Usuario usuario = new Usuario()
            {
                Nick = Text_Nick.Text,
                Contraseña = Text_Contraseña.Text,
                Mail = Text_Mail.Text,
                IDContacto =  DropDownListContactos.SelectedIndex + 1,
                IDDepartamento = DropDownListDepartamentos.SelectedIndex + 1,
                IDPermiso = DropDownListPermisos.SelectedIndex + 1

            };

            negocioUsuario.agregar(usuario);

            Response.Redirect("Usuarios.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }
    }
}