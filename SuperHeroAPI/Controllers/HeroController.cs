using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperHeroAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class HeroController : ControllerBase
    {
        public static List<Hero> MyHero = new List<Hero>
            {
                new Hero
                {
                    Id = 1,
                    name = "IronMan",
                    address = "kar"

                }

            };

        [HttpGet]
        public async Task<ActionResult<List<Hero>>> Get()
        {

            return Ok(MyHero);
        }

        [HttpGet("{id}")]
        public async Task<ActionResult<Hero>> Get(int id)
        {
            var hero = MyHero.Find(h => h.Id == id);

            return Ok(hero);
        }

        [HttpPost]
        public async Task<ActionResult<List<Hero>>> Post(Hero hero)
        {
            MyHero.Add(hero);
            return Ok(MyHero);
        }
    }
}
