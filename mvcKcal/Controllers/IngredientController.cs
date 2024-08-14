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
            IngredientService.Create(ingredient);
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            Ingredient? ingredient = IngredientService.Get(id);
            return View(ingredient);
        }


        [HttpPost]
        public IActionResult Update(Ingredient ingredient)
        {
            IngredientService.Update(ingredient);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            IngredientService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}
