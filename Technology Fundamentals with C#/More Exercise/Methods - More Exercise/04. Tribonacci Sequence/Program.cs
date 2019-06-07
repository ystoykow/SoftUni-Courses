using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04._Tribonacci_Sequence
{
    class Program
    {
        static void Main(string[] args)
        {
            //1 1 2 4 7 13 24 44
            int numbers = int.Parse(Console.ReadLine());
            ulong n = 1;
            ulong m = 1;
            ulong k = 0;
            ulong j = 0;
            {
                for (int i = 0; i < numbers; i++)
                {
                    n = m;
                    m = k;
                    k = j;
                    j = n + m + k;
                    Console.Write("{0} ", j);
                }
            }
        }
    }
}
