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
        public string Cipher(string text)
        {
            string cipher_text = string.Empty;
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < text.Length; j++)
                {
                    if (i < alphabet.Length - key)
                    {
                        cipher_text += alphabet[i + key];
                        break;
                    }
                    else
                    {
                        cipher_text += alphabet[(i - alphabet.Length) + key];
                        break;
                    }
                }
               
                
            }
            return cipher_text;
        }
        public string unCipher(string ciphertext)
        {
            string uncipher_text = string.Empty;
            for (int i = 0; i < alphabet.Length; i++)
            {
                for (int j = 0; j < ciphertext.Length; j++)
                {
                    if (i >= key)
                    {
                        uncipher_text += alphabet[i - key];
                        break;
                    }
                    else
                    {
                        uncipher_text += alphabet[i] ;
                        break;
                    }
                }
                
                
            }
            return uncipher_text;
        }
    }
}
