using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Book
    {
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }
        public string MaTheLoai { get; set; }
        public int SoLuong { get; set; }
        public string NhaXuatBan { get; set; }
        public int NamXuatBan { get; set; }
        public string TacGia { get; set; }

        public Book() { }
        public Book(string matlieu, string tentl, string matloai, int sl, string nxb, int namxb, string tg)
        {
            this.MaTaiLieu = matlieu;
            this.TenTaiLieu = tentl;
            this.MaTheLoai = matloai;
            this.SoLuong = sl;
            this.NhaXuatBan = nxb;
            this.NamXuatBan = namxb;
            this.TacGia = tg;
        }
    }
    public class kind
    {
        public string matheloai { get; set; }
        public string tentheloai { get; set; }
        public string ghichu { get; set; }
        public kind() { }
        public kind(string ma, string ten, string ghi)
        {
            this.matheloai = ma;
            this.tentheloai = ten;
            this.ghichu = ghi;
        }
    }
}
