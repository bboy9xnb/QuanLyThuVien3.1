using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DALConnector;
using DTOModel;
using System.Data;
namespace BULBus
{
    
    public class BULCheckoutBorrow
    {
        DALCheckoutBorrow checkout = new DALCheckoutBorrow();
        public List<CheckoutBorrow> listDataCheckOut(DateTime begin, DateTime end)
        {
            return checkout.listDataCheckoutBorrow(begin, end);
        }
        public DataTable listBorrow(DateTime begin, DateTime end)
        {
            return checkout.listBorrow(begin, end);
        }
        public DataTable listBorrowNoDate()
        {
            return checkout.listBorrowNoDate();
        }
    }
}
