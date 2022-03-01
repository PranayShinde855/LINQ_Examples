using System;
using System.Linq;

namespace LINQ_Practice_Array
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] myarr = { "Pranay", "Shinde", "Test" };

            var getName = from p in myarr
                          where p.Contains("a")
                          select p;

            foreach(var v in getName)
            {
                Console.WriteLine(v);
            }

            
        }
    }
}
