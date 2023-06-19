using Microsoft.Maui.Controls.Shapes;
using Syncfusion.Maui.Charts;

namespace FootballSpentEarned;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
}

public class ScatterExt : ScatterSeries
{
    public string? Source
    {
        get { return (string)GetValue(SourceProperty); }
        set { SetValue(SourceProperty, value); }
    }

    public static readonly BindableProperty SourceProperty =
BindableProperty.Create(
    nameof(Source),
    typeof(string),
    typeof(ScatterExt),
    null,
    BindingMode.Default,
    null);
}


