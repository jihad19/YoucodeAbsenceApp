using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class StudentAbsenceSingleData
    {
        public List<StudentAbsenceSingleModel> Get(string Id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { Id = Id };

            var output = sql.LoadData<StudentAbsenceSingleModel, dynamic>("dbo.spStudent_GetAbsenceSingle", p, "DataTest");

            return output;
        }
    }
}
