using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDogApplication.Model
{
    public class Dog
    {
        public enum Breed
        {
            Dachshund,
            Dalmatian,
            Dingo,
            Doberman,
            Drever,
            Spaniel
        }
        public string name { get; set; }
        public int age { get; set; }
        public Breed breed { get; set; }
    }
}
