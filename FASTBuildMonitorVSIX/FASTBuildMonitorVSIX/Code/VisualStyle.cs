using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Media;

namespace FASTBuildMonitorVSIX
{
    public static class VisualStyle
    {
        public static SolidColorBrush Foreground;
        public static SolidColorBrush MediumGray = new SolidColorBrush(Color.FromArgb(255, 128, 128, 128));

        public static void Initialize(FrameworkElement context)
        {
            var color = VisualStyle.GetResource<System.Windows.Media.Color>(context, Microsoft.VisualStudio.PlatformUI.EnvironmentColors.ToolWindowTextColorKey);
            if (color != null)
            {
                Foreground = new SolidColorBrush(color);
            }

            if (Foreground == null)
            {
                Foreground = Brushes.Black;
            }
        }

        public static T GetResource<T>(FrameworkElement context, object key)
        {
            T result = default(T);

            try
            {
                var res = context.FindResource(key);

                result = (T)res;
            }

            catch (Exception e)
            {
                Console.WriteLine($"Exception: {e}");
            }

            return result;
        }
    }
}
