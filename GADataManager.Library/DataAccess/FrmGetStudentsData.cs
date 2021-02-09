using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class FrmGetStudentsData
    {
        public List<FrmGetStudentsModel> GetUserById(string id)
        {
            SqlDataAccess sql = new SqlDataAccess();

            var p = new { User_Id = id};

            var output = sql.LoadData<FrmGetStudentsModel, dynamic>("spFrmGetStudents", p, "DataTest");

            return output;

        }
    }
}
