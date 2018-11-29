using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DTOModel;
using DALConnector;


namespace BULBus
{
    public class BULEmployees
    {

        DALEmployees nv = new DALEmployees();
        public bool IsServerConnected()
        {
            return nv.IsServerConnected();
        }
        public List<Employees> ViewList()
        {
            return nv.ViewTableNV();
        }
       
        public List<Employees> ViewDetailNV(string ma)
        {
            return nv.ViewDetailNV(ma);
        }
        public bool UpdateNV(Employees editNV)
        {
            return nv.EditNV(editNV);
        }
        public bool DeleteNVtoList(string ma)
        {
            return nv.DeleteNV(ma);
        }
        public bool Them(Employees addNV)
        {
            return nv.addNV(addNV);

        }
        public bool KiemTraNV(string manv, string use)
        {
            return nv.checkNV(manv, use);
        }
        public bool CheckLogin(Login_DTO lg)
        {
            return nv.LoginDB(lg);
        }
        public int CheckPremissionUser(string use)
        {
            return nv.CheckPremission(use);
        }
        public List<Employees> ViewTableNVByUserID(string userID)
        {
            return nv.ViewTableNVByUserID(userID);
        }
    }
}
