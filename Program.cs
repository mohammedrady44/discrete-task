using System;

namespace project1
{
    class Program
    {
        static void Main(string[] args)
        {


            int i, j, flag;
            Console.WriteLine("enter the first value ");
            int x = int.Parse(Console.ReadLine());
            Console.WriteLine("enter the last value ");
            int y = int.Parse(Console.ReadLine());
            Console.Write("\nPrime numbers between " + x
                    + " and " + y + " are: ");

            if (x == 1)
            {
                Console.Write(x + " ");
                x++;
                if (x >= 2)
                {
                    Console.Write(x + " ");
                    x++;
                }
            }
            if (x == 2)
            {
                Console.Write(x + " ");
            }

            if (x % 2 == 0)
            {
                x++;
            }

            for (i = x; i <= y; i += 2)
            {

                flag = 1;

                for (j = 2; j * j <= i; ++j)
                {
                    if (i % j == 0)
                    {
                        flag = 0;
                        break;
                    }
                }

                if (flag == 1)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}
