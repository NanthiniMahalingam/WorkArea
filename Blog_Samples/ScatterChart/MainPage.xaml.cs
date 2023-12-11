using System.Globalization;

namespace ScatterChart
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void NumericalAxis_LabelCreated(object sender, Syncfusion.Maui.Charts.ChartAxisLabelEventArgs e)
        {
            if (e.Label != null)
            {
                var value = double.Parse(e.Label);
                e.Label = value.ToString("#,##0,,M", CultureInfo.InvariantCulture);
            }
        }
    }

}
