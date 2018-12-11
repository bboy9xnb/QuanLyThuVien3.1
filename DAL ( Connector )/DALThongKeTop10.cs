using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTOModel;
using System.Globalization;

namespace DALConnector
{
   public  class DALThongKeTop10
    {
        string sql = "select top 10  ROW_NUMBER() OVER(ORDER BY SUM(PhieuMuonChiTiet.SoLuongMuon) DESC) AS STT, TaiLieu.TenTaiLieu, TheLoai.TenTheLoai, SUM(PhieuMuonChiTiet.SoLuongMuon) as Tongtlmuon, TheLoai.GhiChu from phieumuon, TheLoai, phieumuonchitiet, tailieu where phieumuon.MaPhieuMuon = PhieuMuonChiTiet.MaPhieuMuon and PhieuMuonChiTiet.MaSach = TaiLieu.MaTaiLieu and TaiLieu.MaTheLoai = TheLoai.MaTheLoai GROUP by TheLoai.GhiChu, PhieuMuonChiTiet.MaSach, TaiLieu.TenTaiLieu, TheLoai.TenTheLoai ORDER BY Tongtlmuon DESC";

        public DataTable ThongKeTop10(DateTime begin, DateTime end)
        {

            string sql2 = "select top 10  ROW_NUMBER() OVER(ORDER BY SUM(PhieuMuonChiTiet.SoLuongMuon) DESC) AS STT, TaiLieu.TenTaiLieu, TheLoai.TenTheLoai, SUM(PhieuMuonChiTiet.SoLuongMuon) as Tongtlmuon, TheLoai.GhiChu from phieumuon, TheLoai, phieumuonchitiet, tailieu where  PhieuMuon.NgayMuon > '" + begin + "' and PhieuMuonChiTiet.NgayTra< '" + end + "' and phieumuon.MaPhieuMuon = PhieuMuonChiTiet.MaPhieuMuon and PhieuMuonChiTiet.MaSach = TaiLieu.MaTaiLieu and TaiLieu.MaTheLoai = TheLoai.MaTheLoai GROUP by TheLoai.GhiChu, PhieuMuonChiTiet.MaSach, TaiLieu.TenTaiLieu, TheLoai.TenTheLoai ORDER BY Tongtlmuon DESC";
            ConnectorFactory.openConnectDB();
            DataTable DtTable = new DataTable();
            if (begin.Equals("") || end.Equals(""))
            {
                SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
                SqlDataReader data = cmd.ExecuteReader();

                DtTable.Load(data);



            }
            else
            {
                SqlCommand cmd = new SqlCommand(sql2, ConnectorFactory.conn);
                SqlDataReader data = cmd.ExecuteReader();

                DtTable.Load(data);
            }
            ConnectorFactory.closeConnectDB();

            return DtTable;
        }
        public DataTable ThongKeTop10NoDate()
        {

            
            ConnectorFactory.openConnectDB();
            DataTable DtTable = new DataTable();
           
                SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
                SqlDataReader data = cmd.ExecuteReader();

                DtTable.Load(data);



            ConnectorFactory.closeConnectDB();

            return DtTable;
        }
        public DataTable getDataTKQH(DateTime begin, DateTime end)
        {
            ConnectorFactory.openConnectDB();
            string sqlQuery = "select ROW_NUMBER() OVER(ORDER BY  DocGia.MaDocGia ASC) AS STT, DocGia.MaDocGia, DocGia.HoTen, TaiLieu.TenTaiLieu , DATEDIFF(DAY,PhieuMuon.ngayMuon,GETDATE())-30 as N'songayquahan' from   phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu,TheLoai where TaiLieu.MaTaiLieu = TheLoai.MaTheLoai and phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu and PhieuMuon.NgayMuon  >= ' " + begin + "' and PhieuMuon.NgayMuon  <= ' " + end + "' ";
            DataTable DtTable = new DataTable();

            SqlCommand cmd = new SqlCommand(sqlQuery, ConnectorFactory.conn);
            SqlDataReader data = cmd.ExecuteReader();

            DtTable.Load(data);


            ConnectorFactory.closeConnectDB();
            return DtTable;
        }
        public DataTable getDataTKQHNoDate()
        {
            ConnectorFactory.openConnectDB();
            string sqlQuery = "select ROW_NUMBER() OVER(ORDER BY  DocGia.MaDocGia ASC) AS STT, DocGia.MaDocGia, DocGia.HoTen, TaiLieu.TenTaiLieu , DATEDIFF(DAY,PhieuMuon.ngayMuon,GETDATE())-30 as N'songayquahan' from   phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu,TheLoai where TaiLieu.MaTaiLieu = TheLoai.MaTheLoai and phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu ";
            DataTable DtTable = new DataTable();

            SqlCommand cmd = new SqlCommand(sqlQuery, ConnectorFactory.conn);
            SqlDataReader data = cmd.ExecuteReader();

            DtTable.Load(data);


            ConnectorFactory.closeConnectDB();
            return DtTable;
        }
    }
}
