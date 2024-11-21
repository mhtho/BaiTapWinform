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
       
        public TeacherForm()
        {
            InitializeComponent();
            showForm(new TeacherExamManage());
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
            this.Close();
        }
    }
}
