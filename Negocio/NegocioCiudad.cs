using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioCiudad
    {
        public List<Ciudad> listar()
        {
            List<Ciudad> lista = new List<Ciudad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDProvincia, Descripcion FROM Ciudades ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Ciudad
                    {
                        ID = (int)datos.Lector["ID"],
                        IDProvincia = (int)datos.Lector["IDProvincia"],
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

        public void agregar(Ciudad nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                string valores = "values(" + nuevo.IDProvincia + ", '" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Ciudades (IDProvincia, Descripcion) " + valores);
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

        public void modificar(Ciudad ciudad)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Ciudades SET IDProvincia=" + ciudad.IDProvincia + ", IDCategoriaEmpresa=" + ciudad.Descripcion + "'");
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

        //public void eliminar(int id)
        //{
        //    AccesoDatos datos = new AccesoDatos();
        //    try
        //    {
        //        datos.setearConsulta("UPDATE Direcciones SET baja=1 Where Id = " + id);
        //        datos.ejectutarAccion();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw ex;
        //    }
        //    finally
        //    {
        //        datos.cerrarConexion();
        //    }
        //}

        public string descripcionxid(int id)
        {
            string descripcion = null;
            List<Ciudad> lista = new List<Ciudad>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDProvincia, Descripcion FROM Ciudades;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Ciudad
                    {
                        ID = (int)datos.Lector["ID"],
                        IDProvincia = (int)datos.Lector["IDProvincia"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                      
                    };

                    lista.Add(aux);
                }
                foreach (Ciudad item in lista)
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

