namespace mvcKcal;

public class IngredientService
{
    static List<Ingredient> ingredients = new List<Ingredient>();
    static int nextId = 0;

    public static List<Ingredient> GetAll() => ingredients;

    public static Ingredient? Get(int id) => ingredients.First(i => i.Id == id);

    public static void Create(Ingredient ingredient)
    {
        ingredient.Id = nextId++;
        ingredients.Add(ingredient);
    }

}
