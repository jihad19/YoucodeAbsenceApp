using Caliburn.Micro;
using GADesktopUI.APIHelpers;
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
        //private IAPIHelper _apiHelper;
        private string _userName;
        private string _password;
        private string _errorMessage;
        public LoginCredentialsViewModel( IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
           

        }

        public string PasswordInput
        {
            get { return _password; }
            set
            {
                _password = value;
                NotifyOfPropertyChange(() => PasswordInput);
                NotifyOfPropertyChange(() => CanLoginBtn);
            }
        }

        public string UsernameInput
        {
            get { return _userName; }
            set
            {
                _userName = value;
                NotifyOfPropertyChange(() => UsernameInput);
                NotifyOfPropertyChange(() => CanLoginBtn);
            }
        }

        public string ErrorMessage
        {
            get { return _errorMessage; }
            set
            {
                _errorMessage = value;
                NotifyOfPropertyChange(() => IsErrorVisible);
                NotifyOfPropertyChange(() => ErrorMessage);
            }
        }

        public bool IsErrorVisible
        {
            get
            {
                bool output = false;

                if (ErrorMessage?.Length > 0)
                {
                    output = true;
                }

                return output;
            }
        }

        public bool CanLoginBtn
        {
            get
            {
                bool output = false;

                if (UsernameInput?.Length > 0 && PasswordInput?.Length > 0)
                {
                    output = true;
                }

                return output;
            }

        }
        public void LoginBtn()
        {
            _eventAggregator.PublishOnUIThread(new AttemptLogin(UsernameInput, PasswordInput));


        }

       
    }
}
