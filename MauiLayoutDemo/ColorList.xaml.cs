namespace MauiLayoutDemo;

public partial class ColorList : ContentView
{
    public static BindableProperty ColorsProperty =
       BindableProperty.Create(nameof(Colors),
           typeof(List<Color>),
           typeof(ColorList));

    public List<Color> Colors
    {
        get => (List<Color>)GetValue(ColorsProperty);
        set
        {
            SetValue(ColorsProperty, value);
            OnPropertyChanged(nameof(Color));
        }
    }

    public ColorList()
    {
        InitializeComponent();
    }
}