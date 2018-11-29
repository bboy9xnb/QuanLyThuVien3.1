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
    public partial class FrmBooks : Form
    {
        BULBook book = new BULBook();
        public FrmBooks()
        {
            InitializeComponent();
        }

        private void btnAddTL_Click(object sender, EventArgs e)
        {
            string id = tbTheLoaiID.Text;
            string name = tbTheLoaiName.Text;
            string note = tbGhiChu.Text;
            if (id.Equals("") || name.Equals(""))
                MessageBox.Show( "Vui lòng nhập thông tin thể loại", "Thông báo");
            else
            {
                if (book.AddKind(new kind(id, name, note)))
                {
                    MessageBox.Show( "Đã thêm thể loại thành công! ", "Thành công");
                    ViewData();
                    tbTheLoaiID.Text = "";
                    tbTheLoaiName.Text = "";
                    tbGhiChu.Text = "";
                }
                else
                    MessageBox.Show( "Có lỗi xảy ra, vui lòng kiểm tra lại", "Lỗi");
            }
        }

        private void btnCancelTL_Click(object sender, EventArgs e)
        {
            ViewData();
            tbTheLoaiID.Text = "";
            tbTheLoaiName.Text = "";
            tbGhiChu.Text = "";
            btnUpdateTL.Visible = false;
            btnDeleteKind.Visible = false;
        }

        private void btnAddBook_Click(object sender, EventArgs e)
        {
            string matl = tbBookID.Text;
            string tentl = tbName.Text;
            string matheloai =cbTLID.Text;
            string sl = tbCountBook.Text;
            string namxb = tbYearXB.Text;
            string nxb = tbNXB.Text;
            string tg = tbAuthor.Text;

            if (matl.Equals(""))
                MessageBox.Show("Vui lòng nhập mã tài liệu", "Thông báo");
            else
            {
                if (System.Text.RegularExpressions.Regex.IsMatch(tbCountBook.Text, "[^0-9]"))
                {
                    MessageBox.Show("Please enter only numbers.");
                    tbCountBook.Text = "";
                }
                else {
                    if (book.ThemMotTaiLieu(new Book(matl, tentl, matheloai, int.Parse(sl), nxb, int.Parse(namxb), tg)))
                    {
                        MessageBox.Show("Thêm tài liệu thành công");
                        setTextNull();
                        ViewData();
                        tbBookID.Text = "";
                        tbName.Text = "";

                        tbCountBook.Text = "";
                        tbYearXB.Text = "";
                        tbNXB.Text = "";
                        tbAuthor.Text = "";
                    }
                    else
                    {
                        MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại mã tài liệu");
                    }
                }

                
            }
        }

        private void btnCancelBook_Click(object sender, EventArgs e)
        {
            ViewData();
            tbBookID.Text = "";
            tbName.Text = "";
            btnUpdateBook.Visible = false;
            btnDeleteBook.Visible = false;
            btnAddBook.Visible = true;
            tbCountBook.Text = "";
            tbYearXB.Text = "";
            tbNXB.Text = "";
            tbAuthor.Text = "";
        }
        DataGridViewButtonColumn btnViewDetail = new DataGridViewButtonColumn();
        DataGridViewButtonColumn btnViewDetailTL = new DataGridViewButtonColumn();
        private void dataBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdateBook.Visible = true;
            btnDeleteBook.Visible = true;
            btnAddBook.Visible = false;

            lbTitle.Text = "Cập nhật lại thông tin tài liệu";
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                int i = int.Parse(dataBook.CurrentRow.Index.ToString());
                
                string selectID = dataBook.Rows[i].Cells[0].Value.ToString();
                

                List<Book> list = book.TimTaiLieuTheoMa(selectID);
                if (list.Count > 0)
                {
                    tbBookID.Text = list[0].MaTaiLieu.ToString();
                    tbName.Text = list[0].TenTaiLieu.ToString();
                    cbTLID.Text = list[0].MaTheLoai.ToString();
                    tbCountBook.Text = list[0].SoLuong.ToString();
                    tbYearXB.Text = list[0].NamXuatBan.ToString();
                    tbNXB.Text = list[0].NhaXuatBan.ToString();
                    tbAuthor.Text = list[0].TacGia.ToString();
                    tbBookID.Enabled = false;
                }

                
            }
        }

        private void FrmBooks_Load(object sender, EventArgs e)
        {

            ViewData();
           
        }
       
        private void ViewData()
        {
            // hiển thị danh sách thể loại
            var heightTL = 0;
            foreach (DataGridViewRow row in dataTheLoai.Rows)
            {
                if (row.Visible)
                    heightTL += row.Height;
            }
            btnAddBook.Visible = true;
            cbTLID.DataSource = book.listID();
            dataTheLoai.Height = heightTL;
            lbTL.Text = "Danh sách thể loại ";
            btnUpdateBook.Visible = false;
            btnUpdateTL.Visible = false;
            btnDeleteBook.Visible = false;
            btnDeleteKind.Visible = false;
            tbTheLoaiID.Enabled = true;
            dataTheLoai.ReadOnly = true;
            dataTheLoai.DataSource = book.ListViewKind();
            dataTheLoai.AutoSize = true;
            btnViewDetailTL.Name = "";
            btnViewDetailTL.Text = "Xem chi tiết";
            btnViewDetailTL.UseColumnTextForButtonValue = true;
            int columnIndex = 3;
            if (dataTheLoai.Columns[""] == null)
            {
                dataTheLoai.Columns.Insert(columnIndex, btnViewDetailTL);
            }
            else
            {
                dataTheLoai.Columns.Remove(btnViewDetailTL);
                dataTheLoai.Columns.Insert(columnIndex, btnViewDetailTL);
            }

            // hiển thị danh sách tài liệu
            var height = 0;
            foreach (DataGridViewRow row in dataBook.Rows)
            {
                if (row.Visible)
                    height += row.Height;
            }
            cbTLID.DataSource = book.listID();
            dataBook.Height = height;
            lbTitle.Text = "Thêm tài liệu mới";
            
            tbBookID.Enabled = true;
            dataBook.ReadOnly = true;
            dataBook.DataSource = book.LayDanhSachTaiLieu();
            dataBook.AutoSize = true;
            btnViewDetail.Name = "";
            btnViewDetail.Text = "Xem chi tiết";
            btnViewDetail.UseColumnTextForButtonValue = true;
            int columnIndex1 = 7;
            
            if (dataBook.Columns[""] == null )
            {
                
                dataBook.Columns.Insert(columnIndex1, btnViewDetail);
            }
            else
            {
                dataBook.Columns.Remove(btnViewDetail);
                dataBook.Columns.Insert(columnIndex1, btnViewDetail);
            }
           


        }

        private void btnUpdateBook_Click(object sender, EventArgs e)
        {
            string matl = tbBookID.Text;
            string tentl = tbName.Text;
            string matheloai = cbTLID.Text;
            string sl = tbCountBook.Text;
            string namxb = tbYearXB.Text;
            string nxb = tbNXB.Text;
            string tg = tbAuthor.Text;
            if (System.Text.RegularExpressions.Regex.IsMatch(tbCountBook.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                tbCountBook.Text = "";
            }
            else
            {
                if (book.SuaThongTinTaiLieu(new Book(matl, tentl, matheloai, int.Parse(sl), nxb, int.Parse(namxb), tg)))
                {
                    setTextNull();
                    MessageBox.Show("Cập nhập tài liệu thành công");
                    ViewData();
                    tbBookID.Text = "";
                    tbName.Text = "";
                    btnAddBook.Visible = true;
                    tbCountBook.Text = "";
                    tbYearXB.Text = "";
                    tbNXB.Text = "";
                    tbAuthor.Text = "";
                }
                else
                {
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại mã tài liệu");
                }
            }
           
            
        }

        private void mnBackHome_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (tbSearchID.Text.Equals(""))
                ViewData();
            else
            {
                if (book.TimTaiLieuTheoMa(tbSearchID.Text).Count == 0 && book.SearchByID(tbSearchID.Text).Count==0)
                    MessageBox.Show("Không tìm thấy mã tài liệu hay mã thể loại là : " + tbSearchID.Text, "Thông báo");
                else
                {
                    if(book.SearchByID(tbSearchID.Text).Count == 0)
                        dataBook.DataSource = book.TimTaiLieuTheoMa(tbSearchID.Text);
                    else
                        dataTheLoai.DataSource = book.SearchByID(tbSearchID.Text);
                }
            }
        }

        private void dataTheLoai_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            lbTL.Text = "Cập nhật thông tin thể loại";
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                int i = int.Parse(dataTheLoai.CurrentRow.Index.ToString());

                string selectID = dataTheLoai.Rows[i].Cells[0].Value.ToString();
                btnUpdateTL.Visible = true;
                btnDeleteKind.Visible = true;
                List<kind> list = book.SearchByID(selectID);
                if (list.Count > 0)
                {
                    tbTheLoaiID.Text = list[0].matheloai.ToString();
                    tbTheLoaiName.Text = list[0].tentheloai.ToString();
                    tbGhiChu.Text = list[0].ghichu.ToString();

                }

                tbTheLoaiID.Enabled = false;
            }
        }

        private void btnUpdateTL_Click(object sender, EventArgs e)
        {

            if (book.UpdateKind(new kind(tbTheLoaiID.Text, tbTheLoaiName.Text,tbGhiChu.Text)))
            {
                setTextNull();
                MessageBox.Show("Cập nhập thể loại thành công");
                ViewData();
                
            }
            else
            {
                MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại mã thể loại");
            }
        
        }

        private void btnDeleteBook_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn xóa mã tài liệu " + tbBookID.Text + "?", "Xóa tài liệu", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (book.XoaMotTaiLieu(tbBookID.Text))
                {
                    setTextNull();
                    MessageBox.Show("Xóa thành công");
                    ViewData();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!");
            }
            else
            {
                // user clicked no
            }
        }

        private void btnDeleteKind_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("bạn xóa mã thể loại "+ tbTheLoaiID.Text+"?", "Xóa thể loại", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (book.DeleteKind(tbTheLoaiID.Text))
                {
                    setTextNull();
                    MessageBox.Show("Xóa thành công");
                    ViewData();
                }
                else
                    MessageBox.Show("Có lỗi xảy ra vui lòng kiểm tra lại!");
            }
            else
            {
                // user clicked no
            }
        }
        void setTextNull()
        {
            tbGhiChu.Text = "";
            tbCountBook.Text = "";
            tbAuthor.Text = "";
            tbBookID.Text = "";
            tbName.Text = "";
            tbNXB.Text = "";
            tbSearchID.Text = "";
            tbTheLoaiID.Text = "";
            tbTheLoaiName.Text = "";
            tbYearXB.Text = "";
            tbGhiChu.Text = "";
        }
    }
}
