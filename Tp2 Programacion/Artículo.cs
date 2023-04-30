using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Programacion
{
    internal class Artículo
    {
        public string _codArticulo { get; set; }
        public string _descripcion { get; set; }
        public string _nombre { get; set; }
        public Categoria _categoria { get; set; }
        public Marca _marca { get; set; }

        //public List<string> _imagen;
        public float _precio { get; set; }


    }
}
