using Syncfusion.Maui.SunburstChart;
using System.Collections.ObjectModel;
using System.Data.Common;
using System.Globalization;

namespace MauiApp2;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();

      
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

        Data = new ObservableCollection<SunburstModel>
    {
        new SunburstModel { Country = "USA", JobDescription = "Sales", JobGroup="Executive", EmployeesCount = 50 },
        new SunburstModel { Country = "USA", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 },
        new SunburstModel { Country = "USA", JobDescription = "Marketing", EmployeesCount = 40 },
        new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 35 },
        new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 175 },
        new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 70 },
        new SunburstModel { Country = "USA", JobDescription = "Management", EmployeesCount = 40 },
        new SunburstModel { Country = "USA", JobDescription = "Accounts", EmployeesCount = 60 },

        new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 33 },
        new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 125 },
        new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 60 },
        new SunburstModel { Country = "India", JobDescription = "HR Executives", EmployeesCount = 70 },
        new SunburstModel { Country = "India", JobDescription = "Accounts", EmployeesCount = 45 },

};
    }

    public List<Brush> Brush1 { get; }
    public ObservableCollection<SunburstModel> Data { get; set; }

    private void Button_Clicked(object sender, EventArgs e)
    {
        sunburstChart.AnimationDuration = 5;
        sunburstChart.ItemsSource = Data;
    }

    private void Button_Clicked_1(object sender, EventArgs e)
    {
        sunburstChart.PaletteBrushes = Brush1;
    }

    private void radius_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        sunburstChart.Radius = slider.Value;
    }

    private void startAngle_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        sunburstChart.StartAngle = slider.Value;
    }

    private void endAngle_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        sunburstChart.EndAngle = slider.Value;
    }

    private void strokeWidth_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        sunburstChart.StrokeWidth = slider.Value;
    }

    private void Button_Clicked_2(object sender, EventArgs e)
    {
        sunburstChart.Stroke = Brush.Black;
    }

    //private void Button_Clicked_3(object sender, EventArgs e)
    //{
    //    //sunburstChart.Levels.Clear();
    //    SunburstHierarchicalLevel level3 = new SunburstHierarchicalLevel();
    //    level3.GroupMemberPath = "JobDescription";

    //    sunburstChart.Levels.Add(level3);
    //}

    private void Picker_SelectedIndexChanged(object sender, EventArgs e)
    {
        var picker = (Picker)sender;
        switch (picker.SelectedIndex)
        {
            case 0:
                {
                    sunburstChart.Stroke = new SolidColorBrush(Colors.Green);
                    break;
                }
            case 1:
                {
                    sunburstChart.Stroke = new SolidColorBrush(Colors.Black);
                    break;
                }
            case 2:
                {
                    sunburstChart.Stroke = new SolidColorBrush(Colors.Red);
                    break;
                }
            case 3:
                {
                    sunburstChart.Stroke = new SolidColorBrush(Colors.DarkGray);
                    break;
                }
        }
    }

    private void innerradius_ValueChanged(object sender, ValueChangedEventArgs e)
    {
        var slider = (Slider)sender;
        sunburstChart.InnerRadius = slider.Value;
    }

    private void Button_Clicked_3(object sender, EventArgs e)
    {

      //  dataLabel.RotationMode = SunburstLabelRotationMode.Normal;

       
    }

    private void Button_Clicked_4(object sender, EventArgs e)
    {
        dataLabel.RotationMode = SunburstLabelRotationMode.Normal;
        dataLabel.FontAttributes = FontAttributes.Bold;
        dataLabel.FontSize = 12;
        //// dataLabel.FontFamily = "Calibri";
        dataLabel.TextColor = Colors.Black;
    }

    private void Button_Clicked_5(object sender, EventArgs e)
    {
        sunburstChart.Levels[0].GroupMemberPath = "JobGroup";
    }

    private void Button_Clicked_6(object sender, EventArgs e)
    {
        legend.Placement = Syncfusion.Maui.Core.LegendPlacement.Right;
    }

    private void Button_Clicked_7(object sender, EventArgs e)
    {
        legend.Placement = Syncfusion.Maui.Core.LegendPlacement.Left;
    }

    private void Button_Clicked_8(object sender, EventArgs e)
    {
        legend.Placement = Syncfusion.Maui.Core.LegendPlacement.Bottom;
    }

    private void Button_Clicked_9(object sender, EventArgs e)
    {
        sunburstChart.ShowLabels = true;
    }

    private void Button_Clicked_10(object sender, EventArgs e)
    {
        sunburstChart.ShowLabels = false;

    }

    private void Button_Clicked_11(object sender, EventArgs e)
    {
        sunburstChart.Title = "SunburstChart";
    }

    private void Button_Clicked_12(object sender, EventArgs e)
    {

        dataLabel.OverFlowMode = SunburstLabelOverflowMode.Hide;
    }

    private void Button_Clicked_13(object sender, EventArgs e)
    {
        toolTip.Duration = 5;
    }

    private void Button_Clicked_14(object sender, EventArgs e)
    {
        toolTip.TextColor = Colors.Black;
    }

    private void Button_Clicked_15(object sender, EventArgs e)
    {
        toolTip.Margin = new Thickness(0);
    }

    private void Button_Clicked_16(object sender, EventArgs e)
    {
        toolTip.FontAttributes = FontAttributes.Bold;
        toolTip.FontSize = 15;
        toolTip.Background = Brush.Gray;
    }

    private void Button_Clicked_17(object sender, EventArgs e)
    {
        sunburstChart.ValueMemberPath = "Count";
    }

    private void Button_Clicked_18(object sender, EventArgs e)
    {
        Label label = new Label();
        label.Text = "Center View";


        StackLayout layout = new StackLayout();
        // layout.Background = Brush.Green;
        layout.HorizontalOptions = LayoutOptions.CenterAndExpand;
        layout.VerticalOptions = LayoutOptions.CenterAndExpand;

        // image source


        Image image = new Image();
        image.Source = "image.png";
        image.HorizontalOptions = LayoutOptions.CenterAndExpand;
        image.VerticalOptions = LayoutOptions.CenterAndExpand;

        //image.SetBinding(HeightRequestProperty, nameof(SfSunburstChart.CenterHoleSize));
        //image.SetBinding(WidthRequestProperty, nameof(SfSunburstChart.CenterHoleSize));

        image.SetBinding(HeightRequestProperty, new Binding() { Path = "CenterHoleSize", Source = sunburstChart, Converter = grid.Resources["cornerRadius"] as IValueConverter });
        image.SetBinding(WidthRequestProperty, new Binding() { Path = "CenterHoleSize", Source = sunburstChart, Converter = grid.Resources["cornerRadius"] as IValueConverter });


        layout.Children.Add(image);

        sunburstChart.CenterView = layout;
    }

    private void Button_Clicked_19(object sender, EventArgs e)
    {
        SunburstHierarchicalLevel sunburstHierarchicalLevel = new SunburstHierarchicalLevel();
        sunburstHierarchicalLevel.GroupMemberPath = "JobGroup";
        sunburstChart.Levels.Add(sunburstHierarchicalLevel);
    }
    
    private void Button_Clicked_20(object sender, EventArgs e)
    {
        Navigation.PushAsync(new NewPage1());
    }

    private void Button_Clicked_21(object sender, EventArgs e)
    {
        sunburstChart.DataLabelSettings = new SunburstDataLabelSettings() { FontAttributes = FontAttributes.Italic};
    }

    private void Button_Clicked_22(object sender, EventArgs e)
    {
        sunburstChart.TooltipSettings = new SunburstTooltipSettings() { };
    }

    private void Button_Clicked_23(object sender, EventArgs e)
    {
        sunburstChart.Legend = new SunburstLegend() { Placement = Syncfusion.Maui.Core.LegendPlacement.Right };
    }

    private void Button_Clicked_24(object sender, EventArgs e)
    {
        sunburstChart.TooltipTemplate = grid.Resources["template"] as DataTemplate;
    }

    private void Button_Clicked_25(object sender, EventArgs e)
    {
        sunburstChart.TooltipTemplate = null; 
    }

    private void Button_Clicked_26(object sender, EventArgs e)
    {
        legend.IsVisible = true;
    }

    private void Button_Clicked_27(object sender, EventArgs e)
    {
        legend.IsVisible = false;
    }
}

public class SunburstModel
{
    public string JobDescription { get; set; }
    public string JobGroup { get; set; }
    public string JobRole { get; set; }
    public double EmployeesCount { get; set; }
    public double Count { get; set; }
    public string Country { get; set; }
}

public class SunburstViewModel
{
    public ObservableCollection<Brush> Brush2 { get; set; }
    public System.Collections.ObjectModel.ObservableCollection<SunburstModel> DataSource { get; set; }
    public SunburstViewModel()
    {
        this.DataSource = new ObservableCollection<SunburstModel>
            {
                new SunburstModel { Country = "USA", JobDescription = "Sales", JobGroup="Executive", EmployeesCount = 50 , Count = 200},
                new SunburstModel { Country = "USA", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 },
                new SunburstModel { Country = "USA", JobDescription = "Marketing", EmployeesCount = 40 },
                new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 35 },
                new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 175 },
                new SunburstModel { Country = "USA", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 70 },
                new SunburstModel { Country = "USA", JobDescription = "Management", EmployeesCount = 40 },
                new SunburstModel { Country = "USA", JobDescription = "Accounts", EmployeesCount = 60 },

                new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 33 },
                new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 125 },
                new SunburstModel { Country = "India", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 60 },
                new SunburstModel { Country = "India", JobDescription = "HR Executives", EmployeesCount = 70 },
                new SunburstModel { Country = "India", JobDescription = "Accounts", EmployeesCount = 45 },

                new SunburstModel { Country = "Germany", JobDescription = "Sales", JobGroup = "Executive", EmployeesCount = 30 },
                new SunburstModel { Country = "Germany", JobDescription = "Sales", JobGroup = "Analyst", EmployeesCount = 40 },
                new SunburstModel { Country = "Germany", JobDescription = "Marketing", EmployeesCount = 50 },
                new SunburstModel { Country = "Germany", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 40 },
                new SunburstModel { Country = "Germany", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 65 },
                new SunburstModel { Country = "Germany", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 27 },
                new SunburstModel { Country = "Germany", JobDescription = "Management", EmployeesCount = 33 },
                new SunburstModel { Country = "Germany", JobDescription = "Accounts", EmployeesCount = 55 },

                new SunburstModel { Country = "UK", JobDescription = "Technical", JobGroup = "Testers", EmployeesCount = 25 },
                new SunburstModel { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Windows", EmployeesCount = 96 },
                new SunburstModel { Country = "UK", JobDescription = "Technical", JobGroup = "Developers", JobRole = "Web", EmployeesCount = 55 },
                new SunburstModel { Country = "UK", JobDescription = "HR Executives", EmployeesCount = 60 },
                new SunburstModel { Country = "UK", JobDescription = "Accounts", EmployeesCount = 30 }
            };

        Brush2 = new ObservableCollection<Brush>()
      {
           new SolidColorBrush(Color.FromArgb("#ffc032")),
          new SolidColorBrush(Color.FromArgb("#ff3271")),
          new SolidColorBrush(Color.FromArgb("#750000")),
           new SolidColorBrush(Color.FromArgb("#b9e500")),
          new SolidColorBrush(Color.FromArgb("#b29f9d")),
           new SolidColorBrush(Color.FromArgb("#3271ff")),


      };
    }
}

public class ItemConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
    {
        if (value != null)
        {
            return value;
        }

        return value;
    }

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
    {
        throw new NotImplementedException();
    }
}

public class CornerRadiusConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value != null)
        {
            return (double)value / 2;
        }

        return 0;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value;
    }
}

public class RadiusConverter : IValueConverter
{
    public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        if (value != null)
        {
            return (double)value;
        }

        return 0;
    }

    public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
    {
        return value;
    }
}

