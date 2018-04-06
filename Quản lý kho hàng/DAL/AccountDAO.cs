using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using Quản_lý_kho_hàng.EL;

using System.Data.Linq;

namespace Quản_lý_kho_hàng.DAL
{
    class AccountDAO
    {
        
        public List<Account> SelectAll()
        {
            Table<Account> tbAccount = ConfigureManager.Database.GetTable<Account>();

            var query = from acc in tbAccount select acc;

            return query.ToList<Account>();
        }

        public bool Insert(Account account)
        {
            ConfigureManager.Database.GetTable<Account>().InsertOnSubmit(account);
            try
            {
                ConfigureManager.Database.SubmitChanges();
                return true;
            }
            catch
            {
                return false;
            }
        }

    }
}
