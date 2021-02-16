using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace GADesktopUI.Content.ViewModels
{
    public class MenuViewModel : Screen
    {
        public Thickness BottomMargin { get; set; }

        public MenuViewModel()
        {
            BottomMargin = new Thickness(0, 0, 0, 15);
        }
    }
}
