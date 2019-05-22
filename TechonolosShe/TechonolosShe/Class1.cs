using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechonolosShe
{
    public class Class1
    {
        long valor = 0;
        public long metodo()
        {
            for (long i=0; i<100000000; i ++)
            {
                valor += i;
            }
            return valor;
        }
    }
}
