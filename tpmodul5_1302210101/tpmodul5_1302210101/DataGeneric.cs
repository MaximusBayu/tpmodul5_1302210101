using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul5_1302210101
{
    internal class DataGeneric<T>
    {
        private T Y;

        public DataGeneric(T Y)
        {
            this.Y = Y;
        }

        public void PrintData() {
            Console.WriteLine("Data yang tersimpan adalah: "+Y);
        }
    }
}
