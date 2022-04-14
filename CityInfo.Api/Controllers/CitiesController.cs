using Microsoft.AspNetCore.Mvc;

namespace CityInfo.Api.Controllers
{
    [ApiController]
    [Route("api/cities")]
    public class CitiesController : ControllerBase
    {
        [HttpGet]
        public JsonResult GetCities()
        {
            return new JsonResult(
                new List<object> {
                    new {Id = 1, Name = "New York City", Description = "The one with that big park."},
                    new {Id = 2, Name = "Antwerp", Description = "The one with the cathedral that was never really finished." }
                });
        }
    }
}