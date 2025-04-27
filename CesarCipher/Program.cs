using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Text;
using System.Threading.Tasks;

namespace CesarCipher
{
    internal class Program
    {
        static public void WriteCipherToFile(string ciphertext) // метод записи в фаил
        {
            System.IO.StreamWriter sr = new StreamWriter("cipher.txt", true);
            try
            {
                sr.WriteLine(ciphertext);
                sr.Close();
                Console.WriteLine("Шифр успешно записан в фаил - \"cipher.txt\"");
            }
            catch
            {
                Console.WriteLine("Ошибка записи в фаил!");
            }
 
        }
        static void Main(string[] args)
        {
             //     ШИФРОВАНИЕ

            CesarCipher cesarCipher = new CesarCipher();
            string text = string.Empty;
            Console.WriteLine("Введите текст который хотите зашифровать:");
            text = Console.ReadLine();
            Console.WriteLine("Введите ключ с которым будет происходить шифровка:");
            int key = 3;
            string tmp = string.Empty;
            tmp = Console.ReadLine();
            if (int.TryParse(tmp,out key)) // если ключ число
            {
                cesarCipher.SetKey(key);// установка ключа
                Console.WriteLine("Вы хотите зашифровать ключ используя всю таблицу Аски? /n" +
                    "Если нет введите <<нет>> и шифровка будет происходить используя ваш текст; ");
                string alphabet = string.Empty;
                string answer = string.Empty;
                answer = Console.ReadLine();
                if (answer == "нет")
                {
                    Console.WriteLine("Введите полный текст(набор символов) с помощью которого будет происходить шифрование");
                    alphabet = Console.ReadLine();
                    cesarCipher.SetAlphabet(alphabet); // установка алфавита шифрования
                    Console.WriteLine($"Зашифрованный текст: {cesarCipher.Cipher(ref text)}.");
                    WriteCipherToFile(text);
                }
                else
                {
                    Console.WriteLine($"Зашифрованный текст: { cesarCipher.Cipher(ref text)}."); //шифрования на основе всей аски таблицы
                    WriteCipherToFile(text);
                }
            }
            else
            {
                Console.WriteLine("Вы ввели не ключ не корректно!");
            }

            //         РАСШИФРОВКА
            Console.WriteLine("Введите текст который хотите Расшифровать:");
            text = Console.ReadLine();
            Console.WriteLine("Введите ключ с которым будет происходить ДЕшифровка:");
            tmp = Console.ReadLine();
            if (int.TryParse(tmp, out key))
            {
                cesarCipher.SetKey(key);
                Console.WriteLine($"Расшифрованный текст: {cesarCipher.unCipher(ref text)}.");

            }
            else
            {
                Console.WriteLine("Вы ввели не ключ не корректно!");
            }
        }
    }
}
