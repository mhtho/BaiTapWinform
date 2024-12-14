namespace QuanLyThi
{
    partial class CauHoiTracNghiem
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnCapNhat1 = new System.Windows.Forms.Button();
            this.btnThem = new System.Windows.Forms.Button();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNoiDungCH = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDapAn4 = new System.Windows.Forms.TextBox();
            this.txtDapAn3 = new System.Windows.Forms.TextBox();
            this.txtDapAn2 = new System.Windows.Forms.TextBox();
            this.txtDapAn1 = new System.Windows.Forms.TextBox();
            this.cboDapAnDung = new System.Windows.Forms.ComboBox();
            this.btnCapNhat2 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoiDungDA = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label4 = new System.Windows.Forms.Label();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnXoa);
            this.groupBox1.Controls.Add(this.btnCapNhat1);
            this.groupBox1.Controls.Add(this.btnThem);
            this.groupBox1.Controls.Add(this.txtID);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtNoiDungCH);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(23, 181);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(341, 265);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Câu hỏi";
            // 
            // btnXoa
            // 
            this.btnXoa.Location = new System.Drawing.Point(233, 170);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(75, 23);
            this.btnXoa.TabIndex = 4;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnCapNhat1
            // 
            this.btnCapNhat1.Location = new System.Drawing.Point(153, 170);
            this.btnCapNhat1.Name = "btnCapNhat1";
            this.btnCapNhat1.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat1.TabIndex = 4;
            this.btnCapNhat1.Text = "Cập nhật";
            this.btnCapNhat1.UseVisualStyleBackColor = true;
            this.btnCapNhat1.Click += new System.EventHandler(this.btnCapNhat1_Click);
            // 
            // btnThem
            // 
            this.btnThem.Location = new System.Drawing.Point(72, 170);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(75, 23);
            this.btnThem.TabIndex = 4;
            this.btnThem.Text = "Thêm";
            this.btnThem.UseVisualStyleBackColor = true;
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtID
            // 
            this.txtID.Location = new System.Drawing.Point(72, 19);
            this.txtID.Name = "txtID";
            this.txtID.ReadOnly = true;
            this.txtID.Size = new System.Drawing.Size(232, 20);
            this.txtID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "ID Câu hỏi: ";
            // 
            // txtNoiDungCH
            // 
            this.txtNoiDungCH.Location = new System.Drawing.Point(72, 54);
            this.txtNoiDungCH.Multiline = true;
            this.txtNoiDungCH.Name = "txtNoiDungCH";
            this.txtNoiDungCH.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDungCH.Size = new System.Drawing.Size(236, 85);
            this.txtNoiDungCH.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nội dung";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.numericUpDown1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.cboDapAnDung);
            this.groupBox2.Controls.Add(this.btnCapNhat2);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.txtNoiDungDA);
            this.groupBox2.Location = new System.Drawing.Point(393, 181);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(715, 265);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Đáp án";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtDapAn4);
            this.groupBox3.Controls.Add(this.txtDapAn3);
            this.groupBox3.Controls.Add(this.txtDapAn2);
            this.groupBox3.Controls.Add(this.txtDapAn1);
            this.groupBox3.Location = new System.Drawing.Point(290, 24);
            this.groupBox3.Margin = new System.Windows.Forms.Padding(2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Padding = new System.Windows.Forms.Padding(2);
            this.groupBox3.Size = new System.Drawing.Size(390, 224);
            this.groupBox3.TabIndex = 8;
            this.groupBox3.TabStop = false;
            // 
            // txtDapAn4
            // 
            this.txtDapAn4.Location = new System.Drawing.Point(23, 166);
            this.txtDapAn4.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAn4.Multiline = true;
            this.txtDapAn4.Name = "txtDapAn4";
            this.txtDapAn4.ReadOnly = true;
            this.txtDapAn4.Size = new System.Drawing.Size(337, 44);
            this.txtDapAn4.TabIndex = 0;
            this.txtDapAn4.Enter += new System.EventHandler(this.txtDapAn4_Enter);
            // 
            // txtDapAn3
            // 
            this.txtDapAn3.Location = new System.Drawing.Point(23, 116);
            this.txtDapAn3.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAn3.Multiline = true;
            this.txtDapAn3.Name = "txtDapAn3";
            this.txtDapAn3.ReadOnly = true;
            this.txtDapAn3.Size = new System.Drawing.Size(337, 44);
            this.txtDapAn3.TabIndex = 0;
            this.txtDapAn3.Enter += new System.EventHandler(this.txtDapAn3_Enter);
            // 
            // txtDapAn2
            // 
            this.txtDapAn2.Location = new System.Drawing.Point(23, 66);
            this.txtDapAn2.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAn2.Multiline = true;
            this.txtDapAn2.Name = "txtDapAn2";
            this.txtDapAn2.ReadOnly = true;
            this.txtDapAn2.Size = new System.Drawing.Size(337, 44);
            this.txtDapAn2.TabIndex = 0;
            this.txtDapAn2.Enter += new System.EventHandler(this.txtDapAn2_Enter);
            // 
            // txtDapAn1
            // 
            this.txtDapAn1.Location = new System.Drawing.Point(23, 16);
            this.txtDapAn1.Margin = new System.Windows.Forms.Padding(2);
            this.txtDapAn1.Multiline = true;
            this.txtDapAn1.Name = "txtDapAn1";
            this.txtDapAn1.ReadOnly = true;
            this.txtDapAn1.Size = new System.Drawing.Size(337, 44);
            this.txtDapAn1.TabIndex = 0;
            this.txtDapAn1.Enter += new System.EventHandler(this.txtDapAn1_Enter);
            // 
            // cboDapAnDung
            // 
            this.cboDapAnDung.FormattingEnabled = true;
            this.cboDapAnDung.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.cboDapAnDung.Location = new System.Drawing.Point(103, 155);
            this.cboDapAnDung.Name = "cboDapAnDung";
            this.cboDapAnDung.Size = new System.Drawing.Size(121, 21);
            this.cboDapAnDung.TabIndex = 6;
            // 
            // btnCapNhat2
            // 
            this.btnCapNhat2.Location = new System.Drawing.Point(124, 189);
            this.btnCapNhat2.Name = "btnCapNhat2";
            this.btnCapNhat2.Size = new System.Drawing.Size(75, 23);
            this.btnCapNhat2.TabIndex = 4;
            this.btnCapNhat2.Text = "Cập nhật";
            this.btnCapNhat2.UseVisualStyleBackColor = true;
            this.btnCapNhat2.Click += new System.EventHandler(this.btnCapNhat2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 13);
            this.label5.TabIndex = 0;
            this.label5.Text = "Đáp án đúng: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 57);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 0;
            this.label3.Text = "Nội dung";
            // 
            // txtNoiDungDA
            // 
            this.txtNoiDungDA.Location = new System.Drawing.Point(75, 54);
            this.txtNoiDungDA.Multiline = true;
            this.txtNoiDungDA.Name = "txtNoiDungDA";
            this.txtNoiDungDA.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtNoiDungDA.Size = new System.Drawing.Size(175, 85);
            this.txtNoiDungDA.TabIndex = 1;
            this.txtNoiDungDA.TextChanged += new System.EventHandler(this.txtNoiDungDA_TextChanged);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(23, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1085, 150);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Đáp án số: ";
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(75, 24);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            4,
            0,
            0,
            0});
            this.numericUpDown1.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(175, 20);
            this.numericUpDown1.TabIndex = 10;
            this.numericUpDown1.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDown1.ValueChanged += new System.EventHandler(this.numericUpDown1_ValueChanged);
            // 
            // CauHoiTracNghiem
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1141, 467);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CauHoiTracNghiem";
            this.Text = "CauHoiTracNghiem";
            this.Load += new System.EventHandler(this.CauHoiTracNghiem_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtNoiDungCH;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnThem;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnCapNhat1;
        private System.Windows.Forms.Button btnCapNhat2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoiDungDA;
        private System.Windows.Forms.ComboBox cboDapAnDung;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDapAn4;
        private System.Windows.Forms.TextBox txtDapAn3;
        private System.Windows.Forms.TextBox txtDapAn2;
        private System.Windows.Forms.TextBox txtDapAn1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}