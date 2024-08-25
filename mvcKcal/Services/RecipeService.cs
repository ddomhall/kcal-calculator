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

    public static void Update(Recipe recipe)
    {
        int index = recipes.FindIndex(p => p.Id == recipe.Id);
        if (index != -1) recipes[index] = recipe;
    }


    public static void Delete(int id)
    {
        Recipe? recipe = Get(id);
        if (recipe != null) recipes.Remove(recipe);
    }

    public static RecipeViewModel RecipeToVM(Recipe recipe)
    {
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
                Grams = ingredient.Grams,
                Ingredient = IngredientService.Get(ingredient.IngredientId)
            });
        }
        return recipeVM;
    }
}

