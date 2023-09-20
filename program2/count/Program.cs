using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace count
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            String str=Console.ReadLine();
           
            int cv = 0,cc=0,sc=0;
            foreach (char c in str)
            {
                if ((c >= 'a' && c <= 'z') || (c >= 'A' && c <= 'Z'))
                {
                    if (c == 'a' || c == 'e' || c == 'i' || c == 'o' || c == 'u')
                    {
                        cv++;
                    }
                    else if (c == 'A' || c == 'E' || c == 'I' || c == 'O' || c == 'U')
                    {
                        cv++;
                    }
                    else
                    {
                        cc++;
                    }

                }
               
            }
                for(int i = 0; i < str.Length; i++)
                {
                    if (str[i]== ' ')
                    {
                        sc++;
                    }
                }
            Console.WriteLine("Total number of vowels,spaces and consonents are: {0} {1} {2}", cv, sc,cc);
            Console.ReadLine();
        }
    }
}
