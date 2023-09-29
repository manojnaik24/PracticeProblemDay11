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
                "\n4. Sum Of Each Row"+
                "\n6. Printing Duplicat Element "+
                "\n7. Printing Uniqe Number"+
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

                        case 5:
                        SumOfEachRow sum=new SumOfEachRow();
                        sum.SumOf();
                        break;

                        case 6:
                        DuplicateElements duplicate=new DuplicateElements();
                        duplicate.Duplicat();
                        break;

                        case 7:
                        PrintUniqeNumber printUniqeNumber=new PrintUniqeNumber();
                        printUniqeNumber.Print();
                        break;
                }
            }
            Console.ReadLine();
        }
    }
}
