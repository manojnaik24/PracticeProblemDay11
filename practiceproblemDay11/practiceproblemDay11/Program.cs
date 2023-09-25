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
                "\n2. Square pattern"+
                "\n3. Reverse String"+
                "\n4. Sum of Number"+
                "\n0. Exit");
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

                        case 2:
                        SquarPattercs s=new SquarPattercs();
                        s.Square();
                        break;

                        case 3:
                        ReverseString r=new ReverseString();
                        r.Reverse();
                        break;
                        
                        case 4:
                        SumOfNumber ss=new SumOfNumber();
                        ss.sum();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
