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

        public IActionResult Detail(int id)
        {
            Ingredient? ingredient = IngredientService.Get(id);
            return View(ingredient);
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Ingredient ingredient)
        {
            Console.WriteLine(ingredient.Id);
            IngredientService.Create(ingredient);
            return RedirectToAction("Index");
        }
    }
}
