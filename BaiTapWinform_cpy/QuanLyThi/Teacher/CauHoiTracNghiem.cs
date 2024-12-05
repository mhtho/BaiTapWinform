using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyThi
{
    public partial class CauHoiTracNghiem : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = @"Data Source=DESKTOP-LJO6CVC;Initial Catalog=QuanLyPhanMemThi;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

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
        }

        private void CauHoiTracNghiem_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "INSERT INTO CauHoiTracNghiem VALUES('" + txtNoiDungCH.Text + "','" + txtDapAn1.Text + "','" + txtDapAn2.Text + "','" + txtDapAn3.Text + "','" + txtDapAn4.Text + "','" + cboDapAnDung.Text + "') ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnCapNhat1_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CauHoiTracNghiem SET noiDung = '" + txtNoiDungCH.Text + "' WHERE maCauHoi = '" + txtID.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM CauHoiTracNghiem WHERE maCauHoi = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnCapNhat2_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CauHoiTracNghiem SET dapAn1 = '" + txtDapAn1.Text + "',dapAn2 = '" + txtDapAn2.Text + "',dapAn3 = '" + txtDapAn3.Text + "',dapAn4 = '" + txtDapAn4.Text + "',cauTraLoi = '" + cboDapAnDung.Text + "' WHERE maCauHoi = '" + txtID.Text + "' ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtNoiDungCH.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDapAn1.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
            txtDapAn2.Text = dataGridView1.Rows[i].Cells[3].Value.ToString();
            txtDapAn3.Text = dataGridView1.Rows[i].Cells[4].Value.ToString();
            txtDapAn4.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            cboDapAnDung.Text = dataGridView1.Rows[i].Cells[6].Value.ToString();
        }

        private void txtDapAn1_Enter(object sender, EventArgs e)
        {
            txtNoiDungDA.Text = txtDapAn1.Text;
        }

        private void txtDapAn2_Enter(object sender, EventArgs e)
        {
            txtNoiDungDA.Text = txtDapAn2.Text;
        }

        private void txtDapAn3_Enter(object sender, EventArgs e)
        {
            txtNoiDungDA.Text = txtDapAn3.Text;
        }

        private void txtDapAn4_Enter(object sender, EventArgs e)
        {
            txtNoiDungDA.Text = txtDapAn4.Text;
        }
    }
}
