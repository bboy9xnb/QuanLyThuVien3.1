using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTOModel;
using DALConnector;
using BULBus;
namespace QuanLyThuVienV3._1
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
            if (employees.IsServerConnected())
            {
                tbUserName.Text = "VietPDb";
                tbPassWord.Text = "123456";
            }
            else
                MessageBox.Show("không thể kết nối tới Server");
            tbPassWord.PasswordChar = '*';
        }
        BULEmployees employees = new BULEmployees();
        private void btnLogin_Click(object sender, EventArgs e)
        {
            LoginAction();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void LoginAction()
        {
            string use = tbUserName.Text;
            string passWord = tbPassWord.Text;
            if (use != "" || use != null || passWord != "" || passWord != null)
            {
                Login_DTO addNV = new Login_DTO(use, passWord);
                if (employees.CheckLogin(addNV))
                {

                    FrmLogin log = new FrmLogin();
                    this.Hide();
                    log.Close();
                    FrmMain main = new FrmMain(use);
                    main.Show();


                }
                else
                    MessageBox.Show("Vui lòng kiểm tra lại thông tin tài khoản");
            }
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }

        private void tbPassWord_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                LoginAction();
            }
        }
    }
}
