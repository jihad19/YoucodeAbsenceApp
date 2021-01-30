using Caliburn.Micro;
using GADesktopUI.Login.EventMessages;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Login.ViewModels
{
    public class LoginConductorViewModel : Conductor<Screen>.Collection.OneActive, IHandle<AttemptLogin>, IHandle<ValidLoginCredentialsEntered>
    {
        private  IEventAggregator _eventAggregator;
        private  LoginCredentialsViewModel _loginCredentialsViewModel;
        private readonly PreloaderViewModel _preloaderViewModel;

        public LoginSideBarViewModel LoginSideBar{ get; }

        public LoginConductorViewModel(IEventAggregator eventAggregator, LoginCredentialsViewModel loginCredentialsViewModel, PreloaderViewModel preloaderViewModel, LoginSideBarViewModel loginSideBarViewModel)
        {
            _eventAggregator = eventAggregator;
            _loginCredentialsViewModel = loginCredentialsViewModel;
            _preloaderViewModel = preloaderViewModel;
            LoginSideBar = loginSideBarViewModel;
            Items.AddRange(new Screen[] { _loginCredentialsViewModel, _preloaderViewModel });


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

        }

        public void Handle(AttemptLogin message)
        {
            ActivateItem(_preloaderViewModel);
            System.Threading.Thread.Sleep(3000);
            _eventAggregator.PublishOnUIThread(new ValidLoginCredentialsEntered());
        }
    }
}
