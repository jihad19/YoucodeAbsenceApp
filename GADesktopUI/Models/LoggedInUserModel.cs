using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Models
{
    public class LoggedInUserModel : ILoggedInUserModel
    {
        public LoggedInUserModel(string token, string id, string firstName, string lastName, string emailAddress, DateTime createdDate)
        {
            Token = token;
            user_Id = id;
            FirstName = firstName;
            LastName = lastName;
            EmailAddress = emailAddress;
            CreatedDate = createdDate;
        }

        public string Token { get; set; }
        public string user_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }
        public DateTime CreatedDate { get; set; }

        public void ResetUserModel()
        {
            Token = "";
            user_Id = "";
            FirstName = "";
            LastName = "";
            EmailAddress = "";
            CreatedDate = DateTime.MinValue;
        }
    }
}
