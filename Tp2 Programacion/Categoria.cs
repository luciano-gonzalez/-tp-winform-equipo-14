﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Programacion
{
    public class Categoria
    {
        public int _idCategoria { get; set; }
        public string _descripcion { get; set; }

        public override string ToString()
        {
            return _descripcion;
        }

        

    }

    
}
