using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Quản_lý_kho_hàng.DAL;
using Quản_lý_kho_hàng.EL;

namespace Quản_lý_kho_hàng.BL
{
    class HangHoaBUS
    {
        HangHoaDAO hangHoaDAO;
        public HangHoaBUS()
        {
            hangHoaDAO = new HangHoaDAO();
        }
        public bool Insert(HangHoa hangHoa)
        {
            return hangHoaDAO.Insert(hangHoa);
        }

        public bool Update(int index, HangHoa hangHoa)
        {
            return hangHoaDAO.Update(index, hangHoa);
        }
        public bool Delete(string maHang)
        {
            return hangHoaDAO.Delete(maHang);
        }
        public List<HangHoa> ViewAll()
        {
            return hangHoaDAO.SelectAll();
        }
        public List<HangHoa> Search(HangHoa hangHoa)
        {
            List<HangHoa> result = ViewAll();
            if (hangHoa.MaHang != "")
            {
                result = result.Where((hang) => hang.MaHang == hangHoa.MaHang).ToList<HangHoa>();
            }
            if(hangHoa.TenHang != "")
            {
                result = result.Where((hang) => hang.TenHang == hangHoa.TenHang).ToList<HangHoa>();
            }
            if (hangHoa.NoiChua != "")
            {
                result = result.Where((hang) => hang.NoiChua == hangHoa.NoiChua).ToList<HangHoa>();
            }
            if (hangHoa.GiaHang != "")
            {
                result = result.Where((hang) => hang.GiaHang == hangHoa.GiaHang).ToList<HangHoa>();
            }
            if (hangHoa.SoLuongHang != "")
            {
                result = result.Where((hang) => hang.SoLuongHang == hangHoa.SoLuongHang).ToList<HangHoa>();
            }

            return result;
        }
    }
}
