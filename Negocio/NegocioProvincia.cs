using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioProvincia
    {

        public List<Provincia> listar()
        {
            List<Provincia> lista = new List<Provincia>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDPais, Descripcion FROM Provincias ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Provincia
                    {
                        ID = (int)datos.Lector["ID"],
                        IDPais = (int)datos.Lector["IDPais"],
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

        public void agregar(Provincia nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values("+nuevo.IDPais+",'" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Provincias (IDPais, Descripcion)" + valores);
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

        public void modificar(Provincia provincia)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Provincias SET IDPais = " + provincia.IDPais + ", Descripcion='" + provincia.Descripcion + "' WHERE ID=" + provincia.ID);
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
            List<Provincia> lista = new List<Provincia>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDPais, Descripcion FROM Provincias ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Provincia
                    {
                        ID = (int)datos.Lector["ID"],
                        IDPais = (int)datos.Lector["IDPais"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };

                    lista.Add(aux);
                }
                foreach (Provincia item in lista)
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

