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
        private IAPIHelper _apiHelper;
        private string _userName;
        private string _password;
        //private string _errorMessage;
        public LoginCredentialsViewModel(IAPIHelper apiHelper, IEventAggregator eventAggregator)
        {
            _eventAggregator = eventAggregator;
            _apiHelper = apiHelper;

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
        public async Task LoginBtn()
        {

            try
            {
                var result = await _apiHelper.Authenticate(UsernameInput, PasswordInput);
                _eventAggregator.PublishOnUIThread(new AttemptLogin());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }

       
    }
}
