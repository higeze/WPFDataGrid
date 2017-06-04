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
    public class PersonToPersonsConverter : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && value is Models.Person)
            {
                var persons = new ObservableCollection<Models.Person>();
                persons.Add(value as Models.Person);
                return persons;
            }
            else 
            {
                return null;
            }
        }

        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value != null && value is ObservableCollection<Models.Person> && (value as ObservableCollection<Models.Person>).Count == 1)
            {
                return (value as ObservableCollection<Models.Person>)[0];
            }
            else
            {
                return null;
            }
        }
        #endregion
    }
}
