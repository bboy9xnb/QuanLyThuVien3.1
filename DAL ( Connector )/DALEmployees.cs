using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOModel;
using System.Data;
using System.Configuration;
using DALConnector;
using System.Data.SqlClient;
namespace DALConnector
{
    public class DALEmployees
    {
        
        SqlConnection conn = new SqlConnection(ConfigurationManager.ConnectionStrings["ChuoiKetNoi"].ToString());
        // test connect to database
        public bool IsServerConnected()
        {
            try
            {
                
                 ConnectorFactory.closeConnectDB();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                return false;
            }

        }
        public bool addNV(Employees addNV)
        {
            try
            {
                 ConnectorFactory.openConnectDB();
                string sqlInsertDB = "insert into NhanVien values (@ma,@ten,@chucvu,@user,@pass,@permission)";
                SqlCommand cmdSql = new SqlCommand(sqlInsertDB, ConnectorFactory.conn);
                cmdSql.Parameters.AddWithValue("ma", addNV.MaNhanVien);
                cmdSql.Parameters.AddWithValue("ten", addNV.HoTen);
                cmdSql.Parameters.AddWithValue("chucvu", addNV.ChucVu);
                cmdSql.Parameters.AddWithValue("user", addNV.UserName);
                cmdSql.Parameters.AddWithValue("pass", addNV.Password);
                int permiss = 0;
                if (!addNV.Quyen.Equals("Admin"))
                    permiss = 1;
                cmdSql.Parameters.AddWithValue("permission", permiss);
                cmdSql.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                ConnectorFactory.closeConnectDB();
                return false;
            }
        }
        public bool checkNV(string ma, string use)
        {
            bool iCheck = false;
             ConnectorFactory.openConnectDB();
            string sql = "select MaNhanVien,TaiKhoan  from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
            SqlDataReader readDB = cmd.ExecuteReader();
            while (readDB.Read())
            {
                if (ma.Equals(readDB["MaNhanVien"].ToString()) || use.Equals(readDB["TaiKhoan"].ToString()))
                {
                    iCheck = true;
                    ConnectorFactory.closeConnectDB();
                    return iCheck;
                }

            }

            ConnectorFactory.closeConnectDB();
            return iCheck;
        }

        public bool LoginDB(Login_DTO lg)
        {
            bool iCheck = false;
             ConnectorFactory.openConnectDB();
            string sql = "select TaiKhoan,MatKhau  from NhanVien";
            SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
            SqlDataReader readDB = cmd.ExecuteReader();
            while (readDB.Read())
            {
                if (lg.useName.Equals(readDB["TaiKhoan"].ToString()) || lg.passWord.Equals(readDB["MatKhau"].ToString()))
                {
                    iCheck = true;
                    ConnectorFactory.closeConnectDB();
                    return iCheck;
                }
            }

            ConnectorFactory.closeConnectDB();
            return iCheck;
        }
        public int CheckPremission(string use)
        {
            try
            {
                 ConnectorFactory.openConnectDB();
                string sql = "select Quyen from NhanVien where TaiKhoan='" + use + "'";
                SqlCommand cmd = new SqlCommand(sql, ConnectorFactory.conn);
                SqlDataReader readDB = cmd.ExecuteReader();
                while (readDB.Read())
                {

                    int i = int.Parse(readDB["Quyen"].ToString());
                    ConnectorFactory.closeConnectDB();
                    return i;
                }
                ConnectorFactory.closeConnectDB();
            }
            catch (SqlException)
            {
                ConnectorFactory.closeConnectDB();
                return -1;
            }
            return -1;
        }

        // đọc bảng nhân viên
        public List<Employees> ViewTableNV()
        {
            List<Employees> dsNV = new List<Employees>();
             ConnectorFactory.openConnectDB();
            SqlCommand cmd = new SqlCommand("Select * from NhanVien", ConnectorFactory.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string permiss = "Admin";
                if (int.Parse(dr["Quyen"].ToString()) == 1)
                    permiss = "Thủ thư";
                Employees nvinfo = new Employees(dr["MaNhanVien"].ToString(), dr["HoTen"].ToString(), dr["ChucVu"].ToString(), dr["TaiKhoan"].ToString(), dr["MatKhau"].ToString(), permiss);
                dsNV.Add(nvinfo);
            }
            ConnectorFactory.closeConnectDB();
            return dsNV;
        }
        public List<Employees> ViewTableNVByUserID(string userID)
        {
            List<Employees> dsNV = new List<Employees>();
            ConnectorFactory.openConnectDB();
            SqlCommand cmd = new SqlCommand("Select * from NhanVien where TaiKhoan='"+userID+"'", ConnectorFactory.conn);
            SqlDataReader dr = cmd.ExecuteReader();
            while (dr.Read())
            {
                string permiss = "Admin";
                if (int.Parse(dr["Quyen"].ToString()) == 1)
                    permiss = "Thủ thư";
                Employees nvinfo = new Employees(dr["MaNhanVien"].ToString(), dr["HoTen"].ToString(), dr["ChucVu"].ToString(), dr["TaiKhoan"].ToString(), dr["MatKhau"].ToString(), permiss);
                dsNV.Add(nvinfo);
            }
            ConnectorFactory.closeConnectDB();
            return dsNV;
        }
        public bool EditNV(Employees infoNV)
        {
            try
            {
                 ConnectorFactory.openConnectDB();
                string SqlUpdate = "Update NhanVien set HoTen=@ten,ChucVu=@chuc,TaiKhoan=@use,MatKhau=@pass, Quyen=@quyen where MaNhanVien=@ma";
                SqlCommand cmd = new SqlCommand(SqlUpdate, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", infoNV.MaNhanVien);
                cmd.Parameters.AddWithValue("ten", infoNV.HoTen);
                cmd.Parameters.AddWithValue("chuc", infoNV.ChucVu);
                cmd.Parameters.AddWithValue("use", infoNV.UserName);
                cmd.Parameters.AddWithValue("pass", infoNV.Password);
                int permiss = 0;
                if (!infoNV.Quyen.Equals("Admin"))
                    permiss = 1;
                cmd.Parameters.AddWithValue("quyen", permiss);
                cmd.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                ConnectorFactory.closeConnectDB();
                return false;
            }

        }

        public bool DeleteNV(string ma)
        {
            try
            {
                 ConnectorFactory.openConnectDB();
                string SqlDelete = "Delete from NhanVien where MaNhanVien=@ma";
                SqlCommand cmd = new SqlCommand(SqlDelete, ConnectorFactory.conn);
                cmd.Parameters.AddWithValue("ma", ma);
                cmd.ExecuteNonQuery();
                ConnectorFactory.closeConnectDB();
                return true;
            }
            catch (SqlException)
            {
                ConnectorFactory.closeConnectDB();
                return false;
            }

        }

        public List<Employees> ViewDetailNV(string ma)
        {
            List<Employees> dsNV = new List<Employees>();
            try
            {

                 ConnectorFactory.openConnectDB();
                SqlCommand cmd = new SqlCommand("Select * from NhanVien where MaNhanVien='" + ma + "'", ConnectorFactory.conn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string permiss = "Admin";
                    if (int.Parse(dr["Quyen"].ToString()) == 1)
                        permiss = "Thủ thư";
                    Employees nvinfo = new Employees(dr["MaNhanVien"].ToString(), dr["HoTen"].ToString(), dr["ChucVu"].ToString(), dr["TaiKhoan"].ToString(), dr["MatKhau"].ToString(), permiss);
                    dsNV.Add(nvinfo);
                }
                
                ConnectorFactory.closeConnectDB();

            }
            catch (SqlException)
            {
                ConnectorFactory.closeConnectDB();

            }
            return dsNV;
        }
    }
}
