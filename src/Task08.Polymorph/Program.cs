using System;

namespace Task08.Polymorph
{
    class Program
    {
        static void Main(string[] args)
        {
            Animal[] animals = new Animal[3];
            animals[0] = new Elephant()
            {
                Name = "Майкл"
            };
            animals[1] = new Elephant()
            {
                Name = "Семён"
            };
            animals[2] = new Bear()
            {
                Name = "Миша"
            };

            for (int i = 0; i < animals.Length; i++)
            {
                Console.WriteLine(animals[i].Name);
            }
        }
    }

    public class Animal
    {
        public string Name { get; set; }
    }

    public class Elephant : Animal
    {
    }

    public class Bear : Animal
    {
    }
}
