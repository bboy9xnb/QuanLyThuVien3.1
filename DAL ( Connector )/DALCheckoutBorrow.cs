using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using DTOModel;
namespace DALConnector
{
    public class DALCheckoutBorrow
    {
        
        public DataTable listBorrowNoDate()
        {
            DataTable dbtb = new DataTable();
            ConnectorFactory.openConnectDB();
            string sql = "select ROW_NUMBER() OVER(ORDER BY TheLoai.TenTheLoai ASC) AS STT, TheLoai.TenTheLoai, COUNT(TaiLieu.MaTheLoai) as SoLanMuon from  phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu,TheLoai where TaiLieu.MaTaiLieu = TheLoai.MaTheLoai and phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu GROUP by TaiLieu.MaTheLoai , TheLoai.TenTheLoai";
            SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dbtb.Load(dr);
            ConnectorFactory.closeConnectDB();
            return dbtb;
        }
        public DataTable listBorrow(DateTime begin, DateTime end)
        {
            DataTable dbtb = new DataTable();
            ConnectorFactory.openConnectDB();
            string sql = "select ROW_NUMBER() OVER(ORDER BY TheLoai.TenTheLoai ASC) AS STT, TheLoai.TenTheLoai, COUNT(TaiLieu.MaTheLoai) as SoLanMuon from  phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu,TheLoai where PhieuMuon.NgayMuon >= '" + begin + "' and PhieuMuon.NgayMuon <='" + end + "' and TaiLieu.MaTaiLieu = TheLoai.MaTheLoai and phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu GROUP by TaiLieu.MaTheLoai , TheLoai.TenTheLoai";
            SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            dbtb.Load(dr);
            ConnectorFactory.closeConnectDB();
            return dbtb;
        }
        public List<CheckoutBorrow> listDataCheckoutBorrow(DateTime begin, DateTime end)
        {
            List<CheckoutBorrow> list = new List<CheckoutBorrow>();
            string sql = "select ROW_NUMBER() OVER(ORDER BY TheLoai.TenTheLoai ASC) AS STT, TheLoai.TenTheLoai, COUNT(TaiLieu.MaTheLoai) as SoLanMuon from  phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu,TheLoai where PhieuMuon.NgayMuon > '"+begin+ "' and PhieuMuonChiTiet.NgayTra <'" + end + "' and TaiLieu.MaTaiLieu = TheLoai.MaTheLoai and phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu GROUP by TaiLieu.MaTheLoai , TheLoai.TenTheLoai";
            ConnectorFactory.openConnectDB();
        //    string sqlInsertTL = "select * from TheLoai";
            SqlCommand cmdSql = new SqlCommand(sql, ConnectorFactory.conn);
            SqlDataReader data = cmdSql.ExecuteReader();
            while (data.Read())
            {
                list.Add(new CheckoutBorrow(data["STT"].ToString(), data["TenTheLoai"].ToString(), int.Parse(data["SoLanMuon"].ToString())));
            }
            ConnectorFactory.closeConnectDB();
            return list;
        }
        //select ROW_NUMBER() OVER(ORDER BY TheLoai.TenTheLoai ASC) AS STT, TheLoai.TenTheLoai, COUNT(TaiLieu.MaTheLoai) as SoLanMuon from  phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu,TheLoai where PhieuMuon.NgayMuon > '2018-10-18' and TaiLieu.MaTaiLieu = TheLoai.MaTheLoai and phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu GROUP by TaiLieu.MaTheLoai , TheLoai.TenTheLoai
    }
}
