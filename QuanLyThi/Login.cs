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
using System.IO;
namespace QuanLyThi
{
    public partial class Login : Form
    {
        
        string str = @"Data Source=KHANHLINH\SQLEXPRESS;Initial Catalog=QuanLyPhanMemThi;Integrated Security=True";
        

        
        public Login()
        {
            InitializeComponent();
            init();
        }
        public void init()
        {
            SqlRunner sqlRunner = new SqlRunner();
            str = sqlRunner.getConnectionStr();
            string path = Directory.GetParent(Application.ExecutablePath).Parent.Parent.FullName + "\\Image\\login.png";
            pictureBox1.Image = new Bitmap(path);
        }

        int getID(string user, string pass, string role)
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT * FROM dbo.taikhoan WHERE tenDangNhap = '{0}' AND matKhau = '{1}' AND loaiNguoiDung = '{2}'", user, pass, role));
            return int.Parse(dt.Rows[0]["maNguoiDung"].ToString());     
        }

        void clearData()
        {
            txtPassword.Text = txtUsername.Text = "";
        }

        void openStudentForm(int studentID)
        {
            clearData();
            this.Hide();
            Form form = new StudentForm(studentID);
            form.ShowDialog();
            this.Show();
        }

        void openTeacherForm(int teacherID)
        {
            clearData();
            this.Hide();
            Form form = new TeacherForm(teacherID);
            form.ShowDialog();
            this.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();
            string role = rbStudent.Checked ? "HocSinh" : "GiaoVien";
            if (string.IsNullOrEmpty(username) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Vui lòng nhập đầy đủ thông tin!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            using (SqlConnection connection = new SqlConnection(str))
            {
                try
                {
                    connection.Open();
                    string query = "SELECT * FROM dbo.taikhoan WHERE tenDangNhap = @username AND matKhau = @password AND loaiNguoiDung = @role";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@username", username);
                        command.Parameters.AddWithValue("@password", password);
                        command.Parameters.AddWithValue("@role", role);

                        SqlDataReader reader = command.ExecuteReader();
                        if (reader.HasRows)
                        {
                            MessageBox.Show("Đăng nhập thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if(role == "HocSinh")
                            {
                                openStudentForm(getID(username, password, role));
                            }
                            else if(role == "GiaoVien")
                            {
                                openTeacherForm(getID(username, password, role));
                            }
                            
                        }
                        else
                        {
                            MessageBox.Show("Tên đăng nhập hoặc mật khẩu không đúng!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        reader.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Lỗi kết nối: {ex.Message}", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}

