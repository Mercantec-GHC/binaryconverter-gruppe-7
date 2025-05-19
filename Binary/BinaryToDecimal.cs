
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            //Console.WriteLine("Binary to Decimal Converter");
            Console.Write("Enter a binary number: ");
            string binaryInput = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToDecimal(binaryInput));
            Console.Write("Enter a binary number: ");
             string binaryInput2 = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToDecimal(binaryInput2));
            Console.Write("Enter a binary number: ");
            string binaryInput3 = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToDecimal(binaryInput3));
            Console.Write("Enter a binary number: ");
            string binaryInput4 = Console.ReadLine();
            Console.WriteLine(ConvertBinaryToDecimal(binaryInput4));

            

        }

        public static int ConvertBinaryToDecimal(string binaryInput)
        {
            // binaryString = 10101010 => 170 - 128 + 32 + 8 + 2
            // 128, 64, 32, 16, 8, 4, 2, 1
            List<int> powerOfTwos = new List<int>() { 128, 64, 32, 16, 8, 4, 2, 1 };
            int sum = 0;
            for (int i = 0; i < binaryInput.Length; i++)
                //string ipAddress = "";
            {
                //Console.WriteLine("i" + i);
                int Number = binaryInput[i] - '0';
                //Console.WriteLine(Number);

                int PowerOfTwo = powerOfTwos[i];
                //Console.WriteLine(PowerOfTwo);

                sum += Number * PowerOfTwo;

               

                
            }
            






            Console.WriteLine($"Example: {binaryInput} => {sum}");
            return sum;
        }
    }
}
