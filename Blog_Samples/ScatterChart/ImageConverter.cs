using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScatterChart
{
    public class ImageConverter : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            string image = string.Empty;
            if (value != null)
            {
                 image = value.ToString();
                if (image != null)
                {
                    image = image.ToLower() + ".png";
                }
            }
            return image;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class TooltipLabel : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            
            if (value != null)
            {
                double label = double.Parse(value.ToString());
                if (label <= 1000000)
                {
                    return label.ToString("#,##0,k", CultureInfo.InvariantCulture);
                }
                return label.ToString("#,##0,,M", CultureInfo.InvariantCulture);
            }

            return value;
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

