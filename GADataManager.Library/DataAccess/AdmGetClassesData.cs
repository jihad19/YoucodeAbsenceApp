using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmGetClassesData
    {
        public List<AdmGetClassesModel> Get()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AdmGetClassesModel, dynamic>("spGetClass", new { }, "DataTest");
            return output;
        }
    }
}
