using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace FootballSpentEarned
{
    //
    // Summary:
    //     This class converts brush type to color type and vice versa.
    public class BrushToColorConverter : IValueConverter
    {
        //
        // Summary:
        //     Converts brush value to an color type.
        //
        // Parameters:
        //   value:
        //     The value must be the type of SolidColorBrush
        //
        //   targetType:
        //     The type of the target property
        //
        //   parameter:
        //     An additional parameter for the converter to handle, not used
        //
        //   culture:
        //     The culture to use in the converter, not used
        //
        // Returns:
        //     Returns the color value of the brush
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     Exception is thrown when the value type is null or not a type of SolidColorBrush
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!Brush.IsNullOrEmpty(value as SolidColorBrush))
            {
                SolidColorBrush solidColorBrush = (SolidColorBrush)value;
                return solidColorBrush.Color;
            }

            throw new ArgumentException("Expected value to be a type of brush", "value");
        }

        //
        // Summary:
        //     Converts back the color to brush type.
        //
        // Parameters:
        //   value:
        //     The value must be the type of color
        //
        //   targetType:
        //     The type of the target property
        //
        //   parameter:
        //     An additional parameter for the converter to handle, not used
        //
        //   culture:
        //     The culture to use in the converter, not used
        //
        // Returns:
        //     Returns the brush value of the color
        //
        // Exceptions:
        //   T:System.ArgumentException:
        //     Exception is thrown when the value type is null or not a type of Color
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            Color color = default(Color);
            int num;
            if (value != null)
            {
                color = value as Color;
                num = ((color != null) ? 1 : 0);
            }
            else
            {
                num = 0;
            }

            if (num != 0)
            {
                return new SolidColorBrush(color);
            }

            throw new ArgumentException("Expected value to be a type of color", "value");
        }
    }

    public class ImageSourceConverter : IValueConverter
    {
        string Text { set;get; }
        //
        // Parameters:
        //   value:
        //
        //   targetType:
        //
        //   parameter:
        //
        //   culture:
        public object Convert(object? value, Type targetType, object parameter, CultureInfo culture)
        {
            Text = value as string;

            if(Text.Contains(" ") || Text.Contains("�") || Text.Contains("ü") ||
                Text.Contains("é") || Text.Contains("á") || Text.Contains("'"))
            {
              Text =  Text.Replace(" ", "_").ToLower()  + ".png";
              Text = Text.Replace("&","_");
                Text = Text.Replace("�", "_");
                Text = Text.Replace("ü", "_");
                Text = Text.Replace("é", "_");
                Text = Text.Replace("á", "_");
                Text = Text.Replace("'", "_");
                Text = Text.Replace("î", "_");
                Text = Text.Replace("-", "_");
            }
            else if(!Text.Contains(".png"))
            {
                Text = Text.ToLower() + ".png";
            }

            if (Text.Contains("0") || Text.Contains("5") || Text.Contains("4"))
            {
                Text = Text.Replace("_05", "");
                Text = Text.Replace("_04", "");
            }
            
            return Text;
        }

        //
        // Parameters:
        //   value:
        //
        //   targetType:
        //
        //   parameter:
        //
        //   culture:
        //
        // Exceptions:
        //   T:System.NotImplementedException:
        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

}
