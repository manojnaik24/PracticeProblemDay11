using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class MaxAndMin
    {
        public void Max()
        {
            Console.WriteLine("Enter the Size of The array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            int[] ar = new int[n];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }
            int max = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] > max)
                {
                    max = ar[i];
                    

                }
                Console.WriteLine(max);

            }

        }
        public void Min()

        {
            Console.WriteLine("Enter the Size of The array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the element");
            int[] ar = new int[n];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            int min = 0;
            for (int i = 0; i < ar.Length; i++)
            {
                if (ar[i] < min)
                {
                    min = ar[i];
                }
                Console.WriteLine(min);

            }
        }
    }
}
