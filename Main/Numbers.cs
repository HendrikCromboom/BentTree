using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BentTree.Main
{
    static class Numbers
    {
        private static List<int> Fibonacci(int size)
        {
            List<int> result = new List<int>();
            int n = 1;
            for(var i = 0; i < size; i++)
            {
                n += result[i];
                result.Add(n);
            }
            return result;
        }
        public static int Accuracy(int size)
        {

        }
    }
}
