using Microsoft.AspNetCore.Mvc;

namespace mvcKcal.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            List<Recipe> recipes = RecipeService.GetAll();
            return View(recipes);
        }
    }
}

