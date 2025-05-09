using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.MVVM.Convertors
{
    public class ObservableCollectionConvertor : IValueConverter
    {
        public object? Convert(object? value, Type targetType, object? parameter, CultureInfo culture)
        {                        
            if (value is double price)
            //equavalent to var price = (double)value; --_--
            {
                return price.ToString();
            }

            if (value is int quantity)
            {
                 string temp = $"{quantity} Items";
                return temp;
                
            }
                 
            else
            {
                Debug.WriteLine("Conversion failed: value is not of the expected type.");
                return string.Empty;

            }
                
        }

        public object? ConvertBack(object? value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}


