using Caliburn.Micro;
using GADesktopUI.Login.EventMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Login.ViewModels
{
    public class LoginConductorViewModel : Conductor<Screen>.Collection.OneActive, IHandle<ValidLoginCredentialsEntered>
    {
        private  IEventAggregator _eventAggregator;
        private  LoginCredentialsViewModel _loginCredentialsViewModel;
        public LoginConductorViewModel(IEventAggregator eventAggregator, LoginCredentialsViewModel loginCredentialsViewModel)
        {
            _eventAggregator = eventAggregator;
            _loginCredentialsViewModel = loginCredentialsViewModel;
            Items.AddRange(new Screen[] { _loginCredentialsViewModel });


        }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);
            ActivateItem(_loginCredentialsViewModel);
        }

        protected override void OnDeactivate(bool close)
        {
            base.OnDeactivate(close);
            _eventAggregator.Unsubscribe(this);
        }

        public void Handle(ValidLoginCredentialsEntered message)
        {
            throw new NotImplementedException();
        }
    }
}
