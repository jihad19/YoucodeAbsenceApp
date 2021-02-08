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
    public class AdmGetStudentByClassController : ApiController
    {
        public List<AdmGetStudentByClassModel> Get(int ID)
        {
            AdmGetStudentByClassData data = new AdmGetStudentByClassData();
            return data.Get(ID);
        }
    }
}
