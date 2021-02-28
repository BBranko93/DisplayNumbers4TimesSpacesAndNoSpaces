using System;

namespace DisplayNumbers4TimesSpacesAndNoSpaces
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, i;
            Console.WriteLine("Please enter a number : ");
            num1 = int.Parse(Console.ReadLine());

            for (i = 0; i < 4; i++)
            {
                Console.Write("{0} ", num1);
            }
            Console.WriteLine();
            for (i = 0; i < 4; i++)
            {
                Console.Write("{0}",num1);
            }
        }
    }
}
