using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class ADMDeleteUserData
    {
        public void DeleteUser(AdmDeleteUserModel user)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("dbo.spDeleteUser", user, "DataTest");
        }
    }
}
