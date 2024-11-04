using System;
using System.Xml.Linq;

namespace CollectionExpressions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] empNumbers = [1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008];
            foreach (int num in empNumbers)
                Console.WriteLine(num);
            
            List<string> fruits = ["apple", "orange", "mango"];
            Console.WriteLine("\n");
            foreach (string fruit in fruits)
                Console.WriteLine(fruit);

            Span<char> alphabet = ['a', 'b', 'c', 'd', 'e', 'f', 'g', 'h'];
            Console.WriteLine("\n");
            foreach (char c in alphabet)
                Console.WriteLine(c);

            //spread operator
            int[] departmentOne = [1001, 1002, 1003];
            int[] departmentTwo = [1004, 1005, 1006];
            int[] departmentThree = [1007, 1008, 1009];
            int[] consolidatedDepartments = [..departmentOne, ..departmentTwo, ..departmentThree];
            foreach (var department in consolidatedDepartments)
                Console.Write($"{department}, ");

            Console.ReadLine();
        }
    }
}
