﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio
{
  public  class Insumo
    {
        public int ID { get; set; }
        public int IDEmpresa { get; set; }
        public string Codigo { get; set; }
        public int IDEtapa { get; set; }
        public string Descripcion { get; set; }
    }
}
