using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace OgromniyBober.NavHost
{
    internal class AppNav
    {
        private static List<PageComps> history = new List<PageComps>();

        private static void Refresh(PageComps page)
        {
            App.mainWindow.MainWindowFrame.NavigationService.Navigate(page.Page);
            App.mainWindow.MainTitle.Text = page.Title;
        }

        public static void Navigate(PageComps page)
        {
            history.Add(page);
            Refresh(page);
        }
        public static void NavigateAndPop()
        {
            history.RemoveAt(history.Count - 1);
            Refresh(history[history.Count - 1]);
            //if (history.Count >= 3)
            //{
            //    history.RemoveAt(history.Count - 1);
            //    Refresh(history[history.Count - 1]);
            //}
        }
        public static void DropHistory()
        {
            history.Clear();
        }
    }
}
