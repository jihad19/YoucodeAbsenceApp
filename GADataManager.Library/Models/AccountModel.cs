using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.Models
{
    public class AccountModel
    {
        public AccountModel(string user_ID, string email)
        {
            this.user_ID = user_ID;
            this.email = email;
        }

        public string user_ID { get; set; }
        public string email { get; set; }
    }
}
}
