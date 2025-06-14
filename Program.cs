using System;
using System.Linq;

namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var db = new HomeBills();
            Console.WriteLine(db.OtherBills.ToList().Count);
        }
    }
}
