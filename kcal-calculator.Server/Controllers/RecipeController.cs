using Microsoft.AspNetCore.Mvc;

namespace kcal_calculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        private readonly ILogger<RecipesController> _logger;

        public RecipesController(ILogger<RecipesController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetRecipes")]
        public IEnumerable<Recipe> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Recipe
            {
                Id = index,
                Name = "recipe" + index,
            })
            .ToArray();
        }
    }
}

