using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThi.Student
{
    public partial class History : Form
    {
        private int studentId = 1; // default
        public History()
        {
            InitializeComponent();
            loadDataGridView();
        }

        public History(int studentId)
        {
            InitializeComponent();
            this.studentId = studentId;
            loadDataGridView();
        }

        void loadDataGridView()
        {
            SqlRunner sqlRunner = new SqlRunner();
            dataGridView1.DataSource = sqlRunner.excuteQuery(string.Format("SELECT dt.maDeThi, dt.tenDeThi, kq.diem, kq.thoiGianNop FROM dbo.DeThi AS dt INNER JOIN dbo.KetQua AS kq ON dt.maDeThi = kq.maDeThi WHERE kq.maHocSinh = {0} ORDER BY kq.thoiGianNop DESC", studentId));
        }
    }
}
