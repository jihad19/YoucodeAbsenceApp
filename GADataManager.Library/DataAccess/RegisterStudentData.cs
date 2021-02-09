using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class RegisterStudentData
    {
        public void RegisterStudent(AccountModel account)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.spStudentRegister", account, "DataTest");
        }
    }
}
