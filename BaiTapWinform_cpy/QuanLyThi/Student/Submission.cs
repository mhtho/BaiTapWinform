
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThi.Student
{
    internal class Submission
    {
        public double getResult(List<Question> questionList, double maxPoint = 10.0)
        {
            int cnt = 0;
            foreach (Question question in questionList)
            {
                if (question.isTrue()) cnt++;
            }
            return 1.0 * cnt / questionList.Count * maxPoint;
        }

        public void pushSubmit(int maHocSinh, int maDeThi, double point)
        {
            SqlRunner sqlRunner = new SqlRunner();
            sqlRunner.excuteNonQuery(string.Format("INSERT INTO dbo.KetQua (maHocSinh, maDeThi, diem, thoiGianNop) VALUES ({0}, {1}, {2}, '{3}')", maHocSinh, maDeThi, point, DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")));
        }
    }
}
