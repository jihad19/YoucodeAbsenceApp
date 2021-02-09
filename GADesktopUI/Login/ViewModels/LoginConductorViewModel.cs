﻿using Caliburn.Micro;
using GADesktopUI.APIHelpers;
using GADesktopUI.Content.ViewModels;
using GADesktopUI.Login.EventMessages;
using GADesktopUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Login.ViewModels
{
    public class LoginConductorViewModel : Conductor<Screen>.Collection.OneActive, IHandle<AttemptLogin>
    {
        private readonly IEventAggregator _eventAggregator;
        private readonly LoginCredentialsViewModel _loginCredentialsViewModel;
        private readonly PreloaderViewModel _preloaderViewModel;
        private IAPIHelper _apiHelper;
        private IAddClassEndpoint _addClass;

        public LoginSideBarViewModel LoginSideBar{ get; }

        public LoginConductorViewModel(
            IEventAggregator eventAggregator,
            LoginCredentialsViewModel loginCredentialsViewModel,
            PreloaderViewModel preloaderViewModel,
            LoginSideBarViewModel loginSideBarViewModel,
            IAPIHelper apiHelper,
            IAddClassEndpoint addClass

            )
        {
            _eventAggregator = eventAggregator;
            _loginCredentialsViewModel = loginCredentialsViewModel;
            _preloaderViewModel = preloaderViewModel;
            LoginSideBar = loginSideBarViewModel;
            _apiHelper = apiHelper;
            _addClass = addClass;


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


       
        public async  void Handle(AttemptLogin message)
        {
            // _eventAggregator.PublishOnUIThread(new ValidLoginCredentialsEntered());
            try
            {


                await _apiHelper.RegisterSecretary();
                //ErrorMessage = "";
                /* _loginCredentialsViewModel.ErrorMessage = "";
                 ActivateItem(_preloaderViewModel);
                 var result = await _apiHelper.Authenticate(message.Username, message.Password);
                 _eventAggregator.PublishOnUIThread(new ValidLoginCredentialsEntered());*/
            }
            catch (Exception ex)
            {
                ActivateItem(_loginCredentialsViewModel);
                _loginCredentialsViewModel.ErrorMessage = ex.Message;
            }
        }
    }
}
