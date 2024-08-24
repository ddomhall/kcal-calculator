public class Recipe
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public List<IngredientListItem>? Ingredients { get; set; }
}
