using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class SumOfNumber
    {
        public void sum()
        {
            Console.WriteLine("Entre the Number");
            int n=int.Parse(Console.ReadLine());
            int[]m=new int[n];
            int sum = 0;
            for (int i = 0; i < m.Length; i++) 
            {
                Console.WriteLine($"Enter number {i + 1}: ");
                m[i] = int.Parse(Console.ReadLine());
                sum = sum + m[i];
            }
            Console.WriteLine("Sum:");

            Console.WriteLine(sum);


            
        }
    }
}
