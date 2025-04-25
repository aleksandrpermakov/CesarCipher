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
            string tmp = cesarCipher.Alphabet; // проверяю как шифрует алфавит
            Console.WriteLine(cesarCipher.Cipher(tmp));
            tmp = cesarCipher.Cipher(tmp);
            Console.WriteLine("Дешифровка");
            Console.WriteLine(cesarCipher.unCipher(tmp));
        }
    }
}
