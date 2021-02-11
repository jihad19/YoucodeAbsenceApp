using GADataManager.Library.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GADataManager.Controllers
{
    public class StudentAbsenceSingleController : ApiController
    {
        public List<StudentAbsenceSingleModel> Get()
        {
            StudentAbsenceSingleData data = new StudentAbsenceSingleData();
            return data.Get();
        }
    }
}