using Microsoft.AspNetCore.Mvc;
using RoboDogApplication.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RoboDogApplication.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DogController : ControllerBase
    {
        private IDogStorage dogStorage;

        public DogController(IDogStorage dogStorage)
        {
            this.dogStorage = dogStorage;
        }

        [HttpGet]
        public IEnumerable<Dog> Get()
        {
            return dogStorage.GetAll();
        }

        [HttpGet("Random")]
        public Dog GetRandomDog()
        {
            return dogStorage.AddRandomDog();
        }

        [HttpPost]
        public ActionResult Create(Dog dog)
        {
            if (dog == null)
            {
                return BadRequest();
            }
            dogStorage.Add(dog);
            return Ok(dog);
        }

        [HttpPut("{name}")]
        public ActionResult Update(string name, Dog dog)
        {
            if (dog == null)
            {
                return BadRequest();
            }
            Dog dogUpdate = dogStorage.Update(name, dog);
            if (dogUpdate == null)
            {
                return BadRequest();
            }
            return Ok(dogUpdate);
        }
    }
}
