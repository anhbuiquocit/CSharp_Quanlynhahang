using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
namespace BTLW_BuiQuocAnh.Controller
{
    class DAL
    {
        public SqlConnection getConnection()
        {
            try
            {
                String connString = @"Data Source=BUIQUOCANH\SQLEXPRESS;Initial Catalog=Quanlynhahang;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connString);
                return conn;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
        }
        public DataTable getTable(String sql)
        {
            SqlConnection conn = getConnection();
            SqlDataAdapter adapter = new SqlDataAdapter(sql, conn);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;
        }
        public void execNonQuery(String sql)
        {
            try
            {
                SqlConnection conn = getConnection();
                if (conn.State == ConnectionState.Closed)
                    conn.Open();
                SqlCommand cmd = new SqlCommand(sql, conn);
                cmd.ExecuteNonQuery();

            }
            catch (SqlException ex)
            {

                if (ex.Message.Contains("Violation of PRIMARY KEY"))
                {
                    MessageBox.Show("Lỗi: Mã này đã tồn tại, mời bạn nhập mã người dùng khác", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
