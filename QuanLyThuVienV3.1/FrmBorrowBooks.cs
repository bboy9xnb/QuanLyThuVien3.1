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
    public partial class FrmBorrowBooks : Form
    {
        string userID = FrmMain.userAccount;
        BULAuthor listAuthor = new BULAuthor();
        BULBorrowBook borrow = new BULBorrowBook();
        public FrmBorrowBooks()
        {
            InitializeComponent();
            //ViewTableNVByUserID
            BULEmployees employ = new BULEmployees();

            List<Employees> listNameWithID = employ.ViewTableNVByUserID(userID);
            string a = "", b="";
            foreach (Employees d in listNameWithID)
            {
                b = d.MaNhanVien;
                a = d.HoTen;
            }
            tbEmployessID.Text = b;
            tbEmployeesName.Text = a;
            var autoSource = new AutoCompleteStringCollection();
            //autoSource.AddRange(listAuthor.LayDanhSachDGWithID().ToArray());
            foreach (var item in listAuthor.LayDanhSachDGWithID()) autoSource.Add(item);
            tbAuthorID.AutoCompleteCustomSource = autoSource;
            dataBook.DataSource = borrow.listInforBook();
        }

        private void dataBook_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            btnUpdate.Visible = true;
            btnDelete.Visible = true;
            var senderGrid = (DataGridView)sender;
            if (senderGrid.Columns[e.ColumnIndex] is DataGridViewButtonColumn &&
                 e.RowIndex >= 0)
            {
                //TODO - Button Clicked - Execute Code Here
                int i = int.Parse(dataBook.CurrentRow.Index.ToString());

                string selectID = dataBook.Rows[i].Cells[0].Value.ToString();
                
                //List<kind> list = listAuthor.S(selectID);
                //if (list.Count > 0)
                //{
                //    tbTheLoaiID.Text = list[0].matheloai.ToString();
                //    tbTheLoaiName.Text = list[0].tentheloai.ToString();
                //    tbGhiChu.Text = list[0].ghichu.ToString();

                //}

               
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {

        }

        // lấy thên độc giả theo mã độc giả

        private void tbAuthorID_changerClicl(object sender, EventArgs e)
        {
            BULAuthor author = new BULAuthor();
            
            List<Author> listNameWithID = author.TimDocGia(tbAuthorID.Text);
            string a = "";
            foreach (Author d in listNameWithID)
            {
                a = d.HoTen;
            }
            tbAuthorName.Text = a;
        }

        private void tbUserID_Click(object sender, EventArgs e)
        {
           
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }

        private void FrmBorrowBooks_Load(object sender, EventArgs e)
        {
            ViewTable();
        }
        DataGridViewButtonColumn btnViewDetailTL = new DataGridViewButtonColumn();
        private void ViewTable()
        {
            dataBook.AutoSize = true;
            dataBook.ReadOnly = true;
            var heightTL = 0;
            foreach (DataGridViewRow row in dataBook.Rows)
            {
                if (row.Visible)
                    heightTL += row.Height;
            }

            dataBook.Height = heightTL;
            btnViewDetailTL.Name = "";
            btnViewDetailTL.Text = "Xem chi tiết";
            btnViewDetailTL.UseColumnTextForButtonValue = true;
            int columnIndex = 9;
            if (dataBook.Columns[""] == null)
            {
                dataBook.Columns.Insert(columnIndex, btnViewDetailTL);
            }
            else
            {
                dataBook.Columns.Remove(btnViewDetailTL);
                dataBook.Columns.Insert(columnIndex, btnViewDetailTL);
            }
        }

        private void thoátToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
