using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System;
using System.Windows.Data;
using System.Windows;
using System.Collections.ObjectModel;

namespace SampleWPFApplication.ViewModels
{
    public class VisiblityToInverseBooleanConverter:IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return ((Visibility)value == Visibility.Collapsed) ? false : true;
            }
            else 
            {
                return false;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null)
            {
                return ((bool)value == true) ? Visibility.Visible : Visibility.Collapsed;
            }
            else
            {
                return false;
            }
        }
        #endregion
    }
}
