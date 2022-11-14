using Microsoft.Maui.Controls;

namespace SampleFile;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
        DataOne = new List<Person>()
        {
            new Person { Name = "David", Height = 550 },
            new Person { Name = "Michael", Height = 200 },
            new Person { Name = "Steve", Height = 175 },
            new Person { Name = "Joel", Height = 300 },
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

        Brush1 = new List<Brush>()
        {
            new SolidColorBrush(Color.FromArgb("#36b200")),
            new SolidColorBrush(Color.FromArgb("#00a4cc")),

             new SolidColorBrush(Color.FromArgb("#ff3271")),
              
           
            new SolidColorBrush(Color.FromArgb("#ffc84c")),
         //#b29f9d - light brown
         //#b9e500 ffc84c- Light green
         //#ffc84c - Light orange
         //#3271ff - Light blue
         //#ff3271 - Light red
         //#ffc032 - Light Yellow
         //#36b200
         //#00a4cc
         //#9f00e5 - lavender
         //#e69f00
         //#b100ff
             new SolidColorBrush(Color.FromArgb("#b100ff")),//Light green
            new SolidColorBrush(Color.FromArgb("#9f00e5")),
            new SolidColorBrush(Color.FromArgb("#e69f00")),
             new SolidColorBrush(Color.FromArgb("#62797a")),


        };
        Brush2 = new List<Brush>()
        {
             new SolidColorBrush(Color.FromArgb("#ffc032")),
            new SolidColorBrush(Color.FromArgb("#ff3271")),
            new SolidColorBrush(Color.FromArgb("#750000")),
             new SolidColorBrush(Color.FromArgb("#b9e500")),
            new SolidColorBrush(Color.FromArgb("#b29f9d")),
             new SolidColorBrush(Color.FromArgb("#3271ff")),
            

        };
    }
    public List<Person> DataOne { get; set; }
    public List<Brush> Brush { get; set; }
    public List<Brush> Brush1 { get; set; }
    public List<Brush> Brush2 { get; set; }
    private void Button_Clicked(object sender, EventArgs e)
    {
        // radial.MaximumValue = 100;
        radial.ItemsSource = DataOne;
    }


    private void Button_Clicked_2(object sender, EventArgs e)
    {
        radial.PaletteBrushes = Brush1;
    }



    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        switch (picker.SelectedIndex)
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


    private void slider1_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        radial.Spacing = slider.Value;
    }

    private void slider_ValueChanged_2(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        radial.TrackStrokeWidth = slider.Value;
    }

    private void Picker_SelectedIndexChanged_1(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        switch (picker.SelectedIndex)
        {
            case 0:
                {
                    radial.MaximumValue = 100;
                    break;
                }
            case 1:
                {
                    radial.MaximumValue = 200;
                    break;
                }
            case 2:
                {
                    radial.MaximumValue = 500;
                    break;
                }
            case 3:
                {
                    radial.MaximumValue = 1000;
                    break;
                }
        }
    }

    private void Picker_SelectedIndexChanged_2(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        switch (picker.SelectedIndex)
        {
            case 0:
                {
                    radial.TrackStroke = new SolidColorBrush(Colors.Green);
                    break;
                }
            case 1:
                {
                    radial.TrackStroke = new SolidColorBrush(Colors.Black);
                    break;
                }
            case 2:
                {
                    radial.TrackStroke = new SolidColorBrush(Colors.Red);
                    break;
                }
            case 3:
                {
                    radial.TrackStroke = new SolidColorBrush(Colors.DarkGray);
                    break;
                }
        }
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        radial.CapStyle = Syncfusion.Maui.Charts.RadialBarCapStyle.StartCurve;
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {
        radial.CapStyle = Syncfusion.Maui.Charts.RadialBarCapStyle.EndCurve;
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        radial.CapStyle = Syncfusion.Maui.Charts.RadialBarCapStyle.BothCurve;
    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {
        radial.CapStyle = Syncfusion.Maui.Charts.RadialBarCapStyle.BothFlat;
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
            new Person { Name = "David", Height = 5 },
            new Person { Name = "Michael", Height = 50 },
            new Person { Name = "Steve", Height = 75 },
            new Person { Name = "Joel", Height = 100 },
           // new Person { Name = "Bob", Height = 200 }
        };
    }
}
