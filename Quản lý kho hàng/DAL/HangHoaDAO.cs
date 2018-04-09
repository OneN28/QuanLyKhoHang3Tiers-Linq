using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.Linq;

using Quản_lý_kho_hàng.EL;

namespace Quản_lý_kho_hàng.DAL
{
    class HangHoaDAO
    {
        public List<HangHoa> SelectAll()
        {
            Table<HangHoa> tbHangHoa = ConfigureManager.Database.GetTable<HangHoa>();
            var query = from hanghoa in tbHangHoa select hanghoa;
            return query.ToList<HangHoa>();
        }
        public bool Delete(string maHang)
        {
            Table<HangHoa> tbHangHoa = ConfigureManager.Database.GetTable<HangHoa>();
            var deletion = from hanghoa in tbHangHoa where hanghoa.MaHang == maHang select hanghoa;
            if (deletion.ToList().Count == 1)
            {
                tbHangHoa.DeleteOnSubmit(deletion.ToList()[0]);
            }
            try
            {
                ConfigureManager.Database.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Insert(HangHoa hangHoa)
        {
            Table<HangHoa> tbHangHoa = ConfigureManager.Database.GetTable<HangHoa>();
            tbHangHoa.InsertOnSubmit(hangHoa);
            try
            {
                ConfigureManager.Database.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
        public bool Update(string maHangOld, HangHoa hangHoa)
        {
            Table<HangHoa> tbHangHoa = ConfigureManager.Database.GetTable<HangHoa>();
            var update = from hanghoa in tbHangHoa where hangHoa.MaHang == maHangOld select hanghoa;
            for(int i = 0; i < update.ToList().Count; i++)
            {
                update.ToList()[i] = hangHoa;
            }
            try
            {
                ConfigureManager.Database.SubmitChanges();
                return true;
            }
            catch { return false; }
        }
    }
}
