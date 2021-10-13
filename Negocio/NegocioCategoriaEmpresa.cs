using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;
using Negocio;

namespace Negocio
{
    public class NegocioCategoriaEmpresa
    {
        public List<CategoriaEmpresa> listar()
        {
            List<CategoriaEmpresa> lista = new List<CategoriaEmpresa>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Categorias");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new CategoriaEmpresa
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

        public void agregar(CategoriaEmpresa nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Categorias (Descripcion)" + valores);
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

        public void modificar(CategoriaEmpresa categoriaEmpresa)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Categorias SET Descripcion='" + categoriaEmpresa.Descripcion + "' WHERE ID=" + categoriaEmpresa.ID);
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
            List<CategoriaEmpresa> lista = new List<CategoriaEmpresa>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Categorias;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new CategoriaEmpresa
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };

                    lista.Add(aux);
                }
                foreach (CategoriaEmpresa item in lista)
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

