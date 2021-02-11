using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoDataAbsence.Models
{
    public class TeachersModel
    {
        public int TeacherId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PicPath { get; set; }
        public string Specialty { get; set; }

        public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}

