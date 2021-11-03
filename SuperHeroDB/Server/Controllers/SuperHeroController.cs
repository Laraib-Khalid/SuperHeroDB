using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SuperHeroDB.Shared;

namespace SuperHeroDB.Server.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SuperHeroController : ControllerBase
    {
        static List<Comic> comics = new List<Comic> 
        { 
            new Comic{ Name="Marvel"},
            new Comic{ Name="DC"}
        };
        List<SuperHero> heroes = new List<SuperHero>
        {
            new SuperHero {FirstName = "Peter", LastName ="Parker", HeroName="Spiderman", Comic= comics[0]},
            new SuperHero {FirstName = "Bruce", LastName ="Wynce", HeroName="Batman", Comic= comics[1]}
        };
        public async Task<IActionResult> GetSuperHeroes()
        {
            return Ok(heroes);
        }
    }
}
