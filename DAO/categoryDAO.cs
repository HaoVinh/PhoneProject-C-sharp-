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
    internal class categoryDAO
    {
        Database db;
        public categoryDAO()
        {
            db = new Database();
        }
        public DataTable LayDSLoai()
        {
            string strSQL = "Select * From Category cate";
            DataTable dt = db.Execute(strSQL);
            return dt;
        }
        public int LayMaTLMax()
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            int ma = 0;
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string updateQuery = "SELECT MAX(CAST(SUBSTRING(CategoryID, 3, LEN(CategoryID) - 2) AS INT)) AS MaxCategoryNumber FROM Category";

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
        public bool ThemLoai(categoryDTO category)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "INSERT INTO Category (CategoryID,NameCategory) VALUES (@CategoryID,@NameCategory)";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@CategoryID", category.getCategoryID());
                        command.Parameters.AddWithValue("@NameCategory", category.getCategoryName());
                        

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
        public bool XoaLoai(string id)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string deleteQuery = "DELETE FROM Category WHERE CategoryID = @CategoryID";

                using (SqlCommand command = new SqlCommand(deleteQuery, connection))
                {
                    command.Parameters.AddWithValue("@CategoryID", id);
                    int rowsAffected = command.ExecuteNonQuery();
                    return rowsAffected > 0;
                }
            }
        }
        public bool CapNhatLoai(categoryDTO category)
        {
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string insertQuery = "UPDATE Category Set NameCategory=@NameCategory Where  CategoryID=@CategoryID";
                    using (SqlCommand command = new SqlCommand(insertQuery, connection))
                    {
                        command.Parameters.AddWithValue("@NameCategory", category.getCategoryName());
                        command.Parameters.AddWithValue("@CategoryID", category.getCategoryID());


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
        public List<categoryDTO> SearchCategoryByID(string data)
        {
            List<categoryDTO> list = new List<categoryDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT CategoryID,NameCategory FROM Category WHERE CategoryID=@CategoryID";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection
                        command.Parameters.AddWithValue("@CategoryID", data);

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            categoryDTO cate = new categoryDTO(
                                sdr["CategoryID"].ToString(),
                                sdr["NameCategory"].ToString());
                            

                            list.Add(cate);
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
        public List<categoryDTO> SearchCategoryByName(string data)
        {
            List<categoryDTO> list = new List<categoryDTO>();
            string connectionString = "Data Source=DESKTOP-HM5FT06\\SQLEXPRESS;Initial Catalog=PhoneProject;Integrated Security=True";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();
                    string selectQuery = "SELECT CategoryID, NameCategory FROM Category WHERE NameCategory like '%" + data + "%'";

                    using (SqlCommand command = new SqlCommand(selectQuery, connection))
                    {
                        // Use parameters to avoid SQL injection

                        SqlDataReader sdr = command.ExecuteReader();
                        while (sdr.Read())
                        {
                            // Adjust the column names to match your database schema
                            categoryDTO cate = new categoryDTO(
                                 sdr["CategoryID"].ToString(),
                                 sdr["NameCategory"].ToString());

                            list.Add(cate);
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
