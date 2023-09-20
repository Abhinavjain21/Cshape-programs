using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String to remove all the whitespaces from it");
            String str=Console.ReadLine();
            String str1=String.Empty;
            for(int i=0;i<str.Length;i++)
            {
                if (str[i]==' ')
                {

                }
                else
                {
                    str1=str1+ str[i];
                }
            }
            Console.WriteLine(str1);
            Console.ReadLine();

        }
    }
}
