using System;

namespace task_2
{
    class Program
    {
        static void Main(string[] args)
        {
            string month = "february";
            if (month == "february")
                Console.WriteLine("28 or 29");
            // bir dene | (or) isaresi qoyduqda uygunluq tapdiqda digerlerinin uzerinden bosuna kecmir. Yeni zamana qenaet edir.
            else if (month == "april" | month == "june" | month == "september" | month == "november")       
                Console.WriteLine(30);
            else if (month == "january" | month == "march" | month == "may" | month == "july" | month == "august" | month == "october" | month == "december")
                Console.WriteLine(31);
            else
                Console.WriteLine("wrong input. Please rewrite month name");
        }
    }
}

