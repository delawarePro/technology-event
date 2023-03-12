namespace dte.wall.Data;

public class Category
{
    public int Id { get; set; }
    public string Title { get; set; }
    public IReadOnlyList<CategoryItem> Items { get; set; }
    public int Sort { get; set; }
    public string Type { get; set; }
}

