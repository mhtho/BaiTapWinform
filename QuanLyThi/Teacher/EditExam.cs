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
    public partial class EditExam : Form
    {

        private int maDeThi = 1; // default = 1
        public EditExam()
        {
            InitializeComponent();
            loadThongTin();
            loadDataGridView(1);
        }

        void loadTracNghiem()
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT dt.maChiTietDeThi, tn.* FROM dbo.ChiTiet_DeThi AS dt INNER JOIN dbo.CauHoiTracNghiem AS tn ON dt.maCauHoiTN = tn.maCauHoi WHERE maDeThi = {0}", maDeThi));
            dataGridView1.DataSource = dt;

            // view2
            DataTable dt2 = sqlRunner.excuteQuery("SELECT * FROM dbo.CauHoiTracNghiem");
            dataGridView2.DataSource = dt2;
        }

        void loadTuLuan()
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT dt.maChiTietDeThi, tl.* FROM dbo.ChiTiet_DeThi AS dt INNER JOIN dbo.CauHoiTuLuan AS tl ON dt.maCauHoiTL = tl.maCauHoi WHERE maDeThi = {0}", maDeThi));
            dataGridView1.DataSource = dt;
            // view2
            DataTable dt2 = sqlRunner.excuteQuery("SELECT * FROM dbo.CauHoiTuLuan");
            dataGridView2.DataSource = dt2;
        }

        /// <summary>
        /// id == 1 thi la trac nghiem
        /// id == 2 thi la tu luan
        /// </summary>
        /// <param name="id"></param>
        void loadDataGridView(int id)
        {
            if(id == 1) loadTracNghiem();
            else if(id == 2) loadTuLuan();
        }
        void loadThongTin()
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT * FROM dbo.DeThi WHERE maDeThi = {0}", maDeThi));
            DataRow dataRow = dt.Rows[0];
            textBoxId.Text = dataRow["maDeThi"].ToString();
            textBoxName.Text = dataRow["tenDeThi"].ToString();
            numericUpDownTime.Value = (int)dataRow["thoiGianLamBai"];
            comboBoxMon.Text = dataRow["monThi"].ToString();
            numericUpDownPoint.Value = decimal.Parse(dataRow["diemToiDa"].ToString());
        }

        private void ClickToQuanLyCauHoi(object sender, EventArgs e)
        {
            Form form = new QuanLyCauHoi();
            form.ShowDialog();
        }

        private void ClickToTracNghiem(object sender, EventArgs e)
        {
            loadDataGridView(1);
        }

        private void ClickToTuLuan(object sender, EventArgs e)
        {
            loadDataGridView(2);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView1.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;
            int idx = e.RowIndex;
            if (idx < 0 || idx > dataGridView1.Rows.Count - 2) return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            DataRow dataRow = dt.Rows[idx];
            DialogResult res = MessageBox.Show(string.Format("Bạn có muốn xóa câu hỏi có mã là {0}", dataRow["maChiTietDeThi"].ToString()), "Notice", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("DELETE FROM dbo.ChiTiet_DeThi WHERE maChiTietDeThi = {0}", dataRow["maChiTietDeThi"]));
            loadDataGridView(radioButton1.Checked ? 1 : 2);
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (!(dataGridView2.Columns[e.ColumnIndex] is DataGridViewButtonColumn)) return;
            int idx = e.RowIndex;
            if (idx < 0 || idx > dataGridView2.Rows.Count - 2) return;
            DataTable dt = dataGridView2.DataSource as DataTable;
            DataRow dataRow = dt.Rows[idx];
            SqlRunner sqlRunner = new SqlRunner();
            if (radioButton1.Checked)
            {
                sqlRunner.excuteNonQuery(string.Format("INSERT INTO dbo.ChiTiet_DeThi (maDeThi, maCauHoiTN, maCauHoiTL) VALUES ({0}, {1}, NULL)", maDeThi, dataRow["maCauHoi"]));
            }
            else
            {
                sqlRunner.excuteNonQuery(string.Format("INSERT INTO dbo.ChiTiet_DeThi (maDeThi, maCauHoiTN, maCauHoiTL) VALUES ({0}, NULL, {1})", maDeThi, dataRow["maCauHoi"]));
            }
            MessageBox.Show("Đã thêm");
            loadDataGridView(radioButton1.Checked ? 1 : 2);
        }

        void update()
        {
            DialogResult res = MessageBox.Show("Bạn có muốn cập nhật không ? ", "Notice", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return ; 
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("UPDATE dbo.DeThi SET tenDeThi = N'{0}', thoiGianLamBai = {1}, monThi = N'{2}', diemToiDa = {3} WHERE maDeThi = {4}", textBoxName.Text, numericUpDownTime.Value, comboBoxMon.Text, numericUpDownPoint.Value, maDeThi));
        }

        private void ClickToCapNhat(object sender, EventArgs e)
        {
            this.Close();
        }

        private void EditExam_FormClosing(object sender, FormClosingEventArgs e)
        {
            update();
        }
    }
}
