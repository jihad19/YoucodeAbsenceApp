using System;

namespace GADesktopUI.Models
{
    public interface ILoggedInUserModel
    {
        DateTime CreatedDate { get; set; }
        string EmailAddress { get; set; }
        string FirstName { get; set; }
        string user_Id { get; set; }
        string LastName { get; set; }
        string Token { get; set; }

        void ResetUserModel();
    }
}