using Microsoft.AspNetCore.Mvc;

namespace kcal_calculator.Server.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class IngredientsController : ControllerBase
    {
        [HttpGet]
        public List<Ingredient> GetAll()
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
            return ingredients;
        }

        [HttpGet("{id}")]
        public Ingredient Get(int id)
        {
            return new Ingredient
            {
                Id = id,
                Name = "ingredient" + id,
                Protein = id,
                Carbs = id,
                Fats = id,
            };
        }
    }
}
