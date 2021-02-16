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
    public class AdmGetPromoController : ApiController
    {
        public List<AdmGetPromoModel> Get()
        {
            AdmGetPromoData data = new AdmGetPromoData();
            return data.Get();
        }
    }
}
