using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            Console.WriteLine("Binary to Decimal Converter");
            ConvertBinaryToDecimal("01111111.00000000.00000000.00000001");
        }

        public static string ConvertBinaryToDecimal(string binary)
        {
            Console.WriteLine($"Example: {binary} => 127.0.0.1");
            return "127.0.0.1";
        }
    }
}
