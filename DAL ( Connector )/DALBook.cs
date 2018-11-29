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
    public  class DALBook
    {
        // lấy danh sách thể loại
        public List<kind> ListViewKind()
        {
            List<kind> kind = new List<kind>();
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlInsertTL = "select * from TheLoai";
                SqlCommand cmdSql = new SqlCommand(sqlInsertTL, ConnectorFactory.conn);
                SqlDataReader data = cmdSql.ExecuteReader();
                while (data.Read())
                {
                    kind.Add(new kind(data["MaTheLoai"].ToString(), data["TenTheLoai"].ToString(), data["GhiChu"].ToString()));
                }
                ConnectorFactory.closeConnectDB();
            }
            catch(SqlException)
            {

            }
            return kind;
        }
        public List<string> ListTheLoai()
        {
            List<string> id = new List<string>();
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlInsertTL = "select MaTheLoai from TheLoai";
                SqlCommand cmdSql = new SqlCommand(sqlInsertTL, ConnectorFactory.conn);
                SqlDataReader data =  cmdSql.ExecuteReader();
                while (data.Read())
                {
                    id.Add(data["MaTheLoai"].ToString());
                }
                ConnectorFactory.closeConnectDB();
            }
            catch (SqlException)
            {

            }
            return id;
        }
        public bool AddKind(kind k)
        {
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlInsertTL = "insert into TheLoai values (@matl,@tentl,@ghichu)";
                SqlCommand cmdSql = new SqlCommand(sqlInsertTL, ConnectorFactory.conn);
                cmdSql.Parameters.AddWithValue("matl", k.matheloai);
                cmdSql.Parameters.AddWithValue("tentl", k.tentheloai);
                cmdSql.Parameters.AddWithValue("ghichu", k.ghichu);
               
                cmdSql.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
              
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool UpdateKind(kind updTl)
        {
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlUPDATE = "UPDATE TheLoai SET TenTheLoai=@ten, GhiChu=@ghi WHERE MaTheLoai = @ma";
                SqlCommand cmd = new SqlCommand(sqlUPDATE, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", updTl.matheloai);
                cmd.Parameters.AddWithValue("ten", updTl.tentheloai);
                cmd.Parameters.AddWithValue("ghi", updTl.ghichu);
               
                cmd.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public bool DeleteKind(string ma)
        {
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlDELETE = "DELETE FROM TheLoai WHERE MaTheLoai=@ma";
                SqlCommand cmd = new SqlCommand(sqlDELETE, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<kind> SearchKind(string ma)
        {
            List<kind> ds = new List<kind>();
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlSELECT =
                "SELECT * from TheLoai where MaTheLoai=@ma";
                SqlCommand cmd = new SqlCommand(sqlSELECT, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                   
                    ds.Add(new kind(dr["MaTheLoai"].ToString(), dr["TenTheLoai"].ToString(), dr["GhiChu"].ToString() ));
                }

                ConnectorFactory.closeConnectDB();


            }
            catch (SqlException)
            {

            }

            return ds;
        }
        /*------------------------------------------------------------------------------*/
        public List<Book> LayThongTinTaiLieu()
        {
            List<Book> dsTaiLieu = new List<Book>();
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlSELECT = "SELECT * From TaiLieu inner join TheLoai  on TaiLieu.MaTheLoai = TheLoai.MaTheLoai";
                SqlCommand cmd = new SqlCommand(sqlSELECT, ConnectorFactory.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                //đọc từng dòng và đưa vào danh sách
                while (dr.Read())
                {
                    Book aTL = new Book(
                    dr["MaTaiLieu"].ToString(),
                    dr["TenTaiLieu"].ToString(),
                    dr["TenTheLoai"].ToString(),
                    int.Parse(dr["SoLuong"].ToString()),
                    dr["NhaXuatBan"].ToString(),
                    int.Parse(dr["NamXuatBan"].ToString()),
                    dr["TacGia"].ToString());
                    dsTaiLieu.Add(aTL);
                }
                ConnectorFactory.closeConnectDB();
            }
            catch (SqlException)
            {
                ConnectorFactory.closeConnectDB();
            }
            return dsTaiLieu;
        }

        public bool ThemTL(Book addTL)
        {
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlInsertTL = "insert into TaiLieu values (@matl,@tentl,@mathel,@sl,@nxb, @namxb,@tg)";
                SqlCommand cmdSql = new SqlCommand(sqlInsertTL, ConnectorFactory.conn);
                cmdSql.Parameters.AddWithValue("matl", addTL.MaTaiLieu);
                cmdSql.Parameters.AddWithValue("tentl", addTL.TenTaiLieu);
                cmdSql.Parameters.AddWithValue("mathel", addTL.MaTheLoai);
                cmdSql.Parameters.AddWithValue("sl", addTL.SoLuong);
                cmdSql.Parameters.AddWithValue("nxb", addTL.NhaXuatBan);
                cmdSql.Parameters.AddWithValue("namxb", addTL.NamXuatBan);
                cmdSql.Parameters.AddWithValue("tg", addTL.TacGia);
                cmdSql.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool checkTL(string ma)
        {
            bool iCheck = false;
            ConnectorFactory.openConnectDB();
            string sql = "select MaTaiLieu  from TaiLieu";
            SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
            SqlDataReader readDB = cmd.ExecuteReader();
            while (readDB.Read())
            {
                if (ma.Equals(readDB["MaTaiLieu"].ToString()))
                {
                    iCheck = true;
                    ConnectorFactory.closeConnectDB();
                    return iCheck;
                }

            }

            ConnectorFactory.closeConnectDB();
            return iCheck;
        }

        public bool SuaTaiLieu(Book updTl)
        {
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlUPDATE = "Update TaiLieu set TenTaiLieu=@ten,MaTheLoai=@matheloai,Soluong=@sl,NhaXuatBan=@nxb, NamXuatBan=@namxb, TacGia=@tg where MaTaiLieu=@ma";
                SqlCommand cmd = new SqlCommand(sqlUPDATE, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", updTl.MaTaiLieu);
                cmd.Parameters.AddWithValue("ten", updTl.TenTaiLieu);
                cmd.Parameters.AddWithValue("matheloai", updTl.MaTheLoai);
                cmd.Parameters.AddWithValue("sl", updTl.SoLuong);
                cmd.Parameters.AddWithValue("nxb", updTl.NhaXuatBan);
                cmd.Parameters.AddWithValue("namxb", updTl.NamXuatBan);
                cmd.Parameters.AddWithValue("tg", updTl.TacGia);
                cmd.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }
        public bool XoaTaiLieu(string ma)
        {
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlDELETE = "DELETE FROM TaiLieu WHERE MaTaiLieu=@ma";
                SqlCommand cmd = new SqlCommand(sqlDELETE, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public List<Book> TimTaiLieu(string ma)
        {
            List<Book> ds = new List<Book>();
            try
            {
                ConnectorFactory.openConnectDB();
                string sqlSELECT =
                "SELECT MaTaiLieu, TenTaiLieu, TenTheLoai,SoLuong,NhaXuatBan, NamXuatBan, TacGia FROM "
                + "TaiLieu a, TheLoai b WHERE "
                + "a.MaTheLoai= b.MaTheLoai AND MaTaiLieu=@ma";
                SqlCommand cmd = new SqlCommand(sqlSELECT, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", ma);
                SqlDataReader dr = cmd.ExecuteReader();
                while(dr.Read())
                {
                    Book aTL = new Book(
                   dr["MaTaiLieu"].ToString(),
                   dr["TenTaiLieu"].ToString(),
                   dr["TenTheLoai"].ToString(),
                   int.Parse(dr["SoLuong"].ToString()),
                   dr["NhaXuatBan"].ToString(),
                   int.Parse(dr["NamXuatBan"].ToString()),
                   dr["TacGia"].ToString());
                    ds.Add(aTL);
                }
               
                ConnectorFactory.closeConnectDB();

               
            }
            catch (SqlException)
            {

            }
            
            return ds;
        }
    }
}
