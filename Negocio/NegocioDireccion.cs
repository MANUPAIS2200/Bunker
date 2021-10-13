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

        //    public void agregar(Empresa nuevo)
        //    {
        //        AccesoDatos datos = new AccesoDatos();
        //        try
        //        {

        //            string valores = "values(" + nuevo.IDDireccion + ", " + nuevo.IDCategoriaEmpresa + ", '" + nuevo.RazonSocial + "','" + nuevo.Telefono + "')";
        //            datos.setearConsulta("insert into Empresas (IDDireccion, IDCategoriaEmpresa,RazonSocial, Telefono) " + valores);
        //            datos.ejectutarAccion();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            datos.cerrarConexion();
        //        }
        //    }

        //    public void modificar(Empresa empresa)
        //    {
        //        AccesoDatos datos = new AccesoDatos();
        //        try
        //        {
        //            datos.setearConsulta("Update Empresas SET IDDireccion=" + empresa.IDDireccion + ", IDCategoriaEmpresa=" + empresa.IDCategoriaEmpresa + ", RazonSocial= '" + empresa.RazonSocial + " ', Telefono= '" + empresa.Telefono);
        //            datos.ejectutarAccion();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            datos.cerrarConexion();
        //        }
        //    }

        //    public void eliminar(int id)
        //    {
        //        AccesoDatos datos = new AccesoDatos();
        //        try
        //        {
        //            datos.setearConsulta("UPDATE Empresas SET baja=1 Where Id = " + id);
        //            datos.ejectutarAccion();
        //        }
        //        catch (Exception ex)
        //        {
        //            throw ex;
        //        }
        //        finally
        //        {
        //            datos.cerrarConexion();
        //        }
        //    }

        //    public string descripcionxid(int id)
        //    {
        //        string descripcion = null;
        //        List<Empresa> lista = new List<Empresa>();
        //        AccesoDatos datos = new AccesoDatos();
        //        try
        //        {
        //            datos.setearConsulta("SELECT ID, RazonSocial FROM Empresas;");
        //            datos.ejecutarLectura();

        //            while (datos.Lector.Read())
        //            {
        //                var aux = new Empresa
        //                {
        //                    ID = (int)datos.Lector["ID"],
        //                    RazonSocial = (string)datos.Lector["RazonSocial"],
        //                };

        //                lista.Add(aux);
        //            }
        //            foreach (Empresa item in lista)
        //            {
        //                if (id == item.ID)
        //                    return item.RazonSocial;

        //            }

        //        }
        //        catch (Exception ex)
        //        {

        //            throw ex;
        //        }
        //        finally
        //        {
        //            datos.cerrarConexion();
        //        }

        //        return descripcion;
        //    }

    }


}

