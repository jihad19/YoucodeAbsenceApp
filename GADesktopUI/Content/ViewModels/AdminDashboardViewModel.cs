using Caliburn.Micro;
using DemoDataAbsence;
using DemoDataAbsence.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADesktopUI.Content.ViewModels
{
    public class AdminDashboardViewModel : Screen
    {
        private readonly IEventAggregator _eventAggregator;
        public BindableCollection<StudentModel> Students { get; set; }
        public BindableCollection<TeachersModel> Teachers { get; set; }
        public AdminDashboardViewModel(IEventAggregator eventAggregator)
        {
            DemoDataAccess da = new DemoDataAccess();
            Students = new BindableCollection<StudentModel>(da.GetStudents(3));
            Teachers = new BindableCollection<TeachersModel>(da.GetTeachers());
            _eventAggregator = eventAggregator;
        }

       
    }
}
