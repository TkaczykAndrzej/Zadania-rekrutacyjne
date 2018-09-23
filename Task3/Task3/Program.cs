using System;
using System.Collections.Generic;
using System.Linq;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICollection<Person> collection = new List<Person>();
            collection.Add(new Person { Name = "Kowalski", Age = 10 });
            collection.Add(new Person { Name = "Nowak", Age = 20 });
            collection.Add(new Person { Name = "Małysz", Age = 18 });
            collection.Add(new Person { Name = "Kowalczyk", Age = 1 });
            collection.Add(new Person { Name = "Lewandowski", Age = 40 });
            collection.Add(new Person { Name = "Kaczyński", Age = 33 });
            collection.Add(new Person { Name = "Szymański", Age = 27 });
            collection.Add(new Person { Name = "Kurek", Age = 8 });
            collection.Add(new Person { Name = "Dąbrowski", Age = 53 });
            collection.Add(new Person { Name = "Duda", Age = 18 });

            PrintAscending(collection);
            PrintOccurrenceOfGivenAge(collection, 18);

            Console.ReadKey();
        }

        static void PrintAscending(ICollection<Person> collection)
        {
            var tmpCollection = collection.OrderBy(p => p.Age);      
            foreach (Person person in tmpCollection)
                if(person.Age >=18)
                    Console.WriteLine(person.Name + " - " + person.Age);
        }

        static void PrintOccurrenceOfGivenAge(ICollection<Person> collection, int age)
        {
            bool thuthfulnessOfTheSentence = false;
            foreach (Person person in collection)
            {
                if (person.Age == age)
                    thuthfulnessOfTheSentence = true;
            }
            Console.WriteLine("Sentence \"collection contains person with a given age\" is " + thuthfulnessOfTheSentence.ToString().ToUpper() + ". Given age: " + age.ToString());
        }
    }
}
