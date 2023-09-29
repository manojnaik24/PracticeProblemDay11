using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class DuplicateElements
    {
        public void Duplicat()
        {
            Console.WriteLine("Enter the Size of The array");
            int n=int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            int[] ar = new int[n];
            for (int i=0;i<ar.Length;i++)
            {
                ar[i]= int.Parse(Console.ReadLine());
            }
            int count = 1;

            for (int i=0;i<ar.Length-1; i++)
            {
                if (ar[i] == ar[i+1])
                {

                    count++;
                }
                else
                {
                    Console.WriteLine(ar[i]+" "+count);
                    count = 1;
                }
            }
            Console.WriteLine(ar[ar.Length-1]);

        }
    }
}
