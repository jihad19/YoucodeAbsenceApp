using Caliburn.Micro;
using GADesktopUI.Content.ViewModels;
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
        private readonly IEventAggregator _eventAggregator;
        private readonly LoginCredentialsViewModel _loginCredentialsViewModel;
        private readonly PreloaderViewModel _preloaderViewModel;
        private readonly ContentConductorViewModel _contentConductorViewModel;

        public LoginSideBarViewModel LoginSideBar{ get; }

        public LoginConductorViewModel(IEventAggregator eventAggregator, LoginCredentialsViewModel loginCredentialsViewModel, PreloaderViewModel preloaderViewModel, LoginSideBarViewModel loginSideBarViewModel, ContentConductorViewModel contentConductorViewModel)
        {
            _eventAggregator = eventAggregator;
            _loginCredentialsViewModel = loginCredentialsViewModel;
            _preloaderViewModel = preloaderViewModel;
            LoginSideBar = loginSideBarViewModel;
            _contentConductorViewModel = contentConductorViewModel;
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
            ActivateItem(_contentConductorViewModel);
        }

        public void Handle(AttemptLogin message)
        {
            ActivateItem(_preloaderViewModel);
            _eventAggregator.PublishOnUIThread(new ValidLoginCredentialsEntered());
        }
    }
}
