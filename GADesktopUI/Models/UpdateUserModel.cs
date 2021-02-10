using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Models
{
    public class UpdateUserModel
    {
        public UpdateUserModel(string email, string fullname, int status, string user_ID)
        {
            this.email = email;
            this.fullname = fullname;
            this.status = status;
            this.user_ID = user_ID;
        }
        public UpdateUserModel(string email, string fullname, int status, string user_ID, int Class_ID)
        {
            this.email = email;
            this.fullname = fullname;
            this.status = status;
            this.user_ID = user_ID;
            this.Class_ID = Class_ID;
        }

        public string email { get; set; }
        public string fullname { get; set; }
        public int status { get; set; }
        public string user_ID { get; set; }
        public int Class_ID { get; set; }
    }
}
