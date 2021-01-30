using Caliburn.Micro;
using GADesktopUI.Login.EventMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Login.ViewModels
{
    public class LoginCredentialsViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;
        public LoginCredentialsViewModel(IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;

        }

        public void LoginBtn()
        {
            _eventAggregator.PublishOnUIThread(new AttemptLogin());
        }
    }
}
