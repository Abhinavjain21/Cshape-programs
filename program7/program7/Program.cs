using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a String");
            String str=Console.ReadLine();
            String str1 =String.Empty;
            str=str.ToLower();
            char[] ch=str.ToCharArray();
             for(int i = 0; i < ch.Length; i++)
            {
                
                if (i == 0 || i == ch.Length - 1)
                {
                    ch[i] = char.ToUpper(ch[i]);
                }
                else if (ch[i] ==' ')
                {
                    if (i - 1 >= 0)
                    {
                        ch[i - 1] = char.ToUpper(ch[i - 1]);
                    }
                    if (i + 1 >= 0)
                    {
                        ch[i + 1] = char.ToUpper(ch[i + 1]);
                    }
                }
                
            }
            String result = new string(ch);
            Console.WriteLine(result);
            Console.ReadLine();


            
        }
    }
}
