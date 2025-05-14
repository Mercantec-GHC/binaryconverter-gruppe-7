using System;

namespace Binary
{
    public static class BinaryToDecimal
    {
        public static void Run() // start
        {
            while (true)
            {
                Console.WriteLine("Indtast et binært nummer:"); // tekst efter man kommer ind på opgaven
                string binaryInput = Console.ReadLine()!.Replace(" ", ""); // erstatter input med output

                int decimalValue = 0; 
                int power = 0; // Eksponenten altså som i 2^0

                for (int i = binaryInput.Length - 1; i >= 0; i--) // Læs binært tal bagfra
                {
                    if (binaryInput[i] == '1') // If statement gælder kun for 1 tallerne
                    {
                        decimalValue += (int)Math.Pow(2, power); // For alle 1'erne til at stige exponentielt
                    }
                    power++; // Sørger for at det også er 0'erne der stiger eksponentielt
                }

                Console.WriteLine($"Decimal-tallet er: {decimalValue}\n"); // viser ens decimal og sikrer man ikke går ud til hovedmenu igen
            } // Der er ikke et krav om at det skal være 8 bits specifikt, bare at det er 1 og 0. Derfor kan man godt gå over 255.
        }
    }
}
