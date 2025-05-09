using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_1.MVVM.Services
{
    public class NavUtilities
    {
        public static void Examine(INavigation navigation)
        {
            StringBuilder builder = new();
            foreach (var page in navigation.NavigationStack)
            {
                builder.AppendLine(page.GetType().Name);
            }
            builder.AppendLine("-----------");
            Debug.WriteLine(builder.ToString());
        }

        public static void DeletePage(INavigation navigation, string pageName)
        {
            var pageToDelete =
                 navigation.NavigationStack
                 .FirstOrDefault(x => x.GetType().Name == pageName);
            if (pageToDelete != null)
            {
                navigation.RemovePage(pageToDelete);
            }
        }
    }
}
