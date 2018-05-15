using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animals
{
    public class Dog
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int NumberOfLegs { get; set; }

        public void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int IntelligenceQuotient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }
        public int CrueltyCoefficient { get; set; }
        public void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }

    }
    class Animals
    {
        static void Main()
        {
            var dogs = new Dictionary<string, Dog>();
            var cats = new Dictionary<string, Cat>();
            var snakes = new Dictionary<string, Snake>();

            var line = Console.ReadLine();
            while (line != "I'm your Huckleberry")
            {
                var lineArg = line.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);

                if (lineArg.Length > 2)
                {
                    var type = lineArg[0];
                    var name = lineArg[1];
                    var age = int.Parse(lineArg[2]);
                    var parameter = int.Parse(lineArg[3]);

                    if (lineArg[0] == "Dog")
                    {
                        var newDog = new Dog();
                        newDog.Name = name;
                        newDog.Age = age;
                        newDog.NumberOfLegs = parameter;

                        dogs.Add(newDog.Name, newDog);
                    }
                    else if (lineArg[0] == "Cat")
                    {
                        var newCat = new Cat();
                        newCat.Name = name;
                        newCat.Age = age;
                        newCat.IntelligenceQuotient = parameter;

                        cats.Add(newCat.Name, newCat);
                    }
                    else if (lineArg[0] == "Snake")
                    {
                        var newSnake = new Snake();
                        newSnake.Name = name;
                        newSnake.Age = age;
                        newSnake.CrueltyCoefficient = parameter;

                        snakes.Add(newSnake.Name, newSnake);
                    }
                }
                else
                {
                    var animalName = lineArg[1];

                    if (dogs.ContainsKey(animalName))
                    {
                        dogs[animalName].ProduceSound();
                    }
                    else if (cats.ContainsKey(animalName))
                    {
                        cats[animalName].ProduceSound();
                    }
                    else if (snakes.ContainsKey(animalName))
                    {
                        snakes[animalName].ProduceSound();
                    }
                }

                line = Console.ReadLine();
            }


            foreach (var dog in dogs.Values)
            {
                Console.WriteLine("Dog: {0}, Age: {1}, Number Of Legs: {2}", dog.Name, dog.Age, dog.NumberOfLegs);
            }

            foreach (var cat in cats.Values)
            {
                Console.WriteLine("Cat: {0}, Age: {1}, IQ: {2}", cat.Name, cat.Age, cat.IntelligenceQuotient);
            }

            foreach (var snake in snakes.Values)
            {
                Console.WriteLine("Snake: {0}, Age: {1}, Cruelty: {2}", snake.Name, snake.Age, snake.CrueltyCoefficient);
            }
        }
    }
}
