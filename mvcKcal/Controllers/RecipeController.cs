using Microsoft.AspNetCore.Mvc;

namespace mvcKcal.Controllers
{
    public class RecipeController : Controller
    {
        public IActionResult Index()
        {
            List<Recipe> recipes = RecipeService.GetAll();
            List<RecipeViewModel> recipeVMs = new List<RecipeViewModel>();
            foreach (Recipe recipe in recipes)
            {
                recipeVMs.Add(RecipeService.RecipeToVM(recipe));
            }
            return View(recipeVMs);
        }

        public IActionResult Detail(int id)
        {
            return View(RecipeService.RecipeToVM(RecipeService.Get(id)));
        }

        public IActionResult Create()
        {
            RecipeAndIngredientViewModel recipeAndIngredients = new RecipeAndIngredientViewModel
            {
                Recipe = new Recipe(),
                Ingredients = IngredientService.GetAll()
            };
            return View(recipeAndIngredients);
        }

        [HttpPost]
        public IActionResult Create(string name, List<IngredientListItem> ingredients)
        {
            RecipeService.Create(new Recipe
            {
                Name = name,
                Ingredients = ingredients,
            });
            return RedirectToAction("Index");
        }

        public IActionResult Update(int id)
        {
            RecipeAndIngredientViewModel recipeAndIngredients = new RecipeAndIngredientViewModel
            {
                Recipe = RecipeService.Get(id),
                Ingredients = IngredientService.GetAll()
            };
            return View(recipeAndIngredients);
        }

        [HttpPost]
        public IActionResult Update(Recipe recipe, List<IngredientListItem> ingredients)
        {
            foreach (IngredientListItem ingredient in ingredients)
            {
                recipe.Ingredients.Add(ingredient);
            }
            RecipeService.Update(recipe);
            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            RecipeService.Delete(id);
            return RedirectToAction("Index");
        }
    }
}

