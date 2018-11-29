using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Author
    {
        public string MaDocGia { get; set; }
        public string HoTen { get; set; }
        public string GioiTinh { get; set; }
        public string NgaySinh { get; set; }
        public string DoiTuong { get; set; }
        public string NgayCap { get; set; }
        public string NgayHetHan { get; set; }

        public Author() { }
        public Author(string ma, string ten, string gt, string ns, string dt, string ngayCap, string ngayHH)
        {
            this.MaDocGia = ma;
            this.HoTen = ten;
            this.GioiTinh = gt;
            this.NgaySinh = ns;
            this.DoiTuong = dt;
            this.NgayCap = ngayCap;
            this.NgayHetHan = ngayHH;
        }

    }
}
