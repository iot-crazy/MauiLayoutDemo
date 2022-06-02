namespace MauiLayoutDemo;

public class Product
{
    public int ID { get; set; }
    public string Name { get; set; }
    public List<Color> Colors { get; set; }
    public Product(int id, string name, List<Color> colors)
    {
        ID = id;
        Name = name;
        Colors = colors;
    }

}
