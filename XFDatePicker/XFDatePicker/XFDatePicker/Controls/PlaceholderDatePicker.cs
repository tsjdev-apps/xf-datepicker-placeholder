using Xamarin.Forms;

namespace XFDatePicker.Controls
{
    public class PlaceholderDatePicker : DatePicker
    {
        public static readonly BindableProperty PlaceholderProperty
            = BindableProperty.Create(nameof(Placeholder), typeof(string), typeof(PlaceholderDatePicker), default(string));

        public string Placeholder
        {
            get => (string)GetValue(PlaceholderProperty);
            set => SetValue(PlaceholderProperty, value);
        }
    }
}
