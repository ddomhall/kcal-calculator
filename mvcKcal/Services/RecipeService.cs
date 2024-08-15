namespace mvcKcal;

public class RecipeService
{
    static List<Recipe> recipes { get; }
    static RecipeService()
    {
        recipes = new List<Recipe>
        {
            new Recipe
            {
                    Id = 0,
                   Name = "r0",
                   Ingredients = new List<IngredientListItem>
                   {
                       new IngredientListItem
                       {
                           Quantity = 0,
                           Ingredient = new Ingredient
                           {
                               Id = 0,
                               Name = "i0",
                               Protein = 0,
                               Carbs = 0,
                               Fats = 0
                           }
                       }
                   }
            },
                new Recipe
                {
                    Id = 1,
                    Name = "r1",
                    Ingredients = new List<IngredientListItem>
                    {
                        new IngredientListItem
                        {
                            Quantity = 1,
                            Ingredient = new Ingredient
                            {
                                Id = 1,
                                Name = "i1",
                                Protein = 1,
                                Carbs = 1,
                                Fats = 1
                            }
                        }
                    }
                },
        };
        // Ingredient ingredient = new Ingredient { Id = 0, Name = "i0", Protein = 0, Carbs = 0, Fats = 0 };
        // IngredientListItem ingredientList = new IngredientListItem { Ingredient = ingredient, Quantity = 0 };
        // Recipe recipe = new Recipe { Id = 0, Name = "r0", Ingredients = new List<IngredientListItem>() };
        // recipe.Ingredients.Add(ingredientList);
        // recipes.Add(recipe);
    }

    public static List<Recipe> GetAll() => recipes;
}

