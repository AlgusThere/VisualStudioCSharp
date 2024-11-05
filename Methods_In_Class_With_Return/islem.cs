using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Methods_In_Class_With_Return
{
    internal class islem
    {
        public int topla(int a , int b)
        {
            int c = a + b;
            Console.WriteLine(c);
            return c;
        }
        
        public int cikart(int a , int b)
        {
            int c = a - b;
            Console.WriteLine(c);
            return c;
        }
    }
}
