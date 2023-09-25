using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Problem Number");
            Console.WriteLine("1. Printing Rever triangle" +
                "0. Exit");
            int m=int.Parse(Console.ReadLine());
            if(m==0)
            {
                Console.WriteLine("Enter The Valid Input");
                return;
            }
            else
            {
                switch(m)
                {
                    case 1:
                        PrintingReversPattern p=new PrintingReversPattern();
                        p.Printing();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
