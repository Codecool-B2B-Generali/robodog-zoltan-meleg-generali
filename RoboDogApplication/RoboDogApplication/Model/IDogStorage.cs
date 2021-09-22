using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDogApplication.Model
{
    public interface IDogStorage
    {
        void Add(Dog dog);
        Dog AddRandomDog();
        IEnumerable<Dog> GetAll();
        Dog Update(string name, Dog dog);
    }
}
