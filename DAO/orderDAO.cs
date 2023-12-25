using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class orderDAO
    {
        Database db;
        public orderDAO()
        {

            db = new Database();
        }
        public DataTable LayDSHoaDon()
        {
            string strSQL = "Select OrderID,CustomerID,EmpID,OrderDate From Orders o";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaHDMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(OrderID, 3, LEN(OrderID) - 2) AS INT)) AS MaxOrderNumber FROM Orders";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        ma = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return ma;
        }
        public bool CheckOrder(String orderID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Orders WHERE OrderID='"+orderID+"'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                       

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }

         public bool ThemHoaDon(orderDTO order)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Orders(OrderID,CustomerID,EmpID,OrderDate) VALUES (@OrderID,@CustomerID,@EmpID,@OrderDate)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", order.getOrderID());
                        command.Parameters.AddWithValue("@CustomerID", order.getCusID());
                        command.Parameters.AddWithValue("@EmpID", order.getEmpID());
                        command.Parameters.AddWithValue("@OrderDate", order.getDate());

                        int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected == 1;
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool XoaHoaDon(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Orders WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@OrderID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatHD(orderDTO order)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Orders SET CustomerID=@CustomerID,EmpID=@EmpID,OrderDate=@OrderDate WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", order.getCusID());
                    command.Parameters.AddWithValue("@EmpID", order.getEmpID());
                    command.Parameters.AddWithValue("@OrderDate", order.getDate());
                    command.Parameters.AddWithValue("@OrderID", order.getOrderID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public List<orderDTO> SearchOrder(string column,string data)
        {
            List<orderDTO> list = new List<orderDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "Select OrderID, CustomerID, EmpID, OrderDate from Orders where " + column + " = '" + data + "'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@OrderID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            orderDTO cus = new orderDTO(
                                sdr["OrderID"].ToString(),
                                sdr["CustomerID"].ToString(),
                                sdr["EmpID"].ToString(),
                                sdr["OrderDate"].ToString());

                            list.Add(cus);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }

            return list;
        }
    }
}
