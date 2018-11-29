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
    public partial class FrmAuthorManager : Form
    {
        BULAuthor myDocGia = new BULAuthor();
        DataGridViewButtonColumn btnViewDetail = new DataGridViewButtonColumn();
        public FrmAuthorManager()
        {
            InitializeComponent();
        }

      

        private void mnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearchAuthorID.Text == "")
                HienThiDuLieu();
            else
            {
                if (myDocGia.TimDocGia(tbSearchAuthorID.Text).Count == 0)
                    MessageBox.Show("Không tồn tại mã độc giả trên, Vui lòng kiểm tra lại");
                else
                    dataAuthor.DataSource = myDocGia.TimDocGia(tbSearchAuthorID.Text);
                
            }
                
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string ma = tbAuthorID.Text;
            string ten = tbFullName.Text;
            string gt = "0";
            if (!cbSex.Text.Equals("Nam"))
                gt = "1";
            string ngayS = dateOfBrith.Value.Date.ToString("yyyy-MM-dd");
            string dt = tbObject.Text;
            string ngayC = dateRange.Value.Date.ToString("yyyy-MM-dd");
            string ngayHH = dateexpiration.Value.Date.ToString("yyyy-MM-dd");
            Author aDG = new Author(ma, ten, gt, ngayS, dt, ngayC, ngayHH);
            if (ma.Equals(""))
                MessageBox.Show("Vui lòng nhập mã độc giả");
            else
            {
                if (myDocGia.Them(aDG))
                {
                    MessageBox.Show("Thêm độc giả thành công");
                    viewControll(true);
                    setTextboxNull();
                    HienThiDuLieu();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại");
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            viewControll(true);
            setTextboxNull();
        }

        private void FrmAuthorManager_Load(object sender, EventArgs e)
        {
            HienThiDuLieu();
            List<string> valueCBbox = new List<string>();
            valueCBbox.Add("Nam");
            valueCBbox.Add("Nữ");
            cbSex.DataSource = valueCBbox;
            viewControll(true);
        }
        private void HienThiDuLieu()
        {
            //hiển thị dữ liệu trong data table lên data grid view
            dataAuthor.DataSource = myDocGia.LayDanhSachDG();
            var height = 0;

            foreach (DataGridViewRow row in dataAuthor.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }
            dataAuthor.Height = height;
            dataAuthor.Refresh();
            dataAuthor.AutoSize = true;
           
            dataAuthor.ReadOnly = true;
            dataAuthor.Refresh();
            btnViewDetail.Name = "";
            btnViewDetail.Text = "Xem chi tiết";
            btnViewDetail.UseColumnTextForButtonValue = true;
            int columnIndex = 7;
            if (dataAuthor.Columns[""] == null)
            {
                dataAuthor.Columns.Insert(columnIndex, btnViewDetail);
            }
            else
            {
                dataAuthor.Columns.Remove(btnViewDetail);
                dataAuthor.Columns.Insert(columnIndex, btnViewDetail);
            }

        }
        void viewControll(bool view)
        {
            if (view)
            {
                tbAuthorID.Enabled = true;
                btnAdd.Visible = true;
                btnUpdate.Visible = false;
                btnDelete.Visible = false;
                lbAddEmployees.Text = "Thêm độc giả";

            }
            else
            {
                btnAdd.Visible = false;
                btnUpdate.Visible = true;
                btnDelete.Visible = true;
                lbAddEmployees.Text = "Cập nhật độc giả";
            }
            


        }

        private void dataAuthor_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            viewControll(false);
            dataAuthor.ReadOnly = true;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                int i = int.Parse(dataAuthor.CurrentRow.Index.ToString());
                //                MessageBox.Show(dataGridViewNV.CurrentRow.Index.ToString());
                string selectIDNV = dataAuthor.Rows[i].Cells[0].Value.ToString();
                List<Author> list = myDocGia.TimDocGia(selectIDNV);
                if (list.Count > 0)
                {
                    tbAuthorID.Enabled = false;
                    tbAuthorID.Text = list[0].MaDocGia.ToString();
                    tbFullName.Text = list[0].HoTen.ToString();
                    tbObject.Text = list[0].DoiTuong.ToString();
                    dateexpiration.Text = list[0].NgayHetHan.ToString();
                    dateOfBrith.Text = list[0].NgaySinh.ToString();
                    dateRange.Text = list[0].NgayCap.ToString();
                }
            }
        }
        void setTextboxNull()
        {
            tbFullName.Text = "";
            tbAuthorID.Text = "";
            tbObject.Text = "";
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn cập nhật mã độc giả " + tbAuthorID.Text + "?", "Cập nhật độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                string gt = "0";
                if (!cbSex.Text.Equals("Nam"))
                    gt = "1";
                if (myDocGia.EditDocGia(new Author(tbAuthorID.Text, tbFullName.Text, gt, dateOfBrith.Text, tbObject.Text,dateRange.Text, dateexpiration.Text)))
                {
                    setTextboxNull();
                    MessageBox.Show("Cập nhật thành công");
                    viewControll(true);
                    HienThiDuLieu();

                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!");
            }
            else
            {
                // user clicked no
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn xóa mã độc giả " + tbAuthorID.Text + "?", "Xóa độc giả", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (myDocGia.DeleteDocGia(tbAuthorID.Text))
                {
                    setTextboxNull();
                    MessageBox.Show("Xóa thành công");
                    viewControll(true);
                    HienThiDuLieu();
                    
                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!");
            }
            else
            {
                // user clicked no
            }
        }
    }
}
