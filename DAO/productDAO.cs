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
    internal class productDAO
    {
        Database db;
        public productDAO()
        {
            db = new Database();
        }
        public DataTable LayDSSanPham()
        {
            string strSQL = "Select * From Product p";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayMaThuongHieu()
        {
            string strSQL = "Select BrandID From Brand brand";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayMaLoai()
        {
            string strSQL = "Select CategoryID From Category cate";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public DataTable LayMaNCC()
        {
            string strSQL = "Select SupplierID From Supplier supp";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaSPMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(ProductID, 3, LEN(ProductID) - 2) AS INT)) AS MaxProductNumber FROM Product";

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
        public byte[] LayHinhSanPham(String productID)
        {

            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            byte[] imageData = null;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT Image FROM Product WHERE ProductID='" + productID + "'";


                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                // Lấy dữ liệu hình ảnh từ cột "Image"
                                imageData = (byte[])reader["Image"];
                            }
                        }

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return imageData;

        }
        public bool isProductNameExisted(string productName)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT Count(*) FROM Product WHERE ProductName='" + productName + "'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int count = reader.GetInt32(0);
                                return count > 0;
                            }
                        }
                    }
                }
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
                return false;
            }
        }
        public bool CheckProductID(String productID)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT * FROM Product WHERE ProductID='" + productID + "'";

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
        public bool ThemSanPham(productDTO product)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            //try
            //{
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Product (ProductID,ProductName,UnitPrice,Quantity,BrandID,CategoryID,Image ) VALUES (@ProductID,@ProductName,@UnitPrice,@Quantity,@BrandID,@CategoryID,@Image)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@ProductID", product.getproductID());
                        command.Parameters.AddWithValue("@ProductName", product.getproductName());
                        command.Parameters.AddWithValue("@UnitPrice", product.getUnitPrice());
                        command.Parameters.AddWithValue("@Quantity", product.getQuantity());
                        command.Parameters.AddWithValue("@BrandID", product.getBrandID());
                        command.Parameters.AddWithValue("@CategoryID", product.getCategoryID());
                        command.Parameters.AddWithValue("@Image", product.GetImageData());


                    int rowsAffected = command.ExecuteNonQuery();
                        return rowsAffected == 1;
                    }
                }
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Lỗi: " + ex.Message);
            //    return false;
            //}
        }
        public bool XoaSanPham(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Product WHERE ProductID = @ProductID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatSP(productDTO product)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Product SET ProductName=@ProductName,UnitPrice=@UnitPrice,Quantity=@Quantity,BrandID = @BrandID,CategoryID=@CategoryID,Image=@Image WHERE ProductID = @ProductID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@ProductName", product.getproductName());
                    command.Parameters.AddWithValue("@UnitPrice", product.getUnitPrice());
                    command.Parameters.AddWithValue("@Quantity", product.getQuantity());
                    command.Parameters.AddWithValue("@BrandID", product.getBrandID());
                    command.Parameters.AddWithValue("@CategoryID", product.getCategoryID());
                    command.Parameters.AddWithValue("@Image", product.GetImageData());
                    command.Parameters.AddWithValue("@ProductID", product.getproductID());
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }

        }
        public int countCake()
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
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return count;
        }
        public bool UpdateProductQuantity(String productID, int newQuantity)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Product SET Quantity=Quantity-@Quantity WHERE ProductID = @ProductID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", newQuantity);
                    command.Parameters.AddWithValue("@ProductID", productID);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool UpdateProductQuantityPlus (String productID, int newQuantity)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string updateQuery = "UPDATE Product SET Quantity=Quantity+@Quantity WHERE ProductID = @ProductID";

                using (SqlCommand command = new SqlCommand(updateQuery, connection))
                {
                    command.Parameters.AddWithValue("@Quantity", newQuantity);
                    command.Parameters.AddWithValue("@ProductID", productID);

                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }

        public List<productDTO> SearchProductByID(string data)
        {
            List<productDTO> list = new List<productDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT ProductID,ProductName,UnitPrice,Quantity,BrandID,CategoryID,Image FROM Product WHERE ProductID=@ProductID ";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@ProductID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            byte[] imageData = (byte[])sdr["Image"];
                            productDTO cus = new productDTO(
                                sdr["ProductID"].ToString(),
                                sdr["ProductName"].ToString(),
                                int.Parse(sdr["UnitPrice"].ToString()),
                                int.Parse(sdr["Quantity"].ToString()),
                                sdr["BrandID"].ToString(),
                                sdr["CategoryID"].ToString(),
                                imageData
                            );

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

        public List<productDTO> SearchProductByName(string data)
        {
            List<productDTO> list = new List<productDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT ProductID,ProductName,UnitPrice,Quantity,BrandID,CategoryID,Image FROM Product WHERE ProductName like '%" + data + "%'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            byte[] imageData = (byte[])sdr["Image"];
                            productDTO cus = new productDTO(
                                sdr["ProductID"].ToString(),
                                sdr["ProductName"].ToString(),
                                int.Parse(sdr["UnitPrice"].ToString()),
                                int.Parse(sdr["Quantity"].ToString()),
                                sdr["BrandID"].ToString(),
                                sdr["CategoryID"].ToString(),
                                imageData
                            );

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
        public List<productDTO> SearchProductByNameAndPrice(string data, int minPrice , int maxPrice )
        {
            List<productDTO> list = new List<productDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT ProductID,ProductName,UnitPrice,Quantity,BrandID,CategoryID,Image " +
                                         "FROM Product " +
                                         "WHERE ProductName LIKE '%' + @Data + '%' AND UnitPrice BETWEEN @MinPrice AND @MaxPrice";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Data", data);
                        command.Parameters.AddWithValue("@MinPrice", minPrice);
                        command.Parameters.AddWithValue("@MaxPrice", maxPrice);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            byte[] imageData = (byte[])sdr["Image"];
                            productDTO cus = new productDTO(
                                sdr["ProductID"].ToString(),
                                sdr["ProductName"].ToString(),
                                int.Parse(sdr["UnitPrice"].ToString()),
                                int.Parse(sdr["Quantity"].ToString()),
                                sdr["BrandID"].ToString(),
                                sdr["CategoryID"].ToString(),
                                imageData
                            );

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
        public List<productDTO> SearchProductByNameAndPrice2(string data, int minPrice , int maxPrice )
        {
            List<productDTO> list = new List<productDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT ProductID,ProductName,UnitPrice,Quantity,BrandID,CategoryID,Image " +
                                         "FROM Product " +
                                         "WHERE ProductName LIKE '%' + @Data + '%' AND UnitPrice BETWEEN @MinPrice AND @MaxPrice";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@Data", data);
                        command.Parameters.AddWithValue("@MinPrice", minPrice);
                        command.Parameters.AddWithValue("@MaxPrice", maxPrice);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            byte[] imageData = (byte[])sdr["Image"];
                            productDTO cus = new productDTO(
                                sdr["ProductID"].ToString(),
                                sdr["ProductName"].ToString(),
                                int.Parse(sdr["UnitPrice"].ToString()),
                                int.Parse(sdr["Quantity"].ToString()),
                                sdr["BrandID"].ToString(),
                                sdr["CategoryID"].ToString(),
                                imageData
                            );

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
