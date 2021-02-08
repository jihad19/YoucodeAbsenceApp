using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmGetClassData
    {
        public List<AdmGetClassModel> Get()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AdmGetClassModel, dynamic>("spGetClass", new { }, "DataTest");
            return output;
        }
    }
}
