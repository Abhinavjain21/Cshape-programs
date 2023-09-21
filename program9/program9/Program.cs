using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the String To Find The Largest word:");
            String str=Console.ReadLine();
            String[] words = str.Split(new[] {" "},StringSplitOptions.None);
            String word = " ";
            int n = 0;
            foreach(String s in words)
            {
                if(s.Length>n)
                {
                    word = s;
                    n = s.Length;
                }
            }
            Console.WriteLine(word);
            Console.ReadLine();
        }
    }
}
