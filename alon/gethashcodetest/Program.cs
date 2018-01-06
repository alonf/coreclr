using System;

namespace gethashcodetest
{
    class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var p = new Person {Name = "Alon", Age = 48};
            var h = p.GetHashCode();
            Console.WriteLine($"Hello {h}");
        }
    }
}
