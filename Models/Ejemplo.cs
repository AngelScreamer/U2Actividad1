using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Unidad2Actividad1.Models
{
    public class Ejemplo
    {
        public int Numero1 { get; set; }
        public int Numero2 { get; set; }
        private int res;

        public int Res
        {
            get { return res = Numero1 + Numero2; }
            set { res = value; }
        }

    }
}
