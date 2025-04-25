using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher
{
    internal class CesarCipher
    {
        string alphabet = string.Empty;
        int key = 3;
        public string Alphabet { get { return alphabet; } }
        public CesarCipher()
        {
            for (char i = 'A'; i <= 'Z'; i++)
            {
                alphabet += i;
            }
        }
        public char Cipher(char symbol)
        {
            char cipher_symbol = symbol;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (symbol == alphabet[i])
                {
                    if(i < alphabet.Length - key) 
                    {
                        cipher_symbol = alphabet[i + key];
                    }
                    else
                    {
                        cipher_symbol = 
                            alphabet[(i - alphabet.Length) + key];
                    }
                }
            }
            return cipher_symbol;
        }
        public char unCipher(char symbol)
        {
            char uncipher_symbol = symbol;
            for (int i = 0; i < alphabet.Length; i++)
            {
                if (symbol == alphabet[i])
                {
                    if (i >= key)
                    {
                        uncipher_symbol = alphabet[i - key];
                    }
                    else
                    {
                        uncipher_symbol =
                            alphabet[(i + alphabet.Length) - key];
                    }
                }
            }
            return uncipher_symbol;
        }
    }
}
