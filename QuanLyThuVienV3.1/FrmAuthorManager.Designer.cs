namespace QuanLyThuVienV3._1
{
    partial class FrmAuthorManager
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
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lbAddEmployees = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.tableFrom = new System.Windows.Forms.TableLayoutPanel();
            this.tbAuthorID = new System.Windows.Forms.TextBox();
            this.tbFullName = new System.Windows.Forms.TextBox();
            this.cbSex = new System.Windows.Forms.ComboBox();
            this.dateOfBrith = new System.Windows.Forms.DateTimePicker();
            this.tbObject = new System.Windows.Forms.TextBox();
            this.dateRange = new System.Windows.Forms.DateTimePicker();
            this.dateexpiration = new System.Windows.Forms.DateTimePicker();
            this.dataAuthor = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.tbSearchAuthorID = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.menuStrip1.SuspendLayout();
            this.tableFrom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAuthor)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(251, 560);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 33);
            this.btnCancel.TabIndex = 21;
            this.btnCancel.Text = "Hủy";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(26, 560);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(92, 33);
            this.btnAdd.TabIndex = 19;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lbAddEmployees
            // 
            this.lbAddEmployees.AutoSize = true;
            this.lbAddEmployees.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbAddEmployees.Location = new System.Drawing.Point(14, 235);
            this.lbAddEmployees.Name = "lbAddEmployees";
            this.lbAddEmployees.Size = new System.Drawing.Size(145, 30);
            this.lbAddEmployees.TabIndex = 18;
            this.lbAddEmployees.Text = "Thêm độc giả";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBack});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1031, 24);
            this.menuStrip1.TabIndex = 20;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnBack
            // 
            this.mnBack.Name = "mnBack";
            this.mnBack.Size = new System.Drawing.Size(138, 20);
            this.mnBack.Text = "Trở về màn hình chính";
            this.mnBack.Click += new System.EventHandler(this.mnBack_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 72);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 21);
            this.label5.TabIndex = 4;
            this.label5.Text = "Giới tính";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(3, 36);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 21);
            this.label3.TabIndex = 2;
            this.label3.Text = "Họ và tên";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã độc giả";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 21);
            this.label4.TabIndex = 3;
            this.label4.Text = "Ngày sinh";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 149);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 21);
            this.label2.TabIndex = 1;
            this.label2.Text = "Đối tượng";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 187);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(75, 21);
            this.label6.TabIndex = 5;
            this.label6.Text = "Ngày cấp";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(3, 228);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 21);
            this.label7.TabIndex = 6;
            this.label7.Text = "Ngày hết hạn";
            // 
            // tableFrom
            // 
            this.tableFrom.ColumnCount = 2;
            this.tableFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.86243F));
            this.tableFrom.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 66.13757F));
            this.tableFrom.Controls.Add(this.label5, 0, 2);
            this.tableFrom.Controls.Add(this.label3, 0, 1);
            this.tableFrom.Controls.Add(this.label1, 0, 0);
            this.tableFrom.Controls.Add(this.label4, 0, 3);
            this.tableFrom.Controls.Add(this.label2, 0, 4);
            this.tableFrom.Controls.Add(this.label6, 0, 5);
            this.tableFrom.Controls.Add(this.label7, 0, 6);
            this.tableFrom.Controls.Add(this.tbAuthorID, 1, 0);
            this.tableFrom.Controls.Add(this.tbFullName, 1, 1);
            this.tableFrom.Controls.Add(this.cbSex, 1, 2);
            this.tableFrom.Controls.Add(this.dateOfBrith, 1, 3);
            this.tableFrom.Controls.Add(this.tbObject, 1, 4);
            this.tableFrom.Controls.Add(this.dateRange, 1, 5);
            this.tableFrom.Controls.Add(this.dateexpiration, 1, 6);
            this.tableFrom.Location = new System.Drawing.Point(12, 268);
            this.tableFrom.Name = "tableFrom";
            this.tableFrom.RowCount = 7;
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 36F));
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 38F));
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 41F));
            this.tableFrom.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 42F));
            this.tableFrom.Size = new System.Drawing.Size(334, 271);
            this.tableFrom.TabIndex = 17;
            // 
            // tbAuthorID
            // 
            this.tbAuthorID.Location = new System.Drawing.Point(116, 3);
            this.tbAuthorID.Name = "tbAuthorID";
            this.tbAuthorID.Size = new System.Drawing.Size(215, 20);
            this.tbAuthorID.TabIndex = 7;
            // 
            // tbFullName
            // 
            this.tbFullName.Location = new System.Drawing.Point(116, 39);
            this.tbFullName.Name = "tbFullName";
            this.tbFullName.Size = new System.Drawing.Size(215, 20);
            this.tbFullName.TabIndex = 8;
            // 
            // cbSex
            // 
            this.cbSex.FormattingEnabled = true;
            this.cbSex.Location = new System.Drawing.Point(116, 75);
            this.cbSex.Name = "cbSex";
            this.cbSex.Size = new System.Drawing.Size(121, 21);
            this.cbSex.TabIndex = 9;
            // 
            // dateOfBrith
            // 
            this.dateOfBrith.Location = new System.Drawing.Point(116, 111);
            this.dateOfBrith.Name = "dateOfBrith";
            this.dateOfBrith.Size = new System.Drawing.Size(215, 20);
            this.dateOfBrith.TabIndex = 10;
            // 
            // tbObject
            // 
            this.tbObject.Location = new System.Drawing.Point(116, 152);
            this.tbObject.Name = "tbObject";
            this.tbObject.Size = new System.Drawing.Size(215, 20);
            this.tbObject.TabIndex = 11;
            // 
            // dateRange
            // 
            this.dateRange.Location = new System.Drawing.Point(116, 190);
            this.dateRange.Name = "dateRange";
            this.dateRange.Size = new System.Drawing.Size(215, 20);
            this.dateRange.TabIndex = 12;
            // 
            // dateexpiration
            // 
            this.dateexpiration.Location = new System.Drawing.Point(116, 231);
            this.dateexpiration.Name = "dateexpiration";
            this.dateexpiration.Size = new System.Drawing.Size(215, 20);
            this.dateexpiration.TabIndex = 13;
            // 
            // dataAuthor
            // 
            this.dataAuthor.BackgroundColor = System.Drawing.Color.White;
            this.dataAuthor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataAuthor.Location = new System.Drawing.Point(385, 144);
            this.dataAuthor.Name = "dataAuthor";
            this.dataAuthor.Size = new System.Drawing.Size(662, 248);
            this.dataAuthor.TabIndex = 15;
            this.dataAuthor.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataAuthor_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(924, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 14;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // tbSearchAuthorID
            // 
            this.tbSearchAuthorID.Location = new System.Drawing.Point(765, 88);
            this.tbSearchAuthorID.Name = "tbSearchAuthorID";
            this.tbSearchAuthorID.Size = new System.Drawing.Size(153, 20);
            this.tbSearchAuthorID.TabIndex = 13;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(26, 560);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(92, 33);
            this.btnUpdate.TabIndex = 22;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(141, 560);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(88, 33);
            this.btnDelete.TabIndex = 23;
            this.btnDelete.Text = "Xóa";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(12, 33);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 24;
            // 
            // FrmAuthorManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1031, 629);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.lbAddEmployees);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.tableFrom);
            this.Controls.Add(this.dataAuthor);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.tbSearchAuthorID);
            this.Name = "FrmAuthorManager";
            this.Text = "FrmAuthorManager";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.FrmAuthorManager_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tableFrom.ResumeLayout(false);
            this.tableFrom.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataAuthor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lbAddEmployees;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TableLayoutPanel tableFrom;
        private System.Windows.Forms.TextBox tbAuthorID;
        private System.Windows.Forms.TextBox tbFullName;
        private System.Windows.Forms.ComboBox cbSex;
        private System.Windows.Forms.DateTimePicker dateOfBrith;
        private System.Windows.Forms.TextBox tbObject;
        private System.Windows.Forms.DateTimePicker dateRange;
        private System.Windows.Forms.DateTimePicker dateexpiration;
        private System.Windows.Forms.DataGridView dataAuthor;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.TextBox tbSearchAuthorID;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
    }
}