using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 6, num2 = 14, result;            // 8-11  7-14 6-9 10-14  7-10  6-15   6-14
            result = num2 / 7 - num1 / 7;               //  0     2    1    1     1     2      2
            if (num1 % 7 == 0)
                Console.WriteLine(result + 1);
            else
                Console.WriteLine(result);
        }
    }
}