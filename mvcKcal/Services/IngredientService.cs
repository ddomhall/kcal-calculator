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

    public static void Update(Ingredient ingredient)
    {
        int index = ingredients.FindIndex(p => p.Id == ingredient.Id);
        if (index != -1) ingredients[index] = ingredient;
        return;
    }

    public static void Delete(int id)
    {
        Ingredient? ingredient = Get(id);
        if (ingredient != null) ingredients.Remove(ingredient);
        return;
    }
}
