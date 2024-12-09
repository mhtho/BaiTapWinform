using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace QuanLyThi
{
    public partial class StudentInfo : Form
    {

        private int studentId = 1; // default
        private string tenDangNhap = "";
        public StudentInfo()
        {
            InitializeComponent();
            loadThongTin();
            loadPicture();
        }

        void loadPicture()
        {
            string path = Directory.GetParent(Application.ExecutablePath).Parent.Parent.FullName + "\\Image\\background.png";
            pictureBox1.Image = new Bitmap(path);
        }
        void loadThongTin()
        {
            SqlRunner sqlRunner = new SqlRunner();
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT hs.*, tk.tenDangNhap FROM dbo.HocSinh AS hs INNER JOIN dbo.taikhoan AS tk ON hs.maHocSinh = tk.maNguoiDung WHERE tk.loaiNguoiDung = 'HocSinh' AND maHocSinh = {0}", studentId));
            tenDangNhap = textBoxLoginName.Text = dt.Rows[0]["tenDangNhap"].ToString();
            textBoxName.Text = dt.Rows[0]["hoTen"].ToString();
            textBoxEmail.Text = dt.Rows[0]["email"].ToString();
            textBoxID.Text = dt.Rows[0]["maHocSinh"].ToString();
            textBoxBirthDay.Text = ((DateTime)dt.Rows[0]["ngaySinh"]).ToString("dd-MM-yyyy");
        }

        private void ClickToUpdate(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxCurPassWord.Text) || string.IsNullOrWhiteSpace(textBoxNewPassWord.Text) || string.IsNullOrWhiteSpace(textBoxReNewPassWord.Text))
            {
                MessageBox.Show("Chưa điền đẩy đủ thông tin", "Notice");
                return;
            }
            SqlRunner sqlRunner = new SqlRunner();
            bool checkOldPass = (int)sqlRunner.executeScalar(string.Format("SELECT COUNT(*) FROM dbo.taikhoan WHERE loaiNguoiDung = 'HocSinh' AND maNguoiDung = {0} AND matKhau = '{1}'", studentId, textBoxCurPassWord.Text)) > 0 ? true : false;
            if (!checkOldPass)
            {
                MessageBox.Show("Mật khẩu cũ sai", "Notice");
                return;
            }
            if (!textBoxNewPassWord.Text.Equals(textBoxReNewPassWord.Text))
            {
                MessageBox.Show("Nhập lại mật khẩu sai", "Notice");
                return;
            }
            sqlRunner.excuteNonQuery(string.Format("UPDATE dbo.taikhoan SET matKhau = '{0}' WHERE loaiNguoiDung = 'HocSinh'  AND tenDangNhap = '{1}'", textBoxNewPassWord.Text, tenDangNhap));
            MessageBox.Show("Cập nhật lại mật khẩu thành công");
            textBoxCurPassWord.Text = textBoxNewPassWord.Text = textBoxReNewPassWord.Text = "";
        }
    }
}
