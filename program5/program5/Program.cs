using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String:");
            String str=Console.ReadLine();
            String str2 =String.Empty;
            string la = "abcdefghijklmnopqrstuvwxyz";
            string ua = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            for (int i=0; i<str.Length; i++) 
            {
                if (la.Contains(str[i]) || ua.Contains(str[i]))
                {
                    str2 = str2 + str[i];
                }
                
            }
            Console.WriteLine(str2);
            Console.ReadLine();
        }
    }
}
