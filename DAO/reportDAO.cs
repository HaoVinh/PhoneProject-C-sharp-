using MobileStore.DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobileStore.DAO
{
    internal class reportDAO
    {
        public int countProduct()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "Select Count(ProductID) from Product";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public int countEmployee()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "Select Count(EmpID) from Employee";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public int countCustomer()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "Select Count(CustomerID) from Customer";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public int countOrder()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "Select Count(OrderID) from Orders";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public int countImport()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "Select Count(ImportID) from ImportProduct";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public int countSupplier()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int count = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "Select Count(SupplierID) from Supplier";

                    using (SqlCommand command = new SqlCommand(updateQuery, connection))
                    {
                        count = (int)command.ExecuteScalar();
                        int rowsAffected = command.ExecuteNonQuery();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public List<reportSellDTO> ReportSell(string start_time, string end_time, string field, string data, string date_format = "")
        {
            List<reportSellDTO> list = new List<reportSellDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            string order_date = "Orders.OrderDate";
            if (date_format == "Y-m")
            {
                order_date = "FORMAT(Orders.OrderDate,'MM-yyyy')";
            }
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "select Product.ProductID,Product.ProductName ," + order_date + " as OrderDate , Category.NameCategory, Customer.CustomerName as CustomerName," +
                        " sum(OrderDetailID.Quantity) as Quantity,sum(OrderDetailID.Price) as Price " +
                        "from Product " +
                        "LEFT JOIN OrderDetailID ON OrderDetailID.ProductID = Product.ProductID " +
                        "LEFT JOIN Orders ON OrderDetailID.OrderID = Orders.OrderID " +
                        "LEFT JOIN Category ON Product.CategoryID = Category.CategoryID " +
                        "LEFT JOIN Customer ON Orders.CustomerID = Customer.CustomerID " +
                        "where Orders.OrderDate between '" + start_time + "' and '" + end_time + "' " +
                        " and " + field + " LIKE '%" + data + "%' " +
                        "GROUP BY Product.ProductID,Product.ProductName,Category.NameCategory," + order_date + ",Customer.CustomerName " +
                        "ORDER BY OrderDate DESC"; 

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            if (sdr["OrderDate"] == DBNull.Value)
                            {
                                continue;
                            }
                            // Adjust the column names to match your database schema
                            reportSellDTO report = new reportSellDTO();
                            report.ProductId = sdr["ProductID"].ToString();
                            report.ProductName = sdr["ProductName"].ToString();
                            report.CustomerName = sdr["CustomerName"].ToString();
                            report.Date = sdr["OrderDate"].ToString();
                            report.ProductType = sdr["NameCategory"].ToString();
                            report.Quantity = int.Parse(sdr["Quantity"].ToString());
                            report.TotalPrice = int.Parse(sdr["Price"].ToString());
                            list.Add(report);
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
        public List<reportImportDTO> ReportImport(string start_time, string end_time, string field, string data, string date_format = "")
        {
            List<reportImportDTO> list = new List<reportImportDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            string import_date ="ImportProduct.ImportDate";
            if (date_format == "Y-m")
            {
                import_date = "FORMAT(ImportProduct.ImportDate,'MM-yyyy')";
            }
          
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "select Product.ProductID,Product.ProductName ," + import_date + " as ImportDate ,Category.NameCategory, Supplier.NameSupplier," +
                        " sum(ImportDetail.Quantity) as Quantity,sum(ImportDetail.Price) as Price " +
                        "from Product " +
                        "LEFT JOIN ImportDetail ON ImportDetail.ProductID = Product.ProductID " +
                        "LEFT JOIN ImportProduct ON ImportDetail.ImportID = ImportProduct.ImportID " +
                        "LEFT JOIN Category ON Product.CategoryID = Category.CategoryID " +
                        "LEFT JOIN Supplier ON ImportProduct.SupplierID = Supplier.SupplierID " +
                        "where ImportProduct.ImportDate between '" + start_time + "' and '" + end_time + "' " +
                        " and " + field + " LIKE '%" + data + "%' " +
                        "GROUP BY Product.ProductID,Product.ProductName," + import_date + ",Category.NameCategory, Supplier.NameSupplier " +
                        "ORDER BY ImportDate DESC";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {


                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            if (sdr["ImportDate"] == DBNull.Value)
                            {
                                continue;
                            }
                            // Adjust the column names to match your database schema
                            reportImportDTO report = new reportImportDTO();
                            report.ProductId = sdr["ProductID"].ToString();
                            report.ProductName = sdr["ProductName"].ToString();
                            report.Supplier = sdr["NameSupplier"].ToString();
                            report.Date = sdr["ImportDate"].ToString();
                            report.ProductType = sdr["NameCategory"].ToString();
                            report.Quantity = int.Parse(sdr["Quantity"].ToString());
                            report.TotalPrice = int.Parse(sdr["Price"].ToString());
                            list.Add(report);
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
