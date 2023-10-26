using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notas
{
    internal class boletim
    {
        public double NotaUM;
        public double NotaDois;
        public double NotaTres;

        public double Somar()
        {
            return NotaUM + NotaDois + NotaTres;
    }
        public double Falta()
        {
            return 60 - Somar() ;
        }

    }
}
