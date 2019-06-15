using System;
using System.Linq;

namespace YumiChanDBCore
{
    internal static class Program
    {
        private static void Main()
        {
            Unity.RegisterTypes();

            Console.WriteLine("Hiya Discord!");
        }
    }
}
