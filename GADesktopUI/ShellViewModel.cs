using Caliburn.Micro;
using GADesktopUI.Content.ViewModels;
using GADesktopUI.Login.EventMessages;
using GADesktopUI.Login.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI
{
    public class ShellViewModel: Conductor<Screen>.Collection.OneActive,  IHandle<ValidLoginCredentialsEntered>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly LoginConductorViewModel _loginConductorViewModel;
        private readonly ContentConductorViewModel _contentConductorViewModel;

        public ShellViewModel
            (
                IEventAggregator eventAggregator,
                LoginConductorViewModel loginConductorViewModel,
                ContentConductorViewModel contentConductorViewModel
            )
        {
            _eventAggregator = eventAggregator;
            _loginConductorViewModel = loginConductorViewModel;
            _contentConductorViewModel = contentConductorViewModel;
            Items.AddRange(new Screen[] { _loginConductorViewModel });

        }

        protected override void OnActivate()
        {
            base.OnActivate();
            _eventAggregator.Subscribe(this);
            ActivateItem(_loginConductorViewModel);
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


        //Windows Close button
        public void closeWindow()
        {

            this.TryClose();
        }
    }
}
