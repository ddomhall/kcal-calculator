using Microsoft.AspNetCore.Mvc;

namespace kcal_calculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RecipesController : ControllerBase
    {
        [HttpGet]
        public List<Recipe> GetAll()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            for (int i = 0; i < 5; i++)
            {
                ingredients.Add(new Ingredient
                {
                    Id = i,
                    Name = "ingredient" + i,
                    Protein = i,
                    Carbs = i,
                    Fats = i,
                });
            }

            List<IngredientListItem> ingredientList = new List<IngredientListItem>();
            foreach (Ingredient ingredient in ingredients)
            {
                ingredientList.Add(new IngredientListItem()
                {
                    Ingredient = ingredient,
                    Quantity = 1
                });
            }

            List<Recipe> recipes = new List<Recipe>();
            for (int i = 0; i < 3; i++)
            {
                recipes.Add(new Recipe
                {
                    Id = i,
                    Name = "recipe" + i,
                    Ingredients = ingredientList
                });
            }
            return recipes;
        }

        [HttpGet("{id}")]
        public Recipe Get(int id)
        {
            List<IngredientListItem> ingredientList = new List<IngredientListItem>();
            ingredientList.Add(new IngredientListItem()
            {
                Ingredient = new Ingredient
                {
                    Id = id,
                    Name = "ingredient" + id,
                    Protein = id,
                    Carbs = id,
                    Fats = id,
                },
                Quantity = id
            });

            return new Recipe
            {
                Id = id,
                Name = "recipe" + id,
                Ingredients = ingredientList
            };
        }
    }
}

