using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class AdmUpdateUserData
    {
        public void UpdateUser(AdmUpdateUserModel user)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.spUpdateUser", user, "DataTest");
        }
    }
}
