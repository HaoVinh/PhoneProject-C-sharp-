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
    internal class customerDAO
    {
        Database db;
        public customerDAO()
        {
            db = new Database();
        }
        public DataTable LayDSNhanvien()
        {
            string strSQL = "Select * From Customer c";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayMaNhanvien()
        {
            string strSQL = "Select CustomerID From Customer c";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaTHMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(CustomerID, 3, LEN(CustomerID) - 2) AS INT)) AS MaxCusNumber FROM Customer";

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
        public List<customerDTO> getAllCustomer()
        {
            List<customerDTO> list = new List<customerDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT CustomerID, CustomerName, Phone, Address FROM Customer ";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                     

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            customerDTO cus = new customerDTO(
                                sdr["CustomerID"].ToString(),
                                sdr["CustomerName"].ToString(),
                                sdr["Phone"].ToString(),
                                sdr["Address"].ToString());

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
        public bool ThemNhanVien(customerDTO cus)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Customer (CustomerID,CustomerName,Phone, Address ) VALUES (@CustomerID,@CustomerName,@Phone,@Address)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CustomerID", cus.getCusID());
                        command.Parameters.AddWithValue("@CustomerName", cus.getCusName());
                        command.Parameters.AddWithValue("@Phone", cus.getPhone());
                        command.Parameters.AddWithValue("@Address", cus.getAddress());

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
        public bool XoaNhanVien(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Customer WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatNV(customerDTO cus)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Customer SET CustomerName=@CustomerName,Phone=@Phone,Address=@Address WHERE CustomerID = @CustomerID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@CustomerName", cus.getCusName());
                    command.Parameters.AddWithValue("@Phone", cus.getPhone());
                    command.Parameters.AddWithValue("@Address", cus.getAddress());
                    command.Parameters.AddWithValue("@CustomerID", cus.getCusID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public List<customerDTO> SearchCustomerByID(string data)
        {
            List<customerDTO> list = new List<customerDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT CustomerID, CustomerName, Phone, Address FROM Customer WHERE CustomerID=@CustomerID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@CustomerID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            customerDTO cus = new customerDTO(
                                sdr["CustomerID"].ToString(),
                                sdr["CustomerName"].ToString(),
                                sdr["Phone"].ToString(),
                                sdr["Address"].ToString());

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
        public List<customerDTO> SearchCustomerByName(string data)
        {
            List<customerDTO> list = new List<customerDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT CustomerID, CustomerName, Phone, Address FROM Customer WHERE CustomerName like '%"+data+"%'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            customerDTO cus = new customerDTO(
                                sdr["CustomerID"].ToString(),
                                sdr["CustomerName"].ToString(),
                                sdr["Phone"].ToString(),
                                sdr["Address"].ToString());

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
