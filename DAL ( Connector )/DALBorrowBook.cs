using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DALConnector
{
    public class DALBorrowBook
    {
       
        public List<BorrowDetail> ListViewBorrowDetail()
        {
            List<BorrowDetail> list = new List<BorrowDetail>();
            try
            {
                ConnectorFactory.openConnectDB();
                string sql = "select PhieuMuon.maphieumuon,phieumuon.madocgia, docgia.hoten,phieumuon.manhanvien,nhanvien.hoten,phieumuonchitiet.masach,tailieu.tentailieu,ngaymuon,phieumuonchitiet.soluongmuon from phieumuon,docgia,nhanvien,phieumuonchitiet,tailieu where phieumuon.madocgia = docgia.madocgia and phieumuon.manhanvien = nhanvien.manhanvien and phieumuon.maphieumuon = phieumuonchitiet.maphieumuon and phieumuonchitiet.masach = tailieu.matailieu";

                SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    
                    BorrowDetail book = new BorrowDetail(dr["maphieumuon"].ToString(), dr["madocgia"].ToString(), dr["docgia.hoten"].ToString(), dr["manhanvien"].ToString(), dr["nhanvien.hoten"].ToString(),  dr["phieumuonchitiet.masach"].ToString(), dr["tailieu.tentailieu"].ToString(), dr["ngaymuon"].ToString(), dr["phieumuonchitiet.soluongmuon"].ToString());
                    list.Add(book);
                }
                ConnectorFactory.closeConnectDB();

            }
            catch (SqlException)
            {

            }
            return list;
        }
        public void InsertBorrowBook(BorrowBook pm)
        {
            ConnectorFactory.openConnectDB() ;
            string sqlInsert = "insert into PhieuMuon values(@mapm,@madg,@ngaymuon,@manv)";
            SqlCommand cmd = new SqlCommand(sqlInsert, ConnectorFactory.conn);
            cmd.Parameters.AddWithValue("mapm", pm.Maphieumuon);
            cmd.Parameters.AddWithValue("madg", pm.Madocgia);
            cmd.Parameters.AddWithValue("ngaymuon", pm.Ngaymuon);
            cmd.Parameters.AddWithValue("manv", pm.Manhanvien);
            cmd.ExecuteNonQuery();
            ConnectorFactory.closeConnectDB();
        }
        

        public void updateBorrowBookDetail(DateTime ngaytra, string a)
        {
            ConnectorFactory.openConnectDB();
            string sqlup = "update PhieuMuonChiTiet set NgayTra=@ngay where MaPhieuMuon=@a";
            SqlCommand cmd = new SqlCommand(sqlup, ConnectorFactory.conn);
            cmd.Parameters.AddWithValue("ngay", ngaytra);
            cmd.Parameters.AddWithValue("a", a);
            cmd.ExecuteNonQuery();
            ConnectorFactory.closeConnectDB();

        }
    }
}
