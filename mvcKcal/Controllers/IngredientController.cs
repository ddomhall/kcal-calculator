using Microsoft.AspNetCore.Mvc;

namespace mvcKcal.Controllers
{
    public class IngredientController : Controller
    {
        public IActionResult Index()
        {
            List<Ingredient> ingredients = IngredientService.GetAll();
            return View(ingredients);
        }
    }
}
