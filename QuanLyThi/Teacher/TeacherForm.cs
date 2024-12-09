using QuanLyThi.Teacher;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThi
{
    public partial class TeacherForm : Form
    {
       private int teacherID = 1; // default = 1
        public TeacherForm()
        {
            InitializeComponent();
            showForm(new TeacherExamManage());
        }

        public TeacherForm(int teacherID)
        {
            InitializeComponent();
            this.teacherID = teacherID;
            this.Text += $" ({getNameUser()}) ";
            showForm(new TeacherExamManage());
        }

        string getNameUser()
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT * FROM dbo.taikhoan WHERE loaiNguoiDung = 'GiaoVien' AND maNguoiDung = {0}", teacherID));
            return dt.Rows[0]["tenDangNhap"].ToString();
        }

        private Form curMainForm;
        public void showForm(Form form)
        {
            if(curMainForm != null) curMainForm.Close();
            curMainForm = form;
            curMainForm.Dock = DockStyle.Fill;
            curMainForm.TopLevel = false;
            panelMainTeacher.Controls.Clear();
            panelMainTeacher.Controls.Add(curMainForm);
            panelMainTeacher.Tag = curMainForm;
            curMainForm.Show();
        }
        private void clickToTeacherInfo(object sender, EventArgs e)
        {
            showForm(new TeacherInfo());
        }

        private void clickToTeacherExamManage(object sender, EventArgs e)
        {
            showForm(new TeacherExamManage());
        }

        private void clickToLogOut(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn muốn đăng xuất không?", "Notice", MessageBoxButtons.YesNo);
            if(res == DialogResult.No) return;
            this.Close();
        }

        private void ClickToThongKe(object sender, EventArgs e)
        {
            showForm(new ThongKe());
        }
    }
}
