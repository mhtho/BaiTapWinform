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
    public partial class EditExam : Form
    {
        public EditExam()
        {
            InitializeComponent();
            showForm(new CauHoiTracNghiem());
        }

        private Form curMainForm;
        public void showForm(Form form)
        {
            if (curMainForm != null) curMainForm.Close();
            curMainForm = form;
            curMainForm.Dock = DockStyle.Fill;
            curMainForm.TopLevel = false;
            panelCauHoi.Controls.Clear();
            panelCauHoi.Controls.Add(curMainForm);
            panelCauHoi.Tag = curMainForm;
            curMainForm.Show();
        }

        private void checkToTracNghiem(object sender, EventArgs e)
        {
            showForm(new CauHoiTracNghiem());
        }

        private void checkToTuLuan(object sender, EventArgs e)
        {
            showForm(new CauHoiTuLuan());
        }
    }
}
