using System;

namespace ExerciceB
{
    class Program
    {
        static string[] initialTable = new string[] { "A", "B", "ABC" };
        static bool isLow = true;
        static bool isReversed = true;


        static void Main(string[] args)
        {

            UpDownLeftRight(initialTable, isLow, isReversed);

            Console.ReadLine();
        }

        static string[] UpDownLeftRight(string[] initialTable, bool isLow, bool isReversed)
        {


            for (int i = 0; i < initialTable.Length; i++)
            {
                if (isLow)
                {
                    initialTable[i] = initialTable[i].ToLower(); //met l'élément en minuscule
                }
                else if (!isLow)
                {
                    initialTable[i] = initialTable[i].ToUpper(); //met l'élement an majuscule
                }

                if (isReversed)
                {
                    Array.Reverse(initialTable); //renverse le tableau
                }
            }
    
            return initialTable;
        }

    }
}
