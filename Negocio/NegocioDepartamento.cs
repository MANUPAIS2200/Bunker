using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dominio;

namespace Negocio
{
    public class NegocioDepartamento
    {
        
        public List<Departamento> listar()
        {
            List<Departamento> lista = new List<Departamento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Departamentos");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Departamento
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

        public void agregar(Departamento nuevo)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                string valores = "values('" + nuevo.Descripcion + "')";
                datos.setearConsulta("insert into Departamentos (Descripcion)" + valores);
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

        public void modificar(Departamento departamento)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("Update Departamentos SET Descripcion='" + departamento.Descripcion + "' WHERE ID=" + departamento.ID);
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
            List<Departamento> lista = new List<Departamento>();
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setearConsulta("SELECT ID, Descripcion FROM Departamentos;");
                datos.ejecutarLectura();

                while (datos.Lector.Read())
                {
                    var aux = new Departamento
                    {
                        ID = (int)datos.Lector["ID"],
                        Descripcion = (string)datos.Lector["Descripcion"],
                    };

                    lista.Add(aux);
                }
                foreach (Departamento item in lista)
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

