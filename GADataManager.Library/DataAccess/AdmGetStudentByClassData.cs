using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmGetStudentByClassData
    {
        public List<AdmGetStudentByClassModel> Get(int classId)
        {
            var p = new { classId = classId };
            SqlDataAccess sql = new SqlDataAccess();
            var output = sql.LoadData<AdmGetStudentByClassModel, dynamic>("spGetStudentByClass", new { }, "DataTest");
            return output;
        }
    }
}
