using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CodeScanTest
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Saying hello: " + i + " times.");
            }
            Console.ReadLine();
            RunQeury(5, "empty");
            string queryTest = "select * from dbo.people where rowid=" + args[0];
            Console.WriteLine(queryTest);
            if (args[0].Equals("No"))
            {
                Console.WriteLine("Matched");
            }
        }

        static void RunQeury(int a,string value)
        {
            string queryTest = "select * from dbo.people where rowid=" + a;
            Console.WriteLine(queryTest);
            if(value.Equals("No"))
            {
                Console.WriteLine("Matched");
            }
        }
    }
}
