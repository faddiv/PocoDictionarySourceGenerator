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
            Console.WriteLine("Types in this assembly:");
            foreach (Type t in typeof(Program).Assembly.GetTypes())
            {
                Console.WriteLine(t.FullName);
            }
        }
    }

    [PocoDictionary]
    public partial class Foo
    {
        public string Bar { get; set; }
    }
}
