using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioDireccion
    {
        public List<Direccion> listar()
        {
            List<Direccion> lista = new List<Direccion>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDCiudad, Calle, Numero FROM Direcciones ");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Direccion
                    {
                        ID = (int)datos.Lector["ID"],
                        IDCiudad = (int)datos.Lector["IDCiudad"],
                        Calle = (string)datos.Lector["Calle"],
                        Numero = (string)datos.Lector["Numero"],

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

        public void agregar(Direccion nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {

                string valores = "values(" + nuevo.IDCiudad + ", '" + nuevo.Calle + "', '" + nuevo.Numero + "'')";
                datos.setearConsulta("insert into Direcciones (IDCiudad, Calle,Numero) " + valores);
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

        public void modificar(Direccion direccion)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Direcciones SET IDCiudad=" + direccion.IDCiudad + ", IDCategoriaEmpresa=" + direccion.Calle + ", RazonSocial= '" + direccion.Numero+"'");
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
            List<Direccion> lista = new List<Direccion>();
            NegocioCiudad negocioCiudad = new NegocioCiudad();

            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, IDCiudad, Calle, Numero FROM Direcciones;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Direccion
                    {
                        ID = (int)datos.Lector["ID"],
                        IDCiudad = (int)datos.Lector["IDCiudad"],
                        Calle = (string)datos.Lector["Calle"],
                        Numero = (string)datos.Lector["Numero"],
                    };

                    lista.Add(aux);
                }
                foreach (Direccion item in lista)
                {
                    if (id == item.ID)
                        return "Esta ubicado en " + negocioCiudad.descripcionxid(item.IDCiudad)+ " en la calle: " +item.Calle+ " al "+item.Numero;

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

