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

namespace QuanLyThi
{
    public partial class TeacherInfo : Form
    {
        private int teacherId = 1; // default
        private string tenDangNhap = "";
        public TeacherInfo()
        {
            InitializeComponent();
            loadThongTin();
            loadPicture();
        }

        public TeacherInfo(int teacherId)
        {
            InitializeComponent();
            this.teacherId = teacherId;
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
            DataTable dt = sqlRunner.excuteQuery(string.Format("SELECT gv.*, tk.tenDangNhap FROM dbo.GiaoVien AS gv INNER JOIN dbo.taikhoan AS tk ON gv.maGiaoVien = tk.maNguoiDung WHERE tk.loaiNguoiDung = 'GiaoVien' AND maGiaoVien = {0}", teacherId));
            tenDangNhap = textBoxLoginName.Text = dt.Rows[0]["tenDangNhap"].ToString();
            textBoxName.Text = dt.Rows[0]["hoTen"].ToString();
            textBoxEmail.Text = dt.Rows[0]["email"].ToString();
            textBoxID.Text = dt.Rows[0]["maGiaoVien"].ToString();
            textBoxPhone.Text = dt.Rows[0]["soDienThoai"].ToString();
        }

        private void ClickToUpdate(object sender, EventArgs e)
        {
            if(string.IsNullOrWhiteSpace(textBoxCurPassWord.Text) || string.IsNullOrWhiteSpace(textBoxNewPassWord.Text) || string.IsNullOrWhiteSpace(textBoxReNewPassWord.Text))
            {
                MessageBox.Show("Chưa điền đẩy đủ thông tin", "Notice");
                return;
            }
            SqlRunner sqlRunner = new SqlRunner();
            bool checkOldPass = (int)sqlRunner.executeScalar(string.Format("SELECT COUNT(*) FROM dbo.taikhoan WHERE loaiNguoiDung = 'GiaoVien' AND maNguoiDung = {0} AND matKhau = '{1}'", teacherId, textBoxCurPassWord.Text)) > 0 ? true : false;
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
            sqlRunner.excuteNonQuery(string.Format("UPDATE dbo.taikhoan SET matKhau = '{0}' WHERE loaiNguoiDung = 'GiaoVien'  AND tenDangNhap = '{1}'", textBoxNewPassWord.Text, tenDangNhap));
            MessageBox.Show("Cập nhật lại mật khẩu thành công");
            textBoxCurPassWord.Text = textBoxNewPassWord.Text = textBoxReNewPassWord.Text = "";
        }
    }
}
