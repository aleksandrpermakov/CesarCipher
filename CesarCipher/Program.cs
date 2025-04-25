using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CesarCipher cesarCipher = new CesarCipher();
            Console.WriteLine(cesarCipher.Alphabet);
            Console.WriteLine("Шифрование");
            foreach (var symbol in cesarCipher.Alphabet)
            {
                Console.WriteLine($"{symbol} = {cesarCipher.Cipher(symbol)}");
            }
            Console.WriteLine("Дешифровка");
            foreach (var symbol in cesarCipher.Alphabet)
            {
                Console.WriteLine($"{symbol} = {cesarCipher.unCipher(symbol)}");
            }
        }
    }
}
