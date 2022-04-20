using System;
using System.Text;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Zehmet olmasa stringi daxil edin");

            string str = Console.ReadLine();

            Console.WriteLine(CapitalizeAllWords(str));
        }

        static  string CapitalizeAllWords(string str)
        {
            var sb = new StringBuilder(str.Length);
            bool inWord = false;
            foreach (var c in str)
            {
                if (char.IsLetter(c))
                {
                    sb.Append(inWord ? char.ToLower(c) : char.ToUpper(c));
                    inWord = true;
                }
                else
                {
                    sb.Append(c);
                    inWord = false;
                }
            }
            return sb.ToString();


        }
    }
}
