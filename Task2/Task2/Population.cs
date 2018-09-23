using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    class Population
    {
        private ICollection<IAnimal> animals = new List<IAnimal>();
        private ICollection<Type> typeAnimals = new List<Type>();

        public Population()
        {
            typeAnimals.Add(typeof(Cat));
            typeAnimals.Add(typeof(Dog));
            //4 cats and 5 dogs
            AddAnimal(new Cat());   
            AddAnimal(new Dog());
            AddAnimal(new Cat());
            AddAnimal(new Dog());
            AddAnimal(new Dog());
            AddAnimal(new Dog());
            AddAnimal(new Cat());
            AddAnimal(new Dog());
            AddAnimal(new Cat());
        }

        public void AddAnimal(IAnimal animal)
        {
            animals.Add(animal);
        }

        public void PrintSounds()
        {
            foreach (IAnimal animal in animals)
            {
                animal.Speak();
            }
        }

        public int NrInPopulation(Type animalType)
        {
            int i = 0;
            foreach (IAnimal animal in animals)
            {
                if (animal.GetType() == animalType)
                    i++;
            }
            return i;
        }

        public void PrintNrInPopulation()
        {
            Console.WriteLine("Number of animals in population:" + animals.Count<IAnimal>());
            foreach (Type typeAnimal in typeAnimals)
            {
                Console.WriteLine("Number of "+ typeAnimal.Name +" in population:" + NrInPopulation(typeAnimal));
            }
        }
    }
}
