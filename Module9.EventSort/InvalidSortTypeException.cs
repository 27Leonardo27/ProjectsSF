using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module9.EventSort
{
    internal class InvalidSortTypeException : Exception
    {
        public InvalidSortTypeException(string message)
            : base(message) 
        {

        }
    }
}
