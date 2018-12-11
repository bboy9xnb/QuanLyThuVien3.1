namespace QuanLyThuVienV3._1
{
    partial class FrmCheckOutBorrowBook
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
            this.btnWriteFile = new System.Windows.Forms.Button();
            this.btnCheckOut = new System.Windows.Forms.Button();
            this.dtpBegin = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpEnd = new System.Windows.Forms.DateTimePicker();
            this.dataCheckOut = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnTKDateTurnOn = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnBack = new System.Windows.Forms.ToolStripMenuItem();
            this.mnLoad = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckOut)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnWriteFile
            // 
            this.btnWriteFile.Location = new System.Drawing.Point(234, 129);
            this.btnWriteFile.Name = "btnWriteFile";
            this.btnWriteFile.Size = new System.Drawing.Size(81, 36);
            this.btnWriteFile.TabIndex = 0;
            this.btnWriteFile.Text = "In báo cáo";
            this.btnWriteFile.UseVisualStyleBackColor = true;
            this.btnWriteFile.Click += new System.EventHandler(this.btnWriteFile_Click);
            // 
            // btnCheckOut
            // 
            this.btnCheckOut.Location = new System.Drawing.Point(123, 129);
            this.btnCheckOut.Name = "btnCheckOut";
            this.btnCheckOut.Size = new System.Drawing.Size(86, 36);
            this.btnCheckOut.TabIndex = 1;
            this.btnCheckOut.Text = "Thống kê";
            this.btnCheckOut.UseVisualStyleBackColor = true;
            this.btnCheckOut.Click += new System.EventHandler(this.btnCheckOut_Click);
            // 
            // dtpBegin
            // 
            this.dtpBegin.Location = new System.Drawing.Point(84, 43);
            this.dtpBegin.Name = "dtpBegin";
            this.dtpBegin.Size = new System.Drawing.Size(200, 20);
            this.dtpBegin.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(23, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Từ ngày";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 91);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Đến ngày";
            // 
            // dtpEnd
            // 
            this.dtpEnd.Location = new System.Drawing.Point(84, 91);
            this.dtpEnd.Name = "dtpEnd";
            this.dtpEnd.Size = new System.Drawing.Size(200, 20);
            this.dtpEnd.TabIndex = 5;
            // 
            // dataCheckOut
            // 
            this.dataCheckOut.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataCheckOut.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataCheckOut.Location = new System.Drawing.Point(404, 43);
            this.dataCheckOut.Name = "dataCheckOut";
            this.dataCheckOut.Size = new System.Drawing.Size(344, 292);
            this.dataCheckOut.TabIndex = 6;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "Số thứ tự";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTheLoai";
            this.Column2.HeaderText = "Tên thể loại";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "SoLanMuon";
            this.Column3.HeaderText = "Số lần mượn";
            this.Column3.Name = "Column3";
            // 
            // btnTKDateTurnOn
            // 
            this.btnTKDateTurnOn.Location = new System.Drawing.Point(12, 129);
            this.btnTKDateTurnOn.Name = "btnTKDateTurnOn";
            this.btnTKDateTurnOn.Size = new System.Drawing.Size(86, 36);
            this.btnTKDateTurnOn.TabIndex = 7;
            this.btnTKDateTurnOn.Text = "Thống kê theo ngày";
            this.btnTKDateTurnOn.UseVisualStyleBackColor = true;
            this.btnTKDateTurnOn.Click += new System.EventHandler(this.btnTKDateTurnOn_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnBack,
            this.mnLoad});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1026, 24);
            this.menuStrip1.TabIndex = 8;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnBack
            // 
            this.mnBack.Name = "mnBack";
            this.mnBack.Size = new System.Drawing.Size(54, 20);
            this.mnBack.Text = "Trở về ";
            this.mnBack.Click += new System.EventHandler(this.mnBack_Click);
            // 
            // mnLoad
            // 
            this.mnLoad.Name = "mnLoad";
            this.mnLoad.Size = new System.Drawing.Size(66, 20);
            this.mnLoad.Text = "Làm mới";
            this.mnLoad.Click += new System.EventHandler(this.mnLoad_Click);
            // 
            // FrmCheckOutBorrowBook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::QuanLyThuVienV3._1.Properties.Resources.background_powerpoint_dep_cho_hoc_sinh_3_228x171;
            this.ClientSize = new System.Drawing.Size(1026, 497);
            this.Controls.Add(this.btnTKDateTurnOn);
            this.Controls.Add(this.dataCheckOut);
            this.Controls.Add(this.dtpEnd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtpBegin);
            this.Controls.Add(this.btnCheckOut);
            this.Controls.Add(this.btnWriteFile);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCheckOutBorrowBook";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmCheckOutBorrowBook";
            this.Load += new System.EventHandler(this.FrmCheckOutBorrowBook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataCheckOut)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnWriteFile;
        private System.Windows.Forms.Button btnCheckOut;
        private System.Windows.Forms.DateTimePicker dtpBegin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.DataGridView dataCheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnTKDateTurnOn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnBack;
        private System.Windows.Forms.ToolStripMenuItem mnLoad;
    }
}