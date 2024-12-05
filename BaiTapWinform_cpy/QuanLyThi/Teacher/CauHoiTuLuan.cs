using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyThi
{
    public partial class CauHoiTuLuan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        String str = @"Data Source=DESKTOP-LJO6CVC;Initial Catalog=QuanLyPhanMemThi;Integrated Security=True;Encrypt=False";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table = new DataTable();

        void loadData()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from CauHoiTuLuan";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);
            dataGridView1.DataSource = table;
        }

        public CauHoiTuLuan()
        {
            InitializeComponent();
        }

        private void CauHoiTuLuan_Load(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loadData();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            command.Connection.CreateCommand();
            command.CommandText = "INSERT INTO CauHoiTuLuan VALUES('" + txtNoiDung.Text + "','" + txtDapAn.Text + "') ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CauHoiTuLuan SET noiDung = '" + txtNoiDung.Text + "',cauTraLoi = '" + txtDapAn.Text + "' WHERE  maCauHoi = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "DELETE FROM CauHoiTuLuan WHERE maCauHoi = '" + txtID.Text + "'";
            command.ExecuteNonQuery();
            loadData();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtNoiDung.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDapAn.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
