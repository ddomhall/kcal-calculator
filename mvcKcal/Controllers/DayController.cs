using Microsoft.AspNetCore.Mvc;

namespace mvcKcal.Controllers
{
    public class DayController : Controller
    {
        public IActionResult Index()
        {
            List<Day> days = DayService.GetAll();
            List<DayViewModel> dayVMs = new List<DayViewModel>();
            foreach (Day day in days)
            {
                DayViewModel dayVM = new DayViewModel
                {
                    Id = day.Id,
                    Name = day.Name,
                    Recipes = new List<RecipeViewModel>()
                };
                foreach (int recipeId in day.RecipeIds)
                {
                    Recipe? recipe = RecipeService.Get(recipeId);
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
                    dayVM.Recipes.Add(recipeVM);
                }
            }
            return View(dayVMs);
        }
    }
}
