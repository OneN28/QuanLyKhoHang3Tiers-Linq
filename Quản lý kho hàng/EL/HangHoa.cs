using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Linq.Mapping;


namespace Quản_lý_kho_hàng.EL
{
    [Table(Name ="Hanghoa")]
    class HangHoa
    {
        public HangHoa()
        {

        }
        public HangHoa(string maHang, string tenHang, string noiChua, string giaHang, string soLuongHang)
        {
            MaHang = maHang;
            TenHang = tenHang;
            NoiChua = noiChua;
            GiaHang = giaHang;
            SoLuongHang = soLuongHang;
        }
        [Column(Name ="MaHang",IsPrimaryKey =true)]
        public string MaHang { get; set; }
        [Column(Name ="TenHang")]
        public string TenHang { get; set; }
        [Column(Name ="NoiChua")]
        public string NoiChua { get; set; }
        [Column(Name ="GiaHang")]
        public string GiaHang { get; set; }
        [Column(Name ="SoLuongHang")]
        public string SoLuongHang { get; set; }
    }
}
