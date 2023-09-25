using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class PrintingReversPattern
    {
        public void Printing()
        {
            Console.WriteLine("Enter The Number:");
            int n = int.Parse(Console.ReadLine());

            for (int i = n; i >= 1; i--)
            {
                for (int j = 1; j <= n - i; j++)
                {
                    Console.WriteLine("");
                }

                for (int k = 1; k <= 2 * i - 1; k++)
                {
                    Console.Write("*");
                }
            }
        }
    }
}
