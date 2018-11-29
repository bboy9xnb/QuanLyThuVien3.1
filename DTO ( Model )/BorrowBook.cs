using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public  class BorrowBook
    {
        private string maphieumuon;

        public string Maphieumuon
        {
            get { return maphieumuon; }
            set { maphieumuon = value; }
        }
        private string madocgia;

        public string Madocgia
        {
            get { return madocgia; }
            set { madocgia = value; }
        }
        private DateTime ngaymuon;

        public DateTime Ngaymuon
        {
            get { return ngaymuon; }
            set { ngaymuon = value; }
        }
        private string manhanvien;

        public string Manhanvien
        {
            get { return manhanvien; }
            set { manhanvien = value; }
        }
        public BorrowBook() { }
        public BorrowBook(string maphieumuon, string madocgia, DateTime ngaymuon, string manhanvien)
        {
            this.maphieumuon = maphieumuon;
            this.madocgia = madocgia;
            this.ngaymuon = ngaymuon;
            this.manhanvien = manhanvien;

        }
    }
    public class BorrowDetail
    {
        public string MaPhieuMuon { get; set; }
        public string MaDocGia { get; set; }
        public string TenDocGia { get; set; }
        public string NgayMuon { get; set; }
        public string MaNhanVien { get; set; }
        public string TenNhanVien { get; set; }
        public string MaTaiLieu { get; set; }
        public string TenTaiLieu { get; set; }
        public string SoluongMuon { get; set; }
        public BorrowDetail() { }
        public BorrowDetail(string map, string madg, string tendg, string ngaym, string manv, string tennv, string matl, string tentl, string slm)
        {
            this.MaPhieuMuon = map;
            this.MaDocGia = madg;
            this.TenDocGia = tendg;
            this.NgayMuon = ngaym;
            this.MaNhanVien = manv;
            this.TenNhanVien = tennv;
            this.MaTaiLieu = matl;
            this.TenTaiLieu = tentl;
            this.SoluongMuon = slm;
        }
    }
}
