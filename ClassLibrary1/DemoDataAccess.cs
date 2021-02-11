using DemoDataAbsence.Models;
using System;
using System.Collections.Generic;

namespace DemoDataAbsence
{
    public class DemoDataAccess
    {
        Random rnd = new Random();
        string[] firstNames = new string[] { "Bob", "Sue", "Carla", "Frank", "Monique", "Carlton", "Miguel", "Daniel", "Santiago", "John", "Robert" };
        string[] lastNames = new string[] { "Smith", "Jones", "Garcia", "Miller", "Thomas", "Lee", "Taylor", "Wilson", "Martinez", "Davis", "Hernandez" };
        string[] PicsPaths = new string[] { "/GADesktopUI;component/images/faces/lm.jpg", "/GADesktopUI;component/images/faces/ff.jpg", "/GADesktopUI;component/images/faces/gls.jpg", "/GADesktopUI;component/images/faces/arm.jpg", "/GADesktopUI;component/images/faces/hji.jpg", "/GADesktopUI;component/images/faces/kll.jpg", "/GADesktopUI;component/images/faces/klop.jpg", "/GADesktopUI;component/images/faces/lpi.jpg", "/GADesktopUI;component/images/faces/macrol.jpg", "/GADesktopUI;component/images/faces/org.jpg", "/GADesktopUI;component/images/faces/ty.jpg" };
        string[] AbsenceTypes = new string[] {"full day", "half day" };
        string[] RequestsTypes = new string[] {"sick leave", "sick leave", "sick leave", "Casual leave", "Event Leave" };
        string[] Specialty = new string[] { "Specialty C#", "Specialty JEE", "Specialty FB", "Specialty TC" };
        bool[] RequestStatus = new bool[] { true, false };
        string[] RequestDescription = new string[] { "I'm sick", "I have an invite to an event", "I have to take care of some business" };
        int[] age = new int[] { 22, 23, 24, 20, 29, 21, 25, 22, 30, 23, 26  };
        bool[] IsActive = new bool[] { true, false };
        DateTime lowEndDate = new DateTime(2020, 1, 1);
        int daysFromLowDate;

        public DemoDataAccess()
        {
            daysFromLowDate = (DateTime.Today - lowEndDate).Days;

        }

        public List<StudentModel> GetStudents(int total = 10)
        {
            List<StudentModel> output = new List<StudentModel>();

            for (int i = 0; i < total; i++)
            {

                output.Add(GetStudent(i + 1));
            }

            return output;
        }

        public List<TeachersModel> GetTeachers(int total = 7)
        {
            List<TeachersModel> output = new List<TeachersModel>();

            for (int i = 0; i < total; i++)
            {

                output.Add(GetTeacher(i + 1));
            }

            return output;
        }

        public TeachersModel GetTeacher(int id)
        {
            TeachersModel output = new TeachersModel();

            output.TeacherId = id;
            output.FirstName = GetRandomItem(firstNames);
            output.LastName = GetRandomItem(lastNames);
            output.PicPath = GetRandomItem(PicsPaths);
            output.Specialty = GetRandomItem(Specialty);
          
           
            return output;
        }

        public StudentModel GetStudent(int id)
        {
            StudentModel output = new StudentModel();

            output.StudentId = id;
            output.FirstName = GetRandomItem(firstNames);
            output.LastName = GetRandomItem(lastNames);
            output.PicPath = GetRandomItem(PicsPaths);
            output.IsActive = GetRandomItem(IsActive);
            //output.DateOfBirth = GetRandomDate();
            //output.Age = GetAgeInYears(output.DateOfBirth);
            output.Age = GetRandomItem(age);

            int RequestsCount = rnd.Next(1, 5);
            int AbsenceCount = rnd.Next(1, 3);

            for (int i = 0; i < RequestsCount; i++)
            {
                output.Requests.Add(GetRequests(((id - 1) * 5) + i + 1));
            }

            for (int i = 0; i < AbsenceCount; i++)
            {
                output.Absence.Add(GetAbsence(((id - 1) * 5) + i + 1));
            }
            output.LastRequest = output.Requests[output.Requests.Count - 1];
            return output;

            
        }

        private AbsenceModel GetAbsence(int id)
        {
            AbsenceModel output = new AbsenceModel();
            output.absid = id;
            output.date = GetRandomDate();
            output.type = GetRandomItem(AbsenceTypes);

            return output;
        }

        private RequestsModel GetRequests(int id)
        {
            RequestsModel output = new RequestsModel();

            output.reqid = id;
            output.description = GetRandomItem(RequestDescription);
            output.status = GetRandomItem(RequestStatus);
            output.type = GetRandomItem(RequestsTypes);
            output.date = GetRandomDate();

            return output;
        }

        public T GetRandomItem<T>(T[] data)
        {
            return data[rnd.Next(0, data.Length)];
        }

        private DateTime GetRandomDate()
        {
            return lowEndDate.AddDays(rnd.Next(daysFromLowDate));
        }

        //private int GetAgeInYears(DateTime birthday)
        //{
        //    DateTime now = DateTime.Today;
        //    int age = now.Year - birthday.Year;
        //    if (now < birthday.AddYears(age))
        //    {
        //        age--;
        //    }

        //    return age;
        //}
    }
}
