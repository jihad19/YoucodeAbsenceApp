using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class GetAllRequestsData
    {
        public List<AllRequestsModel> Get()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AllRequestsModel, dynamic>("spAllRequests", new { }, "DataTest");
            return output;
        }
    }
}
