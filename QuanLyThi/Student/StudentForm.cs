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
        public StudentForm()
        {
            InitializeComponent();
            showForm(new ListExam());
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
            showForm(new ListExam());
        }

        private void clickToLogOut(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
