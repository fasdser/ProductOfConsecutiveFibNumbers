using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductOfConsecutiveFibNumbers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(productFib(4895));
            Console.WriteLine();
            Console.ReadKey();
        }

        public static ulong[] productFib(ulong prod)
        {
            ulong[] result = { 0, 1, 0 };
            ulong next = 1;
            while (result[0] * result[1]<prod)
            {
                next = result[0] + result[1];
                result[0]=result[1];
                result[1] = next;
            }
            if (result[0] * result[1]==prod)
            {
                result[2] = 1;
            }
            return result;
        }
    }
}
