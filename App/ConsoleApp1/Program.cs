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
            var docments = dbContext.SrDirectoryPorts.ToList();
            Console.WriteLine("Documents count");
            Console.WriteLine(docments.Count());
        }
    }
}
