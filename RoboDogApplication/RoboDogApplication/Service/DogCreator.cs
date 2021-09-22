using RoboDogApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDogApplication.Service
{
    public static class DogCreator
    {
        private static string[] names = new[]
        {
            "Bella", "Luna", "Lucy", "Daisy", "Lola",
            "Max", "Charlie", "Cooper", "Buddy", "Milo"
        };

        public static Dog CreateRandomDog()
        {
            Array values = Enum.GetValues(typeof(Dog.Breed));
            Random random = new Random();
            return new Dog() { name = names[random.Next(names.Length)], age = random.Next(1,20), breed = (Dog.Breed)values.GetValue(random.Next(values.Length)) };
        }
    }
}
