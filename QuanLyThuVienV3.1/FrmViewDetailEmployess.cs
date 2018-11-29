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
    public partial class FrmViewDetailEmployess : Form
    {
        
       
        BULEmployees employ = new BULEmployees();
        List<Employees> info;
        public FrmViewDetailEmployess( string userid)
        {
            InitializeComponent();
        
            if (!userid.Equals(""))
            {
                cbPermission.DisplayMember = "Text";
                cbPermission.ValueMember = "Value";

                cbPermission.Items.Add(new { Text = "Admin", Value = "Admin" });
                cbPermission.Items.Add(new { Text = "Thủ thư", Value = "Thủ thư" });

                info = employ.ViewDetailNV(userid);
                tbPassword.PasswordChar = '*';
                tbUseID.Text = info[0].MaNhanVien.ToString();
                tbFullName.Text = info[0].HoTen.ToString();
                tbLevel.Text = info[0].ChucVu.ToString();
                tbUserName.Text = info[0].UserName.ToString();
                tbPassword.Text = info[0].Password.ToString();
                cbPermission.Text = info[0].Quyen.ToString();

                editTextbox(false);
            }
        }
        void editTextbox(bool view)
        {
            tbPassword.Enabled = view;
            tbLevel.Enabled = view;
            tbFullName.Enabled = view;
            tbUseID.Enabled = view;
            tbUserName.Enabled = view;
            btnViewPassword.Enabled = view;
            cbPermission.Enabled = view;
            btnDone.Visible = view;
            btnCancel.Visible = view;
            if (view)
                btnClose.Visible = false;
            else
                btnClose.Visible = true;
        }
        private void FrmViewDetailEmployess_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employees em = new Employees(tbUseID.Text, tbFullName.Text, tbLevel.Text, tbUserName.Text, tbPassword.Text, cbPermission.Text);
            if (employ.UpdateNV(em))
            {
                MessageBox.Show("Chỉnh sửa thông tin nhân viên thành công");
                FrmEmployeeManager emp = new FrmEmployeeManager();
                emp.Refresh();
                emp.ViewListNV();
                Close();
            }
            else
                MessageBox.Show("Lỗi! Không thể chỉnh sửa được thông tin, Vui lòng kiểm tra lại!");
        }
        
        private void button2_Click(object sender, EventArgs e)
        {
            Close();

        }
      
        private void button3_Click(object sender, EventArgs e)
        {
            editTextbox(false);
        }
        
        private void btnViewPassword_Click(object sender, EventArgs e)
        {
            if (tbPassword.PasswordChar == '*')
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }

        private void mnEditAccount_Click(object sender, EventArgs e)
        {
            editTextbox(true);
        }

        private void mnDeleteAcount_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn muốn xóa tài khoản này không?", "Xóa tài khoản", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (employ.DeleteNVtoList(tbUseID.Text))
                    MessageBox.Show("Xóa tài khoản thành công", "Thông báo");
                else
                    MessageBox.Show("Có lỗi xảy ra, Vui lòng thử lại sau");
                Close();
                FrmEmployeeManager main = new FrmEmployeeManager();
                main.Refresh();

            }
            else
            {
                // user clicked no
            }
        }

        private void cbPermission_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
