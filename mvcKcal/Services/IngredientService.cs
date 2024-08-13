namespace mvcKcal;

public class IngredientService
{
    static List<Ingredient> ingredients { get; }

    static IngredientService()
    {
        ingredients = new List<Ingredient>
        {
            new Ingredient {Id = 0, Name = "ingredient0", Protein = 0, Carbs = 0, Fats = 0},
            new Ingredient {Id = 1, Name = "ingredient1", Protein = 1, Carbs = 1, Fats = 1},
        };
    }

    public static List<Ingredient> GetAll() => ingredients;
}
