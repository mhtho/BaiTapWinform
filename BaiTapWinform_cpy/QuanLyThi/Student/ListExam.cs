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
    public partial class ListExam : Form
    {
        Form parentForm;
        DataRow curExam;
        int totalQuestionOfCurExam;
        private int studentID;
        public ListExam()
        {
            InitializeComponent();
            loadDefault();
        }

        public ListExam(Form parentForm, int studentID = 1)
        {
            InitializeComponent();
            this.parentForm = parentForm;
            this.studentID = studentID;
            loadDefault();
        }
        void loadDefault()
        {
            loadDataGridView();
            DataTable dt = dataGridViewListExams.DataSource as DataTable;
            if (dt.Rows.Count <= 0) return;
            curExam = dt.Rows[0];
            loadThongTin(curExam);
        }

        void loadDataGridView()
        {
            
            dataGridViewListExams.AutoGenerateColumns = false;
            dataGridViewListExams.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "Column1",
                DataPropertyName = "maDeThi",
                HeaderText = "Mã đề thi",
                Width = dataGridViewListExams.Width / 3,
                Resizable = DataGridViewTriState.False
            });
            dataGridViewListExams.Columns.Add(new DataGridViewTextBoxColumn()
            {
                Name = "column2",
                DataPropertyName = "tenDeThi",
                HeaderText = "Tên đề thi",
                Width = dataGridViewListExams.Width / 2 + 37,
                Resizable = DataGridViewTriState.False
            });
           
            loadAll();
        }

        void connectData(string query)
        {
            SqlRunner sqlRunner = new SqlRunner();
            dataGridViewListExams.DataSource = sqlRunner.excuteQuery(query);
        }

        void loadAll()
        {
            string query = "SELECT dt.*, gv.hoTen FROM dbo.DeThi AS dt INNER JOIN dbo.GiaoVien AS gv ON dt.maGiaoVien = gv.maGiaoVien";
            connectData(query);
        }

        void loadHasExpressionAll(string find)
        {
            string query = string.Format("SELECT dt.*, gv.hoTen FROM dbo.DeThi AS dt INNER JOIN dbo.GiaoVien AS gv ON dt.maGiaoVien = gv.maGiaoVien WHERE dt.maDeThi LIKE '%{0}%' OR dt.tenDeThi LIKE '%{0}%'", find);
            connectData(query);
        }

        void loadHasExpressionByID(string id)
        {
            string query = string.Format("SELECT dt.*, gv.hoTen FROM dbo.DeThi AS dt INNER JOIN dbo.GiaoVien AS gv ON dt.maGiaoVien = gv.maGiaoVien WHERE dt.maDeThi LIKE '%{0}%'", id);
            connectData(query);
        }

        void loadHasExpressionByName(string name)
        {
            string query = string.Format("SELECT dt.*, gv.hoTen FROM dbo.DeThi AS dt INNER JOIN dbo.GiaoVien AS gv ON dt.maGiaoVien = gv.maGiaoVien WHERE dt.tenDeThi LIKE '%{0}%'", name);
            connectData(query);
        }

        void resetData()
        {
            DataTable dt = dataGridViewListExams.DataSource as DataTable;
            dt.Clear();
        }

        int getTotalQuestionOfCurExam(int maDeThi)
        {
            SqlRunner sqlRunner = new SqlRunner();
            return totalQuestionOfCurExam = (int)sqlRunner.executeScalar(string.Format("SELECT COUNT(*) FROM dbo.ChiTiet_DeThi WHERE maDeThi = {0}", maDeThi));
        }

        void loadThongTin(DataRow dataRow)
        {
            labelTenDe.Text = dataRow["tenDeThi"].ToString();
            labelMaDeThi.Text = dataRow["maDeThi"].ToString();
            labelMonThi.Text = dataRow["monThi"].ToString();
            labelNguoiGiao.Text = dataRow["hoTen"].ToString();
            labelThoiGianLam.Text = dataRow["thoiGianLamBai"].ToString();
            labelSoLuongCau.Text = getTotalQuestionOfCurExam(Convert.ToInt32(dataRow["maDeThi"])).ToString();
            labelDiemToiDa.Text = string.Format("{0:f2}", Convert.ToDouble(dataRow["diemToiDa"]));
        }

        private void CellClickToThongTin(object sender, DataGridViewCellEventArgs e)
        {
            int idx = e.RowIndex;
            if (idx < 0 || idx > dataGridViewListExams.Rows.Count - 2) return;
            DataTable dt = dataGridViewListExams.DataSource as DataTable;
            curExam = dt.Rows[idx];
            loadThongTin(curExam);
        }

        private void clickToLamBai(object sender, EventArgs e)
        {
            if(totalQuestionOfCurExam <= 0)
            {
                MessageBox.Show("Đề này không có câu hỏi", "Notice");
                return;
            }
            DialogResult res = MessageBox.Show(string.Format("Bạn muốn làm đề '{0}' không ?", curExam["tenDeThi"]), "Notice", MessageBoxButtons.YesNo);
            if (res == DialogResult.No) return;
            parentForm.Hide();
            Form form = new TakingExam(curExam, totalQuestionOfCurExam, studentID);
            form.ShowDialog();
            parentForm.Show();
        }

        private void ClickToSearch(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(textBoxSearch.Text) || string.IsNullOrWhiteSpace(textBoxSearch.Text))
            {
                return;
            }
            resetData();
            if (radioButtonALL.Checked == true)
            {
                loadHasExpressionAll(textBoxSearch.Text);
            }
            else if (radioButtonByID.Checked == true)
            {
                loadHasExpressionByID(textBoxSearch.Text);
            }
            else if (radioButtonByName.Checked == true)
            {
                loadHasExpressionByName(textBoxSearch.Text);
            }
            textBoxSearch.Text = null;
        }

        private void ClickToReset(object sender, EventArgs e)
        {
            resetData();
            loadAll();
        }
    }
}
