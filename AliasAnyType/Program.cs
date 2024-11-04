using intArray = int[];
using UserEntity = System.Collections.Generic.Dictionary<int, string>;
using EmployeeTuple = System.Tuple<int, string>;

namespace AliasAnyType
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Tuple();
            IntArray();
            Dictionary();
        }

        static void Tuple()
        {
            var person1 = new EmployeeTuple(1001, "John Doe");
            Console.WriteLine($"Person one is: {person1.Item1}, {person1.Item2}");
        }

        static void IntArray()
        {
            intArray p = new int[20];
            for (int i = 0; i < p.Length; i++)
                p[i] = i * i;

            Console.WriteLine("\n");
            for (int i = 0; i < p.Length; i++)
                Console.WriteLine($"Value of p[{i}] = {p[i]}");
        }

        static void Dictionary()
        {
            UserEntity user = new UserEntity();
            user.Add(10001, "Greg Esguerra");
            user.Add(10002, "Michelle Esguerra");
            user.Add(10003, "Carl Judiel Esguerra");

            Console.WriteLine("\n");
            foreach (var item in user)
            {
                Console.WriteLine($"ID: {item.Key}, Name: {item.Value}");
            }
        }
    }
}
