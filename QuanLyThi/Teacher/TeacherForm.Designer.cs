namespace QuanLyThi
{
    partial class TeacherForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItemPersonalInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemQuanLyDeThi = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemThongKe = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemDangXuat = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainTeacher = new System.Windows.Forms.Panel();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPersonalInfo,
            this.ToolStripMenuItemQuanLyDeThi,
            this.ToolStripMenuItemThongKe,
            this.ToolStripMenuItemDangXuat});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemPersonalInfo
            // 
            this.ToolStripMenuItemPersonalInfo.Name = "ToolStripMenuItemPersonalInfo";
            this.ToolStripMenuItemPersonalInfo.Size = new System.Drawing.Size(115, 20);
            this.ToolStripMenuItemPersonalInfo.Text = "Thông tin cá nhân";
            this.ToolStripMenuItemPersonalInfo.Click += new System.EventHandler(this.clickToTeacherInfo);
            // 
            // ToolStripMenuItemQuanLyDeThi
            // 
            this.ToolStripMenuItemQuanLyDeThi.Name = "ToolStripMenuItemQuanLyDeThi";
            this.ToolStripMenuItemQuanLyDeThi.Size = new System.Drawing.Size(93, 20);
            this.ToolStripMenuItemQuanLyDeThi.Text = "Quản lý đề thi";
            this.ToolStripMenuItemQuanLyDeThi.Click += new System.EventHandler(this.clickToTeacherExamManage);
            // 
            // ToolStripMenuItemThongKe
            // 
            this.ToolStripMenuItemThongKe.Name = "ToolStripMenuItemThongKe";
            this.ToolStripMenuItemThongKe.Size = new System.Drawing.Size(68, 20);
            this.ToolStripMenuItemThongKe.Text = "Thống kê";
            // 
            // ToolStripMenuItemDangXuat
            // 
            this.ToolStripMenuItemDangXuat.Name = "ToolStripMenuItemDangXuat";
            this.ToolStripMenuItemDangXuat.Size = new System.Drawing.Size(89, 20);
            this.ToolStripMenuItemDangXuat.Text = "Đăng xuất ->";
            this.ToolStripMenuItemDangXuat.Click += new System.EventHandler(this.clickToLogOut);
            // 
            // panelMainTeacher
            // 
            this.panelMainTeacher.Location = new System.Drawing.Point(0, 27);
            this.panelMainTeacher.Name = "panelMainTeacher";
            this.panelMainTeacher.Size = new System.Drawing.Size(1060, 537);
            this.panelMainTeacher.TabIndex = 2;
            // 
            // TeacherForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 565);
            this.Controls.Add(this.panelMainTeacher);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "TeacherForm";
            this.Text = "TeacherForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPersonalInfo;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemQuanLyDeThi;
        private System.Windows.Forms.Panel panelMainTeacher;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemThongKe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDangXuat;
    }
}