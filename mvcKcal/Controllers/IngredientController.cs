using Microsoft.AspNetCore.Mvc;

namespace mvcKcal.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult Index()
        {
            List<Ingredient> ingredients = new List<Ingredient>();
            ingredients.Add(new Ingredient()
            {
                Id = 1,
                Name = "ingredient 1",
                Protein = 1,
                Carbs = 1,
                Fats = 1,
            });
            return View(ingredients);
        }
    }
}
