using RoboDogApplication.Service;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDogApplication.Model
{
    public class DogStorage : IDogStorage
    {
        private List<Dog> dogs;

        public DogStorage()
        {
            dogs = new List<Dog>();
        }

        public void Add(Dog dog)
        {
            dogs.Add(dog);
        }

        public Dog AddRandomDog()
        {
            Dog dog = DogCreator.CreateRandomDog();
            dogs.Add(dog);
            return dog;
        }

        public IEnumerable<Dog> GetAll()
        {
            return dogs;
        }

        public Dog Update(string name, Dog dog)
        {
            Dog dogUpdate = dogs.Where(x => x.name == name).FirstOrDefault();
            if (dogUpdate == null)
            {
                return null;
            }
            dogUpdate.age = dog.age;
            dogUpdate.breed = dog.breed;
            return dogUpdate;
        }
    }
}
