using System;
using System.Collections.Generic;
using System.Text;

namespace DemoDataAbsence.Models
{
    public class StudentModel
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PicPath { get; set; }
        public int Age { get; set; }
        public bool IsActive { get; set; }
        public List<AbsenceModel> Absence { get; set; } = new List<AbsenceModel>();
        public List<RequestsModel> Requests { get; set; } = new List<RequestsModel>();
        public RequestsModel LastRequest { get; set; }

    public string FullName
        {
            get
            {
                return $"{ FirstName } { LastName }";
            }
        }
    }
}
