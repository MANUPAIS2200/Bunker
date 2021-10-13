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
    public partial class Usuarios_Det : System.Web.UI.Page
    {
        NegocioContacto negocioContacto = new NegocioContacto();
        NegocioDepartamento negocioDepartamento = new NegocioDepartamento();
        NegocioPermiso negocioPermiso = new NegocioPermiso();
        NegocioUsuario negocioUsuario = new NegocioUsuario();

        List<Contacto> listaContactos = new List<Contacto>();
        List<Departamento> listaDepartamentos = new List<Departamento>();
        List<Permiso> listaPermiso = new List<Permiso>();
        List<Usuario> listaUsuarios = new List<Usuario>();

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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


                listaUsuarios = negocioUsuario.listarAltas();
                Usuario seleccionado = listaUsuarios.Find(x => x.ID == (int.Parse(Request.QueryString["id"])));
              
                TextNick.Text = seleccionado.Nick;
                TextContraseña.Text = seleccionado.Contraseña;
                TextMail.Text = seleccionado.Mail;
                DropDownListContactos.SelectedValue= seleccionado.IDContacto.ToString();
                DropDownListDepartamentos.SelectedValue = seleccionado.IDDepartamento.ToString();
                DropDownListPermisos.SelectedValue = seleccionado.IDPermiso.ToString();
            }
        }

        protected void btn_Modificar_Click(object sender, EventArgs e)
        {
            int idusuario = int.Parse(Request.QueryString["id"]);
            Usuario usuario = new Usuario()
            {
                ID = idusuario,
                Nick = TextNick.Text,
                Contraseña = TextContraseña.Text,
                Mail = TextMail.Text,
                IDContacto = int.Parse(DropDownListContactos.SelectedValue),
                IDDepartamento = int.Parse(DropDownListDepartamentos.SelectedValue),
                IDPermiso = int.Parse(DropDownListPermisos.SelectedValue),
            };

            negocioUsuario.modificar(usuario);

            Response.Redirect("Usuarios.aspx");


        }

        protected void btn_Eliminar_Click(object sender, EventArgs e)
        {
            negocioUsuario.eliminar(int.Parse(Request.QueryString["id"]));
            Response.Redirect("Usuarios.aspx");

        }

        protected void btn_Volver_Click(object sender, EventArgs e)
        {
            Response.Redirect("Usuarios.aspx");
        }
    }
}