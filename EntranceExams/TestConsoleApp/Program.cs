using System;

namespace TestConsoleApp
{
    class Program
    {
        private static DateTime tempCheck;

        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                if (Prime(i))
                {
                    var prime = i;
                    for (int j = 1; j <= prime; j++)
                    {
                        if (Prime(j))
                        {
                            Console.Write(1);
                        }
                        else
                        {
                            Console.Write(0);
                        }
                    }
                    Console.WriteLine();
                }
            }
        }

        private static bool Prime(int number)
        {
            int delCount = 0;

            for (int i = 1; i <= number; i++)
            {
                if (number == 1)
                {
                    delCount = 2;
                    break;
                }

                if (number % i == 0)
                {
                    delCount++;
                }
            }

            if (delCount == 2)
                return true;

            return false;
        }
    }
}
