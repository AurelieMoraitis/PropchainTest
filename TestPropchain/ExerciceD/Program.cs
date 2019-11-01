using System;
using System.Collections.Generic;
namespace ExerciceD
{
    class Program
    {
        

        static string text = "kayak";
        static Dictionary<string,int> dict = new Dictionary<string,int>();
        

        static void Main(string[] args)
        {

            SufferingOfKeys(text);
            Console.ReadLine();
        }

        static Dictionary<string, int>[] SufferingOfKeys(string text)
        {
            //pour chaque lettre
            for (int i = 0; i < text.Length; i++)
            {
                //vérifie si clé existe
                if (!dict.ContainsKey(text[i].ToString())) //.toString nécessaire sinon char
                {
                    dict.Add(text[i].ToString(), 1);
                }
                else
                {
                    dict[text[i].ToString()] += 1;
                }

            }

            Dictionary<string, int>[] value = new Dictionary<string, int>[] {dict};

            return value;
        }
    }
}
