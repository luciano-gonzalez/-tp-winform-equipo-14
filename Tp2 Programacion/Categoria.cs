using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Programacion
{
    internal class Categoria
    {
        public int _idCategoria { get; set; }
        public string _descripcion { get; set; }

        public override string ToString()
        {
            string id = _idCategoria.ToString();
            return id;
        }

        

    }

    
}
