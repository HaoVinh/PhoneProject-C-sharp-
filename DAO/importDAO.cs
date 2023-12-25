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
    internal class importDAO
    {
        Database db;
        public importDAO()
        {
            db = new Database();
        }
        public DataTable LayDSNhapHang()
        {
            string strSQL = "Select * From ImportProduct imp";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaPNMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(ImportID, 3, LEN(ImportID) - 2) AS INT)) AS MaxImportNumber FROM ImportProduct";

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
        public bool CheckImport(String importID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM dbo.[ImportProduct] WHERE ImportID='"+ importID + "'";

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
        public bool ThemNhapHang(importDTO imp)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO dbo.[ImportProduct] (ImportID, SupplierID, ImportDate, EmpID) VALUES (@ImportID,@SupplierID,@ImportDate,@EmpID)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ImportID", imp.getImportID());
                        command.Parameters.AddWithValue("@SupplierID", imp.getSuppID());
                        command.Parameters.AddWithValue("@ImportDate", imp.getDate());
                        command.Parameters.AddWithValue("@EmpID", imp.getEmpID());

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
        public List<importDTO> SearchImport(string column, string data)
        {
            List<importDTO> list = new List<importDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "Select ImportID, SupplierID, ImportDate, EmpID from ImportProduct where " + column + " = '" + data + "'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ImportID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            importDTO cus = new importDTO(
                                sdr["ImportID"].ToString(),
                                sdr["SupplierID"].ToString(),
                                sdr["ImportDate"].ToString(),
                                sdr["EmpID"].ToString());

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
        public List<orderInfoDTO> getAllImportInfo(String importID, String suppID, String empID)
        {
            List<orderInfoDTO> list = new List<orderInfoDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    String sql = "SELECT orde.ProductID, product.ProductName, product.UnitPrice, orde.Quantity, orde.Price " +
                     "FROM dbo.[ImportProduct] AS o, ImportDetail AS orde, Product AS product " +
                     "WHERE o.ImportID = orde.ImportID AND orde.ProductID = product.ProductID AND o.ImportID = '" + importID + "' AND o.SupplierID = '" + suppID + "' AND o.EmpID = '" + empID + "'";
                    using (SqlCommand command = new SqlCommand(sql, connection))
                    {
                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            String productID = sdr["ProductID"].ToString();
                            String productName = sdr["ProductName"].ToString();
                            int unitPrice = int.Parse(sdr["UnitPrice"].ToString());
                            int quantity = int.Parse(sdr["Quantity"].ToString());
                            int price = int.Parse(sdr["Price"].ToString());
                            orderInfoDTO infor = new orderInfoDTO(productID, productName, unitPrice, quantity, price);
                            list.Add(infor);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);

            }
            return list;

        }
    }
}
