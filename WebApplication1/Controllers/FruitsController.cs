using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FruitsController : ControllerBase
    {
        public List<string> Fruits = new List<string> { "Apple", "Mango", "Orange" };

        [HttpGet]
        public List<string> GetFruits()
        {
            return Fruits;
        }
        [HttpGet("{id}")]
        public ActionResult<string> GetFruitById([FromRoute]int id)
        {
            if(id >= Fruits.Count)
            {
                return NotFound();
            }
            return Ok(Fruits.ElementAt(id));

        }
        [HttpPost]
        public List<string> AddFruit([FromBody]string fruit)
        {
            Fruits.Add(fruit);

            return Fruits;
        }
    }
}
