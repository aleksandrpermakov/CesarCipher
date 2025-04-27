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
            string tmp = "CLOZE";
            Console.WriteLine(cesarCipher.Cipher(ref tmp));
            Console.WriteLine(cesarCipher.unCipher(ref tmp));
        }
    }
}
