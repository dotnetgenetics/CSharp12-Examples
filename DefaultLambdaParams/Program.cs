using System;

namespace DefaultLambdaParams
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MultiplyIntegers();
            FullNameMaker();
            Console.ReadLine();
        }

        static void MultiplyIntegers()
        {
            var MultiplyNumbers = (int x, int y = 2) => x * y;
            Console.WriteLine(MultiplyNumbers(5));
            Console.WriteLine(MultiplyNumbers(20, 5));
        }

        static void FullNameMaker()
        {
            var fullName = static (string firstName, string lastName = "Esguerra")
                => $"{firstName} {lastName}";

            Console.WriteLine("\n");
            Console.WriteLine(fullName("Gregory Nelson"));
            Console.WriteLine(fullName("Michelle"));
        }
    }
}
