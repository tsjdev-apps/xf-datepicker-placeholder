using Xamarin.Forms;
using Xamarin.Forms.Material.iOS;
using XFDatePicker.Controls;
using XFDatePicker.iOS.CustomRenderer;

[assembly: ExportRenderer(typeof(PlaceholderDatePicker), typeof(PlaceholderDatePickerRenderer), new[] { typeof(VisualMarker.MaterialVisual) })]
namespace XFDatePicker.iOS.CustomRenderer
{
    public class PlaceholderDatePickerRenderer : MaterialDatePickerRenderer, IMaterialEntryRenderer
    {
        string IMaterialEntryRenderer.Placeholder
        {
            get
            {
                if (Element is PlaceholderDatePicker datePicker
                    && !string.IsNullOrEmpty(datePicker.Placeholder))
                {
                    return datePicker.Placeholder;
                }

                return string.Empty;
            }
        }
    }
}