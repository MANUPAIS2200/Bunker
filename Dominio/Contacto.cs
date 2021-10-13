using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public  class Contacto
    {
        public int ID { get; set; }
        public int IDEmpresa{ get; set; }
        public int IDDireccion { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Telefono { get; set; }
        public string Mail { get; set; }
        public string Descripcion { get; set; }
    }
}
