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
    public class VertexStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            VertexStatus status = (VertexStatus)value;

            switch (status)
            {
                case VertexStatus.Default:
                    return new SolidColorBrush(Colors.DeepSkyBlue); 
                    break;
                case VertexStatus.Choosen:
                    return new SolidColorBrush(Colors.LightSlateGray);
                    break;
                case VertexStatus.Inspected:
                    return new SolidColorBrush(Colors.Gold);
                    break;
                default:
                    return new SolidColorBrush(Colors.Aqua);
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class SourceSinkVertexStatusConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            VertexStatus status = (VertexStatus)value;

            switch (status)
            {
                case VertexStatus.Default:
                    return new SolidColorBrush(Colors.DodgerBlue);
                    break;
                case VertexStatus.Choosen:
                    return new SolidColorBrush(Colors.Gray);
                    break;
                case VertexStatus.Inspected:
                    return new SolidColorBrush(Colors.Goldenrod);
                    break;
                default:
                    return new SolidColorBrush(Colors.DodgerBlue);
                    break;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
