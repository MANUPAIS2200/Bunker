using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioPermiso
    {
       

            public List<Permiso> listar()
            {
                List<Permiso> lista = new List<Permiso>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("SELECT ID, Descripcion FROM Permisos");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        var aux = new Permiso
                        {
                            ID = (int)datos.Lector["ID"],
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

            public void agregar(Permiso nuevo)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    string valores = "values('" + nuevo.Descripcion + "')";
                    datos.setearConsulta("insert into Permisos (Descripcion)" + valores);
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

            public void modificar(Permiso  permiso)
            {
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("Update Permisos SET Descripcion='" + permiso.Descripcion + "' WHERE ID=" + permiso.ID);
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
                List<Permiso> lista = new List<Permiso>();
                AccesoDatos datos = new AccesoDatos();
                try
                {
                    datos.setearConsulta("SELECT ID, Descripcion FROM Permisos;");
                    datos.ejecutarLectura();

                    while (datos.Lector.Read())
                    {
                        var aux = new Permiso
                        {
                            ID = (int)datos.Lector["ID"],
                            Descripcion = (string)datos.Lector["Descripcion"],
                        };

                        lista.Add(aux);
                    }
                    foreach (Permiso item in lista)
                    {
                        if (id == item.ID)
                            return item.Descripcion;

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

