using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            StringPalindrome();
            Console.ReadLine();
        }


        static void StringPalindrome()
        {
            string s, revs = "";
            Console.WriteLine("\n >>>> Purpose of this Program <<<< ");
            Console.WriteLine("\n >>>> To Find if a String is a Palindrome or not <<<< ");
         
            Console.WriteLine("\n Please Enter a string: ");
            s = Console.ReadLine();
            s = s.Trim();
            for (int i = s.Length - 1; i >= 0; i--)
            {
                revs += s[i].ToString();
            }
            if (revs == s)
            {
                Console.WriteLine("your word: " +s);
                Console.WriteLine("String is a Palindrome" + " "+ revs);
                

            }
            else
            {
                Console.WriteLine("your word: " + s);
                Console.WriteLine("String is not a Palindrome" + " " + revs);
            }
            Console.ReadKey();
        }





    }
}


