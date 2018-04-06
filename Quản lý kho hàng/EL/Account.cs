using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace Quản_lý_kho_hàng.EL
{
    [Table(Name ="Account")]
    class Account
    {
        public Account()
        {

        }
        public Account(string username, string password)
        {
            Username = username;
            Password = password;
        }
        [Column(Name ="Username", IsPrimaryKey =true)]
        public string Username { get; set; }
        [Column(Name ="Password")]
        public string Password { get; set; }

    }
    
}
