using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace palindrome
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            String name=Console.ReadLine();
            String rev =String.Empty;
            char[] chr= name.ToCharArray();
            for(int i=chr.Length-1;i>=0;i--)
            {
                rev = rev + chr[i];
            }
            if(rev==name)
            {
                Console.WriteLine("String is Palindrome {0}", name);
            }
            else
            {
                Console.WriteLine("String is not Palindrome");
            }
          
            Console.ReadLine();
        }
    }
}
