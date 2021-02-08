using GADataManager.Library.DataAccess;
using GADataManager.Library.Models;
using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace GADataManager.Controllers
{
    public class FrmGetStudentController : ApiController
    {

        public FrmGetStudentsModel Get()
        {
            string userId = RequestContext.Principal.Identity.GetUserId();

            FrmGetStudentsData data = new FrmGetStudentsData();

            return data.GetUserById(userId).First();
        }

        
    }
}
