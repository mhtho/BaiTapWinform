﻿using System;
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
    public partial class CauHoiTuLuan : Form
    {
        SqlConnection connection;
        SqlCommand command;
        string str;
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
            SqlRunner runner = new SqlRunner();
            str = runner.getConnectionStr();
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
            command.CommandText = "INSERT INTO CauHoiTuLuan VALUES(N'" + txtNoiDung.Text + "', N'" + txtDapAn.Text + "') ";
            command.ExecuteNonQuery();
            loadData();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            command = connection.CreateCommand();
            command.CommandText = "UPDATE CauHoiTuLuan SET noiDung = N'" + txtNoiDung.Text + "',cauTraLoi = N'" + txtDapAn.Text + "' WHERE  maCauHoi = '" + txtID.Text + "'";
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


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int i;
            i = dataGridView1.CurrentRow.Index;
            if (i < 0 || i > dataGridView1.Rows.Count - 2) return;
            txtID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();
            txtNoiDung.Text = dataGridView1.Rows[i].Cells[1].Value.ToString();
            txtDapAn.Text = dataGridView1.Rows[i].Cells[2].Value.ToString();
        }
    }
}
