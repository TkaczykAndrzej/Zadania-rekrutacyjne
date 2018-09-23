using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Population population = new Population();
            population.PrintSounds();
            population.PrintNrInPopulation();

            Console.ReadKey();

            //ICollection<IAnimal> animals;
            //animals.Add(new Dog());
            ////4 cats and 5 dogs
            //animals.Add(new Cat());
            //animals.Add(new Dog());
            //animals.Add(new Cat());
            //animals.Add(new Dog());
            //animals.Add(new Dog());
            //animals.Add(new Dog());
            //animals.Add(new Cat());
            //animals.Add(new Dog());
            //animals.Add(new Cat());

            //foreach (IAnimal animal in animals)
            //{
            //    animal.Speak();
            //}
            //Console.ReadKey();
        }


    }
}
