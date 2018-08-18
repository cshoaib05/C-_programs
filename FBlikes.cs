using System;
using System.Collections.Generic;

namespace FB
{
    class FB
    {
        static void Main(string[] arg)
        {
            int i=0;
            var Names = new List<String>();
            Console.WriteLine("ENTER THE NAMES");
            while (true)
            {
               Names.Add(Console.ReadLine());
                if (String.IsNullOrWhiteSpace(Names[i]))
                {
                    break;
                }
                i++;
            }
            Console.WriteLine(Names.Count);
            switch (Names.Count)
            {
                case 2:
                    Console.WriteLine(Names[0] + " Like Your Post");
                    break;
                case 3:
                    Console.WriteLine(Names[0] + " " + Names[1] + " Likes your Post");
                    break;
                default:
                    Console.WriteLine(Names[0] + " " + Names[1] + "and " + ((Names.Count)-2) + " Likes your Post");
                    break;
            }
        }
    }
}