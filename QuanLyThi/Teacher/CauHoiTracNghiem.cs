using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThi
{
    public partial class CauHoiTracNghiem : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str;
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();
        private int curQuestionId = -1; // default = -1
        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CauHoiTracNghiem";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }
        public CauHoiTracNghiem()
        {
            InitializeComponent();
            SqlRunner runner = new SqlRunner();
            str = runner.getConnectionStr();
        }

        private void CauHoiTracNghiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("INSERT INTO dbo.CauHoiTracNghiem (noiDung) VALUES ('{0}')", txtNoiDungCH.Text));
            loadData();
        }

        private void btnCapNhat1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CauHoiTracNghiem SET noiDung = N'" + txtNoiDungCH.Text + "' WHERE maCauHoi = '" + txtID.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        void clearData()
        {
            txtID.Text = txtNoiDungCH.Text = txtNoiDungDA.Text = "";
            txtDapAn1.Text = txtDapAn2.Text = txtDapAn3.Text = txtDapAn4.Text = "";
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM CauHoiTracNghiem WHERE maCauHoi = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loadData();
            clearData();
        }

        void loadDapAn(int id)
        {
            if(id == 1)
            {
                txtNoiDungDA.Text = txtDapAn1.Text;
            }
            else if(id == 2)
            {
                txtNoiDungDA.Text = txtDapAn2.Text;
            }
            else if(id == 3)
            {
                txtNoiDungDA.Text = txtDapAn3.Text;
            }
            else if(id == 4)
            {
                txtNoiDungDA.Text = txtDapAn4.Text;
            }
        }

        void updateDapAn()
        {
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("UPDATE CauHoiTracNghiem SET dapAn1 = N'{0}', dapAn2 = N'{1}', dapAn3 = N'{2}', dapAn4 = N'{3}', cauTraLoi = {4} WHERE maCauHoi = {5}", txtDapAn1.Text, txtDapAn2.Text, txtDapAn3.Text, txtDapAn4.Text, cboDapAnDung.Text, curQuestionId));
            MessageBox.Show(string.Format("Cập nhật thành công câu hỏi có mã {0}", curQuestionId));
        }

        private void btnCapNhat2_Click(object sender, EventArgs e)
        {
            //command = connection.CreateCommand();
            //command.CommandText = "UPDATE CauHoiTracNghiem SET dapAn1 = '" + txtDapAn1.Text + "',dapAn2 = '" + txtDapAn2.Text + "',dapAn3 = '" + txtDapAn3.Text + "',dapAn4 = '" + txtDapAn4.Text + "',cauTraLoi = '" + cboDapAnDung.Text + "' WHERE maCauHoi = '" + txtID.Text + "' ";
            //command.ExecuteNonQuery();
            if (dataGridView1.SelectedRows.Count == 0) return;
            if (curQuestionId == -1)
            {
                MessageBox.Show("Bạn chưa chọn câu hỏi để chỉnh sửa nào");
                return;
            }
                
            updateDapAn();
            loadData();
        }

        private void txtDapAn1_Enter(object sender, EventArgs e)
        {
            //txtNoiDungDA.Text = txtDapAn1.Text;
            numericUpDown1.Value = 1;
        }

        private void txtDapAn2_Enter(object sender, EventArgs e)
        {
            //txtNoiDungDA.Text = txtDapAn2.Text;
            numericUpDown1.Value = 2;
        }

        private void txtDapAn3_Enter(object sender, EventArgs e)
        {
            //txtNoiDungDA.Text = txtDapAn3.Text;
            numericUpDown1.Value = 3;
        }

        private void txtDapAn4_Enter(object sender, EventArgs e)
        {
            //txtNoiDungDA.Text = txtDapAn4.Text;
            numericUpDown1.Value = 4;
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            if (i < 0 || i > dataGridView1.Rows.Count - 2) return;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            curQuestionId = int.Parse(txtID.Text);
            txtNoiDungCH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDapAn1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDapAn2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDapAn3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDapAn4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cboDapAnDung.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
            loadDapAn(1); // default hien thi cau 1
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            loadDapAn((int)numericUpDown1.Value);
        }

        private void txtNoiDungDA_TextChanged(object sender, EventArgs e)
        {
            int id = (int)numericUpDown1.Value;
            if (id == 1)
            {
                txtDapAn1.Text = txtNoiDungDA.Text;
            }
            else if (id == 2)
            {
                txtDapAn2.Text = txtNoiDungDA.Text;
            }
            else if (id == 3)
            {
                txtDapAn3.Text = txtNoiDungDA.Text;
            }
            else if (id == 4)
            {
                txtDapAn4.Text = txtNoiDungDA.Text;
            }
        }
    }
}
