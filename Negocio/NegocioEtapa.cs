using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Negocio;
using Dominio;

namespace Negocio
{
    public class NegocioEtapa
    {

        public List<Etapa> listar()
        {
            List<Etapa> lista = new List<Etapa>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Etapas ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Etapa
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

        public void agregar(Etapa nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Etapas (Descripcion)" + valores);
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

        public void modificar(Etapa etapa)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Etapas SET Descripcion='" + etapa.Descripcion + "' WHERE ID=" + etapa.ID);
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
            List<Etapa> lista = new List<Etapa>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Etapas  ;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Etapa
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };

                    lista.Add(aux);
                }
                foreach (Etapa item in lista)
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
