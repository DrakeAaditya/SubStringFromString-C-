using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace substring_from_string
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            int c = 0;
            Console.WriteLine("Enter the String > ");
            String str = Console.ReadLine();
            int a = str.Length;
            Console.WriteLine("Enter the Substring > ");
            String sub = Console.ReadLine();
            int b = sub.Length;

            for (int i = 0; i < a; i++)
            {
                int j = 0;
                if (str[i] == sub[j])
                {
                    count++;

                    j++;
                }
                if (count == b)
                {

                    c++;
                    count = 0;
                }

            }
            Console.WriteLine(c);
            Console.ReadLine();
        }
    }
}