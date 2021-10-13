using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioEstado
    {

        public List<Estado> listar()
        {
            List<Estado> lista = new List<Estado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Estados where baja = 0");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Estado
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

        public void agregar(Estado nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Estados (Descripcion)" + valores);
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

        public void modificar(Estado estados)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Estados SET Descripcion='" + estados.Descripcion + "' WHERE ID=" + estados.ID);
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
                datos.setearConsulta("UPDATE Estados SET baja=1 Where Id = " + id);
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
            List<Estado> lista = new List<Estado>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Estados where baja = 0 ;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Estado
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };

                    lista.Add(aux);
                }
                foreach (Estado item in lista)
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
