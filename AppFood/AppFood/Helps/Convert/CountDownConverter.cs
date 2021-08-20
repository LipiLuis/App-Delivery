using System;
using System.Globalization;
using Xamarin.Forms;

namespace AppFood.Helps.Convert
{
    public class CountDownConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            double time = 0;
            double.TryParse(parameter.ToString(), out var totalTime);
            double.TryParse(value.ToString(), out var progress);
            time = progress <= double.Epsilon ? totalTime : (totalTime - (totalTime * progress));
            var timeSpan = TimeSpan.FromMilliseconds(time);
            return $"{timeSpan.Hours:00:00}{timeSpan.Minutes:00;00}:{timeSpan.Seconds:00;00}";
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
