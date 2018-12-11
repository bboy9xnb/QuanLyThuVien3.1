using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;
using DALConnector;
using DTOModel;
using BULBus;

namespace QuanLyThuVienV3._1
{
    public partial class FrmCheckOutBorrowBook : Form
    {
        BULCheckoutBorrow checkout = new BULCheckoutBorrow();
        public FrmCheckOutBorrowBook()
        {
           
            InitializeComponent();
        }

        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            //DateTime begin = DateTime.Parse("2018-10-18");
            //DateTime end = DateTime.Parse("2019-10-18");
            if (dtpBegin.Enabled == true)
            {
                DateTime begin = DateTime.Parse(dtpBegin.Value.Date.ToString("yyyy-MM-dd"));
                DateTime end = DateTime.Parse(dtpEnd.Value.Date.ToString("yyyy-MM-dd"));
                if (begin > end)
                {
                    MessageBox.Show("Vui lòng nhập khoảng thời gian hợp lệ");
                }else
                dataCheckOut.DataSource = checkout.listBorrow(begin, end);
            }
            else
                dataCheckOut.DataSource = checkout.listBorrowNoDate();

        }

        private void btnWriteFile_Click(object sender, EventArgs e)
        {
            //DateTime begin = DateTime.Parse("2018-10-18");
           // DateTime end = DateTime.Parse("2019-10-18");
           
            if(dtpBegin.Enabled == true)
            {
                DateTime begin = DateTime.Parse(dtpBegin.Value.Date.ToString("yyyy-MM-dd"));
                DateTime end = DateTime.Parse(dtpEnd.Value.Date.ToString("yyyy-MM-dd"));
                if (begin > end)
                {
                    MessageBox.Show("Vui lòng nhập khoảng thời gian hợp lệ");
                }
                else
                {
                    dataCheckOut.DataSource = checkout.listBorrow(begin, end);
                    createPDF(checkout.listBorrow(begin, end), "S:/BTL/WinForm/QuanLyThuVienV3.1/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " thongkelanmuon-nhom10.pdf");
                    MessageBox.Show("In file thành công \n File được lưu tại: S:/BTL/WinForm/QuanLyThuVienV3.1/"+ DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year+" thongkelanmuon-nhom10.pdf");
                }
                    
            }
            else
            {
                dataCheckOut.DataSource = checkout.listBorrowNoDate();
                createPDF(checkout.listBorrowNoDate(), "S:/BTL/WinForm/QuanLyThuVienV3.1/"+ DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year+" thongkelanmuon-nhom10.pdf");
                MessageBox.Show("In file thành công \n File được lưu tại: S:/BTL/WinForm/QuanLyThuVienV3.1/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " thongkelanmuon-nhom10.pdf");
            }

            
          
        }
        public void createPDF(DataTable dataTable, string destinationPath)
        {
            Document document = new Document();
            PdfWriter writer = PdfWriter.GetInstance(document, new FileStream(destinationPath, FileMode.Create));
            document.Open();

            PdfPTable table = new PdfPTable(dataTable.Columns.Count);
            table.WidthPercentage = 100;

            //Set columns names in the pdf file
            for (int k = 0; k < dataTable.Columns.Count; k++)
            {
                PdfPCell cell = new PdfPCell(new Phrase(dataTable.Columns[k].ColumnName));

                cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;
                cell.BackgroundColor = new iTextSharp.text.BaseColor(51, 102, 102);
               
                table.AddCell(cell);
            }

            //Add values of DataTable in pdf file
            for (int i = 0; i < dataTable.Rows.Count; i++)
            {
                for (int j = 0; j < dataTable.Columns.Count; j++)
                {
                    PdfPCell cell = new PdfPCell(new Phrase(dataTable.Rows[i][j].ToString()));
                    
                    //Align the cell in the center
                    cell.HorizontalAlignment = PdfPCell.ALIGN_CENTER;
                    cell.VerticalAlignment = PdfPCell.ALIGN_CENTER;

                    table.AddCell(cell);
                }
            }
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "ARIALUNI.TTF");
            //System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            //Create a base font object making sure to specify IDENTITY-H
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //Create a specific font object
            iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);
            BULEmployees employ = new BULEmployees();
            string userID = FrmMain.userAccount;
            List<Employees> listNameWithID = employ.ViewTableNVByUserID(userID);
            string a = "";
            foreach (Employees d in listNameWithID)
            {

                a = d.HoTen;
            }


            Paragraph pl = new Paragraph("Tổ chức: Nhóm 10 - CNTT1 \n \n", f);
            Paragraph pl2 = new Paragraph("Ngày lập:  " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " \n \n", f);
            Paragraph pl3 = new Paragraph("Danh sách thống kê số lần mượn theo thể loại \n \n", f);
            Paragraph pl4 = new Paragraph("\n \n \nNgười lập: " + a + " \n \n", f);

            document.Add(pl);
            document.Add(pl2);
            document.Add(pl3);
            document.Add(table);
            document.Add(pl4);
            document.Close();
        }
        private void FrmCheckOutBorrowBook_Load(object sender, EventArgs e)
        {
            dtpBegin.Enabled = false;
            dtpEnd.Enabled = false;
        }

        private void btnTKDateTurnOn_Click(object sender, EventArgs e)
        {
            if(dtpBegin.Enabled == true)
            {
                dtpBegin.Enabled = false;
                dtpEnd.Enabled = false;
            }
            else
            {
                dtpBegin.Enabled = true;
                dtpEnd.Enabled = true;
                btnTKDateTurnOn.Enabled = false;
            }
            
        }

        private void mnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void mnLoad_Click(object sender, EventArgs e)
        {
            if (dtpBegin.Enabled == true)
            {
                btnTKDateTurnOn.Enabled = true;
                dtpBegin.Enabled = false;
                dtpEnd.Enabled = false;

            }
        }
    }
}
