using System;
using System.Collections.Generic;
using System.Linq;

//Tuples from C# 7
namespace NewTuples
{

     public static class Extensions2
        {
            // public static void Deconstruct<T>(this IList<T> list, out T first, out IList<T> rest)
            // {

            //     first = list.Count > 0 ? list[0] : default(T); // or throw
            //     rest = list.Skip(1).ToList();
            // }

            public static void Deconstruct<T>(this IList<T> list, out T first, out T second, out IList<T> rest)
            {
                first = list.Count > 0 ? list[0] : default(T); // or throw
                second = list.Count > 1 ? list[1] : default(T); // or throw
                rest = list.Skip(2).ToList();
            }
        }

    public class Person
    {
        public Person()
        {
            this.Name = "Ana Silva";
        }

        private string Name { get; set; }

        public (string FirstName, string LastName, bool) GetName()
        {
            string[] p = Name.Split(" ");
            return (p[0], p[1], false);
        }

        public (string FirstName, string LastName) GetNameDeconstruct()
        {
            var (a, b, _) = Name.Split(" ");
            return (a, b);
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Console.WriteLine($"{person.GetName().FirstName} {person.GetName().LastName} {person.GetName().Item3}");

            Console.WriteLine($"{person.GetNameDeconstruct().FirstName} {person.GetNameDeconstruct().LastName}");
        }
    }
}
