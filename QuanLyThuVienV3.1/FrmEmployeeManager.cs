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
    
    public partial class FrmEmployeeManager : Form
    {
        BULEmployees employ = new BULEmployees();
        DataGridViewButtonColumn btnViewDetail = new DataGridViewButtonColumn();

        public FrmEmployeeManager()
        {
            Refresh();
            InitializeComponent();
            ViewListNV();
            btnViewAll.Enabled = false;
            tbPassword.PasswordChar = '*';
            tbPasswordConfim.PasswordChar = '*';
            cbPermission.Text = "Admin";

        }
       

        private void dataEmployees_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dataEmployees.ReadOnly = true;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                int i = int.Parse(dataEmployees.CurrentRow.Index.ToString());
                //                MessageBox.Show(dataGridViewNV.CurrentRow.Index.ToString());
                string selectIDNV = dataEmployees.Rows[i].Cells[0].Value.ToString();
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                List<Employees> list = employ.ViewDetailNV(selectIDNV);
                if (list.Count > 0)
                {
                    cickview(true);
                    tbFullName.Text = list[0].HoTen.ToString();
                    tbLevel.Text = list[0].ChucVu.ToString();
                    tbPassword.Text = list[0].Password.ToString();
                    tbPasswordConfim.Text = list[0].Password.ToString();
                    tbUserID.Text = list[0].MaNhanVien.ToString();
                    tbUserName.Text = list[0].UserName.ToString();
                    cbPermission.Text = list[0].Quyen.ToString();
                    tbUserID.Enabled = false;
                }

                
            }
        }
        public  void ViewListNV()
        {

            var height = 0 ;
           
            foreach (DataGridViewRow row in dataEmployees.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }
            
            dataEmployees.Height = height;
            dataEmployees.Refresh();
            dataEmployees.AutoSize = true;
            dataEmployees.DataSource = employ.ViewList();
            dataEmployees.ReadOnly = true;
            dataEmployees.Refresh();
            btnViewDetail.Name = "";
            btnViewDetail.Text = "Xem chi tiết";
            btnViewDetail.UseColumnTextForButtonValue = true;
            int columnIndex = 6;
            if (dataEmployees.Columns[""] == null)
            {
                dataEmployees.Columns.Insert(columnIndex, btnViewDetail);
            }
            else
            {
                dataEmployees.Columns.Remove(btnViewDetail);
                dataEmployees.Columns.Insert(columnIndex, btnViewDetail);
            }

        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            string search = tbSearchUserID.Text;
            if (search.Equals(""))
                ViewListNV();
            else
            {
                List<Employees> list;
                list = employ.ViewDetailNV(search);
                if (list.Count == 0)
                    MessageBox.Show("Mã nhân viên không tồn tại, Vui lòng kiểm tra lại!");
                else
                    dataEmployees.DataSource = list;
                    btnViewAll.Enabled = true;

            }
        }

        private void btnViewAll_Click(object sender, EventArgs e)
        {
            ViewListNV();
            btnViewAll.Enabled = false;
        }

        private void FrmEmployeeManager_Load(object sender, EventArgs e)
        {
            ViewListNV();
           // viewControll(false);
            cbPermission.DisplayMember = "Text";
            cbPermission.ValueMember = "Value";
            cickview(false);
            cbPermission.Items.Add(new { Text = "Admin", Value = "Admin" });
            cbPermission.Items.Add(new { Text = "Thủ thư", Value = "Thủ thư" });
        }
        

     

        private void mnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = tbUserID.Text;
            string use = tbUserName.Text;
            string pass = tbPassword.Text;
            string passConfim = tbPasswordConfim.Text;
            string ten = tbFullName.Text;
            string chuc = tbLevel.Text;
            string quyen = cbPermission.Text;
            if (ma.Length > 1 && use.Length > 1)
            {
                bool iCheck = employ.KiemTraNV(ma, use);
                if (!iCheck)
                {
                    if (pass.Equals(passConfim))
                    {
                        Employees addnv = new Employees(ma, ten, chuc, use, pass, quyen);
                        
                        if (employ.Them(addnv))
                        {
                            MessageBox.Show("Thêm thành công! ");
                            setTextboxNull();
                            ViewListNV();
                            //viewControll(false);
                        }
                        else
                            MessageBox.Show("Có lỗi xảy ra, Vui lòng thử lại sau");
                        
                    }
                    else
                    {
                        MessageBox.Show("Mật khẩu không trùng khớp, vui lòng nhập lại !");
                        tbPassword.Text = "";
                        tbPasswordConfim.Text = "";
                    }
                }
                else
                    MessageBox.Show("Mã thành viên hoặc tài khoản này đã tồn tại, Vui lòng kiểm tra lại !");
            }
            else
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin thành viên!");
            }
        }
        void setTextboxNull()
        {
            tbFullName.Text = "";
            tbLevel.Text = "";
            tbPassword.Text = "";
            tbPasswordConfim.Text = "";
            tbUserID.Text = "";
            tbUserName.Text = "";
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            //viewControll(false);
            cickview(false);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
          
            if (MessageBox.Show("bạn xóa mã nhân viên " + tbUserID.Text + "?", "Xóa nhân viên", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (employ.DeleteNVtoList(tbUserID.Text))
                {
                    setTextboxNull();
                    MessageBox.Show("Xóa thành công");
                    ViewListNV();
                    cickview(false);
                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!");
            }
            else
            {
                // user clicked no
            }
        }

        void cickview(bool view)
        {
            if (view)
            {
                lbTitle.Text = "Cập nhật thông tin nhân viên";
                btnAdd.Visible = false;
                btnDelete.Visible = true;
                btnUpdate.Visible = true;

            }
            else
            {
                lbTitle.Text = "Thêm  nhân viên";
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                tbUserID.Enabled = true;
            }
        }
        
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn có muốn cập nhật " + tbUserID.Text + "?", "Cập nhật", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (employ.UpdateNV(new Employees(tbUserID.Text, tbFullName.Text, tbLevel.Text,tbUserName.Text, tbPassword.Text,cbPermission.Text)))
                {
                    setTextboxNull();
                    MessageBox.Show("Cập nhật thành công");
                    ViewListNV();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!");
            }
            else
            {
                // user clicked no
            }
        }

        private void btnViewPass_Click(object sender, EventArgs e)
        {
            bool iCheck = false;
            if (iCheck)
                tbPassword.PasswordChar = '\0';
            else
                tbPassword.PasswordChar = '*';
        }
    }
}
