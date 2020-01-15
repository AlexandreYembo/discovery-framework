using System;
using System.Linq;
using Discovery.Framework.Extensions.Linq;

namespace Discovery.Implementation
{
    class Program
    {
        static void Main(string[] args)
        {
            var myList = new SetupModel().Setup();
            var myDistictList = myList.DistinctBy(d => d.Name).ToList();
        

            Console.WriteLine("Hello World!");
        }
    }
}
