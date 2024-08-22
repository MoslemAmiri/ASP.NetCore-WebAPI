using Microsoft.AspNetCore.Mvc;

namespace MyApi.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class AvengersController : ControllerBase
    {
        public List<Avenger> _avengers = new List<Avenger>
        {
            new Avenger(1, "The Avengers", 2012),
            new Avenger(2, "Age Of Urltran", 2015),
            new Avenger(3, "Infinity War", 2018)
        };
        
        [HttpGet]
        public List<Avenger> GetAvengers()
        {
            return _avengers;
        }

        [HttpGet("{id}")]
        public Avenger GetAvengerBy(int id)
        {
            return _avengers.Find(x => x.Id == id);
        }

        [HttpPost]
        public List<Avenger> AddAvenger([FromBody] Avenger avenger)
        {
            _avengers.Add(avenger);
            return _avengers;
        }
    }
}