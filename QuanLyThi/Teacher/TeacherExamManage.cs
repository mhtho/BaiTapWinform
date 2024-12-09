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
    public partial class TeacherExamManage : Form
    {
        private int teacherId = 1;
        private int curExamId = -1;
        public TeacherExamManage()
        {
            InitializeComponent();
            loadDataGridView();
        }

        void loadThongTin()
        {
            if (curExamId == -1) return;
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT * FROM dbo.DeThi WHERE maDeThi = {0}", curExamId));
            labelID.Text = dt.Rows[0]["maDeThi"].ToString();
            labelName.Text = dt.Rows[0]["tenDeThi"].ToString();
            labelNumOfQuestions.Text = sqlRunner.executeScalar(string.Format("SELECT COUNT(*) FROM dbo.ChiTiet_DeThi WHERE maDeThi = {0}", curExamId)).ToString();
            labelTime.Text = dt.Rows[0]["thoiGianLamBai"].ToString();
            labelPoint.Text = dt.Rows[0]["diemToiDa"].ToString();
        }

        void loadDataGridView()
        {
            SqlRunner sqlRunner = new SqlRunner();
            dataGridView1.DataSource = sqlRunner.excuteQuery(string.Format("SELECT maDeThi, tenDeThi FROM dbo.DeThi WHERE maGiaoVien = {0}", teacherId));
            if(dataGridView1.Rows.Count - 2 > 0)
            {
                curExamId = (int)dataGridView1.Rows[0].Cells["maDeThi"].Value;
                loadThongTin();
            } 
        }

        // search

        void connectData(string query)
        {
            SqlRunner sqlRunner = new SqlRunner();
            dataGridView1.DataSource = sqlRunner.excuteQuery(query);
            if (dataGridView1.Rows.Count - 2 > 0)
            {
                curExamId = (int)dataGridView1.Rows[0].Cells["maDeThi"].Value;
                loadThongTin();
            }
        }
        void loadAll()
        {
            string query = string.Format("SELECT maDeThi, tenDeThi FROM dbo.DeThi WHERE maGiaoVien = {0}", teacherId);
            connectData(query);
        }

        void loadByName()
        {
            string query = string.Format("SELECT maDeThi, tenDeThi FROM dbo.DeThi WHERE maGiaoVien = {0} AND tenDeThi LIKE N'%{1}%'", teacherId, textBoxFind.Text);
            connectData(query);
        }

        void loadByID()
        {
            string query = string.Format("SELECT maDeThi, tenDeThi FROM dbo.DeThi WHERE maGiaoVien = {0} AND maDeThi LIKE '%{1}%'", teacherId, textBoxFind.Text);
            connectData(query);
        }

        // event

        private void clickToChinhSua(object sender, EventArgs e)
        {
            if(curExamId == -1) return;
            DialogResult res = MessageBox.Show(string.Format("Xác nhận sửa đề '{0}'", labelName.Text), "Notice", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            Form form = new EditExam(curExamId);
            form.ShowDialog();
            loadDataGridView();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0 || idx > dataGridView1.Rows.Count - 2) return;
            DataTable dt = dataGridView1.DataSource as DataTable;
            curExamId = (int)dt.Rows[idx]["maDeThi"];
            loadThongTin();
        }

        private void ClickToTaoDe(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxNameExam.Text))
            {
                MessageBox.Show("Tên đề không được để trống", "Notice");
                return;
            }
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("INSERT INTO dbo.DeThi (tenDeThi, maGiaoVien) VALUES (N'{0}', {1})", textBoxNameExam.Text, teacherId));
            MessageBox.Show("Đã tạo đề '" + textBoxNameExam.Text + "'");
            textBoxNameExam.Text = "";
            loadDataGridView();
        }

        private void ClickToXoa(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Cần chọn 1 đề để xóa", "Notice");
                return;
            }
            DialogResult res = MessageBox.Show(string.Format("Bạn có muốn xóa đề '{0}' không", labelName.Text), "Notice", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("DELETE FROM dbo.DeThi WHERE maDeThi = {0}", curExamId));
            MessageBox.Show("Đã xóa");
            loadDataGridView();
        }

        private void ClickToSearch(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxFind.Text))
            {
                MessageBox.Show("Nội dung tìm kiếm không được để trống", "Notice");
                return;
            }
            if (radioButtonByName.Checked)
            {
                loadByName();
            }
            else if (radioButtonById.Checked)
            {
                loadByID();
            }
            textBoxFind.Text = "";
        }

        private void ClickToReset(object sender, EventArgs e)
        {
            loadAll();
        }
    }
}
