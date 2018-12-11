using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BULBus;
using DALConnector;
using DTOModel;

namespace QuanLyThuVienV3._1
{
    public partial class FrmMain : Form
    {
        BULEmployees emp = new BULEmployees();
        BULAuthor author = new BULAuthor();
        BULBook book = new BULBook();
        BULBorrowBook borow = new BULBorrowBook();
        public static string userAccount;
        public FrmMain(string use)
        {
            userAccount = use;
            InitializeComponent();
            lbUserName.Text = "Xin chào " + use;
            // kiểm tra quyền tài khoản
            int iCheck = emp.CheckPremissionUser(userAccount);
            if (iCheck == 1)
            {
                mnCategoryManager.Visible = false;
            }
            else
            {
                mnStatisticalManager.Visible = false;
                mnPayment.Visible = false;
            }
        }

        private void mnEmployeesManager_Click(object sender, EventArgs e)
        {
            FrmEmployeeManager employ = new FrmEmployeeManager();
            employ.Show();

        }

        private void mnReadersManager_Click(object sender, EventArgs e)
        {
            FrmAuthorManager author = new FrmAuthorManager();
            author.Show();
        }

        private void mnDocumentManager_Click(object sender, EventArgs e)
        {
            FrmBooks book = new FrmBooks();
            book.Show();
        }

        private void mnBookBorrow_Click(object sender, EventArgs e)
        {
            FrmBorrowBooks muon = new FrmBorrowBooks();
            muon.Show();
        }

        private void mnBookPay_Click(object sender, EventArgs e)
        {

        }

        private void mntopborrowedbycategory_Click(object sender, EventArgs e)
        {
            FrmCheckOutBorrowBook st = new FrmCheckOutBorrowBook();
            st.Show();
        }

        private void mnOverdueLoans_Click(object sender, EventArgs e)
        {
            TKQuaHan tk = new TKQuaHan();
            tk.Show();
        }

        private void mnTop10_Click(object sender, EventArgs e)
        {
            TKTop10 tk = new TKTop10();
            tk.Show();
        }

        private void mnSupport_Click(object sender, EventArgs e)
        {

        }

        private void mnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn thoát không?", "Thoát ứng dụng", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Environment.Exit(1);

            }
            else
            {
                // user clicked no
            }
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
           
            lbSumEmployees.Text = emp.ViewList().Count.ToString();
            lbSumDocGia.Text = author.LayDanhSachDG().Count.ToString();
            lbSumBook.Text = book.ListViewKind().Count.ToString();
        }

        private void mnLogout_Click(object sender, EventArgs e)
        {
            Close();
            FrmLogin login = new FrmLogin();
            login.Show();
        }
    }
}
