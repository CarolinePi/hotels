using System;
using ClassLibrary1;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Loader loader = new Loader();
            Console.WriteLine("\n");
            loader.DemonstrateUpcastingAndDowncasting();
            Console.WriteLine("\n");
            loader.DemonstrateRoomSumOperatoroverloading();
            Console.WriteLine("\n");
            loader.DemonstrateDelegate();
            Console.WriteLine("\n");
            loader.DemonstrateSystemExceptione();
            Console.WriteLine("\n");
            loader.DemonstratePriceExceptione();

        }
    }
}
