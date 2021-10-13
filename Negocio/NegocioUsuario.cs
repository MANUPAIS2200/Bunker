using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
namespace Negocio
{
   public class NegocioUsuario
    {
        public List<Usuario> listarAltas()
        {
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDContacto, IDDepartamento, IDPermiso, Nick, Contraseña, Mail FROM Usuarios WHERE baja=0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Usuario
                    {
                        ID = (int)datos.Lector["ID"],
                        IDContacto = (int)datos.Lector["IDContacto"],
                        IDDepartamento = (int)datos.Lector["IDDepartamento"],
                        IDPermiso = (int)datos.Lector["IDPermiso"],
                        Nick = (string)datos.Lector["Nick"],
                        Contraseña = (string)datos.Lector["Contraseña"],
                        Mail = (string)datos.Lector["Mail"],
                    };

                    lista.Add(aux);
                }
                return lista;
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void agregar(Usuario nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                string valores = "values(" + nuevo.IDContacto + ", " +nuevo.IDDepartamento+ ","+ nuevo.IDPermiso+ ", '"+nuevo.Nick + "','"+ nuevo.Contraseña +"', '" +nuevo.Mail +" ')";
                datos.setearConsulta("insert into Usuarios (IDContacto, IDDepartamento,IDPermiso, Nick, Contraseña, Mail) " + valores);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void modificar(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Usuarios SET IDContacto=" + usuario.IDContacto + ", IDDepartamento=" + usuario.IDDepartamento + ", IDPermiso=" + usuario.IDPermiso + ", Nick= '" + usuario.Nick + " ', Contraseña= '" + usuario.Contraseña + " ',Mail= '" + usuario.Mail + " ' WHERE ID=" + usuario.ID);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void eliminar(int id)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("UPDATE Usuarios SET baja=1 Where Id = " + id);
                datos.ejectutarAccion();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public string descripcionxid(int id)
        {
            string descripcion = null;
            List<Usuario> lista = new List<Usuario>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Nick FROM Usuarios;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Usuario
                    {
                        ID = (int)datos.Lector["ID"],
                        Nick = (string)datos.Lector["Nick"],
                    };

                    lista.Add(aux);
                }
                foreach (Usuario item in lista)
                {
                    if (id == item.ID)
                        return item.Nick;

                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }

            return descripcion;
        }
        public bool loguear(Usuario usuario)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDPermiso FROM Usuarios WHERE Nick = '" + usuario.Nick+"' AND Contraseña = '"+usuario.Contraseña+"'");
               
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    usuario.ID = (int)datos.Lector["ID"];
                    usuario.IDPermiso = (int)datos.Lector["IDPermiso"];
                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }
    }
}
