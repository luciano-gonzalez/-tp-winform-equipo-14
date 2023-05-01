using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tp2_Programacion
{
    public class Tabla
    {
        public int Id_Articulo { get; set; }
        public string Nombre_Articulo { get; set; }
        public string Detalles { get; set; }
        public Tabla()
        {
            Detalles = "ver detalle";
        }

        

    }
}
