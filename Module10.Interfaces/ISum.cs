using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module10.Interfaces
{
    interface ISum
    {
        int Sum(int a,  int b);
        
    }

    class Calculator : ISum
    {
        public int Sum(int a, int b)
        {
            return a + b;
        }
    }
}
