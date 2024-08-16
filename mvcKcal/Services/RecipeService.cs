namespace mvcKcal;

public class RecipeService
{
    static List<Recipe> recipes = new List<Recipe>();
    static int nextId = 0;

    public static List<Recipe> GetAll() => recipes;

    public static Recipe? Get(int id) => recipes.Find(i => i.Id == id);

    public static void Create(Recipe recipe)
    {
        recipe.Id = nextId++;
        recipes.Add(recipe);
    }
}

