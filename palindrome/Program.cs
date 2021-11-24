using System;
namespace palindrome_words
{
    class Program
    {

        static void Main(string[] args)
        {
            Program program = new Program();

            if (program.Check("ABCDEFEDCBAA"))
            {
                Console.WriteLine("Kelime Bir Palindrom.");
            }
            else
            {
                Console.WriteLine("Kelime Bir Palindrom Değildir.");
            }
        }
        public bool palindromeCheck(string phrase)
        {
            char[] chars = phrase.ToCharArray();
            for (int i = 0; i < phrase.Length; i++)
            {
                if (phrase[i] != phrase[phrase.Length - i - 1])
                {
                    return false;
                }
            }
            return true;
        }
        bool Check(string word)
        {

            if (string.IsNullOrEmpty(word))
            {
                return false;
            }
            else
            {
                return (palindromeCheck(word));
            }
        }
    }
}