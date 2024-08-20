using Microsoft.AspNetCore.Mvc;
using mvcKcal.Models;
using System.Diagnostics;

namespace mvcKcal.Controllers
{
    public class DayController : Controller
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
                        Ingredient = IngredientService.Get(ingredient.IngredientId),
                        Quantity = ingredient.Quantity,
                    });
                }
                recipeVMs.Add(recipeVM);
            }
            return View(recipeVMs);
        }
    }
}
