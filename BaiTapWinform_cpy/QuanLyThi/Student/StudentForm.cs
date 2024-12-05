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
    public partial class StudentForm : Form
    {
        private int studentID = 1; // defaut = 1
        public StudentForm()
        {
            InitializeComponent();
            showForm(new ListExam(this, studentID));
        }

        private Form curMainForm;
        public void showForm(Form form)
        {
            if (curMainForm != null) curMainForm.Close();
            curMainForm = form;
            curMainForm.Dock = DockStyle.Fill;
            curMainForm.TopLevel = false;
            panelMainStudent.Controls.Clear();
            panelMainStudent.Controls.Add(curMainForm);
            panelMainStudent.Tag = curMainForm;
            curMainForm.Show();
        }
        private void clickToStudentInfo(object sender, EventArgs e)
        {
            showForm(new StudentInfo());
        }

        private void clickToListExam(object sender, EventArgs e)
        {
            showForm(new ListExam(this, studentID));
        }

        private void clickToLogOut(object sender, EventArgs e)
        {
            DialogResult res = MessageBox.Show("Bạn có muốn đăng xuất không ?", "Notice", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            this.Close();
        }
    }
}
