using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DALConnector;
using DTOModel;
using BULBus;
using iTextSharp.text;
using iTextSharp.text.pdf;
using System.IO;

namespace QuanLyThuVienV3._1
{
    public partial class TKTop10 : Form
    {
        public TKTop10()
        {
            InitializeComponent();
        }
        BULThongkeTop10 ThongKe = new BULThongkeTop10();
        string userID = FrmMain.userAccount;
        private void btnTop10_Click(object sender, EventArgs e)
        {
            if (dtpbegin.Enabled == true)
            {
                DateTime begin = DateTime.Parse(dtpbegin.Value.Date.ToString("yyyy-MM-dd"));
                DateTime end = DateTime.Parse(dtpend.Value.Date.ToString("yyyy-MM-dd"));
                if (begin > end)
                {
                    MessageBox.Show("Vui lòng nhập khoảng thời gian hợp lệ");
                }
                else
                    dataThongKeTop10.DataSource = ThongKe.ThongKe10(begin, end);
                
                
            }
            else
            {
                dataThongKeTop10.DataSource = ThongKe.ThongKe10NoDate();
            }

            
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            //string datebegin = dtpbegin.Value.Date.ToString("yyyy-MM-dd");
            //DateTime begin = DateTime.Parse(datebegin);
            //string dateend = dtpend.Value.Date.ToString("yyyy-MM-dd");
            //DateTime end = DateTime.Parse(dateend);
            if (dtpbegin.Enabled == true)
            {
                DateTime begin = DateTime.Parse(dtpbegin.Value.Date.ToString("yyyy-MM-dd"));
                DateTime end = DateTime.Parse(dtpend.Value.Date.ToString("yyyy-MM-dd"));
                if (begin > end)
                {
                    MessageBox.Show("Vui lòng nhập khoảng thời gian hợp lệ");
                }
                else
                {
                    dataThongKeTop10.DataSource = ThongKe.ThongKe10(begin, end);
                    //createPDF(checkout.listBorrow(begin, end), "S:/BTL/WinForm/QuanLyThuVienV3.1/thongkelanmuon-nhom10.pdf");
                    createPDF(ThongKe.ThongKe10(begin, end), "S:/BTL/WinForm/QuanLyThuVienV3.1/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " thongketop10-nhom10.pdf");//-"+ DateTime.Now.ToString()+"
                    MessageBox.Show("In file thành công \n File được lưu tại: S:/BTL/WinForm/QuanLyThuVienV3.1/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " thongketop10-nhom10.pdf");
                }
            }
            else
            {
                dataThongKeTop10.DataSource = ThongKe.ThongKe10NoDate();
                createPDF(ThongKe.ThongKe10NoDate(), "S:/BTL/WinForm/QuanLyThuVienV3.1/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " thongketop10-nhom10.pdf");//-"+ DateTime.Now.ToString()+"
                MessageBox.Show("In file thành công \n File được lưu tại: S:/BTL/WinForm/QuanLyThuVienV3.1/" + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " thongketop10-nhom10.pdf");
            }


            
            
          //  createPDF(ThongKe.ThongKe10(begin, end), "D:/thongketop10.pdf");//-"+ DateTime.Now.ToString()+"
           // MessageBox.Show("In thành công");
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
            string ARIALUNI_TFF = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Fonts), "arial.ttf");
            //System.Text.UTF8Encoding encoding = new System.Text.UTF8Encoding();
            //Create a base font object making sure to specify IDENTITY-H
            BaseFont bf = BaseFont.CreateFont(ARIALUNI_TFF, BaseFont.IDENTITY_H, BaseFont.NOT_EMBEDDED);

            //Create a specific font object
            iTextSharp.text.Font f = new iTextSharp.text.Font(bf, 12, iTextSharp.text.Font.NORMAL);

            BULEmployees employ = new BULEmployees();

            List<Employees> listNameWithID = employ.ViewTableNVByUserID(userID);
            string a = "";
            foreach (Employees d in listNameWithID)
            {

                a = d.HoTen;
            }



            Paragraph pl = new Paragraph("Tổ chức: \n \n", f);
            Paragraph pl2 = new Paragraph("Ngày lập:  " + DateTime.Now.Day + "-" + DateTime.Now.Month + "-" + DateTime.Now.Year + " \n \n", f);
            Paragraph pl3 = new Paragraph("Danh sách tài liệu mượn nhiều nhất \n \n", f);
            Paragraph pl4 = new Paragraph("\n \n \nNgười lập: " + a + " \n \n", f);



            document.Add(pl);
            document.Add(pl2);
            document.Add(pl3);
            document.Add(table);

            document.Add(pl4);
            document.Close();
        }

        private void TKTop10_Load(object sender, EventArgs e)
        {
            dtpbegin.Enabled = false;
            dtpend.Enabled = false;
        }

        private void dtpbegin_ValueChanged(object sender, EventArgs e)
        {
            dtpbegin.Enabled = true;
            dtpend.Enabled = true;
        }

        private void btnTurnOn_Click(object sender, EventArgs e)
        {
            if(dtpend.Enabled == true)
            {
                dtpbegin.Enabled = false;
                dtpend.Enabled = false;
            }
            else
            {
                btnTurnOn.Enabled = false;
                dtpbegin.Enabled = true;
                dtpend.Enabled = true;
            }
        }
    }
}
