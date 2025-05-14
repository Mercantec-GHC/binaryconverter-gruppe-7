using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryConverter
{
    public static class DecimalToBinary
    {

        public static void Run()
        {
            while (true)
            {
                int[] bitVærdier = { 128, 64, 32, 16, 8, 4, 2, 1 };
                int root = ;

                Console.WriteLine("Indtast et binært nummer:"); // tekst efter man kommer ind på opgaven
                string bitInput = Console.ReadLine()!.Replace(" ", ""); // erstatter input med output 


                for (int i = bitInput.Length - 1; i >= 0; i--)
                {
                    bitVærdier += (int)Math.Sqrt(2, root);
                }
            }
        }
    }
}