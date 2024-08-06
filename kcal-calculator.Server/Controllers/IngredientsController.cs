using Microsoft.AspNetCore.Mvc;

namespace kcal_calculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientsController : ControllerBase
    {
        private readonly ILogger<IngredientsController> _logger;

        public IngredientsController(ILogger<IngredientsController> logger)
        {
            _logger = logger;
        }

        [HttpGet(Name = "GetIngredients")]
        public static IEnumerable<Ingredient> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new Ingredient
            {
                Id = index,
                Name = "ingredient" + index,
                Protein = index,
                Carbs = index,
                Fats = index,
            })
            .ToArray();
        }
    }
}
