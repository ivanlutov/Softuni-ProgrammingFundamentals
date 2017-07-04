using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.Animals
{
    public class Dog
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int NumberOfLegs { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Distinguishedog, and I will now produce a distinguished sound! Bau Bau.");
        }
    }

    public class Cat
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int IntelligenceQuotient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm an Aristocat, and I will now produce an aristocratic sound! Myau Myau.");
        }
    }

    public class Snake
    {
        public string Name { get; set; }

        public int Age { get; set; }

        public int CrueltyCoefficient { get; set; }

        public static void ProduceSound()
        {
            Console.WriteLine("I'm a Sophistisnake, and I will now produce a sophisticated sound! Honey, I'm home.");
        }
    }

    public class Animals
    {
        public static void Main()
        {
            var input = Console.ReadLine();
            var dogDict = new Dictionary<string, Dog>();
            var catDict = new Dictionary<string, Cat>();
            var snakeDict = new Dictionary<string, Snake>();

            while (!input.Equals("I'm your Huckleberry"))
            {
                var data = input.Split(' ').ToArray();
                if (data.Length > 2)
                {
                    var classAnimal = data[0];
                    var name = data[1];
                    var age = int.Parse(data[2]);
                    var parameter = int.Parse(data[3]);

                    switch (classAnimal)
                    {
                        case "Dog":
                            Dog newDog = new Dog();
                            newDog.Name = name;
                            newDog.Age = age;
                            newDog.NumberOfLegs = parameter;

                            dogDict[newDog.Name] = newDog;
                            break;

                        case "Cat":
                            Cat newCat = new Cat();
                            newCat.Name = name;
                            newCat.Age = age;
                            newCat.IntelligenceQuotient = parameter;

                            catDict[newCat.Name] = newCat;
                            break;

                        case "Snake":
                            Snake newSnake = new Snake();
                            newSnake.Name = name;
                            newSnake.Age = age;
                            newSnake.CrueltyCoefficient = parameter;

                            snakeDict[newSnake.Name] = newSnake;
                            break;
                    }
                }
                else
                {
                    var name = data[1];

                    if (dogDict.ContainsKey(name))
                    {
                        Dog.ProduceSound();
                    }
                    else if (catDict.ContainsKey(name))
                    {
                        Cat.ProduceSound();
                    }
                    else if (snakeDict.ContainsKey(name))
                    {
                        Snake.ProduceSound();
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var dog in dogDict.Values)
            {
                Console.WriteLine($"Dog: {dog.Name}, Age: {dog.Age}, Number Of Legs: {dog.NumberOfLegs}");
            }
            foreach (var cat in catDict.Values)
            {
                Console.WriteLine($"Cat: {cat.Name}, Age: {cat.Age}, IQ: {cat.IntelligenceQuotient}");
            }
            foreach (var snake in snakeDict.Values)
            {
                Console.WriteLine($"Snake: {snake.Name}, Age: {snake.Age}, Cruelty: {snake.CrueltyCoefficient}");
            }
        }
    }
}