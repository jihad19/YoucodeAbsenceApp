using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Content.ViewModels
{
    public class AdminDashboardViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public AdminDashboardViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }
    }
}
