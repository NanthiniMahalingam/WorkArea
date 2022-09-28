namespace DemoFile;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
        DataOne = new List<Person>()
        {
            new Person { Name = "David", Height = 55 },
            new Person { Name = "Michael", Height = 60 },
            new Person { Name = "Steve", Height = 75 },
            new Person { Name = "Joel", Height = 10 },
            new Person { Name = "Bob", Height = 200 }
        };
        Brush = new List<Brush>()
        {
            new SolidColorBrush(Colors.Green),
            new SolidColorBrush(Colors.Blue),
           
            new SolidColorBrush(Colors.Magenta),
            new SolidColorBrush(Colors.Yellow),
             new SolidColorBrush(Colors.Red),
        };
    }
    public List<Person> DataOne { get; set; }
    public List<Brush> Brush { get; set; }
    private void Button_Clicked(object sender, EventArgs e)
    {
        // radial.MaximumValue = 100;
        radial.ItemsSource = DataOne;
    }


    private void Button_Clicked_2(object sender, EventArgs e)
    {
        radial.PaletteBrushes = Brush;
    }

   

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker =(Picker)sender;
        switch(picker.SelectedIndex)
        {
            case 0:
                {
                    radial.Stroke = new SolidColorBrush(Colors.Green);
                    break;
                }
            case 1:
                {
                    radial.Stroke = new SolidColorBrush(Colors.Black);
                    break;
                }
            case 2:
                {
                    radial.Stroke = new SolidColorBrush(Colors.Red);
                    break;
                }
            case 3:
                {
                    radial.Stroke = new SolidColorBrush(Colors.DarkGray);
                    break;
                }
        }
    }

    private void slider_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;    
        radial.StrokeWidth = slider.Value;
    }

    private void Slider_ValueChanged_1(object sender, ValueChangedEventArgs e)
    {
        var slider1 = (Slider)sender;
        radial.Radius = slider1.Value;
    }
}
public class Person
{
    public string Name { get; set; }
    public double Height { get; set; }
}
public class ViewModel
{
    public List<Person> Data { get; set; }

    public ViewModel()
    {
        Data = new List<Person>()
        {
            new Person { Name = "David", Height = 25 },
            new Person { Name = "Michael", Height = 50 },
            new Person { Name = "Steve", Height = 75 },
            new Person { Name = "Joel", Height = 100 },
            new Person { Name = "Bob", Height = 200 }
        };
    }
}


