using Syncfusion.UI.Xaml.Charts;
using System;
using System.Globalization;
using System.Windows.Data;

namespace FootballSpentEarned
{
    public class ImageConverter : IValueConverter
    {
        string Text { set; get; }
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Text = value as string;

            if (Text.Contains(" ") || Text.Contains("�") || Text.Contains("ü") ||
                Text.Contains("é") || Text.Contains("á") || Text.Contains("'"))
            {
                Text = Text.Replace(" ", "_").ToLower() + ".png";
                Text = Text.Replace("&", "_");
                Text = Text.Replace("�", "_");
                Text = Text.Replace("ü", "_");
                Text = Text.Replace("é", "_");
                Text = Text.Replace("á", "_");
                Text = Text.Replace("'", "_");
                Text = Text.Replace("î", "_");
                Text = Text.Replace("-", "_");
            }
            else if (!Text.Contains(".png"))
            {
                Text = Text.ToLower() + ".png";
            }

            if (Text.Contains("0") || Text.Contains("5") || Text.Contains("4"))
            {
                Text = Text.Replace("_05", "");
                Text = Text.Replace("_04", "");
            }

            Text = "/FootballSpentEarned;component/ClubIcons/" + Text;
            return Text;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }

    public class Converter : IValueConverter
    {
        public int Count { get; set; } = 0;
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if(value != null)
            {
                var data = value as LegendItem;
                var series = data.Series as ScatterExt;
                var str = "/FootballSpentEarned;component/ImageIcons/" + series.Source;
                return str;
            }

            return null;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}
