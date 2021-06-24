using System;

namespace Reflection
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Person person = new Person();
            var type = person.GetType();
            Console.WriteLine(type.FullName);
            Console.WriteLine(type.Namespace);
            foreach (var property in type.GetProperties())
            {
                Console.WriteLine(property);
            }
            foreach (var method in type.GetMethods())
            {
                Console.WriteLine(method.Name);
                foreach (var parameter in method.GetParameters())
                {
                    Console.WriteLine(parameter);
                }
            }

        }
    }
}