using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.Models
{
    public class AdmUpdateUserModel
    {
        public string email { get; set; }
        public string fullname { get; set; }
        public int status { get; set; }
        public string user_ID { get; set; }
        public int class_ID { get; set; }

    }
}
