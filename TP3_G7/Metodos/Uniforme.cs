using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP3_G7.Metodos
{
    public class Uniforme
    {
        public long AleatorioUniforme(long cotainf, long cotasup)
        {
            double random = new Random().NextDouble();
            long result = (long)(cotainf + random * (cotasup - cotainf));
            return result;
        }
    }
}
