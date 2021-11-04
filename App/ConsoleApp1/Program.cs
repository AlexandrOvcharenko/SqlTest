using ConsoleApp1.Models;
using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var dbContext = new SR_SEARCHContext();
            var docments = dbContext.SrDirectoryTypedocuments.ToList();
            Console.WriteLine("Test id", docments.Count());
        }
    }
}
