namespace QuanLyThuVienV3._1
{
    partial class FrmBooks
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
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnBackHome = new System.Windows.Forms.ToolStripMenuItem();
            this.mnRefesh = new System.Windows.Forms.ToolStripMenuItem();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tbTheLoaiID = new System.Windows.Forms.TextBox();
            this.tbTheLoaiName = new System.Windows.Forms.TextBox();
            this.tbGhiChu = new System.Windows.Forms.TextBox();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.tbBookID = new System.Windows.Forms.TextBox();
            this.tbName = new System.Windows.Forms.TextBox();
            this.cbTLID = new System.Windows.Forms.ComboBox();
            this.tbCountBook = new System.Windows.Forms.TextBox();
            this.tbNXB = new System.Windows.Forms.TextBox();
            this.tbYearXB = new System.Windows.Forms.TextBox();
            this.tbAuthor = new System.Windows.Forms.TextBox();
            this.btnAddTL = new System.Windows.Forms.Button();
            this.btnCancelTL = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.lbTitle = new System.Windows.Forms.Label();
            this.btnAddBook = new System.Windows.Forms.Button();
            this.btnCancelBook = new System.Windows.Forms.Button();
            this.dataBook = new System.Windows.Forms.DataGridView();
            this.label13 = new System.Windows.Forms.Label();
            this.btnUpdateBook = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchID = new System.Windows.Forms.TextBox();
            this.lbTL = new System.Windows.Forms.Label();
            this.dataTheLoai = new System.Windows.Forms.DataGridView();
            this.btnUpdateTL = new System.Windows.Forms.Button();
            this.btnDeleteBook = new System.Windows.Forms.Button();
            this.btnDeleteKind = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheLoai)).BeginInit();
            this.SuspendLayout();
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(18, 32);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 0;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBackHome,
            this.mnRefesh});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1126, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnBackHome
            // 
            this.mnBackHome.Name = "mnBackHome";
            this.mnBackHome.Size = new System.Drawing.Size(136, 20);
            this.mnBackHome.Text = "Trở về giao diện chính";
            this.mnBackHome.Click += new System.EventHandler(this.mnBackHome_Click);
            // 
            // mnRefesh
            // 
            this.mnRefesh.Name = "mnRefesh";
            this.mnRefesh.Size = new System.Drawing.Size(81, 20);
            this.mnRefesh.Text = "Tải lại trang";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 40.96916F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 59.03084F));
            this.tableLayoutPanel1.Controls.Add(this.label5, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.label3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTheLoaiID, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.tbTheLoaiName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.tbGhiChu, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(18, 224);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 29F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(227, 93);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 19);
            this.label5.TabIndex = 4;
            this.label5.Text = "Ghi chú";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(82, 19);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tên thể loại";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã thể loại";
            // 
            // tbTheLoaiID
            // 
            this.tbTheLoaiID.Location = new System.Drawing.Point(95, 3);
            this.tbTheLoaiID.Name = "tbTheLoaiID";
            this.tbTheLoaiID.Size = new System.Drawing.Size(129, 20);
            this.tbTheLoaiID.TabIndex = 5;
            // 
            // tbTheLoaiName
            // 
            this.tbTheLoaiName.Location = new System.Drawing.Point(95, 35);
            this.tbTheLoaiName.Name = "tbTheLoaiName";
            this.tbTheLoaiName.Size = new System.Drawing.Size(129, 20);
            this.tbTheLoaiName.TabIndex = 6;
            // 
            // tbGhiChu
            // 
            this.tbGhiChu.Location = new System.Drawing.Point(95, 67);
            this.tbGhiChu.Name = "tbGhiChu";
            this.tbGhiChu.Size = new System.Drawing.Size(129, 20);
            this.tbGhiChu.TabIndex = 7;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 2;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 48.89868F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 51.10132F));
            this.tableLayoutPanel2.Controls.Add(this.label2, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.label10, 0, 6);
            this.tableLayoutPanel2.Controls.Add(this.label8, 0, 5);
            this.tableLayoutPanel2.Controls.Add(this.label7, 0, 4);
            this.tableLayoutPanel2.Controls.Add(this.label6, 0, 3);
            this.tableLayoutPanel2.Controls.Add(this.label4, 0, 2);
            this.tableLayoutPanel2.Controls.Add(this.label9, 0, 1);
            this.tableLayoutPanel2.Controls.Add(this.tbBookID, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.tbName, 1, 1);
            this.tableLayoutPanel2.Controls.Add(this.cbTLID, 1, 2);
            this.tableLayoutPanel2.Controls.Add(this.tbCountBook, 1, 3);
            this.tableLayoutPanel2.Controls.Add(this.tbNXB, 1, 4);
            this.tableLayoutPanel2.Controls.Add(this.tbYearXB, 1, 5);
            this.tableLayoutPanel2.Controls.Add(this.tbAuthor, 1, 6);
            this.tableLayoutPanel2.Location = new System.Drawing.Point(18, 396);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 7;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 51.6129F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 48.3871F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 30F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 33F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 28F));
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 35F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(227, 222);
            this.tableLayoutPanel2.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 19);
            this.label2.TabIndex = 1;
            this.label2.Text = "Mã tài liệu";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(3, 186);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(52, 19);
            this.label10.TabIndex = 9;
            this.label10.Text = "Tác giả";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(3, 158);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(98, 19);
            this.label8.TabIndex = 7;
            this.label8.Text = "Năm xuất bản";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 125);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 19);
            this.label7.TabIndex = 6;
            this.label7.Text = "Nhà xuất bản";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 92);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 19);
            this.label6.TabIndex = 5;
            this.label6.Text = "Số lượng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 19);
            this.label4.TabIndex = 3;
            this.label4.Text = "Mã thể loại";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(3, 32);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(76, 19);
            this.label9.TabIndex = 8;
            this.label9.Text = "Tên tài liệu";
            // 
            // tbBookID
            // 
            this.tbBookID.Location = new System.Drawing.Point(114, 3);
            this.tbBookID.Name = "tbBookID";
            this.tbBookID.Size = new System.Drawing.Size(110, 20);
            this.tbBookID.TabIndex = 10;
            // 
            // tbName
            // 
            this.tbName.Location = new System.Drawing.Point(114, 35);
            this.tbName.Name = "tbName";
            this.tbName.Size = new System.Drawing.Size(110, 20);
            this.tbName.TabIndex = 11;
            // 
            // cbTLID
            // 
            this.cbTLID.FormattingEnabled = true;
            this.cbTLID.Location = new System.Drawing.Point(114, 65);
            this.cbTLID.Name = "cbTLID";
            this.cbTLID.Size = new System.Drawing.Size(110, 21);
            this.cbTLID.TabIndex = 12;
            // 
            // tbCountBook
            // 
            this.tbCountBook.Location = new System.Drawing.Point(114, 95);
            this.tbCountBook.Name = "tbCountBook";
            this.tbCountBook.Size = new System.Drawing.Size(110, 20);
            this.tbCountBook.TabIndex = 13;
            // 
            // tbNXB
            // 
            this.tbNXB.Location = new System.Drawing.Point(114, 128);
            this.tbNXB.Name = "tbNXB";
            this.tbNXB.Size = new System.Drawing.Size(110, 20);
            this.tbNXB.TabIndex = 14;
            // 
            // tbYearXB
            // 
            this.tbYearXB.Location = new System.Drawing.Point(114, 161);
            this.tbYearXB.Name = "tbYearXB";
            this.tbYearXB.Size = new System.Drawing.Size(110, 20);
            this.tbYearXB.TabIndex = 15;
            // 
            // tbAuthor
            // 
            this.tbAuthor.Location = new System.Drawing.Point(114, 189);
            this.tbAuthor.Name = "tbAuthor";
            this.tbAuthor.Size = new System.Drawing.Size(110, 20);
            this.tbAuthor.TabIndex = 16;
            // 
            // btnAddTL
            // 
            this.btnAddTL.Location = new System.Drawing.Point(44, 323);
            this.btnAddTL.Name = "btnAddTL";
            this.btnAddTL.Size = new System.Drawing.Size(75, 23);
            this.btnAddTL.TabIndex = 4;
            this.btnAddTL.Text = "Thêm";
            this.btnAddTL.UseVisualStyleBackColor = true;
            this.btnAddTL.Click += new System.EventHandler(this.btnAddTL_Click);
            // 
            // btnCancelTL
            // 
            this.btnCancelTL.Location = new System.Drawing.Point(170, 323);
            this.btnCancelTL.Name = "btnCancelTL";
            this.btnCancelTL.Size = new System.Drawing.Size(75, 23);
            this.btnCancelTL.TabIndex = 5;
            this.btnCancelTL.Text = "Hủy";
            this.btnCancelTL.UseVisualStyleBackColor = true;
            this.btnCancelTL.Click += new System.EventHandler(this.btnCancelTL_Click);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(4, 202);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(155, 19);
            this.label11.TabIndex = 6;
            this.label11.Text = "Nhập thông tin thể loại";
            // 
            // lbTitle
            // 
            this.lbTitle.AutoSize = true;
            this.lbTitle.Font = new System.Drawing.Font("Segoe UI Historic", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTitle.Location = new System.Drawing.Point(4, 374);
            this.lbTitle.Name = "lbTitle";
            this.lbTitle.Size = new System.Drawing.Size(149, 19);
            this.lbTitle.TabIndex = 7;
            this.lbTitle.Text = "Thêm thông tin tài liệu";
            // 
            // btnAddBook
            // 
            this.btnAddBook.Location = new System.Drawing.Point(39, 624);
            this.btnAddBook.Name = "btnAddBook";
            this.btnAddBook.Size = new System.Drawing.Size(75, 23);
            this.btnAddBook.TabIndex = 8;
            this.btnAddBook.Text = "Thêm";
            this.btnAddBook.UseVisualStyleBackColor = true;
            this.btnAddBook.Click += new System.EventHandler(this.btnAddBook_Click);
            // 
            // btnCancelBook
            // 
            this.btnCancelBook.Location = new System.Drawing.Point(188, 624);
            this.btnCancelBook.Name = "btnCancelBook";
            this.btnCancelBook.Size = new System.Drawing.Size(75, 23);
            this.btnCancelBook.TabIndex = 9;
            this.btnCancelBook.Text = "Hủy";
            this.btnCancelBook.UseVisualStyleBackColor = true;
            this.btnCancelBook.Click += new System.EventHandler(this.btnCancelBook_Click);
            // 
            // dataBook
            // 
            this.dataBook.BackgroundColor = System.Drawing.Color.White;
            this.dataBook.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataBook.Location = new System.Drawing.Point(296, 397);
            this.dataBook.Name = "dataBook";
            this.dataBook.Size = new System.Drawing.Size(539, 150);
            this.dataBook.TabIndex = 10;
            this.dataBook.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataBook_CellContentClick);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(296, 358);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(157, 25);
            this.label13.TabIndex = 11;
            this.label13.Text = "Danh sách tài liệu";
            // 
            // btnUpdateBook
            // 
            this.btnUpdateBook.Location = new System.Drawing.Point(12, 624);
            this.btnUpdateBook.Name = "btnUpdateBook";
            this.btnUpdateBook.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateBook.TabIndex = 12;
            this.btnUpdateBook.Text = "Cập nhật ";
            this.btnUpdateBook.UseVisualStyleBackColor = true;
            this.btnUpdateBook.Click += new System.EventHandler(this.btnUpdateBook_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(1039, 34);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 13;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchID
            // 
            this.tbSearchID.Location = new System.Drawing.Point(893, 36);
            this.tbSearchID.Name = "tbSearchID";
            this.tbSearchID.Size = new System.Drawing.Size(146, 20);
            this.tbSearchID.TabIndex = 14;
            // 
            // lbTL
            // 
            this.lbTL.AutoSize = true;
            this.lbTL.BackColor = System.Drawing.Color.White;
            this.lbTL.Font = new System.Drawing.Font("Segoe UI Semibold", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTL.Location = new System.Drawing.Point(291, 32);
            this.lbTL.Name = "lbTL";
            this.lbTL.Size = new System.Drawing.Size(162, 25);
            this.lbTL.TabIndex = 15;
            this.lbTL.Text = "Danh sách thể loại";
            // 
            // dataTheLoai
            // 
            this.dataTheLoai.BackgroundColor = System.Drawing.Color.White;
            this.dataTheLoai.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataTheLoai.Location = new System.Drawing.Point(296, 68);
            this.dataTheLoai.Name = "dataTheLoai";
            this.dataTheLoai.Size = new System.Drawing.Size(240, 150);
            this.dataTheLoai.TabIndex = 16;
            this.dataTheLoai.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataTheLoai_CellContentClick);
            // 
            // btnUpdateTL
            // 
            this.btnUpdateTL.Location = new System.Drawing.Point(18, 323);
            this.btnUpdateTL.Name = "btnUpdateTL";
            this.btnUpdateTL.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateTL.TabIndex = 17;
            this.btnUpdateTL.Text = "Cập nhật";
            this.btnUpdateTL.UseVisualStyleBackColor = true;
            this.btnUpdateTL.Click += new System.EventHandler(this.btnUpdateTL_Click);
            // 
            // btnDeleteBook
            // 
            this.btnDeleteBook.Location = new System.Drawing.Point(107, 624);
            this.btnDeleteBook.Name = "btnDeleteBook";
            this.btnDeleteBook.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteBook.TabIndex = 18;
            this.btnDeleteBook.Text = "Xóa";
            this.btnDeleteBook.UseVisualStyleBackColor = true;
            this.btnDeleteBook.Click += new System.EventHandler(this.btnDeleteBook_Click);
            // 
            // btnDeleteKind
            // 
            this.btnDeleteKind.Location = new System.Drawing.Point(90, 323);
            this.btnDeleteKind.Name = "btnDeleteKind";
            this.btnDeleteKind.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteKind.TabIndex = 19;
            this.btnDeleteKind.Text = "Xóa";
            this.btnDeleteKind.UseVisualStyleBackColor = true;
            this.btnDeleteKind.Click += new System.EventHandler(this.btnDeleteKind_Click);
            // 
            // FrmBooks
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVienV3._1.Properties.Resources.background_powerpoint_dep_cho_hoc_sinh_3_228x171;
            this.ClientSize = new System.Drawing.Size(1126, 659);
            this.Controls.Add(this.btnDeleteKind);
            this.Controls.Add(this.btnDeleteBook);
            this.Controls.Add(this.btnUpdateTL);
            this.Controls.Add(this.dataTheLoai);
            this.Controls.Add(this.lbTL);
            this.Controls.Add(this.tbSearchID);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.btnUpdateBook);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dataBook);
            this.Controls.Add(this.btnCancelBook);
            this.Controls.Add(this.btnAddBook);
            this.Controls.Add(this.lbTitle);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.btnCancelTL);
            this.Controls.Add(this.btnAddTL);
            this.Controls.Add(this.tableLayoutPanel2);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmBooks";
            this.Text = "Quản lý tài liệu";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmBooks_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.tableLayoutPanel2.ResumeLayout(false);
            this.tableLayoutPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataBook)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataTheLoai)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnBackHome;
        private System.Windows.Forms.ToolStripMenuItem mnRefesh;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbTheLoaiID;
        private System.Windows.Forms.TextBox tbTheLoaiName;
        private System.Windows.Forms.TextBox tbGhiChu;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbBookID;
        private System.Windows.Forms.TextBox tbName;
        private System.Windows.Forms.ComboBox cbTLID;
        private System.Windows.Forms.TextBox tbCountBook;
        private System.Windows.Forms.TextBox tbNXB;
        private System.Windows.Forms.TextBox tbYearXB;
        private System.Windows.Forms.TextBox tbAuthor;
        private System.Windows.Forms.Button btnAddTL;
        private System.Windows.Forms.Button btnCancelTL;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lbTitle;
        private System.Windows.Forms.Button btnAddBook;
        private System.Windows.Forms.Button btnCancelBook;
        private System.Windows.Forms.DataGridView dataBook;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnUpdateBook;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchID;
        private System.Windows.Forms.Label lbTL;
        private System.Windows.Forms.DataGridView dataTheLoai;
        private System.Windows.Forms.Button btnUpdateTL;
        private System.Windows.Forms.Button btnDeleteBook;
        private System.Windows.Forms.Button btnDeleteKind;
    }
}