using Android.Content;
using Xamarin.Forms;
using Xamarin.Forms.Material.Android;
using Xamarin.Forms.Platform.Android;
using XFDatePicker.Controls;
using XFDatePicker.Droid.CustomRenderer;

[assembly: ExportRenderer(typeof(PlaceholderDatePicker), typeof(PlaceholderDatePickerRenderer), new[] { typeof(VisualMarker.MaterialVisual) })]
namespace XFDatePicker.Droid.CustomRenderer
{
    public class PlaceholderDatePickerRenderer : MaterialDatePickerRenderer
    {
        public PlaceholderDatePickerRenderer(Context context) : base(context)
        {
        }

        protected override void OnElementChanged(ElementChangedEventArgs<DatePicker> e)
        {
            base.OnElementChanged(e);

            if (Control != null && Element is PlaceholderDatePicker datePicker 
                && !string.IsNullOrWhiteSpace(datePicker.Placeholder))
            {
                Control.HintEnabled = true;
                Control.Hint = datePicker.Placeholder;
            }
        }
    }
}