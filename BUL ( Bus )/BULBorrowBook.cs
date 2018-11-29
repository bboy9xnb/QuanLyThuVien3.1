using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALConnector;
using DTOModel;
namespace BULBus

{
    public class BULBorrowBook
    {
        DALBorrowBook a = new DALBorrowBook();
        public void InsertPhieuMuon(BorrowBook pm)
        {

            if (pm.Madocgia == "" || pm.Madocgia.Length > 5)
            {
                MessageBox.Show("Nhập Đúng Mã Độc Giả");
            }
            else if (pm.Manhanvien == "" || pm.Manhanvien.Length > 5)
            {
                MessageBox.Show("Nhập Sai Mã Nhân Viên");
            }
            else
            {
                a.InsertBorrowBook(pm);
            }
        }
        public List<BorrowDetail> listInforBook()
        {
            return a.ListViewBorrowDetail();
        }
        public void UpdatePMCT(DateTime dt, string b)
        {
            try
            {
                a.updateBorrowBookDetail(dt, b);
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
