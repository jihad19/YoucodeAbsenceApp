using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmGetFormerData
    {
        public List<AdmGetFormerModel> Get()
        {
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AdmGetFormerModel, dynamic>("spFormer", new { }, "DataTest");
            return output;
        }
    }
}
