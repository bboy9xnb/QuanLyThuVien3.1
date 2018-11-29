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
   public class DALAuthor
    {
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ToString());

        public List<Author> LayThongTinDocGia()
        {
            List<Author> dsDocGia = new List<Author>();
            try
            {
                conn.Open();
                string sqlSELECT = "SELECT * FROM DocGia";
                SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
                SqlDataReader dr = cmd.ExecuteReader();
                //đọc từng dòng và đưa vào danh sách
                while (dr.Read())
                {
                    string gt = "Nam";
                    if (dr["GioiTinh"].ToString().Equals("1"))
                        gt = "Nữ";
                    Author aDG = new Author(
                    dr["MaDocGia"].ToString(),
                    dr["HoTen"].ToString(),
                    gt,
                    dr["NgaySinh"].ToString(),
                    dr["Doituong"].ToString(),
                    dr["NgayCap"].ToString(),
                    dr["NgayHetHan"].ToString());
                    dsDocGia.Add(aDG);
                }
                conn.Close();
            }
            catch(SqlException)
            {

            }
            return dsDocGia;
        }

        public bool ThemDG(Author addDG)
        {
            try
            {
                conn.Open();
                string sqlInsertDB = "insert into DocGia values (@ma,@ten,@gt,@dt,@ngayCap, @ngayHH,@ns)";
                SqlCommand cmdSql = new SqlCommand(sqlInsertDB, conn);
                cmdSql.Parameters.AddWithValue("ma", addDG.MaDocGia);
                cmdSql.Parameters.AddWithValue("ten", addDG.HoTen);
                cmdSql.Parameters.AddWithValue("gt", int.Parse(addDG.GioiTinh));
                cmdSql.Parameters.AddWithValue("dt", addDG.DoiTuong);
                cmdSql.Parameters.AddWithValue("ngayCap", addDG.NgayCap);
                cmdSql.Parameters.AddWithValue("ngayHH", addDG.NgayHetHan);
                cmdSql.Parameters.AddWithValue("ns", addDG.NgaySinh);
                cmdSql.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
            
        }

        public bool checkDG(string ma)
        {
            
            
            try
            {
                conn.Open();
                string sql = "select MaDocGia  from NhanVien";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader readDB = cmd.ExecuteReader();
                while (readDB.Read())
                {
                    if (ma.Equals(readDB["MaDocGia"].ToString()))
                    {
                        
                        conn.Close();
                        return true;
                    }

                }

                conn.Close();
            }
            catch (SqlException)
            {
                return false;
            }
            return false;
        }

        public bool SuaDocGia(Author updDG)
        {
            
            try
            {
                conn.Open();
                string sqlUPDATE = "UPDATE DocGia SET HoTen=@ten, GioiTinh=@gt,DoiTuong=@dt, NgayCap=@nc, NgayHetHan=@nhh,NgaySinh=@ns WHERE MaDocGia = @ma";
                SqlCommand cmd = new SqlCommand(sqlUPDATE, conn);
                cmd.Parameters.AddWithValue("ma", updDG.MaDocGia);
                cmd.Parameters.AddWithValue("ten", updDG.HoTen);
                cmd.Parameters.AddWithValue("gt", int.Parse(updDG.GioiTinh));
                cmd.Parameters.AddWithValue("ns", DateTime.Parse(updDG.NgaySinh));
                cmd.Parameters.AddWithValue("dt", updDG.DoiTuong);
                cmd.Parameters.AddWithValue("nc", DateTime.Parse(updDG.NgayCap));
                cmd.Parameters.AddWithValue("nhh", DateTime.Parse(updDG.NgayHetHan));
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }
        }

        public bool XoaDocGia(string ma)
        {
            try
            {
                conn.Open();
                string sqlDELETE =
                "DELETE FROM DocGia WHERE MaDocGia=@ma";
                SqlCommand cmd = new SqlCommand(sqlDELETE, conn);
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.ExecuteNonQuery();
                conn.Close();
                return true;
            }
            catch(SqlException )
            {
                return false;
            }
        }

        public List<Author> TimDocGia(string ma)
        {
            List<Author> ds = new List<Author>();
            try
            {
                conn.Open();
                string sqlSELECT =
                "SELECT * FROM DocGia  WHERE MaDocGia='"+ ma+"'";
                SqlCommand cmd = new SqlCommand(sqlSELECT, conn);
                
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string gt = "Nam";
                    if (dr["GioiTinh"].ToString().Equals("1"))
                        gt = "Nữ";
                    Author aDG = new Author(
                    dr["MaDocGia"].ToString(),
                    dr["HoTen"].ToString(),
                    gt,
                    dr["NgaySinh"].ToString(),
                    dr["Doituong"].ToString(),
                    dr["NgayCap"].ToString(),
                    dr["NgayHetHan"].ToString());
                    ds.Add(aDG);
                }
                
                conn.Close();

               
            }catch(SqlException)
            {

            }
            return ds;
        }
    }
}
