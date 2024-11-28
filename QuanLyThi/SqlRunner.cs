using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyThi
{
    internal class SqlRunner
    {

        private string connectionStr = "Data Source=.\\Sqlexpress;Initial Catalog=QuanLyPhanMemThi;Integrated Security=True;Encrypt=False";
        
        /// <summary>
        /// Thuc hien truy van truyen vao va tra ra DataTable
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public DataTable excuteQuery(string query)
        {
            DataTable data = new DataTable();

            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                SqlDataAdapter adapter = new SqlDataAdapter(command);
                adapter.Fill(data);

                connection.Close();
            }
            return data;
        }

        /// <summary>
        /// Thuc hien cac truy van nhu: them, sua, xoa gi do...
        /// Tra ve so dong dc thuc hien thanh cong
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public int excuteNonQuery(string query)
        {
            int numRowSuccessed = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                numRowSuccessed = command.ExecuteNonQuery();

                connection.Close();
            }
            return numRowSuccessed;
        }
        /// <summary>
        /// Thuc hien cac truy van nhu: SUM, MAX, COUNT, ...
        /// Tra ra gia tri cua hang dau tien, dong dau tien kieu object
        /// Khi dung thi nho ep kieu ve dung kieu can dung
        /// </summary>
        /// <param name="query"></param>
        /// <returns></returns>
        public object executeScalar(string query)
        {
            object data = 0;
            using (SqlConnection connection = new SqlConnection(connectionStr))
            {
                connection.Open();

                SqlCommand command = new SqlCommand(query, connection);
                data = command.ExecuteScalar();

                connection.Close();
            }
            return data;
        }
    }
}
