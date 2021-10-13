using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public  class Consumible
    {
        public int ID { get; set; }
        public int IDIngreso { get; set; }
        public string Descripcion { get; set; }
        public float Cantidad { get; set; }
    }
}
