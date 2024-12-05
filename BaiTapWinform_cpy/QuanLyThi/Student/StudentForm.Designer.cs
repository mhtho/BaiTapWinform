namespace QuanLyThi
{
    partial class StudentForm
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
            this.ToolStripMenuItemPeronalInfor = new System.Windows.Forms.ToolStripMenuItem();
            this.ToolStripMenuItemListExam = new System.Windows.Forms.ToolStripMenuItem();
            this.panelMainStudent = new System.Windows.Forms.Panel();
            this.đăngXuấtToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItemPeronalInfor,
            this.ToolStripMenuItemListExam,
            this.đăngXuấtToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1063, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // ToolStripMenuItemPeronalInfor
            // 
            this.ToolStripMenuItemPeronalInfor.Name = "ToolStripMenuItemPeronalInfor";
            this.ToolStripMenuItemPeronalInfor.Size = new System.Drawing.Size(115, 20);
            this.ToolStripMenuItemPeronalInfor.Text = "Thông tin cá nhân";
            this.ToolStripMenuItemPeronalInfor.Click += new System.EventHandler(this.clickToStudentInfo);
            // 
            // ToolStripMenuItemListExam
            // 
            this.ToolStripMenuItemListExam.Name = "ToolStripMenuItemListExam";
            this.ToolStripMenuItemListExam.Size = new System.Drawing.Size(52, 20);
            this.ToolStripMenuItemListExam.Text = "Bài thi";
            this.ToolStripMenuItemListExam.Click += new System.EventHandler(this.clickToListExam);
            // 
            // panelMainStudent
            // 
            this.panelMainStudent.Location = new System.Drawing.Point(0, 27);
            this.panelMainStudent.Name = "panelMainStudent";
            this.panelMainStudent.Size = new System.Drawing.Size(1063, 538);
            this.panelMainStudent.TabIndex = 1;
            // 
            // đăngXuấtToolStripMenuItem
            // 
            this.đăngXuấtToolStripMenuItem.Name = "đăngXuấtToolStripMenuItem";
            this.đăngXuấtToolStripMenuItem.Size = new System.Drawing.Size(73, 20);
            this.đăngXuấtToolStripMenuItem.Text = "Đăng xuất";
            this.đăngXuấtToolStripMenuItem.Click += new System.EventHandler(this.clickToLogOut);
            // 
            // StudentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1063, 565);
            this.Controls.Add(this.panelMainStudent);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "StudentForm";
            this.Text = "StudentForm";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemPeronalInfor;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemListExam;
        private System.Windows.Forms.Panel panelMainStudent;
        private System.Windows.Forms.ToolStripMenuItem đăngXuấtToolStripMenuItem;
    }
}