public class RecipeViewModel
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<IngredientListItemViewModel>? Ingredients { get; set; }
}

