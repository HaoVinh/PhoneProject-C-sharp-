using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class ordDetailDAO
    {
        Database db;
        public ordDetailDAO()
        {

            db = new Database();
        }
        public DataTable LayDSChiTietHoaDon()
        {
            string strSQL = "Select * From OrderDetailID od";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public List<orderDetailDTO> getOrderDetail(String orderID)
        {
            List<orderDetailDTO> list = new List<orderDetailDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "Select OrderID, ProductID, Price, Quantity from OrderDetailID where OrderID = '" + orderID + "'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@OrderID", orderID);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            orderDetailDTO cus = new orderDetailDTO(
                                sdr["OrderID"].ToString(),
                                sdr["ProductID"].ToString(),
                                int.Parse(sdr["Price"].ToString()),
                                int.Parse(sdr["Quantity"].ToString()));

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
        public bool CheckChiTietHoaDon(string orderID, string productID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "Select * from OrderDetailID where OrderID ='" + orderID + "' and ProductID = '" + productID + "'";
                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Check if there are any rows
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
        public bool ThemChiTietHoaDon(orderDetailDTO od)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO OrderDetailID (OrderID,ProductID,Price,Quantity ) VALUES (@OrderID,@ProductID,@Price,@Quantity)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@OrderID", od.getOrderID());
                        command.Parameters.AddWithValue("@ProductID", od.getProductID());
                        command.Parameters.AddWithValue("@Price", od.getPrice());
                        command.Parameters.AddWithValue("@Quantity", od.getQuantity());

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
        public bool CapNhatCTHD(orderDetailDTO od)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE OrderDetailID SET ProductID=@ProductID,Price=@Price,Quantity=@Quantity WHERE OrderID = @OrderID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", od.getProductID());
                    command.Parameters.AddWithValue("@Price", od.getPrice());
                    command.Parameters.AddWithValue("@Quantity", od.getQuantity());
                    command.Parameters.AddWithValue("@OrderID", od.getOrderID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
    }
}
