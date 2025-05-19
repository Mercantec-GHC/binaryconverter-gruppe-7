using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Binary
{
    //using System;
    internal class teSt;


    public static class BtoD
    {
        public static void Run()
        {
            Console.Write("Enter a 32-bit binary string (e.g., 11000000101010000000000100000001): ");
            string binaryInput = Console.ReadLine();

            if (binaryInput.Length != 32 || !IsBinary(binaryInput))
            {
                Console.WriteLine("Invalid input! Please enter exactly 32 binary digits (0 or 1).");
                return;
            }

            string ipAddress = "";

            for (int i = 0; i < 4; i++)
            {
                string octetBinary = binaryInput.Substring(i * 8, 8);
                int octetDecimal = 0;

                // Manual binary to decimal conversion
                for (int j = 0; j < 8; j++)
                {
                    if (octetBinary[j] == '1')
                    {
                        int power = 7 - j;
                        octetDecimal += (int)Math.Pow(2, power);
                    }
                }

                ipAddress += octetDecimal.ToString();
                if (i < 3) ipAddress += ".";
            }

            Console.WriteLine("IP Address: " + ipAddress);
        }

        static bool IsBinary(string input)
        {
            foreach (char c in input)
            {
                if (c != '0' && c != '1')
                    return false;
            }
            return true;
        }
    }
}