namespace QuanLyThuVienV3._1
{
    partial class FrmMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnCategoryManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnEmployeesManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnReadersManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnDocumentManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mnPayment = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBookBorrow = new System.Windows.Forms.ToolStripMenuItem();
            this.mnBookPay = new System.Windows.Forms.ToolStripMenuItem();
            this.mnStatisticalManager = new System.Windows.Forms.ToolStripMenuItem();
            this.mntopborrowedbycategory = new System.Windows.Forms.ToolStripMenuItem();
            this.mnOverdueLoans = new System.Windows.Forms.ToolStripMenuItem();
            this.mnTop10 = new System.Windows.Forms.ToolStripMenuItem();
            this.mnSupport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnExit = new System.Windows.Forms.ToolStripMenuItem();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.lbUserName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label10 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lbSumEmployees = new System.Windows.Forms.Label();
            this.lbSumDocGia = new System.Windows.Forms.Label();
            this.lbSumBook = new System.Windows.Forms.Label();
            this.lbSumOutDate = new System.Windows.Forms.Label();
            this.lnSumBorrow = new System.Windows.Forms.Label();
            this.chartData = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnCategoryManager,
            this.mnPayment,
            this.mnStatisticalManager,
            this.mnSupport,
            this.mnExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(923, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnCategoryManager
            // 
            this.mnCategoryManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnEmployeesManager,
            this.mnReadersManager,
            this.mnDocumentManager});
            this.mnCategoryManager.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_manager;
            this.mnCategoryManager.Name = "mnCategoryManager";
            this.mnCategoryManager.Size = new System.Drawing.Size(133, 20);
            this.mnCategoryManager.Text = "Quản lý danh mục";
            // 
            // mnEmployeesManager
            // 
            this.mnEmployeesManager.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_user;
            this.mnEmployeesManager.Name = "mnEmployeesManager";
            this.mnEmployeesManager.Size = new System.Drawing.Size(170, 22);
            this.mnEmployeesManager.Text = "Quản lý nhân viên";
            this.mnEmployeesManager.Click += new System.EventHandler(this.mnEmployeesManager_Click);
            // 
            // mnReadersManager
            // 
            this.mnReadersManager.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_ac;
            this.mnReadersManager.Name = "mnReadersManager";
            this.mnReadersManager.Size = new System.Drawing.Size(170, 22);
            this.mnReadersManager.Text = "Quản lý độc giả";
            this.mnReadersManager.Click += new System.EventHandler(this.mnReadersManager_Click);
            // 
            // mnDocumentManager
            // 
            this.mnDocumentManager.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_document;
            this.mnDocumentManager.Name = "mnDocumentManager";
            this.mnDocumentManager.Size = new System.Drawing.Size(170, 22);
            this.mnDocumentManager.Text = "Quản lý tài liệu";
            this.mnDocumentManager.Click += new System.EventHandler(this.mnDocumentManager_Click);
            // 
            // mnPayment
            // 
            this.mnPayment.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBookBorrow,
            this.mnBookPay});
            this.mnPayment.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_pay;
            this.mnPayment.Name = "mnPayment";
            this.mnPayment.Size = new System.Drawing.Size(128, 20);
            this.mnPayment.Text = "Quản lý mượn trả";
            // 
            // mnBookBorrow
            // 
            this.mnBookBorrow.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_book;
            this.mnBookBorrow.Name = "mnBookBorrow";
            this.mnBookBorrow.Size = new System.Drawing.Size(152, 22);
            this.mnBookBorrow.Text = "Mượn sách";
            this.mnBookBorrow.Click += new System.EventHandler(this.mnBookBorrow_Click);
            // 
            // mnBookPay
            // 
            this.mnBookPay.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_book_2;
            this.mnBookPay.Name = "mnBookPay";
            this.mnBookPay.Size = new System.Drawing.Size(152, 22);
            this.mnBookPay.Text = "Trả sách";
            this.mnBookPay.Click += new System.EventHandler(this.mnBookPay_Click);
            // 
            // mnStatisticalManager
            // 
            this.mnStatisticalManager.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mntopborrowedbycategory,
            this.mnOverdueLoans,
            this.mnTop10});
            this.mnStatisticalManager.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_statistical;
            this.mnStatisticalManager.Name = "mnStatisticalManager";
            this.mnStatisticalManager.Size = new System.Drawing.Size(130, 20);
            this.mnStatisticalManager.Text = "Thống kê báo cáo";
            // 
            // mntopborrowedbycategory
            // 
            this.mntopborrowedbycategory.Name = "mntopborrowedbycategory";
            this.mntopborrowedbycategory.Size = new System.Drawing.Size(242, 22);
            this.mntopborrowedbycategory.Text = "Số lần mượn theo thể loại";
            this.mntopborrowedbycategory.Click += new System.EventHandler(this.mntopborrowedbycategory_Click);
            // 
            // mnOverdueLoans
            // 
            this.mnOverdueLoans.Name = "mnOverdueLoans";
            this.mnOverdueLoans.Size = new System.Drawing.Size(242, 22);
            this.mnOverdueLoans.Text = "Tài liệu mượn quá hạn";
            this.mnOverdueLoans.Click += new System.EventHandler(this.mnOverdueLoans_Click);
            // 
            // mnTop10
            // 
            this.mnTop10.Image = global::QuanLyThuVienV3._1.Properties.Resources.icons8_10_50;
            this.mnTop10.Name = "mnTop10";
            this.mnTop10.Size = new System.Drawing.Size(242, 22);
            this.mnTop10.Text = "Top 10 tài liệu mượn nhiều nhất";
            this.mnTop10.Click += new System.EventHandler(this.mnTop10_Click);
            // 
            // mnSupport
            // 
            this.mnSupport.Image = global::QuanLyThuVienV3._1.Properties.Resources.ic_help;
            this.mnSupport.Name = "mnSupport";
            this.mnSupport.Size = new System.Drawing.Size(69, 20);
            this.mnSupport.Text = "Hỗ trợ";
            this.mnSupport.Click += new System.EventHandler(this.mnSupport_Click);
            // 
            // mnExit
            // 
            this.mnExit.Image = global::QuanLyThuVienV3._1.Properties.Resources.icons8_exit_26;
            this.mnExit.Name = "mnExit";
            this.mnExit.Size = new System.Drawing.Size(66, 20);
            this.mnExit.Text = "Thoát";
            this.mnExit.Click += new System.EventHandler(this.mnExit_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(17, 90);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 1;
            // 
            // lbUserName
            // 
            this.lbUserName.AutoSize = true;
            this.lbUserName.BackColor = System.Drawing.Color.Transparent;
            this.lbUserName.Font = new System.Drawing.Font("Sitka Heading", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUserName.Location = new System.Drawing.Point(12, 39);
            this.lbUserName.Name = "lbUserName";
            this.lbUserName.Size = new System.Drawing.Size(144, 26);
            this.lbUserName.TabIndex = 2;
            this.lbUserName.Text = "Xin chào VietPDb";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 273);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 23);
            this.label1.TabIndex = 3;
            this.label1.Text = "Thống kê tổng quan";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.BackColor = System.Drawing.Color.Transparent;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 58.51393F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 41.48607F));
            this.tableLayoutPanel1.Controls.Add(this.label10, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lbSumEmployees, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lbSumDocGia, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lbSumBook, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lbSumOutDate, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.lnSumBorrow, 1, 3);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(17, 310);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 26F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(323, 132);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(180, 23);
            this.label10.TabIndex = 12;
            this.label10.Text = "Số tài liệu mượn quá hạn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 23);
            this.label2.TabIndex = 4;
            this.label2.Text = "Tổng số nhân viên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 27);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 23);
            this.label3.TabIndex = 5;
            this.label3.Text = "Tổng số độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 23);
            this.label4.TabIndex = 6;
            this.label4.Text = "Tổng số tài liệu";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(149, 23);
            this.label5.TabIndex = 7;
            this.label5.Text = "Số tài liệu cho mượn";
            // 
            // lbSumEmployees
            // 
            this.lbSumEmployees.AutoSize = true;
            this.lbSumEmployees.BackColor = System.Drawing.Color.Transparent;
            this.lbSumEmployees.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumEmployees.Location = new System.Drawing.Point(191, 0);
            this.lbSumEmployees.Name = "lbSumEmployees";
            this.lbSumEmployees.Size = new System.Drawing.Size(19, 23);
            this.lbSumEmployees.TabIndex = 8;
            this.lbSumEmployees.Text = "0";
            // 
            // lbSumDocGia
            // 
            this.lbSumDocGia.AutoSize = true;
            this.lbSumDocGia.BackColor = System.Drawing.Color.Transparent;
            this.lbSumDocGia.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumDocGia.Location = new System.Drawing.Point(191, 27);
            this.lbSumDocGia.Name = "lbSumDocGia";
            this.lbSumDocGia.Size = new System.Drawing.Size(19, 23);
            this.lbSumDocGia.TabIndex = 9;
            this.lbSumDocGia.Text = "0";
            // 
            // lbSumBook
            // 
            this.lbSumBook.AutoSize = true;
            this.lbSumBook.BackColor = System.Drawing.Color.Transparent;
            this.lbSumBook.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumBook.Location = new System.Drawing.Point(191, 54);
            this.lbSumBook.Name = "lbSumBook";
            this.lbSumBook.Size = new System.Drawing.Size(19, 23);
            this.lbSumBook.TabIndex = 10;
            this.lbSumBook.Text = "0";
            // 
            // lbSumOutDate
            // 
            this.lbSumOutDate.AutoSize = true;
            this.lbSumOutDate.BackColor = System.Drawing.Color.Transparent;
            this.lbSumOutDate.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbSumOutDate.Location = new System.Drawing.Point(191, 108);
            this.lbSumOutDate.Name = "lbSumOutDate";
            this.lbSumOutDate.Size = new System.Drawing.Size(19, 23);
            this.lbSumOutDate.TabIndex = 11;
            this.lbSumOutDate.Text = "0";
            // 
            // lnSumBorrow
            // 
            this.lnSumBorrow.AutoSize = true;
            this.lnSumBorrow.BackColor = System.Drawing.Color.Transparent;
            this.lnSumBorrow.Font = new System.Drawing.Font("Sitka Heading", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnSumBorrow.Location = new System.Drawing.Point(191, 80);
            this.lnSumBorrow.Name = "lnSumBorrow";
            this.lnSumBorrow.Size = new System.Drawing.Size(19, 23);
            this.lnSumBorrow.TabIndex = 13;
            this.lnSumBorrow.Text = "0";
            // 
            // chartData
            // 
            chartArea1.Name = "ChartArea1";
            this.chartData.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chartData.Legends.Add(legend1);
            this.chartData.Location = new System.Drawing.Point(410, 90);
            this.chartData.Name = "chartData";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.chartData.Series.Add(series1);
            this.chartData.Size = new System.Drawing.Size(481, 189);
            this.chartData.TabIndex = 5;
            this.chartData.Text = "chart1";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVienV3._1.Properties.Resources.background;
            this.ClientSize = new System.Drawing.Size(923, 529);
            this.Controls.Add(this.chartData);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbUserName);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.Text = "Quản lý thư viện";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartData)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnCategoryManager;
        private System.Windows.Forms.ToolStripMenuItem mnEmployeesManager;
        private System.Windows.Forms.ToolStripMenuItem mnReadersManager;
        private System.Windows.Forms.ToolStripMenuItem mnDocumentManager;
        private System.Windows.Forms.ToolStripMenuItem mnPayment;
        private System.Windows.Forms.ToolStripMenuItem mnBookBorrow;
        private System.Windows.Forms.ToolStripMenuItem mnBookPay;
        private System.Windows.Forms.ToolStripMenuItem mnStatisticalManager;
        private System.Windows.Forms.ToolStripMenuItem mntopborrowedbycategory;
        private System.Windows.Forms.ToolStripMenuItem mnOverdueLoans;
        private System.Windows.Forms.ToolStripMenuItem mnTop10;
        private System.Windows.Forms.ToolStripMenuItem mnSupport;
        private System.Windows.Forms.ToolStripMenuItem mnExit;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Label lbUserName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lbSumEmployees;
        private System.Windows.Forms.Label lbSumDocGia;
        private System.Windows.Forms.Label lbSumBook;
        private System.Windows.Forms.Label lbSumOutDate;
        private System.Windows.Forms.Label lnSumBorrow;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartData;
    }
}