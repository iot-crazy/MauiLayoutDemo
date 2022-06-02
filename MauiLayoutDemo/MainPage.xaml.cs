namespace MauiLayoutDemo;

public partial class MainPage : ContentPage
{
    public List<Product> Products => Getproducts();

    public MainPage()
	{
		InitializeComponent();
        BindingContext = this;
	}

	private List<Product> Getproducts()
    {
        List<Product> products = new()
        {
            new Product(1, "TV", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(2, "Laptop", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(3, "Radio", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(4, "Mug", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(5, "Water bottle", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(6, "Cables", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(7, "Coffee",  new List<Color>() { Colors.Red, Colors.Blue, Colors.Green}),
            new Product(8, "Biscuit", new List<Color>() { Colors.Red, Colors.Blue, Colors.Green})
        };

        return products;
    }
}

