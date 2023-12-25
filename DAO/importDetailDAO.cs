using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class importDetailDAO
    {
        Database db;
        public importDetailDAO()
        {

            db = new Database();
        }
        public DataTable LayDSChiTietNhapHang()
        {
            string strSQL = "Select * From ImportDetail id";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public List<importDetailDTO> getOrderDetail(String importID)
        {
            List<importDetailDTO> list = new List<importDetailDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "Select ImportID, ProductID, Price, Quantity from OrderDetailID where ImportID = '" + importID + "'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ImportID", importID);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            importDetailDTO cus = new importDetailDTO(
                                sdr["ImportID"].ToString(),
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
        public bool CheckChiTietNhapHang(string importID, string productID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "Select * from ImportDetail where ImportID ='" + importID + "' and ProductID = '" + productID + "'";
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

        public bool ThemChiTietNhapHang(importDetailDTO id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO ImportDetail (ImportID,ProductID,Price,Quantity ) VALUES (@ImportID,@ProductID,@Price,@Quantity)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ImportID", id.getImportID());
                        command.Parameters.AddWithValue("@ProductID", id.getProductID());
                        command.Parameters.AddWithValue("@Price", id.getUnitprice());
                        command.Parameters.AddWithValue("@Quantity", id.getQuantity());

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
        public bool CapNhatCTPN(importDetailDTO id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE ImportDetail SET Price=@Price,Quantity=@Quantity WHERE ImportID=@ImportID and ProductID=@ProductID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Price", id.getUnitprice());
                    command.Parameters.AddWithValue("@Quantity", id.getQuantity());
                    command.Parameters.AddWithValue("@ImportID", id.getImportID());
                    command.Parameters.AddWithValue("@ProductID", id.getProductID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
    }
}
