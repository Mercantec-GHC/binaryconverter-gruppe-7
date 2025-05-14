using System;

namespace Binary
{
    public static class BinaryToDecimal
    {
        public static void Run()
        {
            while (true)
            {
                Console.WriteLine("Indtast et binært nummer:");
                string binaryInput = Console.ReadLine()!.Replace(" ", "");

                int decimalValue = 0;
                int power = 0;

                // Læs binært tal bagfra
                for (int i = binaryInput.Length - 1; i >= 0; i--)
                {
                    if (binaryInput[i] == '1')
                    {
                        decimalValue += (int)Math.Pow(2, power);
                    }
                    power++;
                }

                Console.WriteLine($"Decimal-tallet er: {decimalValue}\n");
            }
        }
    }
}
