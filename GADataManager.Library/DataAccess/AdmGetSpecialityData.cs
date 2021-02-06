using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmGetSpecialityData
    {
        public List<AdmGetSpecialityModel> Get()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AdmGetSpecialityModel, dynamic>("spSpeciality", new { }, "DataTest");
            return output;
        }

    }
}
