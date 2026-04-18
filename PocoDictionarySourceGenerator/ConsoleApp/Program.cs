using System;
using System.Text;
using Foxy.PocoDictionary;

// ReSharper disable UnusedParameter.Local

namespace ConsoleApp
{
    partial class Program
    {
        static void Main()
        {
            Console.WriteLine("Baz fields:");
            var foo = new Baz { Foo = 42, Bar = "Hello", Date = new DateTime(2024, 1, 1) };
            foreach (var kv in foo)
            {
                Console.WriteLine($"{kv.Key}: {kv.Value}");
            }
        }
    }

    [PocoDictionary]
    public partial class Foo
    {
        public string Bar { get; set; }
    }

    public partial class Baz
    {
        public int Foo { get; set; }
        public string Bar { get; set; }
        public DateTime Date { get; set; }
    }
}
