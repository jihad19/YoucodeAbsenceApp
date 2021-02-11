using GADataManager.Library.Internal.DataAccess;
using GADataManager.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GADataManager.Library.DataAccess
{
    public class RegisterSecretaryData
    {
        public void RegisterSecretary(AccountModel account)
        {
            SqlDataAccess sql = new SqlDataAccess();

            sql.SaveData("spSecretaryRegister", account, "DataTest");
        }
    }
}
