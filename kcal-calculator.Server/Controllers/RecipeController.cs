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
            IEnumerable<Ingredient> ingredients = IngredientsController.Get();
            List<IngredientListItem> ingredientList = [];

            foreach (Ingredient ingredient in ingredients)
            {
                ingredientList.Add(new IngredientListItem()
                {
                    Ingredient = ingredient,
                    Quantity = 1
                });
            }

            return Enumerable.Range(1, 5).Select(index => new Recipe
            {
                Id = index,
                Name = "recipe" + index,
                Ingredients = ingredientList
            })
            .ToArray();
        }
    }
}

