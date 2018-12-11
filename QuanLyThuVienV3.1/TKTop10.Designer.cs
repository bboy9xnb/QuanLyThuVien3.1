namespace QuanLyThuVienV3._1
{
    partial class TKTop10
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
            this.dtpend = new System.Windows.Forms.DateTimePicker();
            this.dtpbegin = new System.Windows.Forms.DateTimePicker();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnTop10 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataThongKeTop10 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.btnTurnOn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKeTop10)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpend
            // 
            this.dtpend.CustomFormat = "dd/MM/yyyy";
            this.dtpend.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpend.Location = new System.Drawing.Point(108, 93);
            this.dtpend.Name = "dtpend";
            this.dtpend.Size = new System.Drawing.Size(163, 20);
            this.dtpend.TabIndex = 32;
            // 
            // dtpbegin
            // 
            this.dtpbegin.CustomFormat = "dd/MM/yyyy";
            this.dtpbegin.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpbegin.Location = new System.Drawing.Point(108, 62);
            this.dtpbegin.Name = "dtpbegin";
            this.dtpbegin.Size = new System.Drawing.Size(163, 20);
            this.dtpbegin.TabIndex = 31;
            this.dtpbegin.ValueChanged += new System.EventHandler(this.dtpbegin_ValueChanged);
            // 
            // btnIn
            // 
            this.btnIn.Location = new System.Drawing.Point(267, 137);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(86, 39);
            this.btnIn.TabIndex = 28;
            this.btnIn.Text = "In";
            this.btnIn.UseVisualStyleBackColor = true;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnTop10
            // 
            this.btnTop10.Location = new System.Drawing.Point(146, 138);
            this.btnTop10.Name = "btnTop10";
            this.btnTop10.Size = new System.Drawing.Size(100, 38);
            this.btnTop10.TabIndex = 27;
            this.btnTop10.Text = "Thống Kê Top 10";
            this.btnTop10.UseVisualStyleBackColor = true;
            this.btnTop10.Click += new System.EventHandler(this.btnTop10_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(44, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Đến Ngày:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 30;
            this.label1.Text = "Từ Ngày:";
            // 
            // dataThongKeTop10
            // 
            this.dataThongKeTop10.AllowUserToOrderColumns = true;
            this.dataThongKeTop10.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataThongKeTop10.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataThongKeTop10.Location = new System.Drawing.Point(389, 62);
            this.dataThongKeTop10.Name = "dataThongKeTop10";
            this.dataThongKeTop10.Size = new System.Drawing.Size(549, 326);
            this.dataThongKeTop10.TabIndex = 33;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "STT";
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "TenTaiLieu";
            this.Column2.HeaderText = "Tên Tài Liêu";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "TenTheLoai";
            this.Column3.HeaderText = "Tên Thể Loại";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "TongtlMuon";
            this.Column4.HeaderText = "Số Lượng Mượn";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GhiChu";
            this.Column5.HeaderText = "Ghi Chú";
            this.Column5.Name = "Column5";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(372, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(192, 22);
            this.label2.TabIndex = 34;
            this.label2.Text = "Thống kê tài liệu mượn";
            // 
            // btnTurnOn
            // 
            this.btnTurnOn.Location = new System.Drawing.Point(23, 138);
            this.btnTurnOn.Name = "btnTurnOn";
            this.btnTurnOn.Size = new System.Drawing.Size(100, 38);
            this.btnTurnOn.TabIndex = 35;
            this.btnTurnOn.Text = "Thống kê theo thời gian";
            this.btnTurnOn.UseVisualStyleBackColor = true;
            this.btnTurnOn.Click += new System.EventHandler(this.btnTurnOn_Click);
            // 
            // TKTop10
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 415);
            this.Controls.Add(this.btnTurnOn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataThongKeTop10);
            this.Controls.Add(this.dtpend);
            this.Controls.Add(this.dtpbegin);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.btnTop10);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Name = "TKTop10";
            this.Text = "TKTop10";
            this.Load += new System.EventHandler(this.TKTop10_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataThongKeTop10)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpend;
        private System.Windows.Forms.DateTimePicker dtpbegin;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.Button btnTop10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataThongKeTop10;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnTurnOn;
    }
}