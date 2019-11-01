using System;

namespace ExerciceC
{
    class Program
    {
        static string word = "sas";
        static string wordReversed;

        static void Main(string[] args)
        {

            Console.WriteLine("Word: " + " " + word.ToLower());
            Kayak(word);

            Console.ReadLine();
        }

        static bool Kayak(string word)
        {
            //parcours le mot a l'envers
            for (int i = word.Length - 1; i >= 0; i--)
            {
                //assigne le mot inversé dans wordReversed
                wordReversed += word[i];
            }

            if (wordReversed == word)
            {
                Console.WriteLine("Word reversed: " + wordReversed.ToLower() + "\n" + "This word is  a palindrom");
                return true;
            }
            else
            {
                Console.WriteLine("Word reversed: " + wordReversed.ToLower() + "\n" + "This word is not a palindrom");
                return false;
            }
        }
    }
}
