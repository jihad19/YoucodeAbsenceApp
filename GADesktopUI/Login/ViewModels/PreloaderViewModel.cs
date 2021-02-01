using Caliburn.Micro;
using GADesktopUI.Login.EventMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Login.ViewModels
{
    public class PreloaderViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;

        public PreloaderViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
        }

     
    }
}
