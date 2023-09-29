using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class PrintUniqeNumber
    {
        public void Print()
        {

            Console.WriteLine("Enter the Size of The array");
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements");
            int[] ar = new int[n];
            for (int i = 0; i < ar.Length; i++)
            {
                ar[i] = int.Parse(Console.ReadLine());
            }

            // Print unique elements
            Console.WriteLine("Unique elements:");
            PrintUniqueElements(ar);

            Console.ReadLine(); 



        }
        public static void PrintUniqueElements(int[] arr)
        {
            HashSet<int> uniqueElements = new HashSet<int>();

            foreach (int num in arr)
            {
                if (!uniqueElements.Contains(num))
                {
                    Console.WriteLine(num);
                    uniqueElements.Add(num);
                }
            }
        }

    }
}

