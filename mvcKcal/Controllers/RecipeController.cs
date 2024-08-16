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
                RecipeViewModel recipeVM = new RecipeViewModel
                {
                    Id = recipe.Id,
                    Name = recipe.Name,
                    Ingredients = new List<IngredientListItemViewModel>(),
                };
                foreach (IngredientListItem ingredient in recipe.Ingredients)
                {
                    recipeVM.Ingredients.Add(new IngredientListItemViewModel
                    {
                        Quantity = ingredient.Quantity,
                        Ingredient = IngredientService.Get(ingredient.IngredientId),
                    });
                }
                recipeVMs.Add(recipeVM);
            }
            return View(recipeVMs);
        }

        public IActionResult Detail(int id)
        {
            Recipe? recipe = RecipeService.Get(id);
            RecipeViewModel recipeVM = new RecipeViewModel
            {
                Id = recipe.Id,
                Name = recipe.Name,
                Ingredients = new List<IngredientListItemViewModel>()
            };
            foreach (IngredientListItem ingredient in recipe.Ingredients)
            {
                recipeVM.Ingredients.Add(new IngredientListItemViewModel
                {
                    Quantity = ingredient.Quantity,
                    Ingredient = IngredientService.Get(ingredient.IngredientId)
                });
            }
            return View(recipeVM);
        }

        // public IActionResult Create()
        // {
        //     return View();
        // }
        //
        // [HttpPost]
        // public IActionResult Create(Recipe recipe)
        // {
        //     RecipeService.Create(recipe);
        //     return RedirectToAction("Index");
        // }
    }
}

