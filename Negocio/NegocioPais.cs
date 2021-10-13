using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
   public class NegocioPais
    {
        public List<Pais> listar()
        {
            List<Pais> lista = new List<Pais>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Paises");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Pais
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

        public void agregar(Pais nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Paises (Descripcion)" + valores);
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

        public void modificar(Pais pais)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Paises SET Descripcion='" + pais.Descripcion + "' WHERE ID=" + pais.ID);
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
            List<Pais> lista = new List<Pais>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Paises;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Pais
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };

                    lista.Add(aux);
                }
                foreach (Pais item in lista)
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

