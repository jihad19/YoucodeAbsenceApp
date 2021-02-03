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

        public ContentConductorViewModel
            (
            IEventAggregator eventAggregator,
            MenuViewModel menuViewModel
            )
        {
            _eventAggregator = eventAggregator;
            MenuBar = menuViewModel;
        }

        public MenuViewModel MenuBar { get; }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);

        }

    }
}
