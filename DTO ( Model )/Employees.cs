using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTOModel
{
    public class Employees
    {
        /*------- Begin Register -------------*/
        public string MaNhanVien { get; set; }
        public string HoTen { get; set; }
        public string ChucVu { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Quyen { get; set; }

        public Employees() { }

        public Employees(string ma, string ten, string chu, string use, string pass, string quyenI)
        {
            this.MaNhanVien = ma;
            this.HoTen = ten;
            this.ChucVu = chu;
            this.UserName = use;
            this.Password = pass;
            this.Quyen = quyenI;
        }
        /*------- end Register -------------*/
    }
    public class Login_DTO
    {
        public string useName { get; set; }
        public string passWord { get; set; }
        public Login_DTO() { }
        public Login_DTO(string use, string pass)
        {
            this.useName = use;
            this.passWord = pass;
        }
    }
}
