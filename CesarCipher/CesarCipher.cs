﻿using System;
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
        public void SetKey(int key) { this.key = key; }
        public void SetAlphabet(string alphabet) { this.alphabet = alphabet; }
        public string Alphabet { get { return alphabet; } }
        public CesarCipher()
        {
            for (char i = '!'; i <= 'я'; i++) //для шифра будет применяться вся аски таблица
            {
                alphabet += i;
            }
        }
        public string Cipher(ref string  text)
        {
            string cipher_text = string.Empty;
            for (int i = 0; i < text.Length; i++)
            {
                for (int j = 0; j < alphabet.Length; j++)
                {
                    if (alphabet[j] == text[i])
                    {
                        if (j < alphabet.Length - key)
                        {
                            cipher_text += alphabet[j + key];
                            break;
                        }
                        else
                        {
                            cipher_text += alphabet[(j - alphabet.Length) + key];
                            break;
                        }
                    }
                }
            }
            text = cipher_text;
            return text;
        }
        public string unCipher(ref string ciphertext)
        {
            string uncipher_text = string.Empty;
            for(int j =  0; j < ciphertext.Length; j++)
            { 
                 for (int i = 0; i < alphabet.Length; i++)
                 {
                    if (alphabet[i] == ciphertext[j])
                    {
                        if ((i - key) < 0)
                        {
                            uncipher_text += alphabet[(i + alphabet.Length) - key];
                            break;
                        }
                        else
                        {
                            uncipher_text += alphabet[(i - key)];
                            break;
                        }
                    }
                 }
            }
            ciphertext = uncipher_text;
            return ciphertext;
        }
    }
}
