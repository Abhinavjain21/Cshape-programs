using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the first String");
            String str=Console.ReadLine();
            str=str.ToUpper();
            Console.WriteLine("Enter the Second String");
            String str1=Console.ReadLine();
            str1=str1.ToUpper();    
            char[] ch= str.ToCharArray();
            char[] ch1=str1.ToCharArray();
            Array.Sort(ch);
            Array.Sort(ch1);

            for(int i = 0; i < ch.Length; i++)
            {
                if (ch[i] != ch1[i])
                {
                    Console.WriteLine("false");
                    Console.ReadLine();
                }
                else
                {
                    Console.WriteLine("true");
                    Console.ReadLine();
                }
            }
        }
    }
}
