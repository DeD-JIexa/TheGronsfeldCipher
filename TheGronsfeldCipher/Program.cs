using System;
using System.Linq;
using System.Text;

namespace TheGronsfeldCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            string alphabet = "АБВГДЕЖЗИЙКЛМНОПРСТУФХЦЧШЩЬЫЪЭЮЯ";
            int[] keys = "2718".Select(ch => (int)Char.GetNumericValue(ch)).ToArray();
            Console.WriteLine("Введите ваше слово:");
            string s =  Console.ReadLine();
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < s.Length; i++)
            {
                sb.Append(alphabet[(alphabet.IndexOf(s[i]) + keys[i % keys.Length]) % alphabet.Length]);
            }
            Console.WriteLine(sb);
        }
    }
}
