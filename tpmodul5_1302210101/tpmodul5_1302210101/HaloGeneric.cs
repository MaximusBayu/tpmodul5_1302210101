using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302210101
{
    internal class HaloGeneric<T>
    {
        public void sapaUser(T X) { 
            Console.WriteLine("Halo user "+X);
        }
    }

}
