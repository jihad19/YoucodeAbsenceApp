using Caliburn.Micro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Content.ViewModels
{
    public class ContentConductorViewModel : Conductor<Screen>.Collection.OneActive
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly AdminDashboardViewModel _adminDashboardViewModel;

        public ContentConductorViewModel
            (
            IEventAggregator eventAggregator,
            MenuViewModel menuViewModel,
            AdminDashboardViewModel adminDashboardViewModel,
            HeaderViewModel header
            )
        {
            _eventAggregator = eventAggregator;
            MenuBar = menuViewModel;
            _adminDashboardViewModel = adminDashboardViewModel;
            Header = header;
        }

        public MenuViewModel MenuBar { get; }
        public HeaderViewModel Header { get; }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);
            ActivateItem(_adminDashboardViewModel);
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
            _eventAggregator.Unsubscribe(this);
        }
    }
}
