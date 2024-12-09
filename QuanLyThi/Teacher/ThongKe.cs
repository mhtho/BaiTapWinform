using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThi.Teacher
{
    public partial class ThongKe : Form
    {

        private int teacherId = 1; // default
        public ThongKe()
        {
            InitializeComponent();
            loadDataGridView();
        }

        void loadDataGridView()
        {
            SqlRunner sqlRunner = new SqlRunner();
            dataGridView1.DataSource = sqlRunner.excuteQuery(string.Format("SELECT dt.maDeThi, dt.tenDeThi, hs.hoTen, hs.ngaySinh, kq.diem, kq.thoiGianNop FROM dbo.DeThi AS dt INNER JOIN dbo.KetQua AS kq ON dt.maDeThi = kq.maDeThi INNER JOIN dbo.HocSinh AS hs ON hs.maHocSinh = kq.maHocSinh WHERE dt.maGiaoVien = {0}", teacherId));
        }

        void connectData()
        {
            SqlRunner sqlRunner = new SqlRunner();
            dataGridView1.DataSource = sqlRunner.excuteQuery(string.Format("SELECT dt.maDeThi, dt.tenDeThi, hs.hoTen, hs.ngaySinh, kq.diem, kq.thoiGianNop FROM dbo.DeThi AS dt INNER JOIN dbo.KetQua AS kq ON dt.maDeThi = kq.maDeThi INNER JOIN dbo.HocSinh AS hs ON hs.maHocSinh = kq.maHocSinh WHERE dt.maGiaoVien = {0} AND (dt.maDeThi LIKE '%{1}%' OR dt.tenDeThi LIKE N'%{1}%')", teacherId, textBoxFind.Text));
        }

        private void ClickToSearch(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFind.Text))
            {
                MessageBox.Show("Thông tin tìm kiếm đang trống", "Notice");
                return;
            }
            connectData();
            textBoxFind.Text = "";
        }
    }
}
