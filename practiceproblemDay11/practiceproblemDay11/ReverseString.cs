using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceproblemDay11
{
    internal class ReverseString
    {
        public void Reverse()
        {
            Console.WriteLine("Enter name");
            string st=Console.ReadLine();
            char[] tr = st.ToCharArray();

            for (int i = st.Length-1; i >=0 ; i--)
            {
                char c = tr[i];
                Console.WriteLine(c);
            }
            
            
           
        }
    }
}
