using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;
using System.Windows.Media;

namespace FordFulkersonVisualization
{
    public class EdgeStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            EdgeStatus status = (EdgeStatus)value;

            switch (status)
            {
                case EdgeStatus.Default:
                    return new SolidColorBrush(Colors.Black);
                    break;
                case EdgeStatus.Choosen:
                    return new SolidColorBrush(Colors.DarkGreen);
                    break;
                case EdgeStatus.Inspected:
                    return new SolidColorBrush(Colors.DimGray);
                    break;
                case EdgeStatus.Saturated:
                    return new SolidColorBrush(Colors.Red);
                    break;
                case EdgeStatus.Bottleneck:
                    return new SolidColorBrush(Colors.Red);
                    break;
                default:
                    return new SolidColorBrush(Colors.Black);
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
