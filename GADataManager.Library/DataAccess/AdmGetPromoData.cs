using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmGetPromoData
    {
        public List<AdmGetPromoModel> Get()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AdmGetPromoModel, dynamic>("spPromo", new { }, "DataTest");
            return output;
        }
    }
}
