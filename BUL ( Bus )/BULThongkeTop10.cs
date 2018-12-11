using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALConnector;
using System.Data;
namespace BULBus
{
    public class BULThongkeTop10
    {
        DALThongKeTop10 TKTop10 = new DALThongKeTop10();

        public DataTable ThongKe10(DateTime begin, DateTime end)
        {
            return TKTop10.ThongKeTop10(begin, end);
        }
        public DataTable ThongKe10NoDate()
        {
            return TKTop10.ThongKeTop10NoDate();
        }
        public DataTable TKQH(DateTime begin, DateTime end)
        {
            return TKTop10.getDataTKQH(begin, end);
        }
        public DataTable TKQHNoDate()
        {
            return TKTop10.getDataTKQHNoDate();
        }
    }
}
