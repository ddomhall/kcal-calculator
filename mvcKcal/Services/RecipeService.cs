namespace mvcKcal;

public class RecipeService
{
    static List<Recipe> recipes { get; }
    static RecipeService()
    {
        IngredientService.Create(new Ingredient { Name = "i0", Protein = 0, Carbs = 0, Fats = 0, Calories = 0 });
        IngredientService.Create(new Ingredient { Name = "i1", Protein = 1, Carbs = 1, Fats = 1, Calories = 1 });
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
                           IngredientId = 0,                       }
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
                            Quantity = 2,
                            IngredientId = 1,
                        }
                    }
                },
        };
    }

    public static List<Recipe> GetAll() => recipes;

    public static Recipe? Get(int id) => recipes.Find(i => i.Id == id);
}

