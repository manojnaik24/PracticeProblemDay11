using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class Frequency
    {
        public void Fun()
        {
           
                Console.WriteLine("Enter the Size of The array");
                int n = int.Parse(Console.ReadLine());

                Console.WriteLine("Enter the elements");
                int[] ar = new int[n];
                for (int i = 0; i < ar.Length; i++)
                {
                    ar[i] = int.Parse(Console.ReadLine());
                }

                // Count the frequency of each element
                Dictionary<int, int> elementFrequency = CountElementFrequency(ar);

                // Print the result
                Console.WriteLine("Element frequencies:");
                foreach (var kvp in elementFrequency)
                {
                    Console.WriteLine($"Element {kvp.Key}: {kvp.Value} times");
                }

                Console.ReadLine(); // Wait for user input before closing the console window
            

           
        }
       public static Dictionary<int, int> CountElementFrequency(int[] arr)
        {
            Dictionary<int, int> elementFrequency = new Dictionary<int, int>();

            foreach (int num in arr)
            {
                if (elementFrequency.ContainsKey(num))
                {
                    elementFrequency[num]++;
                }
                else
                {
                    elementFrequency[num] = 1;
                }
            }

            return elementFrequency;
        }

    }
}

