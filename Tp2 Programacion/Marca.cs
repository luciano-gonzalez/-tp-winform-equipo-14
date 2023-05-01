using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Programacion
{
    internal class Marca
    {
        public int _idMarca { get; set; }
        public string _nombre { get; set; }

        public override string ToString()
        {
            string id = _idMarca.ToString();
            return id;
        }

    }
}
