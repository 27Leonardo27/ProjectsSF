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
        private ILogger logger;

        public Calculator(ILogger logger)
        {
            this.logger = logger;
        }

        public int Sum(int a, int b)
        {
            logger.Log($"Выполнили сложение {a} и {b}");
            return a + b;
        }
    }
}
