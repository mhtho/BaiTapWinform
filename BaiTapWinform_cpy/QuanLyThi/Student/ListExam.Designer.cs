namespace QuanLyThi
{
    partial class ListExam
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
            this.dataGridViewListExams = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonSearch = new System.Windows.Forms.Button();
            this.radioButtonByName = new System.Windows.Forms.RadioButton();
            this.radioButtonByID = new System.Windows.Forms.RadioButton();
            this.radioButtonALL = new System.Windows.Forms.RadioButton();
            this.textBoxSearch = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelDiemToiDa = new System.Windows.Forms.Label();
            this.labelSoLuongCau = new System.Windows.Forms.Label();
            this.labelThoiGianLam = new System.Windows.Forms.Label();
            this.labelNguoiGiao = new System.Windows.Forms.Label();
            this.labelMonThi = new System.Windows.Forms.Label();
            this.labelMaDeThi = new System.Windows.Forms.Label();
            this.labelTenDe = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.buttonReset = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListExams)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewListExams
            // 
            this.dataGridViewListExams.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewListExams.Location = new System.Drawing.Point(6, 67);
            this.dataGridViewListExams.Name = "dataGridViewListExams";
            this.dataGridViewListExams.ReadOnly = true;
            this.dataGridViewListExams.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewListExams.Size = new System.Drawing.Size(475, 441);
            this.dataGridViewListExams.TabIndex = 0;
            this.dataGridViewListExams.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.CellClickToThongTin);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonReset);
            this.groupBox1.Controls.Add(this.buttonSearch);
            this.groupBox1.Controls.Add(this.radioButtonByName);
            this.groupBox1.Controls.Add(this.radioButtonByID);
            this.groupBox1.Controls.Add(this.radioButtonALL);
            this.groupBox1.Controls.Add(this.textBoxSearch);
            this.groupBox1.Controls.Add(this.dataGridViewListExams);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(489, 514);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh sách đề thi";
            // 
            // buttonSearch
            // 
            this.buttonSearch.Location = new System.Drawing.Point(401, 17);
            this.buttonSearch.Name = "buttonSearch";
            this.buttonSearch.Size = new System.Drawing.Size(75, 23);
            this.buttonSearch.TabIndex = 3;
            this.buttonSearch.Text = "Tìm kiếm";
            this.buttonSearch.UseVisualStyleBackColor = true;
            this.buttonSearch.Click += new System.EventHandler(this.ClickToSearch);
            // 
            // radioButtonByName
            // 
            this.radioButtonByName.AutoSize = true;
            this.radioButtonByName.Location = new System.Drawing.Point(158, 46);
            this.radioButtonByName.Name = "radioButtonByName";
            this.radioButtonByName.Size = new System.Drawing.Size(84, 17);
            this.radioButtonByName.TabIndex = 2;
            this.radioButtonByName.TabStop = true;
            this.radioButtonByName.Text = "Theo tên đề";
            this.radioButtonByName.UseVisualStyleBackColor = true;
            // 
            // radioButtonByID
            // 
            this.radioButtonByID.AutoSize = true;
            this.radioButtonByID.Location = new System.Drawing.Point(69, 46);
            this.radioButtonByID.Name = "radioButtonByID";
            this.radioButtonByID.Size = new System.Drawing.Size(83, 17);
            this.radioButtonByID.TabIndex = 2;
            this.radioButtonByID.TabStop = true;
            this.radioButtonByID.Text = "Theo mã đề";
            this.radioButtonByID.UseVisualStyleBackColor = true;
            // 
            // radioButtonALL
            // 
            this.radioButtonALL.AutoSize = true;
            this.radioButtonALL.Checked = true;
            this.radioButtonALL.Location = new System.Drawing.Point(7, 46);
            this.radioButtonALL.Name = "radioButtonALL";
            this.radioButtonALL.Size = new System.Drawing.Size(56, 17);
            this.radioButtonALL.TabIndex = 2;
            this.radioButtonALL.TabStop = true;
            this.radioButtonALL.Text = "Tất cả";
            this.radioButtonALL.UseVisualStyleBackColor = true;
            // 
            // textBoxSearch
            // 
            this.textBoxSearch.Location = new System.Drawing.Point(6, 19);
            this.textBoxSearch.Name = "textBoxSearch";
            this.textBoxSearch.Size = new System.Drawing.Size(389, 20);
            this.textBoxSearch.TabIndex = 1;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelDiemToiDa);
            this.groupBox2.Controls.Add(this.labelSoLuongCau);
            this.groupBox2.Controls.Add(this.labelThoiGianLam);
            this.groupBox2.Controls.Add(this.labelNguoiGiao);
            this.groupBox2.Controls.Add(this.labelMonThi);
            this.groupBox2.Controls.Add(this.labelMaDeThi);
            this.groupBox2.Controls.Add(this.labelTenDe);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(508, 13);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(543, 247);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin";
            // 
            // labelDiemToiDa
            // 
            this.labelDiemToiDa.AutoSize = true;
            this.labelDiemToiDa.Location = new System.Drawing.Point(99, 177);
            this.labelDiemToiDa.Name = "labelDiemToiDa";
            this.labelDiemToiDa.Size = new System.Drawing.Size(34, 13);
            this.labelDiemToiDa.TabIndex = 1;
            this.labelDiemToiDa.Text = ".........";
            // 
            // labelSoLuongCau
            // 
            this.labelSoLuongCau.AutoSize = true;
            this.labelSoLuongCau.Location = new System.Drawing.Point(99, 150);
            this.labelSoLuongCau.Name = "labelSoLuongCau";
            this.labelSoLuongCau.Size = new System.Drawing.Size(34, 13);
            this.labelSoLuongCau.TabIndex = 1;
            this.labelSoLuongCau.Text = ".........";
            // 
            // labelThoiGianLam
            // 
            this.labelThoiGianLam.AutoSize = true;
            this.labelThoiGianLam.Location = new System.Drawing.Point(99, 126);
            this.labelThoiGianLam.Name = "labelThoiGianLam";
            this.labelThoiGianLam.Size = new System.Drawing.Size(34, 13);
            this.labelThoiGianLam.TabIndex = 1;
            this.labelThoiGianLam.Text = ".........";
            // 
            // labelNguoiGiao
            // 
            this.labelNguoiGiao.AutoSize = true;
            this.labelNguoiGiao.Location = new System.Drawing.Point(99, 100);
            this.labelNguoiGiao.Name = "labelNguoiGiao";
            this.labelNguoiGiao.Size = new System.Drawing.Size(34, 13);
            this.labelNguoiGiao.TabIndex = 1;
            this.labelNguoiGiao.Text = ".........";
            // 
            // labelMonThi
            // 
            this.labelMonThi.AutoSize = true;
            this.labelMonThi.Location = new System.Drawing.Point(99, 75);
            this.labelMonThi.Name = "labelMonThi";
            this.labelMonThi.Size = new System.Drawing.Size(34, 13);
            this.labelMonThi.TabIndex = 1;
            this.labelMonThi.Text = ".........";
            // 
            // labelMaDeThi
            // 
            this.labelMaDeThi.AutoSize = true;
            this.labelMaDeThi.Location = new System.Drawing.Point(99, 47);
            this.labelMaDeThi.Name = "labelMaDeThi";
            this.labelMaDeThi.Size = new System.Drawing.Size(34, 13);
            this.labelMaDeThi.TabIndex = 1;
            this.labelMaDeThi.Text = ".........";
            // 
            // labelTenDe
            // 
            this.labelTenDe.AutoSize = true;
            this.labelTenDe.Location = new System.Drawing.Point(99, 25);
            this.labelTenDe.Name = "labelTenDe";
            this.labelTenDe.Size = new System.Drawing.Size(34, 13);
            this.labelTenDe.TabIndex = 1;
            this.labelTenDe.Text = ".........";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(7, 177);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 0;
            this.label7.Text = "Điểm tối đa: ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(7, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 0;
            this.label6.Text = "Số lượng câu hỏi: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 126);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(93, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Thời gian làm bài: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 100);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Người giao: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Môn thi: ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 49);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Mã đề thi:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên đề thi: ";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(712, 360);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(101, 45);
            this.button2.TabIndex = 3;
            this.button2.Text = "Làm bài";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.clickToLamBai);
            // 
            // buttonReset
            // 
            this.buttonReset.Location = new System.Drawing.Point(320, 43);
            this.buttonReset.Name = "buttonReset";
            this.buttonReset.Size = new System.Drawing.Size(75, 23);
            this.buttonReset.TabIndex = 4;
            this.buttonReset.Text = "O Reset";
            this.buttonReset.UseVisualStyleBackColor = true;
            this.buttonReset.Click += new System.EventHandler(this.ClickToReset);
            // 
            // ListExam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 538);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ListExam";
            this.Text = "ListExam";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewListExams)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewListExams;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSearch;
        private System.Windows.Forms.RadioButton radioButtonByName;
        private System.Windows.Forms.RadioButton radioButtonByID;
        private System.Windows.Forms.RadioButton radioButtonALL;
        private System.Windows.Forms.Button buttonSearch;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label labelDiemToiDa;
        private System.Windows.Forms.Label labelSoLuongCau;
        private System.Windows.Forms.Label labelThoiGianLam;
        private System.Windows.Forms.Label labelNguoiGiao;
        private System.Windows.Forms.Label labelMonThi;
        private System.Windows.Forms.Label labelMaDeThi;
        private System.Windows.Forms.Label labelTenDe;
        private System.Windows.Forms.Button buttonReset;
    }
}