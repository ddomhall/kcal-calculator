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
                            Quantity = 5,
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
    }

    public static List<Recipe> GetAll() => recipes;

    public static Recipe? Get(int id) => recipes.Find(i => i.Id == id);
}

