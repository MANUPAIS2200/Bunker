using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioContacto
    {

        
    
        public List<Contacto> listarAltas()
        {
            List<Contacto> lista = new List<Contacto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDEmpresa, Nombre, Apellido, Telefono, Mail, Descripcion FROM Contactos WHERE baja=0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Contacto
                    {
                        ID = (int)datos.Lector["ID"],
                        IDEmpresa = (int)datos.Lector["IDEmpresa"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Apellido = (string)datos.Lector["Apellido"],
                        Telefono = (string)datos.Lector["Telefono"],
                        Mail = (string)datos.Lector["Mail"],
                        Descripcion = (string)datos.Lector["Descripcion"],
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

        public void agregar(Contacto nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                string valores = "values(" + nuevo.IDEmpresa + ", " + nuevo.Nombre + ",'" + nuevo.Apellido + "', '" + nuevo.Telefono + "','" + nuevo.Mail + "', '" + nuevo.Descripcion + " ')";
                datos.setearConsulta("insert into Constactos (IDEmpresa, Nombre,Apellido, Telefono, Mail, Descripcion) " + valores);
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

        public void modificar(Contacto contacto)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Usuarios SET IDEmpresa=" + contacto.IDEmpresa + ", Nombre= '" + contacto.Nombre + " ', Apellido= '" + contacto.Apellido + "', Telefono= '" + contacto.Telefono + " ', Mail= '" + contacto.Mail + " ',Descripcion= '" + contacto.Descripcion + " ' WHERE ID=" + contacto.ID);
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
                datos.setearConsulta("UPDATE Constactos SET baja=1 Where Id = " + id);
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
            List<Contacto> lista = new List<Contacto>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Nombre, Apellido FROM Contactos;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Contacto
                    {
                        ID = (int)datos.Lector["ID"],
                        Nombre = (string)datos.Lector["Nombre"],
                        Apellido = (string)datos.Lector["Apellido"],
                    };

                    lista.Add(aux);
                }
                foreach (Contacto item in lista)
                {
                    if (id == item.ID)
                        return item.Nombre+" " +item.Apellido ;

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
        
    }
}

