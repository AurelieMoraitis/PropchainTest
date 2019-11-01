using System;

namespace ExerciceA
{
    class Program
    {
        static int n = 4;

        static void Main(string[] args)
        {

            DingDingBottle(n);


            Console.ReadLine();
        }
        static void DingDingBottle(int n)
        {
            for (int i = 0; i <= n; i++)
            {
                if (i % 5 == 0 && i % 3 == 0)
                {
                    Console.WriteLine("dingdingbottle");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("dingding");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("bottle");
                }
                else if(i == n)
                {
                    Console.WriteLine(n);
                }
            }


        }
    }
}
